﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AL_PowerPanels : MonoBehaviour {

    bool doOnce = false;
    GameObject panelManager;
    public GameObject PlateOn;
    public GameObject PlateOff;
    // Use this for initialization
    void Start () {
        panelManager = FindObjectOfType<AL_PanelManager>().gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponentInParent<DN_PlayerMovement>() && doOnce == false)
        {
            PlateOn.SetActive(true);
            PlateOff.SetActive(false);
            doOnce = true;
            panelManager.GetComponent<AL_PanelManager>().switches();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponentInParent<DN_PlayerMovement>()&& doOnce == true)
        {
            PlateOn.SetActive(false);
            PlateOff.SetActive(true);
            doOnce = false;
            panelManager.GetComponent<AL_PanelManager>().switchesOn();
        }
    }
}
