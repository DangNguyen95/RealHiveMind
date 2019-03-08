using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AL_Door : MonoBehaviour {
    public int doorNum;
    public bool playerOnMe = false;
    public GameObject pressurePlate;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerStay(Collider other)
    {
        if (other.GetComponentInParent<DN_PlayerMovement>())
        {
            playerOnMe = true;  
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponentInParent<DN_PlayerMovement>())
        {
            playerOnMe = false;

            pressurePlate.GetComponent<AL_PressurePlate>().playerTrigger();
        }
    }
}
