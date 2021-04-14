using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PanelTask : MonoBehaviour
{
    public TextMeshProUGUI display;
    public TextMeshProUGUI contraseña;
    public GameObject puerta;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddNumber (string number)
    {
        if(display.text.Length >= 4)
        {
            return;
        }
        display.text += number;
    }
    public void EraseDisplay()
    {
        display.text = "";
    }
    public void CheckPassword()
    {
        if(display.text.Equals(contraseña.text))
        {
            display.color = Color.green;
            display.text = "Granted";
            Destroy(gameObject, 1.0f);
            Destroy(puerta, 1.0f);
        }
        else
        {
            display.text = "Denied";
        }
    }
}
