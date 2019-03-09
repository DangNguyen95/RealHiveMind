using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AL_PanelManager : MonoBehaviour {


    int numOfSwitchesOn;
    List<GameObject> listObjects = new List<GameObject>();
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(numOfSwitchesOn == 2)
        {
            foreach(AL_Spotlights element in FindObjectsOfType<AL_Spotlights>())
            {
                listObjects.Add(element.gameObject);
                element.gameObject.SetActive(false);
            }
        }
	}


    public void switches()
    {
        numOfSwitchesOn++;
        listObjects.RemoveRange(0, listObjects.Count);
    }

    public void switchesOn()
    {
        numOfSwitchesOn--;
        foreach (GameObject element in listObjects)
        {
            element.gameObject.SetActive(true);
        }
    }
}
