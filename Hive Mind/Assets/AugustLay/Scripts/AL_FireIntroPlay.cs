using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AL_FireIntroPlay : MonoBehaviour {


    GameObject myPfiIntro;
    GameObject myFirePitINtro;
    

	// Use this for initialization
	void Start () {
        AL_FireIntro.startIntro += PlayMyIntro;
        myPfiIntro = transform.GetChild(1).gameObject;
        myFirePitINtro = transform.GetChild(0).gameObject;

        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PlayMyIntro()
    {
        StartCoroutine(startIntro());
    }

    IEnumerator startIntro()
    {
        myPfiIntro.SetActive(true);
        yield return new WaitForSeconds(2);
        myPfiIntro.SetActive(false);
        myFirePitINtro.SetActive(true);
        yield return new WaitForSeconds(2);

        transform.parent.gameObject.GetComponent<AL_FireIntro>().DoneWithIntro();
        
    }
}
