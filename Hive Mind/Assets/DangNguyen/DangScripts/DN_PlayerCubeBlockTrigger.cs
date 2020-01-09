using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DN_PlayerCubeBlockTrigger : MonoBehaviour {
    public bool Player1InPlace;
    public bool Player2InPlace;
    public bool Player3InPlace;
    public bool Player4InPlace;
    //public bool Player5InPlace;
    //public bool Player6InPlace;
    //public bool Player7InPlace;
    //public bool Player8InPlace;
    public bool OTrigger;
    public bool XTrigger;
    public bool TriangleTrigger;
    public bool SquareTrigger;
    public GameObject SpriteSelf;
    private Animator SpriteSelfAnim;
    // Use this for initialization
    void Start () {
        SpriteSelfAnim = SpriteSelf.GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "X")
        {
            SpriteSelfAnim.SetBool("Close", true);
            if (XTrigger)
            {
                Player1InPlace = true;
            }
        }

        if (other.tag == "O")
        {
            SpriteSelfAnim.SetBool("Close", true);
            if (OTrigger)
            {
                Player2InPlace = true;
            }

        }

        if (other.tag == "Square")
        {
            SpriteSelfAnim.SetBool("Close", true);
            if (SquareTrigger)
            {
                Player3InPlace = true;
            }
        }

        if (other.tag == "Triangle")
        {
            SpriteSelfAnim.SetBool("Close", true);
            if (TriangleTrigger)
            {
                Player4InPlace = true;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "X")
        {
            SpriteSelfAnim.SetBool("Close", false);
            if (XTrigger)
            {
                Player1InPlace = false;
            }
        }

        if (other.tag == "O")
        {
            SpriteSelfAnim.SetBool("Close", false);
            if (OTrigger)
            {
                Player2InPlace = false;
            }

        }

        if (other.tag == "Square")
        {
            SpriteSelfAnim.SetBool("Close", false);
            if (SquareTrigger)
            {
                Player3InPlace = false;
            }
        }

        if (other.tag == "Triangle")
        {
            SpriteSelfAnim.SetBool("Close", false);
            if (TriangleTrigger)
            {
                Player4InPlace = false;
            }
        }
    }
}
