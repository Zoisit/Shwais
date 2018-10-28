using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PfuetzenScript : MonoBehaviour {

    public Sprite mediumPfuetze;
    public Sprite smallPfuetze;

    private float nextActionTime = 0.0f;
    public float period = 1.0f;

    public int timer;

    // Use this for initialization
    void Start () {
        timer = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time > nextActionTime)
        {
            nextActionTime += period;
            // execute block of code here
            timer++;
        }
        /*
         * if timer == 1 -> parent.mediumsprite
         * if timmer == 2 -> parent.smallsprite
         * if timmer == 3 -> delete parent
         * */
    }
}
