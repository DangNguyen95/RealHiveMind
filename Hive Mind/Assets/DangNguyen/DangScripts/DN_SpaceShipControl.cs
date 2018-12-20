using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DN_SpaceShipControl : MonoBehaviour {
    public bool UpPad;
    public bool DownPad;
    public bool StopPointDown;
    public bool StopPointUp;
    public bool ShootLeft;
    public bool ShootRight;
    public bool Shield;
    public bool FixShip;
    public bool Grab;
    public float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //if(StopPointUp)
        //{
        //    MoveBox1.SetActive(false);
        //}
        //else
        //{
        //    MoveBox1.SetActive(true);
        //}
        //if(StopPointDown)
        //{
        //    MoveBox2.SetActive(false);
        //}
        //else
        //{
        //    MoveBox2.SetActive(true);
        //}
		if(UpPad && StopPointDown == false)
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
        if(DownPad && StopPointUp == false)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
	}
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "StopPointUpper")
        {
            StopPointUp = true;
        }
        if (other.tag == "StopPointUnder")
        {
            StopPointDown = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "StopPointUpper")
        {
            StopPointUp = false;
        }
        if (other.tag == "StopPointUnder")
        {
            StopPointDown = false;
        }
    }

}
