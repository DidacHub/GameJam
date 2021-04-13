using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyScript : MonoBehaviour
{
    private SpringJoint2D spring;
    // Start is called before the first frame update
    void Start()
    {
        spring = GetComponent<SpringJoint2D>();
        spring.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
                spring.enabled = true;
        }
                
        if (collision.gameObject.name == "DoorCollider")
        {
            Destroy(gameObject);
        }
    }
}
