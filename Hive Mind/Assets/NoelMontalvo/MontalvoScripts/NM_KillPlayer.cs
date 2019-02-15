using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NM_KillPlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "X"|| other.gameObject.tag == "O" || other.gameObject.tag == "Traingle" || other.gameObject.tag == "Square")
        {
            DN_GameManager.Death = true;
        }
    }
}
