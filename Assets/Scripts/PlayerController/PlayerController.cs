﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool tastenzugewiesen = false;
    public bool sweating;
    
    public float speed = 5;
    public float sweatingSpeed;
    public float normalSpeed;
    public float rageSpeed;
    private Rigidbody2D rb2d;
    private Collider2D bcW;
    public bool up;
    public bool down;
    public bool left;
    public bool right;
    public bool crossroad;
    public bool spawnpoint;
    public Vector2 chosenDirection;
    public Vector2 rightV = new Vector2(1, 0);
    public Vector2 leftV = new Vector2(-1, 0);
    public Vector2 upV = new Vector2(0, 1);
    public Vector2 downV = new Vector2(0, -1);
    public bool predatorHit;
    public bool preyHit;
    public bool PlayerIsSpawned;
    public bool deospray;
    public bool usesDeospray;
    KeyCode k_north = KeyCode.A;
    KeyCode k_south = KeyCode.A;
    KeyCode k_west = KeyCode.A;
    KeyCode k_east = KeyCode.A;
    KeyCode k_use = KeyCode.A;
    private void Awake()
    {
        up = true;
        down = true;
        left = true;
        right = true;
        
    }
    

    public Vector2 currentDirection;
    public enum DirectionEnum { idle, north, south, west, east };
    public DirectionEnum nextdirection = DirectionEnum.idle;
    public DirectionEnum lastdirection = DirectionEnum.idle;
    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        currentDirection = new Vector2(0, 0);
        chosenDirection = currentDirection;
        PlayerIsSpawned = true;
        predatorHit = false;
        preyHit = false;
        deospray = false;
        usesDeospray = false;
        sweating = false;
        speed = 1;
        normalSpeed = speed;
        sweatingSpeed = normalSpeed * 0.8f;
        rageSpeed = normalSpeed * 1.4f;

    crossroad = true;
        spawnpoint = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get pressed keys
        /*
        foreach (KeyCode kcode in System.Enum.GetValues(typeof(KeyCode)))
        {
            if (Input.GetKeyDown(kcode))
                Debug.Log("KeyCode down: " + kcode);
        }
        */
        if (preyHit)
        {
            print(gameObject.name);
            if (lastdirection == DirectionEnum.east)
            {
                currentDirection = leftV;
                chosenDirection = new Vector2(-1, 0);
                nextdirection = DirectionEnum.west;
                lastdirection = DirectionEnum.west;
                right = false;
            }
            else if (lastdirection == DirectionEnum.west)
            {
                currentDirection = rightV;
                chosenDirection = new Vector2(1, 0);
                nextdirection = DirectionEnum.east;
                lastdirection = DirectionEnum.east;
                left = false;
            }
            else if (lastdirection == DirectionEnum.north)
            {
                currentDirection = downV;
                chosenDirection = new Vector2(0, -1);
                nextdirection = DirectionEnum.south;
                lastdirection = DirectionEnum.south;
                up = false;
            }
            else if (lastdirection == DirectionEnum.south)
            {
                currentDirection = upV;
                chosenDirection = new Vector2(0, 1);
                nextdirection = DirectionEnum.north;
                lastdirection = DirectionEnum.north;
                down = false;
            }
            preyHit = false;
        }
        
        if(predatorHit)
        {
            GameManagement.Instance.aPlayerDied = true;
            GameManagement.Instance.deadPlayerList.Add(gameObject);
        }
        

        //currentDirection = chosenDirection;
        rb2d.velocity = currentDirection * speed;

        

        if (tastenzugewiesen == false)
        {
            if(gameObject.name == "Player1")
                {
                k_north = KeyCode.W;
                k_west = KeyCode.A;
                k_south = KeyCode.S;
                k_east = KeyCode.D;
                k_use = KeyCode.E;
            }
            if (gameObject.name == "Player2")
            {
                k_north = KeyCode.Z;
                k_west = KeyCode.G;
                k_south = KeyCode.H;
                k_east = KeyCode.J;
                k_use = KeyCode.U;
            }
            if (gameObject.name == "Player3")
            {
                k_north = KeyCode.P;
                k_west = KeyCode.L;
                k_south = KeyCode.BackQuote;
                k_east = KeyCode.Quote;
                k_use = KeyCode.Semicolon;
            }
            if (gameObject.name == "Player4")
            {
                k_north = KeyCode.Keypad8;
                k_west = KeyCode.Keypad4;
                k_south = KeyCode.Keypad5;
                k_east = KeyCode.Keypad6;
                k_use = KeyCode.Keypad9;
            }


            tastenzugewiesen = true;
        }

        if (Input.GetKey(k_east) && lastdirection != DirectionEnum.west)
        {
            chosenDirection = new Vector2(1, 0);
            nextdirection = DirectionEnum.east;
        }
        if (Input.GetKey(k_west) && lastdirection != DirectionEnum.east)
        {
            chosenDirection = new Vector2(-1, 0);
            nextdirection = DirectionEnum.west;
        }
        if (Input.GetKey(k_north) && lastdirection != DirectionEnum.south)
        {
            chosenDirection = new Vector2(0, 1);
            nextdirection = DirectionEnum.north;
        }
        if (Input.GetKey(k_south) && lastdirection != DirectionEnum.north)
        {
            chosenDirection = new Vector2(0, -1);
            nextdirection = DirectionEnum.south;
        }        
        if (Input.GetKey(k_use))
        {
            deospray = false;
        }


        if (crossroad)
        {

            if (nextdirection.Equals(DirectionEnum.east) && right)
            {
                currentDirection = rightV;
                lastdirection = DirectionEnum.east;
                left = false;                
            }
            else if (nextdirection.Equals(DirectionEnum.west) && left)
            {
                currentDirection = leftV;
                lastdirection = DirectionEnum.west;
                right = false;
            }
            else if (nextdirection.Equals(DirectionEnum.north) && up)
            {
                currentDirection = upV;
                lastdirection = DirectionEnum.north;
                down = false;
            }
            else if (nextdirection.Equals(DirectionEnum.south) && down)
            {
                currentDirection = downV;
                lastdirection = DirectionEnum.south;
                up = false;
            }


            else if ((!right && up && down && nextdirection == DirectionEnum.east) || (!left && up && down && nextdirection == DirectionEnum.west))
            {
                int dir = Random.Range(1, 3);
                if (dir == 1)
                {

                    currentDirection = upV;
                    chosenDirection = new Vector2(0, 1);
                    nextdirection = DirectionEnum.north;
                    lastdirection = DirectionEnum.north;
                    down = false;
                }

                if (dir == 2)
                {

                    currentDirection = downV;
                    chosenDirection = new Vector2(0, -1);
                    nextdirection = DirectionEnum.south;
                    lastdirection = DirectionEnum.south;
                    up = false;
                }
            }

            else if ((!up && left && right && nextdirection == DirectionEnum.north) || (!down && left && right && nextdirection == DirectionEnum.south))
            {
                int dir = Random.Range(1, 3);
                if (dir == 1)
                {

                    currentDirection = leftV;
                    chosenDirection = new Vector2(-1, 0);
                    nextdirection = DirectionEnum.west;
                    lastdirection = DirectionEnum.west;
                    right = false;
                }

                if (dir == 2)
                {

                    currentDirection = rightV;
                    chosenDirection = new Vector2(1, 0);
                    nextdirection = DirectionEnum.east;
                    lastdirection = DirectionEnum.east;
                    left = false;
                }
            }
            // force north
            else if ((!down && !left && !right && lastdirection == DirectionEnum.west) || (!down && !left && !right && lastdirection == DirectionEnum.east))
            {
                currentDirection = upV;
                chosenDirection = new Vector2(0, 1);
                nextdirection = DirectionEnum.north;
                lastdirection = DirectionEnum.north;
                down = false;

            }
            // force east
            else if ((!down && !up && right && !left && lastdirection == DirectionEnum.south) || (!up && !down && !left && right && lastdirection == DirectionEnum.north))
            {
                currentDirection = rightV;
                chosenDirection = new Vector2(1, 0);
                nextdirection = DirectionEnum.east;
                lastdirection = DirectionEnum.east;
                left = false;

            }
            // force west
            else if ((!right && !down && !up && lastdirection == DirectionEnum.south) || (!right && !down && !up && lastdirection == DirectionEnum.north))
            {
                currentDirection = leftV;
                chosenDirection = new Vector2(-1, 0);
                nextdirection = DirectionEnum.west;
                lastdirection = DirectionEnum.west;
                right = false;
            }
            // force south
            else if ((!up && !left && !right && lastdirection == DirectionEnum.west) || (!up && !left && !right && lastdirection == DirectionEnum.east))
            {
                currentDirection = downV;
                chosenDirection = new Vector2(0, -1);
                nextdirection = DirectionEnum.south;
                lastdirection = DirectionEnum.south;
                up = false;
            }



            if(lastdirection != DirectionEnum.idle)
                crossroad = false;
            
        }
        speed = normalSpeed;
    }
}
