using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionCallbackToPlayerD : MonoBehaviour {

    [SerializeField]
    PlayerController Player;

	// Use this for initialization
	void Start () {
        Player = GetComponentInParent<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "obstacle")
        {            
            Player.right = false;                 
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {        
        if (collision.gameObject.tag == "obstacle" && Player.lastdirection != PlayerController.DirectionEnum.west)
        {
            Player.right = true;
        }
    }
}
