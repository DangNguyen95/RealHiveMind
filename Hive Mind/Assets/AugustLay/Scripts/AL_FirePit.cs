using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AL_FirePit : MonoBehaviour {
    
    public int fireNumber;
    public bool fireOn = true;
	// Use this for initialization
	void Start () {
        AL_FireManager.FiresToReach += turnMeOnOrOff;
    }
	
	// Update is called once per frame
	void Update () {
        
    }


    void turnMeOnOrOff()
    {
        if(fireOn == true)
        {
            gameObject.SetActive(true);
        }
        if(fireOn == false)
        {
            gameObject.SetActive(false);
        }
    }
}
