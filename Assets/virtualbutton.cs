using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class virtualbutton : MonoBehaviour, IVirtualButtonEventHandler {

    private GameObject contextButton;
    private GameObject buttonParent;
    // Use this for initialization
    void Start () {
        contextButton = GameObject.Find("contextButton");
        buttonParent = GameObject.Find("Notification");
        contextButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {
        buttonParent.active = false;
    }

    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {
        buttonParent.active = false;
    }
}
