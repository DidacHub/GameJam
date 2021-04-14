using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScriptPuzzleColores : MonoBehaviour
{
    
        public static bool GameIsPaused = false;


        public bool isInRange;
        public KeyCode interactKey;
        public UnityEvent interactAction;
        public GameObject Button;
        public GameObject Button2;
        public GameObject Button3;
        public GameObject Button4;
        public GameObject Puzzle2;
        public GameObject Image2;
        
        



        void Update()
        {
            if (isInRange)
            {
                if (Input.GetKeyDown(interactKey))
                {
                    changeToPuzzle2();

                }
            }
            if (Input.GetKeyDown("escape"))
            {
                exitPuzzle2();
            }
        }

        private void changeToPuzzle2()
        {

            Puzzle2.SetActive(true);
            Time.timeScale = 0f;
            GameIsPaused = true;

        }
        private void exitPuzzle2()
        {
            Puzzle2.SetActive(false);
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
            Image2.SetActive(true);
            Button.SetActive(false);
            Button2.SetActive(false);
            Button3.SetActive(false);
            Button4.SetActive(false);

        }
        public void incorrecto()
        {
            exitPuzzle2();
        }

    
}
