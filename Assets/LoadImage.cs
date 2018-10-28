using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadImage : MonoBehaviour {

    public Sprite hexe;
    public Sprite teufel;
    public Sprite werwolf;
    public Sprite zombie;

    // Use this for initialization
    void Start () {
        for (int i = 0; i < 4; i++)
        {
            if (Verwalter.Instance.chardex[i] == 0)
            {
                gameObject.transform.GetChild(i).GetComponent<Image>().sprite = hexe;
            }
            else if (Verwalter.Instance.chardex[i] == 1)
            {
                gameObject.transform.GetChild(i).GetComponent<Image>().sprite = teufel;
            }
            else if (Verwalter.Instance.chardex[i] == 2)
            {
                gameObject.transform.GetChild(i).GetComponent<Image>().sprite = werwolf;
            }
            else if (Verwalter.Instance.chardex[i] == 3)
            {
                gameObject.transform.GetChild(i).GetComponent<Image>().sprite = zombie;
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
