using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapActivate : MonoBehaviour {
    public GameObject FireTrap;
	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void DeathActivate()
    {
        FireTrap.GetComponent<BoxCollider>().enabled = true;
    }
    public void DeathDeactivate()
    {
        FireTrap.GetComponent<BoxCollider>().enabled = false;
    }
}
