using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panelScript : MonoBehaviour
{
   /* public static bool GameIsPaused = false;


    public bool isInRange;
    public KeyCode interactKey;
    
    public GameObject Button;
    public GameObject Button2;
    public GameObject Button3;
    public GameObject Button4;
    public GameObject PanelTask;
    public GameObject Image2;





    void Update()
    {
        if (isInRange)
        {
            if (Input.GetKeyDown(interactKey))
            {
                PanelTask();

            }
        }
        if (Input.GetKeyDown("escape"))
        {
            exitPanelTask();
        }
    }

    private void PanelTask()
    {

        PanelTask.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;

    }
    private void exitPanelTask()
    {
        PanelTask.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = true;
            Debug.Log("Player now in range");
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = false;
            Debug.Log("Player is not in range");
        }
    }
    */
}
