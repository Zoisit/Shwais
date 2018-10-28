using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectingPlayer : MonoBehaviour {

    private int player1 = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.D))
        {
            if (player1 == 0)
            {
                player1++;
                gameObject.transform.GetChild(0).GetChild(1).GetChild(0).gameObject.SetActive(false);
                gameObject.transform.GetChild(0).GetChild(1).GetChild(1).gameObject.SetActive(true);
            }
        }
	}
}
