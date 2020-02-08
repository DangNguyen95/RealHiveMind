using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DN_BotOut : MonoBehaviour {
    public bool GoUp;
    public Animator BotAnim;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(GoUp == true)
        {
            BotAnim.SetBool("GoUp", true);
        }
	}
    public void BotOut()
    {
        gameObject.SetActive(false);
    }
}
