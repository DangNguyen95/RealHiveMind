using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AL_FireIntro : MonoBehaviour {
    bool doOnce = false;

    public delegate void FireIntroToListen();
    public static event FireIntroToListen startIntro;

    AL_FireManager fireManager;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.timeScale == 1 &&doOnce == false)
        {
            doOnce = true;
            fireManager = FindObjectOfType<AL_FireManager>();
            startIntro.Invoke();
        }
	}

    public void DoneWithIntro()
    {
        fireManager.doneWithIntro = true;
        gameObject.SetActive(false);
    }
}
