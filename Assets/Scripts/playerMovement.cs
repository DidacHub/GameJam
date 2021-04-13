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
    public Animator animator;

    public enum OBJECTS {KEY, KEYCARD, CRUCIFIX, WRENCH, EMPTY }
    public OBJECTS ActiveObject = OBJECTS.EMPTY;

    public float moveSpeed = 5f;

    private bool pick;
    private string objectName;
    private bool onObject;
    private int Look;
    private GameObject floorObject;

    private Rigidbody2D rb;
    Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");


        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
        
        
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
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

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

    

    
    public static bool Interact
    {
        get { return Input.GetKey(KeyCode.E); }
    }

}
