using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteRotation : MonoBehaviour {


    [SerializeField]
    PlayerController Player;
    private Rigidbody2D rb2d;

    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;

    // Use this for initialization
    void Start()
    {
        Player = GetComponentInParent<PlayerController>();
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Player.lastdirection.Equals(PlayerController.DirectionEnum.east))
            gameObject.transform.eulerAngles = new Vector3(0, 0, 0);
        if (Player.lastdirection.Equals(PlayerController.DirectionEnum.north))
            gameObject.transform.eulerAngles = new Vector3(0, 0, 90);
        if (Player.lastdirection.Equals(PlayerController.DirectionEnum.south))
            gameObject.transform.eulerAngles = new Vector3(0, 0, 270);
        if (Player.lastdirection.Equals(PlayerController.DirectionEnum.west))
            gameObject.transform.eulerAngles = new Vector3(0, 0, 180);
        
    }
}
