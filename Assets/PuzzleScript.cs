using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleScript : MonoBehaviour
{

    public static bool GameIsPaused = false;

    public GameObject Cajafuerte;
    public GameObject Puzzle;
    public BoxCollider2D colliderCajaFuerte;
    

    public bool isInRange;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (isInRange)
       {
            
            if (Input.GetKeyDown(KeyCode.E))
            {
                enterPuzzle();

            }
       }
       if (Input.GetKeyDown(KeyCode.Escape))
       {
            exitPuzzle();
       }
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
    void enterPuzzle()
    {
        Puzzle.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    void exitPuzzle()
    {
        Puzzle.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }


}

