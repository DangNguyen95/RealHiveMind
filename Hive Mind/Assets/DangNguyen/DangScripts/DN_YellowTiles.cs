using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DN_YellowTiles : MonoBehaviour {
    public GameObject FakeBlock;
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
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "YellowBlock")
        {
            if (YellowTile)
            {
                TileDone = true;
                gameObject.GetComponent<BoxCollider>().enabled = false;
                FakeBlock.SetActive(true);
                other.gameObject.SetActive(false);
            }
        }
        if(other.tag == "BlueBlock")
        {
            if(BlueTile)
            {
                TileDone = true;
                gameObject.GetComponent<BoxCollider>().enabled = false;
                FakeBlock.SetActive(true);
                other.gameObject.SetActive(false);
            }
        }
        if (other.tag == "PurpleBlock")
        {
            if (PurpleTile)
            {
                TileDone = true;
                gameObject.GetComponent<BoxCollider>().enabled = false;
                FakeBlock.SetActive(true);
                other.gameObject.SetActive(false);
            }
        }
        if (other.tag == "GreenBlock")
        {
            if (GreenTile)
            {
                TileDone = true;
                gameObject.GetComponent<BoxCollider>().enabled = false;
                FakeBlock.SetActive(true);
                other.gameObject.SetActive(false);
            }
        }
    }

}
