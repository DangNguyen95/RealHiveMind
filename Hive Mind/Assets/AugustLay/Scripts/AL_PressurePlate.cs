using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AL_PressurePlate : MonoBehaviour {
    [SerializeField]
    int myDoorNumber = 0;
    GameObject refToMyDoorManager;
    GameObject refToMyDoor;
    float step;

    bool onThePlate = false;
	// Use this for initialization
	void Start () {
        //AL_DoorManager doorManager = FindObjectOfType<AL_DoorManager>();
        StartCoroutine(ExecuteDelay(2));
        //refToMyDoor = doorManager.gameObject.GetComponent<AL_DoorManager>().numDoors[myDoorNumber];
	}
	IEnumerator ExecuteDelay(float time)
    {
        yield return new WaitForSeconds(time);
        AL_DoorManager doorManager = FindObjectOfType<AL_DoorManager>();
        refToMyDoorManager = doorManager.gameObject;
        refToMyDoor = refToMyDoorManager.GetComponent<AL_DoorManager>().numDoors[myDoorNumber];
        refToMyDoor.GetComponent<AL_Door>().pressurePlate = gameObject;
    }
	// Update is called once per frame
	void Update () {
        step = Time.deltaTime * 10;
	}

    private void OnTriggerStay(Collider other)
    {
        if (other.GetComponentInParent<DN_PlayerMovement>())
        {
            onThePlate = true;
            if (refToMyDoor != null)
            {
                refToMyDoor.GetComponent<BoxCollider>().size = Vector3.Lerp(refToMyDoor.GetComponent<BoxCollider>().size, new Vector3(0.5f, 0.5f, 0.5f), step);
                if (refToMyDoor.GetComponent<BoxCollider>().size.x <= 0.6f && refToMyDoor.GetComponent<BoxCollider>().size.z <= 0.6f)
                {
                refToMyDoor.tag = "Untagged";
                //refToMyDoor.GetComponent<BoxCollider>().size = new Vector3(0.5f, 0.5f, 0.5f);
                refToMyDoor.GetComponent<MeshRenderer>().enabled = false;
                }
                //refToMyDoor.GetComponent<Rigidbody>().useGravity = true;
                //refToMyDoor.GetComponent<Rigidbody>().isKinematic = false;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {

        if (other.GetComponentInParent<DN_PlayerMovement>())
        {
            onThePlate = false;
            if (refToMyDoor != null && refToMyDoor.GetComponent<AL_Door>().playerOnMe == false)
            {
                refToMyDoor.GetComponent<BoxCollider>().size = new Vector3(1f, 1f, 1f);
                refToMyDoor.GetComponent<MeshRenderer>().enabled = true;
                refToMyDoor.tag = "Wall";

            }
        }
    }

    public void playerTrigger()
    {
        if(refToMyDoor.GetComponent<MeshRenderer>().enabled == false && onThePlate == false)
        {
            refToMyDoor.GetComponent<BoxCollider>().size = new Vector3(1f, 1f, 1f);
            refToMyDoor.GetComponent<MeshRenderer>().enabled = true;
            refToMyDoor.tag = "Wall";
        }
    }
}
