using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AL_PressurePlate : MonoBehaviour {
   
    public GameObject PlateOn;
    public GameObject PlateOff;
    public GameObject PlateOff2;
 
	// Use this for initialization
	void Start () {
      
	}
	
	// Update is called once per frame
	void Update () {
    
	}

    private void OnTriggerStay(Collider other)
    {
        
        if(other.tag == "O")
        {
            PlateOn.SetActive(true);
            PlateOff.SetActive(false);
            PlateOff2.SetActive(false);
        }
        if (other.tag == "Triangle")
        {
            PlateOn.SetActive(true);
            PlateOff.SetActive(false);
            PlateOff2.SetActive(false);
        }
        if (other.tag == "X")
        {
            PlateOn.SetActive(true);
            PlateOff.SetActive(false);
            PlateOff2.SetActive(false);
        }
        if (other.tag == "Square")
        {
            PlateOn.SetActive(true);
            PlateOff.SetActive(false);
            PlateOff2.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "O")
        {
            PlateOn.SetActive(false);
            PlateOff.SetActive(true);
            PlateOff2.SetActive(false);
        }
        if (other.tag == "Triangle")
        {
            PlateOn.SetActive(false);
            PlateOff.SetActive(true);
            PlateOff2.SetActive(false);
        }
        if (other.tag == "X")
        {
            PlateOn.SetActive(false);
            PlateOff.SetActive(true);
            PlateOff2.SetActive(false);
        }
        if (other.tag == "Square")
        {
            PlateOn.SetActive(false);
            PlateOff.SetActive(true);
            PlateOff2.SetActive(false);
        }

    }
}
