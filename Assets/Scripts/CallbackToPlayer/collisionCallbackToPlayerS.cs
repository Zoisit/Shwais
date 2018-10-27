using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionCallbackToPlayerS : MonoBehaviour {

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
        Player.down = false;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Player.down = true;
    }
}
