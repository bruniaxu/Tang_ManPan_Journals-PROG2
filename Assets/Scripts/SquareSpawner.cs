using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class SquareSpawner : MonoBehaviour
{
    private Camera cam;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {

        //get mouse pos
        Vector2 mousePosition = Mouse.current.position.ReadValue();
        Vector3 click = cam.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, cam.nearClipPlane));
        click.z = 0f;

        //create 4 values
        Vector2 aVector = new Vector2(0f, 3f);
        Vector2 bVector = new Vector2(3f, 3f);
        Vector2 cVector = new Vector2(3f, 0f);
        //the fourth one Vector2.zero (0,0)

        //make clicking the screen to draw a white square
        if(Mouse.current.leftButton.wasPressedThisFrame)
        {
            Debug.DrawLine(click,click +(Vector3) aVector, Color.white, 2f);
            Debug.DrawLine(click+ (Vector3)aVector, click + (Vector3)bVector, Color.white,2f);
            Debug.DrawLine(click + (Vector3)bVector, click + (Vector3)cVector, Color.white,2f);
            Debug.DrawLine(click + (Vector3)cVector, click + (Vector3)Vector2.zero, Color.white, 2f);
        }

        
       
            
        

       

    }
}
