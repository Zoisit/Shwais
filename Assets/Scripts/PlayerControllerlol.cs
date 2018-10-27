using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerlol : MonoBehaviour {

    public float speed = 1;
    private Rigidbody2D rb2d;
    Vector2 dir = new Vector2(0,0);
    // Use this for initialization
    void Start () {
        rb2d = GetComponent<Rigidbody2D>();
	}    

    // Update is called once per frame
    void FixedUpdate () {
        rb2d.velocity = new Vector2(0, 0);

        if (Input.GetKey(KeyCode.D))
        {
            rb2d.velocity = new Vector2(1 * speed, 0);
            dir = new Vector2(1, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb2d.velocity = new Vector2(-1 * speed, 0);
            dir = new Vector2(-1, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            rb2d.velocity = new Vector2(0, 1 * speed);
            dir = new Vector2(0, 1);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb2d.velocity = new Vector2(0, -1 * speed);
            dir = new Vector2(0, -1);
        }
    }
}
