﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DN_LeverManager : MonoBehaviour {
    public GameObject Cell;
    public GameObject Cell2;
    public static bool SquareInPlace;
    public static bool CirlceInPlace;
    public static bool XInplace;
    public static bool OInplace;
    public Animator HorrizontalDoor;
    public Animator VerticalDoor;
	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
		if(SquareInPlace && CirlceInPlace)
        {
            HorrizontalDoor.SetBool("HDoorOff", true);
            Cell.GetComponent<Rigidbody>().useGravity = true;
            Cell.GetComponent<Rigidbody>().isKinematic = false;
        }
        if(XInplace && SquareInPlace)
        {
            VerticalDoor.SetBool("VDoorOff", true);
            Cell2.GetComponent<Rigidbody>().useGravity = true;
            Cell2.GetComponent<Rigidbody>().isKinematic = false;
        }
	}
}
