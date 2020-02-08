using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DN_MechActivateScript : MonoBehaviour {
    public GameObject MechSuit;
    private DN_Mech MechScript;
    public AudioSource MechactivateSOund;
	// Use this for initialization
	void Start () {
        MechScript = MechSuit.GetComponent<DN_Mech>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void MechStopActivating()
    {
        MechScript.StopActivating = true;
        MechScript.MechIdle.SetActive(true);
    }
    public void ActivatingSOund()
    {
        MechactivateSOund.Play();
    }
}
