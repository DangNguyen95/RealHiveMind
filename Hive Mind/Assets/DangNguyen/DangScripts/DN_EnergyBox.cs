using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DN_EnergyBox : MonoBehaviour {
    private bool p1;
    private bool p2;
    public GameObject Ship;
    private DN_SpaceShipControl ShipScripts;
    // Use this for initialization
    void Start () {
        ShipScripts = Ship.GetComponent<DN_SpaceShipControl>();
	}
	
	// Update is called once per frame
	void Update () {
		if(p1 && p2)
        {
            if (ShipScripts.RegenEnergy == false)
            {
                ShipScripts.DecreaseEnergy();
              //  ShipScripts.ForceEnergyIncrease = false;
            }
        }
        if(p1 == false || p2 == false)
        {
            
            if (ShipScripts.RegenEnergy == false)
            {
                ShipScripts.IncreaseEnergy();
                //ShipScripts.ForceEnergyIncrease = true;
            }

        }
	}
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Square")
        {
            p1 = true;
        }
        if (other.tag == "X")
        {
            p2 = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Square")
        {
            p1 = false;
        }
        if (other.tag == "X")
        {
            p2 = false;
        }
    }
}
