using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DN_MechTrigger : MonoBehaviour {
    public bool TopLeft;
    public bool TopRight;
    public bool BotRight;
    public bool BotLeft;
    public GameObject Mech;
    private DN_Mech MechScripts;
	// Use this for initialization
	void Start () {
        MechScripts = Mech.GetComponent<DN_Mech>();
	}
	
	// Update is called once per frame
	void Update () {
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Square")
        {
            if (TopRight)
            {
             //   MechScripts.P1 = true;
                MechScripts.TopRight = true;
                other.gameObject.SetActive(false);
                gameObject.SetActive(false);
            }
        }
        if(other.tag == "X")
        {
            if(BotLeft)
            {
              //  MechScripts.P2 = true;
                MechScripts.BotLeft = true;
                other.gameObject.SetActive(false);
                gameObject.SetActive(false);
            }
        }
        if(other.tag == "Triangle")
        {
            if(BotRight)
            {
              //  MechScripts.P3 = true;
                MechScripts.BotRight = true;
                other.gameObject.SetActive(false);
                gameObject.SetActive(false);
            }
        }
        if(other.tag == "O")
        {
            if(TopLeft)
            {
             //   MechScripts.P4 = true;
                MechScripts.TopLeft = true;
                other.gameObject.SetActive(false);
                gameObject.SetActive(false);
            }
        }
    }
}
