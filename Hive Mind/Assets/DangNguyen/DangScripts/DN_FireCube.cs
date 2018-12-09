using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DN_FireCube : MonoBehaviour {
    public float FireCoolDown;
    public float SetCooldown;
	// Use this for initialization
	void Start () {
        FireCoolDown = SetCooldown;
	}
	
	// Update is called once per frame
	void Update () {
        FireCoolDown -= Time.deltaTime;
		if(FireCoolDown <=3)
        {
            gameObject.GetComponent<BoxCollider>().enabled = true;
            gameObject.GetComponent<MeshRenderer>().enabled = true;
        }
        if (FireCoolDown > 3)
        {

            gameObject.GetComponent<BoxCollider>().enabled = false;
            gameObject.GetComponent<MeshRenderer>().enabled = false;
        }
        if(FireCoolDown <= 0)
        {
            FireCoolDown = SetCooldown;
        }
	}
}
