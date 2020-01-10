using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockManip : MonoBehaviour {

    public GameObject Block;
    public Transform OriginalPosition; 
	// Use this for initialization
	void Start () {
      
	}

    // Update is called once per frame
    private void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Wall")
        {
            Block.transform.position = OriginalPosition.position;
        }
        if (other.tag == "X")
        {
            Block.transform.position = OriginalPosition.position;
        }
        if (other.tag == "O")
        {
            Block.transform.position = OriginalPosition.position;
        }
        if (other.tag == "Triangle")
        {
            Block.transform.position = OriginalPosition.position;
        }
        if (other.tag == "Square")
        {
            Block.transform.position = OriginalPosition.position;
        }
    }


}
