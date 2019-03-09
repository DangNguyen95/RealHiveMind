using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DN_ActivateTurret : MonoBehaviour {
    public GameObject Turrets;

	// Use this for initialization
	void Start () {
    
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Square")
        {
            Turrets.SetActive(true);
        }
        if (other.tag == "X")
        {
            Turrets.SetActive(true);
        }
        if (other.tag == "O")
        {
            Turrets.SetActive(true);
        }
        if (other.tag == "Triangle")
        {
            Turrets.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Square")
        {
            Turrets.SetActive(false);
        }
        if (other.tag == "X")
        {
            Turrets.SetActive(false);
        }
        if (other.tag == "O")
        {
            Turrets.SetActive(false);
        }
        if (other.tag == "Triangle")
        {
            Turrets.SetActive(false);
        }
    }
}
