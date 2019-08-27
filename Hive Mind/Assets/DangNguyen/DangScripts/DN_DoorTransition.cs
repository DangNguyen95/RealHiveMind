using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DN_DoorTransition : MonoBehaviour {
    public GameObject OtherDoor;
    public bool ThisDoor;
    public bool ThatDoor;
    private DN_DoorTransition DoorScripts;
    public GameObject DoorClose;
    public bool ThisCloseDoor;
    public GameObject RightDoor;
    public GameObject LeftDoor;
    private DN_DoorTransition LeftdoorScript;
    private DN_DoorTransition RightdoorScript;
    public bool ReOpen;
   
	// Use this for initialization
	void Start () {
        if (ThisCloseDoor == false)
        {
            DoorScripts = OtherDoor.GetComponent<DN_DoorTransition>();
            gameObject.GetComponent<Animator>().SetBool("Close", true);
            gameObject.GetComponent<Animator>().SetBool("Open", false);
        }
        if(ThisCloseDoor)
        {
            LeftdoorScript = LeftDoor.GetComponent<DN_DoorTransition>();
            RightdoorScript = RightDoor.GetComponent<DN_DoorTransition>();
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (ThisCloseDoor == false && ReOpen == false)
        {
            ThatDoor = DoorScripts.ThisDoor;
        }
        if (ThisDoor && ThatDoor && ThisCloseDoor == false && ReOpen == false)
        {
            DoorClose.SetActive(true);
            
            gameObject.SetActive(false);
        }
        if(ReOpen)
        {
            gameObject.GetComponent<Animator>().SetBool("Open", true);
            gameObject.GetComponent<Animator>().SetBool("Close", false);
            ReOpen = false;
        }

    }
    public void ThisDoorActivate()
    {
        ThisDoor = true;
    }
    public void ActivateClosing()
    {
        gameObject.GetComponent<Animator>().SetBool("Close", true);
        gameObject.GetComponent<Animator>().SetBool("Open", false);
    }
    public void OpenThemDoor()
    {
       
        LeftdoorScript.ThisDoor = false;
        LeftdoorScript.ThatDoor = false;
        RightdoorScript.ThisDoor = false;
        RightdoorScript.ThatDoor = false;
        LeftdoorScript.ReOpen = true;
        RightdoorScript.ReOpen = true;
        RightDoor.SetActive(true);
        LeftDoor.SetActive(true);
      
        gameObject.SetActive(false);
    }
}
