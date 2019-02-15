using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NM_WallStop : MonoBehaviour {
    [SerializeField]
    GameObject[] Wallsstop;
    [SerializeField]
    GameObject[] Wallsmove;

    public bool stopwalls, movewalls;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "X" || other.gameObject.tag == "O" || other.gameObject.tag == "Traingle" || other.gameObject.tag == "Square")
        {

            if (stopwalls)
            {
                foreach (GameObject stop in Wallsstop)
                {
                    stop.GetComponent<NM_WallMove>().speed = 0;


                    //element.gameObject.SetActive(false);
                }
            }

            if (movewalls)
            {
                foreach (GameObject move in Wallsmove)
                {
                    move.GetComponent<NM_WallMove>().speed = 1;


                    //element.gameObject.SetActive(false);
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {

        if (other.gameObject.tag == "X" || other.gameObject.tag == "O" || other.gameObject.tag == "Triangle" || other.gameObject.tag == "Square")
        {
            if (stopwalls)
            {

                foreach (GameObject element in Wallsstop)
                {
                   element.GetComponent<NM_WallMove>().speed = 1;


                    //element.gameObject.SetActive(false);
                }
            }

            if (movewalls)
            {
                foreach (GameObject move in Wallsmove)
                {
                    move.GetComponent<NM_WallMove>().speed = 0;


                    //element.gameObject.SetActive(false);
                }
            }
        }
    }
}
