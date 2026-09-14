using UnityEngine;
using UnityEngine.InputSystem;

public class Pipeline : MonoBehaviour
{
    //store the previosu mouse pos
    Vector2 prvPoint;
    float timer = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
  
        if (Mouse.current.leftButton.wasPressedThisFrame) 
        {
            //store the current mouse pos
            prvPoint = Mouse.current.position.ReadValue();

            //reset the timer
            timer = 0f;
        }
      
        if (Mouse.current.leftButton.isPressed)
        {
            timer += Time.deltaTime;

            //store the current mouse pos
            prvPoint = Mouse.current.position.ReadValue();

            if (timer > 0.1f)
            {
                Debug.Log("0.1 sec");
                //reset the timer
                timer = 0f;
            }

          
        }
    }

}
