using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class notaInteraction : MonoBehaviour
{
    public bool isInRange;
    public KeyCode interactKey;
    public UnityEvent interactAction;
    public GameObject number;



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
                displayNumber();

            }
            if (Input.GetKeyDown("escape"))
            {
                stopDisplaying();
            }
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
    private void displayNumber()
    {
        number.SetActive(true);
    }
    private void stopDisplaying()
    {
        number.SetActive(false);
    }
}
