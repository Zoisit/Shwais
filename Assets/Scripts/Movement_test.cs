using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_test : MonoBehaviour
{

    public float speed = 1;
    private Rigidbody2D rb2d;
    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    public AudioSource deathSound;
    // Update is called once per frame
    void FixedUpdate()
    {

        rb2d.velocity = new Vector2(0, 0);

        if (Input.GetKey(KeyCode.W))
        {
            rb2d.velocity = new Vector2(0, 1 * speed);
            deathSound.Play();
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb2d.velocity = new Vector2(-1 * speed, 0);

        }
        if (Input.GetKey(KeyCode.D))
        {
            rb2d.velocity = new Vector2(1 * speed, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb2d.velocity = new Vector2(0, -1 * speed);
        }



    }

}
