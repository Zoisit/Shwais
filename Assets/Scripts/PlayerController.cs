using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed = 5;
    private Rigidbody2D rb2d;
    private Collider2D bcW;
    public bool up = false;
    public bool down = false;
    public bool left = false;
    public bool right = false;
    public bool crossroad = false;
    public Vector2 nextDir;


    Vector2 dir;
    public enum lastDir {north,south,west,east};
    public lastDir direction = lastDir.north;
    // Use this for initialization
    void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        dir = new Vector2(1 * speed, 0);
        nextDir = dir;

	}    

    // Update is called once per frame
    void FixedUpdate () {
        rb2d.velocity = dir;
        if (crossroad)
        {
            dir = nextDir;
            crossroad = false;
        }
        if (Input.GetKey(KeyCode.D))
        {
            //rb2d.velocity = new Vector2(1 * speed, 0);
            nextDir = new Vector2(1, 0);
            direction = lastDir.east;
            //dir = nextDir;
        }
        if (Input.GetKey(KeyCode.A))
        {
            //rb2d.velocity = new Vector2(-1 * speed, 0);
            nextDir = new Vector2(-1, 0);
            direction = lastDir.west;
        }
        if (Input.GetKey(KeyCode.W))
        {
            //rb2d.velocity = new Vector2(0, 1 * speed);
            nextDir = new Vector2(0, 1);
            direction = lastDir.north;
        }
        if (Input.GetKey(KeyCode.S))
        {
            //rb2d.velocity = new Vector2(0, -1 * speed);
            nextDir = new Vector2(0, -1);
            direction = lastDir.south;
        }
    }
}
