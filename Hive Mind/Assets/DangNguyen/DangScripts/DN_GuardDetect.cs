using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DN_GuardDetect : MonoBehaviour {
    public GameObject Guard;
    private DN_Guard GuardScripts;
    public bool Guard1;
    public bool Guard2;
    public bool Guard3;
    public bool Guard4;
    public bool TopDetection;
    public bool BotDetection;
    public bool RightDetection;
    public bool LeftDetection;
    public bool KillLEvel;
    private DN_GameManager GameManager;
    public GameObject GamemangerObject;
    // Use this for initialization
    void Start () {
        GuardScripts = Guard.GetComponent<DN_Guard>();
        if (KillLEvel)
        {
            GameManager = GamemangerObject.GetComponent<DN_GameManager>();
        }
    }
	
	// Update is called once per frame
	void Update () {
      
    }
    void OnDisable()
    {
        if (KillLEvel)
        {
            GameManager.KillerCount -= 1;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "RightWall")
        {
            GuardScripts.RunRight = true;
          
        }
        if (other.tag == "LeftWall")
        {
            GuardScripts.RunRight = false;
           
        }
        if (TopDetection)
        {
            if (other.tag == "Kill")
            {
                GuardScripts.DeathANimation = true;
            }
        }
        if(RightDetection)
        {
            if (other.tag == "Kill")
            {
                GuardScripts.DeathANimation = true;
            }
        }
        if(LeftDetection)
        {
            if (other.tag == "Kill")
            {
                GuardScripts.DeathANimation = true;
            }
        }
        if(BotDetection)
        {
            if (other.tag == "Kill")
            {
                GuardScripts.DeathANimation = true;
            }
        }

        }
    private void OnTriggerStay(Collider other)
    {
        if (TopDetection)
        {
            if(other.tag == "Kill")
            {
                GuardScripts.DeathANimation = true;
            }
            if (other.tag == "Wall")
            {
                GuardScripts.StopTop = true;
            }
            if (Guard1 && other.tag == "Guard2")
            {
                GuardScripts.StopTop = true;
            }
            if (Guard1 && other.tag == "Guard3")
            {
                GuardScripts.StopTop = true;
            }
            if (Guard1 && other.tag == "Guard4")
            {
                GuardScripts.StopTop = true;
            }
            if (Guard2 && other.tag == "Guard1")
            {
                GuardScripts.StopTop = true;
            }
            if (Guard2 && other.tag == "Guard3")
            {
                GuardScripts.StopTop = true;
            }
            if (Guard2 && other.tag == "Guard4")
            {
                GuardScripts.StopTop = true;
            }
            if (Guard3 && other.tag == "Guard1")
            {
                GuardScripts.StopTop = true;
            }
            if (Guard3 && other.tag == "Guard2")
            {
                GuardScripts.StopTop = true;
            }
            if (Guard3 && other.tag == "Guard4")
            {
                GuardScripts.StopTop = true;
            }
            if (Guard4 && other.tag == "Guard1")
            {
                GuardScripts.StopTop = true;
            }
            if (Guard4 && other.tag == "Guard2")
            {
                GuardScripts.StopTop = true;
            }
            if (Guard4 && other.tag == "Guard3")
            {
                GuardScripts.StopTop = true;
            }

        }
        if (BotDetection)
        {
            if (other.tag == "Kill")
            {
                GuardScripts.DeathANimation = true;
            }
            if (other.tag == "Wall")
            {
                GuardScripts.StopBot = true;
            }
           
            if (Guard1 && other.tag == "Guard2")
            {
                GuardScripts.StopBot = true;
            }
            if (Guard1 && other.tag == "Guard3")
            {
                GuardScripts.StopBot = true;
            }
            if (Guard1 && other.tag == "Guard4")
            {
                GuardScripts.StopBot = true;
            }
            if (Guard2 && other.tag == "Guard1")
            {
                GuardScripts.StopBot = true;
            }
            if (Guard2 && other.tag == "Guard3")
            {
                GuardScripts.StopBot = true;
            }
            if (Guard2 && other.tag == "Guard4")
            {
                GuardScripts.StopBot = true;
            }
            if (Guard3 && other.tag == "Guard1")
            {
                GuardScripts.StopBot = true;
            }
            if (Guard3 && other.tag == "Guard2")
            {
                GuardScripts.StopBot = true;
            }
            if (Guard3 && other.tag == "Guard4")
            {
                GuardScripts.StopBot = true;
            }
            if (Guard4 && other.tag == "Guard1")
            {
                GuardScripts.StopBot = true;
            }
            if (Guard4 && other.tag == "Guard2")
            {
                GuardScripts.StopBot = true;
            }
            if (Guard4 && other.tag == "Guard3")
            {
                GuardScripts.StopBot = true;
            }

        }
        if (RightDetection)
        {
            if (other.tag == "Kill")
            {
                GuardScripts.DeathANimation = true;
            }
            if (other.tag == "Wall")
            {
                GuardScripts.StopRight = true;
            }
            if (Guard1 && other.tag == "Guard2")
            {
                GuardScripts.StopRight = true;
            }
            if (Guard1 && other.tag == "Guard3")
            {
                GuardScripts.StopRight = true;
            }
            if (Guard1 && other.tag == "Guard4")
            {
                GuardScripts.StopRight = true;
            }
            if (Guard2 && other.tag == "Guard1")
            {
                GuardScripts.StopRight = true;
            }
            if (Guard2 && other.tag == "Guard3")
            {
                GuardScripts.StopRight = true;
            }
            if (Guard2 && other.tag == "Guard4")
            {
                GuardScripts.StopRight = true;
            }
            if (Guard3 && other.tag == "Guard1")
            {
                GuardScripts.StopRight = true;
            }
            if (Guard3 && other.tag == "Guard2")
            {
                GuardScripts.StopRight = true;
            }
            if (Guard3 && other.tag == "Guard4")
            {
                GuardScripts.StopRight = true;
            }
            if (Guard4 && other.tag == "Guard1")
            {
                GuardScripts.StopRight = true;
            }
            if (Guard4 && other.tag == "Guard2")
            {
                GuardScripts.StopRight = true;
            }
            if (Guard4 && other.tag == "Guard3")
            {
                GuardScripts.StopRight = true;
            }
        }
        if (LeftDetection)
        {
            if (other.tag == "Kill")
            {
                GuardScripts.DeathANimation = true;
            }
            if (other.tag == "Wall")
            {
                GuardScripts.StopLeft = true;
            }
            if (Guard1 && other.tag == "Guard2")
            {
                GuardScripts.StopLeft = true;
            }
            if (Guard1 && other.tag == "Guard3")
            {
                GuardScripts.StopLeft = true;
            }
            if (Guard1 && other.tag == "Guard4")
            {
                GuardScripts.StopLeft = true;
            }
            if (Guard2 && other.tag == "Guard1")
            {
                GuardScripts.StopLeft = true;
            }
            if (Guard2 && other.tag == "Guard3")
            {
                GuardScripts.StopLeft = true;
            }
            if (Guard2 && other.tag == "Guard4")
            {
                GuardScripts.StopLeft = true;
            }
            if (Guard3 && other.tag == "Guard1")
            {
                GuardScripts.StopLeft = true;
            }
            if (Guard3 && other.tag == "Guard2")
            {
                GuardScripts.StopLeft = true;
            }
            if (Guard3 && other.tag == "Guard4")
            {
                GuardScripts.StopLeft = true;
            }
            if (Guard4 && other.tag == "Guard1")
            {
                GuardScripts.StopLeft = true;
            }
            if (Guard4 && other.tag == "Guard2")
            {
                GuardScripts.StopLeft = true;
            }
            if (Guard4 && other.tag == "Guard3")
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
            if (Guard1 && other.tag == "Guard2")
            {
                GuardScripts.StopTop = false;
            }
            if (Guard1 && other.tag == "Guard3")
            {
                GuardScripts.StopTop = false;
            }
            if (Guard1 && other.tag == "Guard4")
            {
                GuardScripts.StopTop = false;
            }
            if (Guard2 && other.tag == "Guard1")
            {
                GuardScripts.StopTop = false;
            }
            if (Guard2 && other.tag == "Guard3")
            {
                GuardScripts.StopTop = false;
            }
            if (Guard2 && other.tag == "Guard4")
            {
                GuardScripts.StopTop = false;
            }
            if (Guard3 && other.tag == "Guard1")
            {
                GuardScripts.StopTop = false;
            }
            if (Guard3 && other.tag == "Guard2")
            {
                GuardScripts.StopTop = false;
            }
            if (Guard3 && other.tag == "Guard4")
            {
                GuardScripts.StopTop = false;
            }
            if (Guard4 && other.tag == "Guard1")
            {
                GuardScripts.StopTop = false;
            }
            if (Guard4 && other.tag == "Guard2")
            {
                GuardScripts.StopTop = false;
            }
            if (Guard4 && other.tag == "Guard3")
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
            if (Guard1 && other.tag == "Guard2")
            {
                GuardScripts.StopBot = false;
            }
            if (Guard1 && other.tag == "Guard3")
            {
                GuardScripts.StopBot = false;
            }
            if (Guard1 && other.tag == "Guard4")
            {
                GuardScripts.StopBot = false;
            }
            if (Guard2 && other.tag == "Guard1")
            {
                GuardScripts.StopBot = false;
            }
            if (Guard2 && other.tag == "Guard3")
            {
                GuardScripts.StopBot = false;
            }
            if (Guard2 && other.tag == "Guard4")
            {
                GuardScripts.StopBot = false;
            }
            if (Guard3 && other.tag == "Guard1")
            {
                GuardScripts.StopBot = false;
            }
            if (Guard3 && other.tag == "Guard2")
            {
                GuardScripts.StopBot = false;
            }
            if (Guard3 && other.tag == "Guard4")
            {
                GuardScripts.StopBot = false;
            }
            if (Guard4 && other.tag == "Guard1")
            {
                GuardScripts.StopBot = false;
            }
            if (Guard4 && other.tag == "Guard2")
            {
                GuardScripts.StopBot = false;
            }
            if (Guard4 && other.tag == "Guard3")
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
            if (Guard1 && other.tag == "Guard2")
            {
                GuardScripts.StopRight = false;
            }
            if (Guard1 && other.tag == "Guard3")
            {
                GuardScripts.StopRight = false;
            }
            if (Guard1 && other.tag == "Guard4")
            {
                GuardScripts.StopRight = false;
            }
            if (Guard2 && other.tag == "Guard1")
            {
                GuardScripts.StopRight = false;
            }
            if (Guard2 && other.tag == "Guard3")
            {
                GuardScripts.StopRight = false;
            }
            if (Guard2 && other.tag == "Guard4")
            {
                GuardScripts.StopRight = false;
            }
            if (Guard3 && other.tag == "Guard1")
            {
                GuardScripts.StopRight = false;
            }
            if (Guard3 && other.tag == "Guard2")
            {
                GuardScripts.StopRight = false;
            }
            if (Guard3 && other.tag == "Guard4")
            {
                GuardScripts.StopRight = false;
            }
            if (Guard4 && other.tag == "Guard1")
            {
                GuardScripts.StopRight = false;
            }
            if (Guard4 && other.tag == "Guard2")
            {
                GuardScripts.StopRight = false;
            }
            if (Guard4 && other.tag == "Guard3")
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
            if (Guard1 && other.tag == "Guard2")
            {
                GuardScripts.StopLeft = false;
            }
            if (Guard1 && other.tag == "Guard3")
            {
                GuardScripts.StopLeft = false;
            }
            if (Guard1 && other.tag == "Guard4")
            {
                GuardScripts.StopLeft = false;
            }
            if (Guard2 && other.tag == "Guard1")
            {
                GuardScripts.StopLeft = false;
            }
            if (Guard2 && other.tag == "Guard3")
            {
                GuardScripts.StopLeft = false;
            }
            if (Guard2 && other.tag == "Guard4")
            {
                GuardScripts.StopLeft = false;
            }
            if (Guard3 && other.tag == "Guard1")
            {
                GuardScripts.StopLeft = false;
            }
            if (Guard3 && other.tag == "Guard2")
            {
                GuardScripts.StopLeft = false;
            }
            if (Guard3 && other.tag == "Guard4")
            {
                GuardScripts.StopLeft = false;
            }
            if (Guard4 && other.tag == "Guard1")
            {
                GuardScripts.StopLeft = false;
            }
            if (Guard4 && other.tag == "Guard2")
            {
                GuardScripts.StopLeft = false;
            }
            if (Guard4 && other.tag == "Guard3")
            {
                GuardScripts.StopLeft = false;
            }
        }
       
    }
}
