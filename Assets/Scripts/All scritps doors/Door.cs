using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Door : MonoBehaviour
{
    public BoxCollider2D door;
    private SpriteRenderer sprite;
    private bool DoorClose = true;

    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        sprite.enabled = true;
        door.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collison.gameObject.tag == "Key") {
            if (DoorClose) {
                sprite.enabled = false;
                door.enabled = false;
                DoorClose = false;
            }
        }
    }
}
