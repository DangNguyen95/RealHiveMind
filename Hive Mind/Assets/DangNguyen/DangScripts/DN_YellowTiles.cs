using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DN_YellowTiles : MonoBehaviour {
    public GameObject FakeBlock;
    public bool TileDone;
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
            TileDone = true;
            gameObject.GetComponent<BoxCollider>().enabled = false;
            FakeBlock.SetActive(true);
            other.gameObject.SetActive(false);
        }
    }

}
