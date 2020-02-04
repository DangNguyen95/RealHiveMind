using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AL_PressurePlate : MonoBehaviour {
   
   
    public GameObject PlateOff;
    public GameObject PlateOff2;
    public GameObject PlateOff3;
    public GameObject Otherplate1;
    private AL_PressurePlate PresureplateScript1;
    private AL_PressurePlate PresureplateScript2;
    public GameObject Otherplate2;
    public Transform gateLoc;
    public Transform GateLoc2;
    public bool RushLevel;
    public bool GateSync;
	// Use this for initialization
	void Start () {
      if(RushLevel)
        {
            PresureplateScript1 = Otherplate1.GetComponent<AL_PressurePlate>();
            PresureplateScript2 = Otherplate2.GetComponent<AL_PressurePlate>();
        }
	}
	
	// Update is called once per frame
	void Update () {
    
	}

    private void OnTriggerStay(Collider other)
    {
        
        if(other.tag == "O")
        {
            if(RushLevel)
            {
                PlateOff.GetComponent<Rigidbody>().useGravity = true;
                PlateOff.GetComponent<Rigidbody>().isKinematic = false;
                PlateOff2.GetComponent<Rigidbody>().useGravity = true;
                PlateOff2.GetComponent<Rigidbody>().isKinematic = false;
                PlateOff3.GetComponent<Rigidbody>().useGravity = true;
                PlateOff3.GetComponent<Rigidbody>().isKinematic = false;
                GateSync = true;

            }
            else
            {
                PlateOff.GetComponent<Rigidbody>().useGravity = true;
                PlateOff.GetComponent<Rigidbody>().isKinematic = false;
                PlateOff2.GetComponent<Rigidbody>().useGravity = true;
                PlateOff2.GetComponent<Rigidbody>().isKinematic = false;
                PlateOff3.GetComponent<Rigidbody>().useGravity = true;
                PlateOff3.GetComponent<Rigidbody>().isKinematic = false;
            }
           
            //PlateOn.SetActive(true);
            //PlateOff.SetActive(false);
            //PlateOff2.SetActive(false);
        }
        if (other.tag == "Triangle")
        {
            if (RushLevel)
            {
                PlateOff.GetComponent<Rigidbody>().useGravity = true;
                PlateOff.GetComponent<Rigidbody>().isKinematic = false;
                PlateOff2.GetComponent<Rigidbody>().useGravity = true;
                PlateOff2.GetComponent<Rigidbody>().isKinematic = false;
                PlateOff3.GetComponent<Rigidbody>().useGravity = true;
                PlateOff3.GetComponent<Rigidbody>().isKinematic = false;
                GateSync = true;

            }
            else
            {
                PlateOff.GetComponent<Rigidbody>().useGravity = true;
                PlateOff.GetComponent<Rigidbody>().isKinematic = false;
                PlateOff2.GetComponent<Rigidbody>().useGravity = true;
                PlateOff2.GetComponent<Rigidbody>().isKinematic = false;
                PlateOff3.GetComponent<Rigidbody>().useGravity = true;
                PlateOff3.GetComponent<Rigidbody>().isKinematic = false;
            }
        }
        if (other.tag == "X")
        {
            if (RushLevel)
            {

                PlateOff.GetComponent<Rigidbody>().useGravity = true;
                PlateOff.GetComponent<Rigidbody>().isKinematic = false;
                PlateOff2.GetComponent<Rigidbody>().useGravity = true;
                PlateOff2.GetComponent<Rigidbody>().isKinematic = false;
                PlateOff3.GetComponent<Rigidbody>().useGravity = true;
                PlateOff3.GetComponent<Rigidbody>().isKinematic = false;
                GateSync = true;
            }
            else
            {
                PlateOff.GetComponent<Rigidbody>().useGravity = true;
                PlateOff.GetComponent<Rigidbody>().isKinematic = false;
                PlateOff2.GetComponent<Rigidbody>().useGravity = true;
                PlateOff2.GetComponent<Rigidbody>().isKinematic = false;
                PlateOff3.GetComponent<Rigidbody>().useGravity = true;
                PlateOff3.GetComponent<Rigidbody>().isKinematic = false;
            }
        }
        if (other.tag == "Square")
        {
            if (RushLevel)
            {
                PlateOff.GetComponent<Rigidbody>().useGravity = true;
                PlateOff.GetComponent<Rigidbody>().isKinematic = false;
                PlateOff2.GetComponent<Rigidbody>().useGravity = true;
                PlateOff2.GetComponent<Rigidbody>().isKinematic = false;
                PlateOff3.GetComponent<Rigidbody>().useGravity = true;
                PlateOff3.GetComponent<Rigidbody>().isKinematic = false;
                GateSync = true;

            }
            else
            {
                PlateOff.GetComponent<Rigidbody>().useGravity = true;
                PlateOff.GetComponent<Rigidbody>().isKinematic = false;
                PlateOff2.GetComponent<Rigidbody>().useGravity = true;
                PlateOff2.GetComponent<Rigidbody>().isKinematic = false;
                PlateOff3.GetComponent<Rigidbody>().useGravity = true;
                PlateOff3.GetComponent<Rigidbody>().isKinematic = false;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "O")
        {
            if (RushLevel && PresureplateScript1.GateSync ==false || RushLevel && PresureplateScript2.GateSync == false)
            {
                PlateOff.GetComponent<Rigidbody>().useGravity = false;
                PlateOff.GetComponent<Rigidbody>().isKinematic = true;
                PlateOff2.GetComponent<Rigidbody>().useGravity = false;
                PlateOff2.GetComponent<Rigidbody>().isKinematic = true;
                PlateOff3.GetComponent<Rigidbody>().useGravity = false;
                PlateOff3.GetComponent<Rigidbody>().isKinematic = true;
                PlateOff.transform.position = gateLoc.transform.position;
                PlateOff2.transform.position = gateLoc.transform.position;
                PlateOff3.transform.position = GateLoc2.transform.position;
                GateSync = false;
            }
            else
            {
                PlateOff.GetComponent<Rigidbody>().useGravity = false;
                PlateOff.GetComponent<Rigidbody>().isKinematic = true;
                PlateOff2.GetComponent<Rigidbody>().useGravity = false;
                PlateOff2.GetComponent<Rigidbody>().isKinematic = true;
                PlateOff3.GetComponent<Rigidbody>().useGravity = false;
                PlateOff3.GetComponent<Rigidbody>().isKinematic = true;
                PlateOff.transform.position = gateLoc.transform.position;
                PlateOff2.transform.position = gateLoc.transform.position;
            }
               
            //PlateOn.SetActive(false);
            //PlateOff.SetActive(true);
            //PlateOff2.SetActive(false);
        }
        if (other.tag == "Triangle")
        {
            if (RushLevel && PresureplateScript1.GateSync ==false || RushLevel && PresureplateScript2.GateSync == false)
            {
                PlateOff.GetComponent<Rigidbody>().useGravity = false;
                PlateOff.GetComponent<Rigidbody>().isKinematic = true;
                PlateOff2.GetComponent<Rigidbody>().useGravity = false;
                PlateOff2.GetComponent<Rigidbody>().isKinematic = true;
                PlateOff3.GetComponent<Rigidbody>().useGravity = false;
                PlateOff3.GetComponent<Rigidbody>().isKinematic = true;
                PlateOff.transform.position = gateLoc.transform.position;
                PlateOff3.transform.position = GateLoc2.transform.position;
                PlateOff2.transform.position = gateLoc.transform.position;
                GateSync = false;
            }
            else
            {
                PlateOff.GetComponent<Rigidbody>().useGravity = false;
                PlateOff.GetComponent<Rigidbody>().isKinematic = true;
                PlateOff2.GetComponent<Rigidbody>().useGravity = false;
                PlateOff2.GetComponent<Rigidbody>().isKinematic = true;
                PlateOff3.GetComponent<Rigidbody>().useGravity = false;
                PlateOff3.GetComponent<Rigidbody>().isKinematic = true;
                PlateOff.transform.position = gateLoc.transform.position;
                PlateOff2.transform.position = gateLoc.transform.position;
                PlateOff3.transform.position = GateLoc2.transform.position;
            }
        }
        if (other.tag == "X")
        {
            if (RushLevel && PresureplateScript1.GateSync==false || RushLevel && PresureplateScript2.GateSync == false)
            {
                PlateOff.GetComponent<Rigidbody>().useGravity = false;
                PlateOff.GetComponent<Rigidbody>().isKinematic = true;
                PlateOff2.GetComponent<Rigidbody>().useGravity = false;
                PlateOff2.GetComponent<Rigidbody>().isKinematic = true;
                PlateOff3.GetComponent<Rigidbody>().useGravity = false;
                PlateOff3.GetComponent<Rigidbody>().isKinematic = true;
                PlateOff.transform.position = gateLoc.transform.position;
                PlateOff2.transform.position = gateLoc.transform.position;
                PlateOff3.transform.position = GateLoc2.transform.position;
                GateSync = false;
            }
            else
            {
                PlateOff.GetComponent<Rigidbody>().useGravity = false;
                PlateOff.GetComponent<Rigidbody>().isKinematic = true;
                PlateOff2.GetComponent<Rigidbody>().useGravity = false;
                PlateOff2.GetComponent<Rigidbody>().isKinematic = true;
                PlateOff3.GetComponent<Rigidbody>().useGravity = false;
                PlateOff3.GetComponent<Rigidbody>().isKinematic = true;
                PlateOff.transform.position = gateLoc.transform.position;
                PlateOff2.transform.position = gateLoc.transform.position;
            }
        }
        if (other.tag == "Square")
        {
            if (RushLevel && PresureplateScript1.GateSync == false || RushLevel && PresureplateScript2.GateSync == false)
            {
                PlateOff.GetComponent<Rigidbody>().useGravity = false;
                PlateOff.GetComponent<Rigidbody>().isKinematic = true;
                PlateOff2.GetComponent<Rigidbody>().useGravity = false;
                PlateOff2.GetComponent<Rigidbody>().isKinematic = true;
                PlateOff3.GetComponent<Rigidbody>().useGravity = false;
                PlateOff3.GetComponent<Rigidbody>().isKinematic = true;
                PlateOff.transform.position = gateLoc.transform.position;
                PlateOff2.transform.position = gateLoc.transform.position;
                PlateOff3.transform.position = GateLoc2.transform.position;
                GateSync = false;
            }
            else
            {
                PlateOff.GetComponent<Rigidbody>().useGravity = false;
                PlateOff.GetComponent<Rigidbody>().isKinematic = true;
                PlateOff2.GetComponent<Rigidbody>().useGravity = false;
                PlateOff2.GetComponent<Rigidbody>().isKinematic = true;
                PlateOff3.GetComponent<Rigidbody>().useGravity = false;
                PlateOff3.GetComponent<Rigidbody>().isKinematic = true;
                PlateOff.transform.position = gateLoc.transform.position;
                PlateOff2.transform.position = gateLoc.transform.position;
            }
        }

    }
}
