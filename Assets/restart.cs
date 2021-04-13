using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
    private bool reinicio;


    void Update()
    {
        reinicio = reset;

        if (Input.GetKeyDown(KeyCode.R))
        {
            
            RestartGame();
        }
    }


    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }



    

    public static bool reset
    {
        get { return Input.GetKey(KeyCode.R); }
    }

}

