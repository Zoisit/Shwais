using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectingPlayer : MonoBehaviour {

    private int player1 = 0;
    private int player2 = 0;
    private int player3 = 0;
    private int player4 = 0;

    private int[] chardex=new int[4];

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Charakterauswahl weitergeben
        if (Input.GetKeyDown(KeyCode.Return))
        {
            chardex[0] = player1;
            chardex[1] = player2;
            chardex[2] = player3;
            chardex[3] = player4;

            Verwalter.Instance.chardex = chardex;
            //Ergänzen
        }


        //Spieler 1
		if (Input.GetKeyDown(KeyCode.D))
        {
            if (player1 == 0)
            {
                player1++;
                gameObject.transform.GetChild(0).GetChild(1).GetChild(0).gameObject.SetActive(false);
                gameObject.transform.GetChild(0).GetChild(1).GetChild(1).gameObject.SetActive(true);
            }
            else if (player1 == 1)
            {
                player1++;
                gameObject.transform.GetChild(0).GetChild(1).GetChild(1).gameObject.SetActive(false);
                gameObject.transform.GetChild(0).GetChild(1).GetChild(2).gameObject.SetActive(true);
            }
            else if (player1 == 2)
            {
                player1++;
                gameObject.transform.GetChild(0).GetChild(1).GetChild(2).gameObject.SetActive(false);
                gameObject.transform.GetChild(0).GetChild(1).GetChild(3).gameObject.SetActive(true);
            }
            else if (player1 == 3)
            {
                player1 = 0;
                gameObject.transform.GetChild(0).GetChild(1).GetChild(3).gameObject.SetActive(false);
                gameObject.transform.GetChild(0).GetChild(1).GetChild(0).gameObject.SetActive(true);
            }
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            if (player1 == 0)
            {
                player1=3;
                gameObject.transform.GetChild(0).GetChild(1).GetChild(0).gameObject.SetActive(false);
                gameObject.transform.GetChild(0).GetChild(1).GetChild(3).gameObject.SetActive(true);
            }
            else if (player1 == 1)
            {
                player1--;
                gameObject.transform.GetChild(0).GetChild(1).GetChild(1).gameObject.SetActive(false);
                gameObject.transform.GetChild(0).GetChild(1).GetChild(0).gameObject.SetActive(true);
            }
            else if (player1 == 2)
            {
                player1--;
                gameObject.transform.GetChild(0).GetChild(1).GetChild(2).gameObject.SetActive(false);
                gameObject.transform.GetChild(0).GetChild(1).GetChild(1).gameObject.SetActive(true);
            }
            else if (player1 == 3)
            {
                player1--;
                gameObject.transform.GetChild(0).GetChild(1).GetChild(3).gameObject.SetActive(false);
                gameObject.transform.GetChild(0).GetChild(1).GetChild(2).gameObject.SetActive(true);
            }
        }

        //Spieler 2
        if (Input.GetKeyDown(KeyCode.J))
        {
            if (player2 == 0)
            {
                player2++;
                gameObject.transform.GetChild(1).GetChild(1).GetChild(0).gameObject.SetActive(false);
                gameObject.transform.GetChild(1).GetChild(1).GetChild(1).gameObject.SetActive(true);
            }
            else if (player2 == 1)
            {
                player2++;
                gameObject.transform.GetChild(1).GetChild(1).GetChild(1).gameObject.SetActive(false);
                gameObject.transform.GetChild(1).GetChild(1).GetChild(2).gameObject.SetActive(true);
            }
            else if (player2 == 2)
            {
                player2++;
                gameObject.transform.GetChild(1).GetChild(1).GetChild(2).gameObject.SetActive(false);
                gameObject.transform.GetChild(1).GetChild(1).GetChild(3).gameObject.SetActive(true);
            }
            else if (player2 == 3)
            {
                player2 = 0;
                gameObject.transform.GetChild(1).GetChild(1).GetChild(3).gameObject.SetActive(false);
                gameObject.transform.GetChild(1).GetChild(1).GetChild(0).gameObject.SetActive(true);
            }
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            if (player2 == 0)
            {
                player2 = 3;
                gameObject.transform.GetChild(1).GetChild(1).GetChild(0).gameObject.SetActive(false);
                gameObject.transform.GetChild(1).GetChild(1).GetChild(3).gameObject.SetActive(true);
            }
            else if (player2 == 1)
            {
                player2--;
                gameObject.transform.GetChild(1).GetChild(1).GetChild(1).gameObject.SetActive(false);
                gameObject.transform.GetChild(1).GetChild(1).GetChild(0).gameObject.SetActive(true);
            }
            else if (player2 == 2)
            {
                player2--;
                gameObject.transform.GetChild(1).GetChild(1).GetChild(2).gameObject.SetActive(false);
                gameObject.transform.GetChild(1).GetChild(1).GetChild(1).gameObject.SetActive(true);
            }
            else if (player2 == 3)
            {
                player2--;
                gameObject.transform.GetChild(1).GetChild(1).GetChild(3).gameObject.SetActive(false);
                gameObject.transform.GetChild(1).GetChild(1).GetChild(2).gameObject.SetActive(true);
            }
        }

        //Spieler 3
        if (Input.GetKeyDown(KeyCode.Quote))
        {
            if (player3 == 0)
            {
                player3++;
                gameObject.transform.GetChild(2).GetChild(1).GetChild(0).gameObject.SetActive(false);
                gameObject.transform.GetChild(2).GetChild(1).GetChild(1).gameObject.SetActive(true);
            }
            else if (player3 == 1)
            {
                player3++;
                gameObject.transform.GetChild(2).GetChild(1).GetChild(1).gameObject.SetActive(false);
                gameObject.transform.GetChild(2).GetChild(1).GetChild(2).gameObject.SetActive(true);
            }
            else if (player3 == 2)
            {
                player3++;
                gameObject.transform.GetChild(2).GetChild(1).GetChild(2).gameObject.SetActive(false);
                gameObject.transform.GetChild(2).GetChild(1).GetChild(3).gameObject.SetActive(true);
            }
            else if (player3 == 3)
            {
                player3 = 0;
                gameObject.transform.GetChild(2).GetChild(1).GetChild(3).gameObject.SetActive(false);
                gameObject.transform.GetChild(2).GetChild(1).GetChild(0).gameObject.SetActive(true);
            }
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            if (player3 == 0)
            {
                player3 = 3;
                gameObject.transform.GetChild(2).GetChild(1).GetChild(0).gameObject.SetActive(false);
                gameObject.transform.GetChild(2).GetChild(1).GetChild(3).gameObject.SetActive(true);
            }
            else if (player3 == 1)
            {
                player3--;
                gameObject.transform.GetChild(2).GetChild(1).GetChild(1).gameObject.SetActive(false);
                gameObject.transform.GetChild(2).GetChild(1).GetChild(0).gameObject.SetActive(true);
            }
            else if (player3 == 2)
            {
                player3--;
                gameObject.transform.GetChild(2).GetChild(1).GetChild(2).gameObject.SetActive(false);
                gameObject.transform.GetChild(2).GetChild(1).GetChild(1).gameObject.SetActive(true);
            }
            else if (player3 == 3)
            {
                player3--;
                gameObject.transform.GetChild(2).GetChild(1).GetChild(3).gameObject.SetActive(false);
                gameObject.transform.GetChild(2).GetChild(1).GetChild(2).gameObject.SetActive(true);
            }
        }

        //Spieler 4
        if (Input.GetKeyDown(KeyCode.Keypad6))
        {
            if (player4 == 0)
            {
                player4++;
                gameObject.transform.GetChild(3).GetChild(1).GetChild(0).gameObject.SetActive(false);
                gameObject.transform.GetChild(3).GetChild(1).GetChild(1).gameObject.SetActive(true);
            }
            else if (player4 == 1)
            {
                player4++;
                gameObject.transform.GetChild(3).GetChild(1).GetChild(1).gameObject.SetActive(false);
                gameObject.transform.GetChild(3).GetChild(1).GetChild(2).gameObject.SetActive(true);
            }
            else if (player4 == 2)
            {
                player4++;
                gameObject.transform.GetChild(3).GetChild(1).GetChild(2).gameObject.SetActive(false);
                gameObject.transform.GetChild(3).GetChild(1).GetChild(3).gameObject.SetActive(true);
            }
            else if (player4 == 3)
            {
                player4 = 0;
                gameObject.transform.GetChild(3).GetChild(1).GetChild(3).gameObject.SetActive(false);
                gameObject.transform.GetChild(3).GetChild(1).GetChild(0).gameObject.SetActive(true);
            }
        }

        if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            if (player4 == 0)
            {
                player4 = 3;
                gameObject.transform.GetChild(3).GetChild(1).GetChild(0).gameObject.SetActive(false);
                gameObject.transform.GetChild(3).GetChild(1).GetChild(3).gameObject.SetActive(true);
            }
            else if (player4 == 1)
            {
                player4--;
                gameObject.transform.GetChild(3).GetChild(1).GetChild(1).gameObject.SetActive(false);
                gameObject.transform.GetChild(3).GetChild(1).GetChild(0).gameObject.SetActive(true);
            }
            else if (player4 == 2)
            {
                player4--;
                gameObject.transform.GetChild(3).GetChild(1).GetChild(2).gameObject.SetActive(false);
                gameObject.transform.GetChild(3).GetChild(1).GetChild(1).gameObject.SetActive(true);
            }
            else if (player4 == 3)
            {
                player4--;
                gameObject.transform.GetChild(3).GetChild(1).GetChild(3).gameObject.SetActive(false);
                gameObject.transform.GetChild(3).GetChild(1).GetChild(2).gameObject.SetActive(true);
            }
        }
    }
}
