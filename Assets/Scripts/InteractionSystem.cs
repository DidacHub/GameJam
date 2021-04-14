using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InteractionSystem : MonoBehaviour
{
    public static bool GameIsPaused = false;


    public bool isInRange;
    public KeyCode interactKey;
    public UnityEvent interactAction;
    public GameObject Pantalla;
    public GameObject Puzzle;
    public GameObject Image;
    public GameObject Error;
    public GameObject Texto;
    
    

    void Update()
    {
        if (isInRange)
        {
            if (Input.GetKeyDown(interactKey))
            {
                changeToPuzzle();
                
            }
        }
        if (Input.GetKeyDown("escape"))
        {
            exitPuzzle();
        }
    }
    
    private void changeToPuzzle()
    {

        Puzzle.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;

    }
    private void exitPuzzle()
    {
        Puzzle.SetActive(false);
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
    public void correcto()
    {
        Image.SetActive(true);
        Texto.SetActive(false);

    }
    public void incorrecto()
    {
        exitPuzzle();
    }
        
}
