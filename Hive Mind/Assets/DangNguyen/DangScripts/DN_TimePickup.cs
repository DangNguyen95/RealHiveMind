using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DN_TimePickup : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Square")
        {
            FindObjectOfType<DN_Time>().IncreaseTimer();
            gameObject.SetActive(false);
        }
        if (other.tag == "O")
        {
            FindObjectOfType<DN_Time>().IncreaseTimer();
            gameObject.SetActive(false);
        }
        if (other.tag == "X")
        {
            FindObjectOfType<DN_Time>().IncreaseTimer();
            gameObject.SetActive(false);
        }
        if (other.tag == "Triangle")
        {
            FindObjectOfType<DN_Time>().IncreaseTimer();
            gameObject.SetActive(false);
        }
    }
}
