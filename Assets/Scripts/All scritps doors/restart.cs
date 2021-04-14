using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
    private bool reinicio;
    private float currentTime = 0f;
    float startingTime = 10f;


    void Update()
    {
        currentTime = startingTime;

        if (Input.GetKeyDown(KeyCode.R))
        {

            Debug.Log("funciona");
            currentTime -= 1 * Time.deltaTime;
            if (currentTime <= 0)
            {
                RestartGame();
            }
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

