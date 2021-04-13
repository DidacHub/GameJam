using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertaCrucifijo : MonoBehaviour
{
    public BoxCollider2D Door;
    
    private SpriteRenderer Sprite;
    private bool DoorClosed = true;
    
    // Start is called before the first frame update
    void Start()
    {
        Sprite = GetComponent<SpriteRenderer>();
        Sprite.enabled = true;
        Door.enabled = true;
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Crucifijo")
        {
            if (DoorClosed)
            {
                Sprite.enabled = false;
                Door.enabled = false;
                DoorClosed = false;
                GetComponent<BoxCollider2D>().enabled = false;
                
            }

        }
    }
}
