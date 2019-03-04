using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DN_MoveBOx : MonoBehaviour {
    public GameObject Ship;
    private DN_SpaceShipControl ShipScripts;
    public bool UpPad;
    public bool DownPad;
    // Use this for initialization
    void Start () {
        ShipScripts = Ship.GetComponent<DN_SpaceShipControl>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Triangle" && UpPad)
        {
            ShipScripts.UpPad = true;
        }
        if (other.tag == "O" && UpPad)
        {
            ShipScripts.UpPad = true;
        }
        if (other.tag == "Triangle" && DownPad)
        {
            ShipScripts.DownPad = true;
        }
        if (other.tag == "O" && DownPad)
        {
            ShipScripts.DownPad = true;
        }
        if (other.tag == "Square" && UpPad)
        {
            ShipScripts.UpPad = true;
        }
        if (other.tag == "Square" && DownPad)
        {
            ShipScripts.DownPad = true;
        }
        if (other.tag == "X" && UpPad)
        {
            ShipScripts.UpPad = true;
        }
        if (other.tag == "X" && DownPad)
        {
            ShipScripts.DownPad = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Triangle" && UpPad)
        {
            ShipScripts.UpPad = false;
        }
        if (other.tag == "O" && UpPad)
        {
            ShipScripts.UpPad = false;
        }
        if (other.tag == "Triangle" && DownPad)
        {
            ShipScripts.DownPad = false;
        }
        if (other.tag == "O" && DownPad)
        {
            ShipScripts.DownPad = false;
        }
        if (other.tag == "Square" && UpPad)
        {
            ShipScripts.UpPad = false;
        }
        if (other.tag == "Square" && DownPad)
        {
            ShipScripts.DownPad = false;
        }
        if (other.tag == "X" && UpPad)
        {
            ShipScripts.UpPad = false;
        }
        if (other.tag == "X" && DownPad)
        {
            ShipScripts.DownPad = false;
        }
    }
}
