using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AL_PressurePlate : MonoBehaviour {
    [SerializeField]
    int myDoorNumber = 0;
    GameObject refToMyDoorManager;
    GameObject refToMyDoor;
    float step;
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
    }
	// Update is called once per frame
	void Update () {
        step = Time.deltaTime * 10;
	}

    private void OnTriggerStay(Collider other)
    {
        if (other.GetComponentInParent<DN_PlayerMovement>())
        {
            if (refToMyDoor != null)
            {
                refToMyDoor.GetComponent<BoxCollider>().size = Vector3.Lerp(refToMyDoor.GetComponent<BoxCollider>().size, new Vector3(0.5f, 0, 0.5f), step);
                if (refToMyDoor.GetComponent<BoxCollider>().size == new Vector3(0.5f, 0, 0.5f))
                {
                    refToMyDoor.SetActive(false);
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
            if (refToMyDoor != null)
            {
                refToMyDoor.SetActive(true);
                refToMyDoor.GetComponent<BoxCollider>().size = new Vector3(0.9f,1,0.9f);
                
            }
        }
    }
}
