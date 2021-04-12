using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Key;
    public GameObject Keycard;
    public GameObject Crucifix;
    public GameObject Wrench;

    public enum OBJECTS {KEY, KEYCARD, CRUCIFIX, WRENCH, EMPTY }
    public OBJECTS ActiveObject = OBJECTS.EMPTY;

    public float moveSpeed;

    private bool pick;
    private string objectName;
    private bool onObject;
    private int Look;
    private GameObject floorObject;

    private Rigidbody2D rb;
    private Vector2 moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInputs();
        pick = Interact;
        if (pick && onObject)
        {
            if (objectName == "Key")
            {
                ActiveObject = OBJECTS.KEY;
            }
            else if (objectName == "Keycard")
            {
                ActiveObject = OBJECTS.KEYCARD;
            }
            else if (objectName == "Crucifix")
            {
                ActiveObject = OBJECTS.CRUCIFIX;
            }
            else if (objectName == "WRENCH")
            {
                ActiveObject = OBJECTS.WRENCH;
            }
        }
    }

    void FixedUpdate()
    {
        Move();

        switch (ActiveObject)
        {
            default:
                break;
            case OBJECTS.EMPTY:
                Key.SetActive(false);
                Keycard.SetActive(false);
                Crucifix.SetActive(false);
                Wrench.SetActive(false);
                break;
            case OBJECTS.KEY:
                Key.SetActive(true);
                Keycard.SetActive(false);
                Crucifix.SetActive(false);
                Wrench.SetActive(false);
                break;
            case OBJECTS.KEYCARD:
                Key.SetActive(false);
                Keycard.SetActive(true);
                Crucifix.SetActive(false);
                Wrench.SetActive(false);
                break;
            case OBJECTS.CRUCIFIX:
                Key.SetActive(false);
                Keycard.SetActive(false);
                Crucifix.SetActive(true);
                Wrench.SetActive(false);
                break;
            case OBJECTS.WRENCH:
                Key.SetActive(false);
                Keycard.SetActive(false);
                Crucifix.SetActive(false);
                Wrench.SetActive(true);
                break;

        }
    }

    private void OntriggerEnter2D (Collider2D collision)
    {
        if (collision.gameObject.tag == "Object")
        {
            objectName = collision.gameObject.name;
            onObject = true;

            floorObject = collision.gameObject;
        }
    }

    private void OnTriggerExit2D (Collider2D collision)
    {
        if (collision.gameObject.tag == "Object")
        {
            onObject = false;
        }
    }

    public void Dead()
    {
        Key.SetActive(false);
        Keycard.SetActive(false);
        Crucifix.SetActive(false);
        Wrench.SetActive(false);
    }

    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX, moveY).normalized;
    }

    void Move()
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }
    public static bool Interact
    {
        get { return Input.GetKey(KeyCode.E); }
    }

}
