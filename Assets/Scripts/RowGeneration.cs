using UnityEngine;
using TMPro;
using System;

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

        for (int i = 0; i < num; i++)
        {
            Console.WriteLine(i);
        }
    }
}
