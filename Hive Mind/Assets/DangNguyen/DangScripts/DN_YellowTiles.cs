using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DN_YellowTiles : MonoBehaviour {
    public GameObject FakeBlock;
    public GameObject BloxON;
    public GameObject BloxIdle;
    public bool TileDone;
    public bool YellowTile;
    public bool PurpleTile;
    public bool BlueTile;
    public bool GreenTile;
	// Use this for initialization
	void Start () {
   
      
	}
	
	// Update is called once per frame
	void Update () {
   
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "YellowBlock")
        {
            if (YellowTile)
            {
                BloxIdle.SetActive(true);
                TileDone = true;
                gameObject.GetComponent<BoxCollider>().enabled = false;
                BloxON.SetActive(true);
               FakeBlock.SetActive(true);
                other.gameObject.SetActive(false);
                
            }
        }
        if(other.tag == "BlueBlock")
        {
            if(BlueTile)
            {
                BloxIdle.SetActive(true);
                TileDone = true;
                gameObject.GetComponent<BoxCollider>().enabled = false;
                BloxON.SetActive(true);
               FakeBlock.SetActive(true);
                other.gameObject.SetActive(false);
            }
        }
        if (other.tag == "PurpleBlock")
        {
            if (PurpleTile)
            {
                BloxIdle.SetActive(true);
                TileDone = true;
                gameObject.GetComponent<BoxCollider>().enabled = false;
                BloxON.SetActive(true);
                FakeBlock.SetActive(true);
                other.gameObject.SetActive(false);
            }
        }
        if (other.tag == "GreenBlock")
        {
            if (GreenTile)
            {
                BloxIdle.SetActive(true);
                TileDone = true;
                gameObject.GetComponent<BoxCollider>().enabled = false;
                BloxON.SetActive(true);
                FakeBlock.SetActive(true);
                other.gameObject.SetActive(false);
            }
        }
    }

}
