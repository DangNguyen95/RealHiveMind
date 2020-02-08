using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DN_mechMovingScript : MonoBehaviour {
    public AudioSource MechMovingSound;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void MechMove()
    {
        MechMovingSound.Play();
    }
}
