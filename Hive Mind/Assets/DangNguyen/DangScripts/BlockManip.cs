using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockManip : MonoBehaviour {
    public GameObject Self;
    private Rigidbody SelfRidgidbody;
    private bool Undo;
	// Use this for initialization
	void Start () {
        SelfRidgidbody = Self.GetComponent<Rigidbody>();
	}

    // Update is called once per frame
    private void FixedUpdate()
    {

        if (transform.position.z >= 0.461711f)
        {
            //if (Undo == false)
            //{
            //    SelfRidgidbody.isKinematic = true;
            //    Undo = true;
            //}
            //else
            //{
            //    SelfRidgidbody.isKinematic = false;
            //}

            SelfRidgidbody.constraints = RigidbodyConstraints.FreezeRotation;
            SelfRidgidbody.constraints = RigidbodyConstraints.FreezePositionZ;
            SelfRidgidbody.constraints = RigidbodyConstraints.FreezePositionY;
        }
    }
  
    
}
