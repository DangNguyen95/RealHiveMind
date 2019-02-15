using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NM_ChangePosition : MonoBehaviour {
    public bool Back, Forward, Left, Right;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Wall")
        {

            print("here i am");
            if (Back)
            {
                other.GetComponent<NM_WallMove>().Back = true;
                other.GetComponent<NM_WallMove>().Forward = false;
                other.GetComponent<NM_WallMove>().Left = false;
                other.GetComponent<NM_WallMove>().Right = false;
            }
            if (Forward)
            {
                other.GetComponent<NM_WallMove>().Back = false;
                other.GetComponent<NM_WallMove>().Forward = true;
                other.GetComponent<NM_WallMove>().Left = false;
                other.GetComponent<NM_WallMove>().Right = false;
            }
            if (Right)
            {
                other.GetComponent<NM_WallMove>().Back = false;
                other.GetComponent<NM_WallMove>().Forward = false;
                other.GetComponent<NM_WallMove>().Left = false;
                other.GetComponent<NM_WallMove>().Right = true;
            }
            if (Left)
            {
                other.GetComponent<NM_WallMove>().Back = false;
                other.GetComponent<NM_WallMove>().Forward = false;
                other.GetComponent<NM_WallMove>().Left = true;
                other.GetComponent<NM_WallMove>().Right = false;
            }
            other.GetComponent<NM_WallMove>().positioning();
        }
    }
}
