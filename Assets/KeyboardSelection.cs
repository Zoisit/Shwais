using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class KeyboardSelection : MonoBehaviour {

    public EventSystem eventSystem;
    public GameObject selectedObject;
    private bool buttonSelected;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxisRaw("Vertical") != 0 && buttonSelected == false)
        {
            eventSystem.SetSelectedGameObject(selectedObject);
            buttonSelected = true;
        }
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetButtonDown("1"))
        {
            buttonSelected = false;
        }
    }

    //sorgt beim zurückkehren aus anderem Menü dafür, dass wieder ausgewählt werden kann
    private void OnDisable()
    {
        buttonSelected = false;
    }
}
