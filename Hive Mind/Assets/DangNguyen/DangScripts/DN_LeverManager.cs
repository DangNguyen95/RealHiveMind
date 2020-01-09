using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DN_LeverManager : MonoBehaviour {
    public GameObject Cell;
    public GameObject Cell2;
    public static bool SquareInPlace;
    public static bool CirlceInPlace;
    public static bool XInplace;
    public static bool OInplace;
    public Animator HorrizontalDoor;
    public Animator VerticalDoor;
    public bool Prison;
    public GameObject TrappedBot1;
    public GameObject TrappedBot2;
    private DN_PlayerMovement PlayerScripts;
    private DN_PlayerMovement PlayerScripts2;
    // Use this for initialization
    private void Awake()
    {
        SquareInPlace = false;
        CirlceInPlace = false;
        XInplace = false;
        OInplace = false;
    }
    void Start () {
        if (Prison)
        {
            PlayerScripts = TrappedBot1.GetComponent<DN_PlayerMovement>();
            PlayerScripts2 = TrappedBot2.GetComponent<DN_PlayerMovement>();
        }
	}
	
	// Update is called once per frame
	void Update () {
		if(SquareInPlace && CirlceInPlace)
        {
            if (PlayerScripts)
            {
                PlayerScripts.Imprision = false;
            }
                VerticalDoor.SetBool("VDoorOff", true);
            
            Cell.GetComponent<Rigidbody>().useGravity = true;
            Cell.GetComponent<Rigidbody>().isKinematic = false;
        }
        if(XInplace && SquareInPlace)
        {
           
                HorrizontalDoor.SetBool("HDoorOff", true);
            if (PlayerScripts2)
            {
                PlayerScripts2.Imprision = false;
            }
            Cell2.GetComponent<Rigidbody>().useGravity = true;
            Cell2.GetComponent<Rigidbody>().isKinematic = false;
        }
	}
}
