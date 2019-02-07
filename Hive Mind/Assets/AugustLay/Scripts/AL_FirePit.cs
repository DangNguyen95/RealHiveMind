using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AL_FirePit : MonoBehaviour {
    
    public int fireNumber;
    public bool fireOn = true;
    public bool firePFIOn = true;
    [SerializeField]
    GameObject myChildFires;
    [SerializeField]
    GameObject myChildPFI;
	// Use this for initialization
	void Start () {
        AL_FireManager.FiresToReach += turnMeOnOrOff;
        AL_FireManager.FirePFIReach += turnMyPFIOnOrOff;
        AL_FireManager.FireReset += resetFires;
        myChildFires = transform.GetChild(0).gameObject;
        myChildPFI = transform.GetChild(1).gameObject;
    }
	
	// Update is called once per frame
	void Update () {
        
    }


    void turnMeOnOrOff()
    {
        if(fireOn == true)
        {
            //gameObject.SetActive(true);
            myChildPFI.SetActive(false);
            myChildFires.SetActive(true);
        }
        if(fireOn == false)
        {
            //gameObject.SetActive(false);
        }
    }
    void turnMyPFIOnOrOff()
    {
        if(firePFIOn == true)
        {
            myChildPFI.SetActive(true);
        }
        else
        {

        }
    }
    void resetFires()
    {
        myChildPFI.SetActive(false);
        myChildFires.SetActive(false);
        fireOn = true;
        firePFIOn = true;
    }
}
