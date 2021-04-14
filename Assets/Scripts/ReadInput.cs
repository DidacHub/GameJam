using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReadInput : MonoBehaviour
{
    
    private string input;
    private InputField input;

    public GameObject image;
    public GameObject error;

    public string respuesta = "pene";
    void Start()
    {
        
    }
    void Awake()
    {
        input = GameObject.Find("InputField").GetComponent<InputField>();
    }
    void Update()
    { 
        respuesta += input;
        ReadStringInput(input);

        if (respuesta == input)
        { 
            image.SetActive(true);
        }
        else
        {
            error.SetActive(true);
        }
    }
    void fixedUpdate()
    {
        respuesta += input;
        ReadStringInput(guess);

        if (respuesta = input)
        { 
            image.SetActive(true);
        }
        else
        {
            error.SetActive(true);
        }
    }

    public void ReadStringInput(string guess)
    {
        input = guess;
        Debug.Log(input);
        input.text = "";
    }


}
