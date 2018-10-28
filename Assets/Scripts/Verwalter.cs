using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Verwalter : MonoBehaviour {

    public static Verwalter Instance { get; private set; }



    private void Awake()
    {
        Instance = this;
    }

    /*
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    */
}
