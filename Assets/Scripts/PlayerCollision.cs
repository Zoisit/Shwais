using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    [SerializeField]
    PlayerController Player;

    // Use this for initialization
    void Start()
    {
        Player = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Prey")
        {            
            Player.preyHit = true;
        }
        if (collision.gameObject.tag == "Predator")
        {
            Player.predatorHit = true;
        }
        

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Item")
        {
            Player.deospray = true;
            Destroy(collision.gameObject);
        }

    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Pfuetze")
        {
            if(Player.tag == "Predator")
            {
                Player.speed = Player.rageSpeed;
            }
        }
    }
}
