using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagement : MonoBehaviour {

    public GameObject Player1;
    public GameObject Player2;
    public GameObject Player3;
    public GameObject Player4;
    public int GameTimer;

    public UnityEngine.UI.Text text;

    private float game_nextActionTime = 0.0f;
    public float game_period = 1.0f;

    private float nextActionTime = 0.0f;
    public float period = 0.7f;


    public Transform Pfuetze;

    public float predatorAbstand;

    List<GameObject> playerList;

    public GameObject PredatorPlayer;

    // Use this for initialization
    void Start () {
        GameTimer = 60;
        predatorAbstand = 3.5f;

        int predator = Random.Range(1, 5);
        switch(predator)
        {
            case 1:
                Player1.tag = "Predator";
                PredatorPlayer = Player1;
                for(int i = 0; i < Player1.transform.childCount - 1; i++)
                {
                    if (Player1.transform.GetChild(i).name == "kasten_weiss")
                    {
                        Player1.transform.GetChild(i).GetComponent<SpriteRenderer>().sortingOrder = 6;
                        Player1.transform.GetChild(i).GetComponent<SpriteRenderer>().color = Color.red;
                    }
                        
                }
                
                break;
            case 2:
                Player2.tag = "Predator";
                PredatorPlayer = Player2;
                for (int i = 0; i < Player1.transform.childCount - 1; i++)
                {
                    if (Player1.transform.GetChild(i).name == "kasten_weiss")
                    {
                        Player1.transform.GetChild(i).GetComponent<SpriteRenderer>().sortingOrder = 6;
                        Player1.transform.GetChild(i).GetComponent<SpriteRenderer>().color = Color.red;
                    }

                }
                break;
            case 3:
                Player3.tag = "Predator";
                PredatorPlayer = Player3;
                for (int i = 0; i < Player1.transform.childCount - 1; i++)
                {
                    if (Player1.transform.GetChild(i).name == "kasten_weiss")
                    {
                        Player1.transform.GetChild(i).GetComponent<SpriteRenderer>().sortingOrder = 6;
                        Player1.transform.GetChild(i).GetComponent<SpriteRenderer>().color = Color.red;
                    }

                }
                break;
            case 4:
                Player4.tag = "Predator";
                PredatorPlayer = Player4;
                for (int i = 0; i < Player1.transform.childCount - 1; i++)
                {
                    if (Player1.transform.GetChild(i).name == "kasten_weiss")
                    {
                        Player1.transform.GetChild(i).GetComponent<SpriteRenderer>().sortingOrder = 6;
                        Player1.transform.GetChild(i).GetComponent<SpriteRenderer>().color = Color.red;
                    }

                }
                break;
            default:
                break;
        }

        playerList = new List<GameObject>();
        playerList.Add(Player1);
        playerList.Add(Player2);
        playerList.Add(Player3);
        playerList.Add(Player4);
        for (int i = playerList.Count-1; i > 0-1; i--)
        {
            if (playerList[i].tag == "Predator")
                playerList.RemoveAt(i);
        }


    }
	
	// Update is called once per frame
	void Update () {
        bool sweatingTime = false;
        if (Time.time > nextActionTime)
        {
            nextActionTime += period;
            // execute block of code here
            sweatingTime = true;
        }
        else
            sweatingTime = false;

        if (Time.time > game_nextActionTime)
        {
            game_nextActionTime += game_period;
            // execute block of code here
            GameTimer--;
            text.text = GameTimer.ToString();
        }

        foreach (var item in playerList)
        {
            PlayerController pc = item.GetComponentInParent<PlayerController>();
            
            if ((PredatorPlayer.transform.position - item.transform.position).sqrMagnitude < predatorAbstand * predatorAbstand)
            {
                item.GetComponentInParent<PlayerController>().sweating = true;
                
            }
            else
                item.GetComponentInParent<PlayerController>().sweating = false;
                
            if (sweatingTime)
            {
                if(pc.deospray == false)
                {
                    if (pc.sweating)
                    {
                        Instantiate(Pfuetze, item.transform.position, item.transform.rotation);
                    }
                }  
            }
            
            
            
        }
        
    }
}
