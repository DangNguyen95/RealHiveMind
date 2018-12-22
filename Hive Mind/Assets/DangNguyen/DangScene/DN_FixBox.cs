using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DN_FixBox : MonoBehaviour {
    public GameObject Ship;
    private DN_SpaceShipControl ShipScripts;
    public float HPCountdown = 0f;
    public float MaxHpCountdown;
    public bool StartCD;
    private bool p1;
    private bool p2;
    // Use this for initialization
    void Start () {
        ShipScripts = Ship.GetComponent<DN_SpaceShipControl>();
        HPCountdown = MaxHpCountdown;
    }
	
	// Update is called once per frame
	void Update () {
        if (HPCountdown <= 0)
        {
            ShipScripts.Currenthealth += 5;
            HPCountdown = MaxHpCountdown;
        }
       
        if(StartCD)
        {
            HPCountdown -= Time.deltaTime;
        }
        if(p1 &&p2)
        {
            StartCD = true;
        }
        if(p1 == false || p2 ==false)
        {
            StartCD = false;
        }

    }
    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Square")
        {
            p1 = true;
        }
        if(other.tag == "X")
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
        if(other.tag == "X")
        {
            p2 = false;
        }
    }

}
