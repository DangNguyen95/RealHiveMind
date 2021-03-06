﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DN_MoveBlock : MonoBehaviour {
    public GameObject WallTop;
    public GameObject WallBot;
    public GameObject WallLeft;
    public GameObject WallRight;
    public GameObject WallTopGO;
    public GameObject WallBotGO;
    public GameObject WallLeftGO;
    public GameObject WallRightGO;
    //public GameObject TopO;
    //public GameObject BotO;
    //public GameObject LeftO;
    //public GameObject RightO;
    //public GameObject TopX;
    //public GameObject BotX;
    //public GameObject LeftX;
    //public GameObject RightX;
    //public GameObject TopSquare;
    //public GameObject BotSquare;
    //public GameObject LeftSquare;
    //public GameObject RightSquare;
    //public GameObject TopTriangle;
    //public GameObject BotTriangle;
    //public GameObject RightTriangle;
    //public GameObject LeftTriangle;
    public bool UpTrigger;
    public bool DownTrigger;
    public bool RightTrigger;
    public bool LeftTrigger;
    

    
	// Use this for initialization
	void Start () {

        
    }

    // Update is called once per frame
    void Update() {

    }
    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Wall")
        {
            if (UpTrigger)
            {
                WallBot.SetActive(true);
                WallBotGO.SetActive(false);
                //TopX.SetActive(false);
                //BotX.SetActive(true);
                //RightX.SetActive(false);
                //LeftX.SetActive(false);
            }

            if (DownTrigger)
            {
                WallTop.SetActive(true);
                WallTopGO.SetActive(false);
                //TopX.SetActive(true);
                //BotX.SetActive(false);
                //RightX.SetActive(false);
                //LeftX.SetActive(false);
            }

            if (RightTrigger)
            {
                WallLeft.SetActive(true);
                WallLeftGO.SetActive(false);
                //TopX.SetActive(false);
                //BotX.SetActive(false);
                //RightX.SetActive(false);
                //LeftX.SetActive(true);
            }

            if (LeftTrigger)
            {
                WallRight.SetActive(true);
                WallRightGO.SetActive(false);
                //TopX.SetActive(false);
                //BotX.SetActive(false);
                //RightX.SetActive(true);
                //LeftX.SetActive(false);
            }

        }
        if(other.tag == "O")
        {
            if (UpTrigger)
            {
                WallBot.SetActive(true);
                WallBotGO.SetActive(false);
                //TopX.SetActive(false);
                //BotX.SetActive(true);
                //RightX.SetActive(false);
                //LeftX.SetActive(false);
            }

            if (DownTrigger)
            {
                WallTop.SetActive(true);
                WallTopGO.SetActive(false);
                //TopX.SetActive(true);
                //BotX.SetActive(false);
                //RightX.SetActive(false);
                //LeftX.SetActive(false);
            }

            if (RightTrigger)
            {
                WallLeft.SetActive(true);
                WallLeftGO.SetActive(false);
                //TopX.SetActive(false);
                //BotX.SetActive(false);
                //RightX.SetActive(false);
                //LeftX.SetActive(true);
            }

            if (LeftTrigger)
            {
                WallRight.SetActive(true);
                WallRightGO.SetActive(false);
                //TopX.SetActive(false);
                //BotX.SetActive(false);
                //RightX.SetActive(true);
                //LeftX.SetActive(false);
            }
        }
        if(other.tag == "X")
        {
            if (UpTrigger)
            {
                WallBot.SetActive(true);
                WallBotGO.SetActive(false);
                //TopX.SetActive(false);
                //BotX.SetActive(true);
                //RightX.SetActive(false);
                //LeftX.SetActive(false);
            }
       
            if(DownTrigger)
            {
                WallTop.SetActive(true);
                WallTopGO.SetActive(false);
                //TopX.SetActive(true);
                //BotX.SetActive(false);
                //RightX.SetActive(false);
                //LeftX.SetActive(false);
            }
          
            if(RightTrigger)
            {
                WallLeft.SetActive(true);
                WallLeftGO.SetActive(false);
                //TopX.SetActive(false);
                //BotX.SetActive(false);
                //RightX.SetActive(false);
                //LeftX.SetActive(true);
            }
      
            if(LeftTrigger)
            {
                WallRight.SetActive(true);
                WallRightGO.SetActive(false);
                //TopX.SetActive(false);
                //BotX.SetActive(false);
                //RightX.SetActive(true);
                //LeftX.SetActive(false);
            }
   
        }
        if (other.tag == "Triangle")
        {
            if (UpTrigger)
            {
                WallBot.SetActive(true);
                WallBotGO.SetActive(false);
                //TopTriangle.SetActive(false);
                //BotTriangle.SetActive(true);
                //RightTriangle.SetActive(false);
                //LeftTriangle.SetActive(false);
            }
      
            if (DownTrigger)
            {
                WallTop.SetActive(true);
                WallTopGO.SetActive(false);
                //TopTriangle.SetActive(true);
                //BotTriangle.SetActive(false);
                //RightTriangle.SetActive(false);
                //LeftTriangle.SetActive(false);
            }
        
       
            if (RightTrigger)
            {
                WallLeft.SetActive(true);
                WallLeftGO.SetActive(false);
                //TopTriangle.SetActive(false);
                //BotTriangle.SetActive(false);
                //RightTriangle.SetActive(false);
                //LeftTriangle.SetActive(true);
            }
         
            if (LeftTrigger)
            {
                WallRight.SetActive(true);
                WallRightGO.SetActive(false);
               
                 //TopTriangle.SetActive(false);
                //BotTriangle.SetActive(false);
                //RightTriangle.SetActive(true);
                //LeftTriangle.SetActive(false);
            }
  
        }
        if (other.tag == "Square")
        {
            if (UpTrigger)
            {
                WallBot.SetActive(true);
                WallBotGO.SetActive(false);
                //TopX.SetActive(false);
                //BotX.SetActive(true);
                //RightX.SetActive(false);
                //LeftX.SetActive(false);
            }

            if (DownTrigger)
            {
                WallTop.SetActive(true);
                WallTopGO.SetActive(false);
                //TopX.SetActive(true);
                //BotX.SetActive(false);
                //RightX.SetActive(false);
                //LeftX.SetActive(false);
            }

            if (RightTrigger)
            {
                WallLeft.SetActive(true);
                WallLeftGO.SetActive(false);
                //TopX.SetActive(false);
                //BotX.SetActive(false);
                //RightX.SetActive(false);
                //LeftX.SetActive(true);
            }

            if (LeftTrigger)
            {
                WallRight.SetActive(true);
                WallRightGO.SetActive(false);
                //TopX.SetActive(false);
                //BotX.SetActive(false);
                //RightX.SetActive(true);
                //LeftX.SetActive(false);
            }
        }


    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Wall")
        {
            if (UpTrigger)
            {
                WallBot.SetActive(true);
                WallBotGO.SetActive(false);
                //TopX.SetActive(false);
                //BotX.SetActive(true);
                //RightX.SetActive(false);
                //LeftX.SetActive(false);
            }

            if (DownTrigger)
            {
                WallTop.SetActive(true);
                WallTopGO.SetActive(false);
                //TopX.SetActive(true);
                //BotX.SetActive(false);
                //RightX.SetActive(false);
                //LeftX.SetActive(false);
            }

            if (RightTrigger)
            {
                WallLeft.SetActive(true);
                WallLeftGO.SetActive(false);
                //TopX.SetActive(false);
                //BotX.SetActive(false);
                //RightX.SetActive(false);
                //LeftX.SetActive(true);
            }

            if (LeftTrigger)
            {
                WallRight.SetActive(true);
                WallRightGO.SetActive(false);
                //TopX.SetActive(false);
                //BotX.SetActive(false);
                //RightX.SetActive(true);
                //LeftX.SetActive(false);
            }

        }
        if (other.tag == "O")
        {
            if (UpTrigger)
            {
                WallBot.SetActive(true);
                WallBotGO.SetActive(false);
                //TopX.SetActive(false);
                //BotX.SetActive(true);
                //RightX.SetActive(false);
                //LeftX.SetActive(false);
            }

            if (DownTrigger)
            {
                WallTop.SetActive(true);
                WallTopGO.SetActive(false);
                //TopX.SetActive(true);
                //BotX.SetActive(false);
                //RightX.SetActive(false);
                //LeftX.SetActive(false);
            }

            if (RightTrigger)
            {
                WallLeft.SetActive(true);
                WallLeftGO.SetActive(false);
                //TopX.SetActive(false);
                //BotX.SetActive(false);
                //RightX.SetActive(false);
                //LeftX.SetActive(true);
            }

            if (LeftTrigger)
            {
                WallRight.SetActive(true);
                WallRightGO.SetActive(false);
                //TopX.SetActive(false);
                //BotX.SetActive(false);
                //RightX.SetActive(true);
                //LeftX.SetActive(false);
            }
        }
        if (other.tag == "X")
        {
            if (UpTrigger)
            {
                WallBot.SetActive(true);
                WallBotGO.SetActive(false);
                //TopX.SetActive(false);
                //BotX.SetActive(true);
                //RightX.SetActive(false);
                //LeftX.SetActive(false);
            }

            if (DownTrigger)
            {
                WallTop.SetActive(true);
                WallTopGO.SetActive(false);
                //TopX.SetActive(true);
                //BotX.SetActive(false);
                //RightX.SetActive(false);
                //LeftX.SetActive(false);
            }

            if (RightTrigger)
            {
                WallLeft.SetActive(true);
                WallLeftGO.SetActive(false);
                //TopX.SetActive(false);
                //BotX.SetActive(false);
                //RightX.SetActive(false);
                //LeftX.SetActive(true);
            }

            if (LeftTrigger)
            {
                WallRight.SetActive(true);
                WallRightGO.SetActive(false);
                //TopX.SetActive(false);
                //BotX.SetActive(false);
                //RightX.SetActive(true);
                //LeftX.SetActive(false);
            }
        }
        if (other.tag == "Triangle")
        {
            if (UpTrigger)
            {
                WallBot.SetActive(true);
                WallBotGO.SetActive(false);
                //TopTriangle.SetActive(false);
                //BotTriangle.SetActive(true);
                //RightTriangle.SetActive(false);
                //LeftTriangle.SetActive(false);
            }

            if (DownTrigger)
            {
                WallTop.SetActive(true);
                WallTopGO.SetActive(false);
                //TopTriangle.SetActive(true);
                //BotTriangle.SetActive(false);
                //RightTriangle.SetActive(false);
                //LeftTriangle.SetActive(false);
            }


            if (RightTrigger)
            {
                WallLeft.SetActive(true);
                WallLeftGO.SetActive(false);
                //TopTriangle.SetActive(false);
                //BotTriangle.SetActive(false);
                //RightTriangle.SetActive(false);
                //LeftTriangle.SetActive(true);
            }

            if (LeftTrigger)
            {
                WallRight.SetActive(true);
                WallRightGO.SetActive(false);
               
                //TopTriangle.SetActive(false);
                //BotTriangle.SetActive(false);
                //RightTriangle.SetActive(true);
                //LeftTriangle.SetActive(false);
            }
        }
        if (other.tag == "Square")
        {
            if (UpTrigger)
            {
                WallBot.SetActive(true);
                WallBotGO.SetActive(false);
                //TopX.SetActive(false);
                //BotX.SetActive(true);
                //RightX.SetActive(false);
                //LeftX.SetActive(false);
            }

            if (DownTrigger)
            {
                WallTop.SetActive(true);
                WallTopGO.SetActive(false);
                //TopX.SetActive(true);
                //BotX.SetActive(false);
                //RightX.SetActive(false);
                //LeftX.SetActive(false);
            }

            if (RightTrigger)
            {
                WallLeft.SetActive(true);
                WallLeftGO.SetActive(false);
                //TopX.SetActive(false);
                //BotX.SetActive(false);
                //RightX.SetActive(false);
                //LeftX.SetActive(true);
            }

            if (LeftTrigger)
            {
                WallRight.SetActive(true);
                WallRightGO.SetActive(false);
                //TopX.SetActive(false);
                //BotX.SetActive(false);
                //RightX.SetActive(true);
                //LeftX.SetActive(false);
            }
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Wall")
        {
            if (UpTrigger)
            {
                WallBot.SetActive(false);
                WallBotGO.SetActive(true);
                
            }
            if (DownTrigger)
            {
                
                WallTop.SetActive(false);
                WallTopGO.SetActive(true);
                
            }
            if (RightTrigger)
            {
                WallLeftGO.SetActive(true);
                WallLeft.SetActive(false);
            }
            if (LeftTrigger)
            {
                WallRight.SetActive(false);
                WallRightGO.SetActive(true);
            }
        }
        if (other.tag == "O")
        {
            if (UpTrigger)
            {
                WallBot.SetActive(false);
                WallBotGO.SetActive(true);

            }
            if (DownTrigger)
            {

                WallTop.SetActive(false);
                WallTopGO.SetActive(true);

            }
            if (RightTrigger)
            {
                WallLeftGO.SetActive(true);
                WallLeft.SetActive(false);
            }
            if (LeftTrigger)
            {
                WallRight.SetActive(false);
                WallRightGO.SetActive(true);
            }
        }
        if (other.tag == "X")
        {
            if (UpTrigger)
            {
                WallBot.SetActive(false);
                WallBotGO.SetActive(true);

            }
            if (DownTrigger)
            {
                WallTopGO.SetActive(true);
                WallTop.SetActive(false);

            }
            if (RightTrigger)
            {
                WallLeftGO.SetActive(true);
                WallLeft.SetActive(false);
            }
            if (LeftTrigger)
            {
                WallRight.SetActive(false);
                WallRightGO.SetActive(true);
            }
        }
        if (other.tag == "Triangle")
        {
            if (UpTrigger)
            {
                WallBot.SetActive(false);
                WallBotGO.SetActive(true);

            }
            if (DownTrigger)
            {
                WallTopGO.SetActive(true);
                WallTop.SetActive(false);

            }
            if (RightTrigger)
            {
                WallLeftGO.SetActive(true);
                WallLeft.SetActive(false);
            }
            if (LeftTrigger)
            {

                WallRight.SetActive(false);
                WallRightGO.SetActive(true);
              
            }
        }
        if (other.tag == "Square")
        {
            if (UpTrigger)
            {
                WallBot.SetActive(false);
                WallBotGO.SetActive(true);

            }
            if (DownTrigger)
            {

                WallTop.SetActive(false);
                WallTopGO.SetActive(true);

            }
            if (RightTrigger)
            {
                WallLeftGO.SetActive(true);
                WallLeft.SetActive(false);
            }
            if (LeftTrigger)
            {
                WallRight.SetActive(false);
                WallRightGO.SetActive(true);
            }
        }
      

    }


}
