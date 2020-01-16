using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DN_TDCore : MonoBehaviour {

    public GameObject HealthText;
    private DN_TDBaseHealth BaseHealthScript;
    // Use this for initialization
  
    void Start () {
        BaseHealthScript = HealthText.GetComponent<DN_TDBaseHealth>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "RedEnemy")
        {
            BaseHealthScript.TDHealth -= 1;
           
        }
        if (other.tag == "BlueEnemy")
        {
            BaseHealthScript.TDHealth -= 1;
        }
        if (other.tag == "YellowEnemy")
        {
            BaseHealthScript.TDHealth -= 1;

        }
        if (other.tag == "GreenEnemy")
        {
            BaseHealthScript.TDHealth -= 1;

        }
    }
}
