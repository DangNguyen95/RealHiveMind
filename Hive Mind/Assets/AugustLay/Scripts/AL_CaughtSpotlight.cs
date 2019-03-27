using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AL_CaughtSpotlight : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<DN_PlayerMovement>())
        {
            DN_GameManager.Death = true;
        }
    }
}
