using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DN_TDCore : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "RedEnemy")
        {
            DN_GameManager.Death = true;
        }
    }
}
