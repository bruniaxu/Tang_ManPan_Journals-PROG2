using UnityEngine;
using TMPro;

public class RowGeneration : MonoBehaviour
{
    public TMP_InputField SquareNumberInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RowGenerate()
    {
        int num = int.Parse(SquareNumberInput.text);
        Debug.Log(num);
    }
}
