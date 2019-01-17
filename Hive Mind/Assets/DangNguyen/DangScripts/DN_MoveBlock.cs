using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DN_MoveBlock : MonoBehaviour {
    public GameObject WallTop;
    public GameObject WallBot;
    public GameObject WallLeft;
    public GameObject WallRight;
    public bool UpTrigger;
    public bool DownTrigger;
    public bool RightTrigger;
    public bool LeftTrigger;

    
	// Use this for initialization
	void Start () {
       
        
    }

    // Update is called once per frame
    void Update() {

    }
    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Wall")
        {
            if(UpTrigger)
            {
                WallBot.SetActive(true);
                WallTop.SetActive(false);
                WallRight.SetActive(false);
                WallLeft.SetActive(false);
            }
            if (DownTrigger)
            {
                WallBot.SetActive(false);
                WallTop.SetActive(true);
                WallRight.SetActive(false);
                WallLeft.SetActive(false);
            }
            if (RightTrigger)
            {
                WallBot.SetActive(false);
                WallTop.SetActive(false);
                WallRight.SetActive(false);
                WallLeft.SetActive(true);
            }
            if (LeftTrigger)
            {
                WallBot.SetActive(false);
                WallTop.SetActive(false);
                WallRight.SetActive(true);
                WallLeft.SetActive(false);
            }

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Wall")
        {
            if (UpTrigger)
            {
                WallBot.SetActive(true);
                WallTop.SetActive(false);
                WallRight.SetActive(false);
                WallLeft.SetActive(false);
            }
            if (DownTrigger)
            {
                WallBot.SetActive(false);
                WallTop.SetActive(true);
                WallRight.SetActive(false);
                WallLeft.SetActive(false);
            }
            if (RightTrigger)
            {
                WallBot.SetActive(false);
                WallTop.SetActive(false);
                WallRight.SetActive(false);
                WallLeft.SetActive(true);
            }
            if (LeftTrigger)
            {
                WallBot.SetActive(false);
                WallTop.SetActive(false);
                WallRight.SetActive(true);
                WallLeft.SetActive(false);
            }

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Wall")
        {
            if (UpTrigger)
            {
                WallBot.SetActive(false);
                
            }
            if (DownTrigger)
            {
                
                WallTop.SetActive(false);
                
            }
            if (RightTrigger)
            {
             
                WallLeft.SetActive(false);
            }
            if (LeftTrigger)
            {
                WallRight.SetActive(false);
           
            }
        }
    }


}
