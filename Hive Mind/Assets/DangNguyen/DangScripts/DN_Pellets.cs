using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DN_Pellets : MonoBehaviour {
    public GameObject PointText;
    private DN_Points PointsScripts;
	// Use this for initialization
	void Start () {
        PointsScripts = PointText.GetComponent<DN_Points>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "X" ||other.tag == "Square" || other.tag == "O" || other.tag == "Triangle")
        {
            PointsScripts.PointsNumber += 1;
            gameObject.SetActive(false);
        }
    }

}
