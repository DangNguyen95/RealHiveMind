using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DN_Lever : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Square")
        {
            DN_LeverManager.SquareInPlace = true;
        }
        if (other.tag == "O")
        {
            DN_LeverManager.CirlceInPlace = true;
        }
        if (other.tag == "X")
        {
            DN_LeverManager.XInplace = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Square")
        {
            DN_LeverManager.SquareInPlace = false;
        }
        if (other.tag == "O")
        {
            DN_LeverManager.CirlceInPlace = false;
        }
        if (other.tag == "X")
        {
            DN_LeverManager.XInplace = true;
        }
    }
}
