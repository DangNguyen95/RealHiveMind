using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DN_TDCore : MonoBehaviour {
    public static float Health = 10;

    // Use this for initialization
    private void Awake()
    {
        Health = 10;
    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Health <=0)
        {
            DN_GameManager.Death = true;
        }
	}
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "RedEnemy")
        {
            Health -= 1;
           
        }
        if (other.tag == "BlueEnemy")
        {
            Health -= 1;
            
        }
        if (other.tag == "YellowEnemy")
        {
            Health -= 1;
            
        }
        if (other.tag == "GreenEnemy")
        {
            Health -= 1;
            
        }
    }
}
