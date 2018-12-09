using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DN_GuardDetect : MonoBehaviour {
    public GameObject Guard;
    private DN_Guard GuardScripts;
    public bool TopDetection;
    public bool BotDetection;
    public bool RightDetection;
    public bool LeftDetection;
    // Use this for initialization
    void Start () {
        GuardScripts = Guard.GetComponent<DN_Guard>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerStay(Collider other)
    {
        if (TopDetection)
        {
            if (other.tag == "Wall")
            {
                GuardScripts.StopTop = true;
            }

        }
        if (BotDetection)
        {
            if (other.tag == "Wall")
            {
                GuardScripts.StopBot = true;
            }
          
        }
        if (RightDetection)
        {
            if (other.tag == "Wall")
            {
                GuardScripts.StopRight = true;
            }
            
        }
        if (LeftDetection)
        {
            if (other.tag == "Wall")
            {
                GuardScripts.StopLeft = true;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (TopDetection)
        {
            if (other.tag == "Wall")
            {
                GuardScripts.StopTop = false;
            }

        }
        if (BotDetection)
        {
            if (other.tag == "Wall")
            {
                GuardScripts.StopBot = false;
            }
          
        }
        if (RightDetection)
        {
            if (other.tag == "Wall")
            {
                GuardScripts.StopRight = false;
            }

        }
        if (LeftDetection)
        {
            if (other.tag == "Wall")
            {
                GuardScripts.StopLeft = false;
            }
        }
    }
}
