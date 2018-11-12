using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PfuetzenScript : MonoBehaviour {

    public Sprite mediumPfuetze;
    public Sprite smallPfuetze;

    private float nextActionTime;
    public float period;

    public int timer;

    // Use this for initialization
    void Awake () {
        timer = 0;
        period = 2;
        nextActionTime = Time.time + period;
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time > nextActionTime)
        {
            nextActionTime += period;
            // execute block of code here
            timer++;
        }
        switch (timer)
        {
            case 1:
                gameObject.GetComponent<SpriteRenderer>().sprite = mediumPfuetze;
                break;
            case 2:
                gameObject.GetComponent<SpriteRenderer>().sprite = smallPfuetze;
                break;
            case 3:
                Destroy(gameObject);
                break;
            default:
                break;
        }

    }
}
