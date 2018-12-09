using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DN_HomeDetect : MonoBehaviour {

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
            DN_GameManager.SquareHome = true;
        }
        if (other.tag == "O")
        {
            DN_GameManager.OHome = true;
        }
        if (other.tag == "X")
        {
            DN_GameManager.XHome = true;
        }
        if (other.tag == "Triangle")
        {
            DN_GameManager.TriangleHome = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Square")
        {
            DN_GameManager.SquareHome = false;
        }
        if (other.tag == "O")
        {
            DN_GameManager.OHome = false;
        }
        if (other.tag == "X")
        {
            DN_GameManager.XHome = false;
        }
        if (other.tag == "Triangle")
        {
            DN_GameManager.TriangleHome = false;
        }
    }
}
