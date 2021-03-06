﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DN_Mech : MonoBehaviour {
    public bool canMove = true, moving = false;
    public int speed = 5, buttonCooldown = 0;
    public int cooldownforbutton;
    private DIRECTION dir = DIRECTION.DOWN;
    private Vector3 pos;
    public bool MovingDown;
    public bool MovingUp;
    public bool MovingLeft;
    public bool MovingRight;
    public bool StopTop;
    public bool StopRight;
    public bool StopLeft;
    public bool StopBot;
    private bool O1;
    private bool Square1;
    private bool Triangle1;
    private bool X1;
    private bool O2;
    private bool Square2;
    private bool Triangle2;
    private bool X2;
    private bool X3;
    private bool O3;
    private bool Square3;
    private bool Triangle3;
    private bool X4;
    private bool O4;
    private bool Square4;
    private bool Triangle4;
    private bool B1;
    private bool A1;
    private bool XB1;
    private bool Y1;
    private bool B2;
    private bool A2;
    private bool XB2;
    private bool Y2;
    private bool B3;
    private bool A3;
    private bool XB3;
    private bool Y3;
    private bool B4;
    private bool A4;
    private bool XB4;
    private bool Y4;
    public bool P1;
    public bool P2;
    public bool P3;
    public bool P4;
    public GameObject[] Marker1;
    public GameObject[] Marker2;
    public GameObject[] Marker3;
    public GameObject[] Marker4;
    public static bool SoloKeyBoard;
    public static bool UsbExtender;
    public static bool SoloController;
    public static bool DualController;
    public static bool ThreeController;
    public static bool FourController;
    public GameObject[] KeyboardKey;
    public GameObject[] PS4Buttons;
    public GameObject[] XboxButtons;
    public GameObject TopRightCube;
    public GameObject TopLeftCube;
    public GameObject BotRightCube;
    public GameObject BotLeftCube;
    public GameObject TopRightCube2;
    public GameObject TopLeftCube2;
    public GameObject BotRightCube2;
    public GameObject BotLeftCube2;
    public GameObject FakeTopRightCube;
    public GameObject FakeBotLeftCube;
    public GameObject FakeBotRightCube;
    public GameObject FakeTopLeftCube;
    public GameObject Bouncewall;
    public bool TopRight;
    public bool TopLeft;
    public bool BotRight;
    public bool BotLeft;
    public bool TopBool;
    public bool LeftBool;
    public bool RightBool;
    public bool DownBool;
    public GameObject KillerTrigger1;
    public GameObject KillerTrigger2;
    public GameObject[] ArrowDirection;
    public GameObject MechFakeIdle;
    public GameObject MechIdle;
    public GameObject MechActivating;
    public GameObject MechMoveRNL;
    public GameObject MechMoveUND;
    public bool StopActivating;
    public DN_BotOut XBotOut;
    public DN_BotOut OBotOut;
    public DN_BotOut TriangleBotOut;
    public DN_BotOut SquareBotOut;
   
    // Use this for initialization
    void Start()
    {
        SquareBotOut = TopRightCube.GetComponent<DN_BotOut>();
        OBotOut = TopLeftCube.GetComponent<DN_BotOut>();
        TriangleBotOut = BotRightCube.GetComponent<DN_BotOut>();
        XBotOut = BotLeftCube.GetComponent<DN_BotOut>();
       
        //SoloController = true;
        // DualController = true;
        // UsbExtender = true;
        // ThreeController = true;
        // FourController = true;
        //  SoloKeyBoard = true;
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetAxis("Solo P1 Press Up Arrow") < 1 && Input.GetAxis("Solo P1 Press Right Arrow") < 1 && Input.GetAxis("Solo P1 Press Left Arrow") < 1 && Input.GetAxis("Solo P1 Press Down Arrow") < 1 && (Input.GetAxis("P1 Press Up Arrow") < 1 && Input.GetAxis("P1 Press Left Arrow") < 1 && Input.GetAxis("P1 Press Right Arrow") < 1 && Input.GetAxis("P1 Press Down Arrow") < 1 && Input.GetAxis("P2 Press Left Arrow") < 1 && Input.GetAxis("P2 Press Right Arrow") < 1 && Input.GetAxis("P2 Press Down Arrow") < 1 && Input.GetAxis("P2 Press Up Arrow") < 1 && Input.GetAxis("P3 Press Left Arrow") < 1 && Input.GetAxis("P3 Press Right Arrow") < 1 && Input.GetAxis("P3 Press Down Arrow") < 1 && Input.GetAxis("P3 Press Up Arrow") < 1 && Input.GetAxis("P4 Press Left Arrow") < 1 && Input.GetAxis("P4 Press Right Arrow") < 1 && Input.GetAxis("P4 Press Down Arrow") < 1 && Input.GetAxis("P4 Press Up Arrow") < 1 && DN_MainMenuMannager.Ps4 && StopActivating))
        //{
        //    MechIdle.SetActive(true);
        //    MechMoveRNL.SetActive(false);
        //    MechMoveUND.SetActive(false);
        //}
        if (DN_PlayerMovement.SoloController)
        {
            SoloController = true;
        }
        if(DN_PlayerMovement.DualController)
        {
            DualController = true;
        }
        if(DN_PlayerMovement.ThreeController)
        {
            ThreeController = true;
        }
        if(DN_PlayerMovement.FourController)
        {
            FourController = true;
        }
        if(DN_PlayerMovement.UsbExtender)
        {
            UsbExtender = true;
        }
        Debug.Log(SoloController);
        if (TopRight)
        {
        
            if (StopActivating)
            {
                TopRightCube2.SetActive(true);
               
             //   TopRightCube.SetActive(false);
            }
            if(TopBool == false)
            {
                TopRightCube.SetActive(true);
                TopBool = true;
            }
          
            FakeTopRightCube.SetActive(false);
        }
        if(TopLeft)
        {
            
            if (StopActivating)
            {
                TopLeftCube2.SetActive(true);
                
              //  TopLeftCube.SetActive(false);
            }
            if(LeftBool == false)
            {
                TopLeftCube.SetActive(true);
             
                LeftBool = true;
            }
        
            FakeTopLeftCube.SetActive(false);
        }
        if(BotRight)
        {
            
            if (StopActivating)
            {
                BotRightCube2.SetActive(true);
               
              //  BotRightCube.SetActive(false);
            }
            if(RightBool == false)
            {
                BotRightCube.SetActive(true);
                RightBool = true;
            }
         
            FakeBotRightCube.SetActive(false);
        }
        if(BotLeft)
        {
           
            if (StopActivating)
            {
                BotLeftCube2.SetActive(true);
            
                //   BotLeftCube.SetActive(false);
            }
          if(DownBool == false)
            {
                BotLeftCube.SetActive(true);
                DownBool = true;
            }
            FakeBotLeftCube.SetActive(false);
           
        }
        if (TopLeft && TopRight && BotLeft && BotRight)
        {
            if(StopActivating == false)
            {
                OBotOut.GoUp = true;
                TriangleBotOut.GoUp = true;
                XBotOut.GoUp = true;
                SquareBotOut.GoUp = true;
                //TopRightCube.SetActive(false);
                //TopLeftCube.SetActive(false);
                //BotRightCube.SetActive(false);
                //BotLeftCube.SetActive(false);
                MechFakeIdle.SetActive(false);
                MechActivating.SetActive(true);
                MechMoveRNL.SetActive(false);
                MechMoveUND.SetActive(false);
            }
            if(StopActivating)
            {
                for (int i = 0; i < ArrowDirection.Length; i++)
                {
                    ArrowDirection[i].SetActive(true);
                }
                MechActivating.SetActive(false);
            }
        }
            if (SoloController && DN_MainMenuMannager.Ps4)
        {
            if (TopLeft && TopRight && BotLeft && BotRight)
            {
                for (int i = 0; i < KeyboardKey.Length; i++)
                {
                    KeyboardKey[i].SetActive(false);
                }
                for (int i = 0; i < PS4Buttons.Length; i++)
                {
                    PS4Buttons[i].SetActive(true);
                }
                for (int i = 0; i < XboxButtons.Length; i++)
                {
                    XboxButtons[i].SetActive(false);
                }

                if (Input.GetAxis("Solo P1 Press Circle") != 0)
                {
                    Marker1[0].SetActive(true);
                    Marker2[0].SetActive(false);
                    Marker3[0].SetActive(false);
                    Marker4[0].SetActive(false);
                    O1 = true;
                    Square1 = false;
                    Triangle1 = false;
                    X1 = false;
                }
                if (Input.GetAxis("Solo P1 Press Square") != 0)
                {
                    Marker1[0].SetActive(false);
                    Marker2[0].SetActive(true);
                    Marker3[0].SetActive(false);
                    Marker4[0].SetActive(false);
                    O1 = false;
                    Square1 = true;
                    Triangle1 = false;
                    X1 = false;
                }
                if (Input.GetAxis("Solo P1 Press Triangle") != 0)
                {
                    Marker1[0].SetActive(false);
                    Marker2[0].SetActive(false);
                    Marker3[0].SetActive(true);
                    Marker4[0].SetActive(false);
                    O1 = false;
                    Square1 = false;
                    Triangle1 = true;
                    X1 = false;
                }
                if (Input.GetAxis("Solo P1 Press X") != 0)
                {
                    Marker1[0].SetActive(false);
                    Marker2[0].SetActive(false);
                    Marker3[0].SetActive(false);
                    Marker4[0].SetActive(true);
                    O1 = false;
                    Square1 = false;
                    Triangle1 = false;
                    X1 = true;
                }
            }
        }
        if (SoloController && DN_MainMenuMannager.Xbox && TopLeft && TopRight && BotLeft && BotRight)
        {
            for (int i = 0; i < KeyboardKey.Length; i++)
            {
                KeyboardKey[i].SetActive(false);
            }
            for (int i = 0; i < PS4Buttons.Length; i++)
            {
                PS4Buttons[i].SetActive(false);
            }
            for (int i = 0; i < XboxButtons.Length; i++)
            {
                XboxButtons[i].SetActive(true);
            }

            if (Input.GetAxis("Xbox Solo P1 Press B") != 0)
            {
                Marker1[0].SetActive(true);
                Marker2[0].SetActive(false);
                Marker3[0].SetActive(false);
                Marker4[0].SetActive(false);
                B1 = true;
                XB1 = false;
                Y1 = false;
                A1 = false;
            }
            if (Input.GetAxis("Xbox Solo P1 Press X") != 0)
            {
                Marker1[0].SetActive(false);
                Marker2[0].SetActive(true);
                Marker3[0].SetActive(false);
                Marker4[0].SetActive(false);
                B1 = false;
                XB1 = true;
                Y1 = false;
                A1 = false;
            }
            if (Input.GetAxis("Xbox Solo P1 Press Y") != 0)
            {
                Marker1[0].SetActive(false);
                Marker2[0].SetActive(false);
                Marker3[0].SetActive(true);
                Marker4[0].SetActive(false);
                B1 = false;
                XB1 = false;
                Y1 = true;
                A1 = false;
            }
            if (Input.GetAxis("Xbox Solo P1 Press A") != 0)
            {
                Marker1[0].SetActive(false);
                Marker2[0].SetActive(false);
                Marker3[0].SetActive(false);
                Marker4[0].SetActive(true);
                B1 = false;
                XB1 = false;
                Y1 = false;
                A1 = true;
            }
        }
        if (SoloKeyBoard)
        {
            if (TopLeft && TopRight && BotLeft && BotRight)
            {
                
                for (int i = 0; i < KeyboardKey.Length; i++)
                {
                    KeyboardKey[i].SetActive(true);
                }
                for (int i = 0; i < PS4Buttons.Length; i++)
                {
                    PS4Buttons[i].SetActive(false);
                }
                for (int i = 0; i < XboxButtons.Length; i++)
                {
                    XboxButtons[i].SetActive(false);
                }
                if (Input.GetKey(KeyCode.A))
                {

                    Marker1[0].SetActive(true);
                    Marker2[0].SetActive(false);
                    Marker3[0].SetActive(false);
                    Marker4[0].SetActive(false);
                    O1 = true;
                    Square1 = false;
                    Triangle1 = false;
                    X1 = false;
                }
                if (Input.GetKey(KeyCode.D))
                {
                    Marker1[0].SetActive(false);
                    Marker2[0].SetActive(true);
                    Marker3[0].SetActive(false);
                    Marker4[0].SetActive(false);
                    O1 = false;
                    Square1 = true;
                    Triangle1 = false;
                    X1 = false;
                }
                if (Input.GetKey(KeyCode.S))
                {
                    Marker1[0].SetActive(false);
                    Marker2[0].SetActive(false);
                    Marker3[0].SetActive(true);
                    Marker4[0].SetActive(false);
                    O1 = false;
                    Square1 = false;
                    Triangle1 = true;
                    X1 = false;
                }
                if (Input.GetKey(KeyCode.W))
                {
                    Marker1[0].SetActive(false);
                    Marker2[0].SetActive(false);
                    Marker3[0].SetActive(false);
                    Marker4[0].SetActive(true);
                    O1 = false;
                    Square1 = false;
                    Triangle1 = false;
                    X1 = true;
                }
            }
        }
        if (DualController && DN_MainMenuMannager.Xbox && TopLeft && TopRight && BotLeft && BotRight)
        {
            for (int i = 0; i < KeyboardKey.Length; i++)
            {
                KeyboardKey[i].SetActive(false);
            }
            for (int i = 0; i < PS4Buttons.Length; i++)
            {
                PS4Buttons[i].SetActive(false);
            }
            for (int i = 0; i < XboxButtons.Length; i++)
            {
                XboxButtons[i].SetActive(true);
            }
            if (UsbExtender)
            {
                if (Input.GetAxis("Xbox P1 Press B") != 0)
                {
                    Marker1[0].SetActive(true);
                    Marker2[0].SetActive(false);
                    Marker3[0].SetActive(false);
                    Marker4[0].SetActive(false);
                    B1 = true;
                    XB1 = false;
                    Y1 = false;
                    A1 = false;
                }
                if (Input.GetAxis("Xbox P1 Press X") != 0)
                {
                    Marker1[0].SetActive(false);
                    Marker2[0].SetActive(true);
                    Marker3[0].SetActive(false);
                    Marker4[0].SetActive(false);
                    B1 = false;
                    XB1 = true;
                    Y1 = false;
                    A1 = false;
                }
                if (Input.GetAxis("Xbox P1 Press Y") != 0)
                {
                    Marker1[0].SetActive(false);
                    Marker2[0].SetActive(false);
                    Marker3[0].SetActive(true);
                    Marker4[0].SetActive(false);
                    B1 = false;
                    XB1 = false;
                    Y1 = true;
                    A1 = false;
                }
                if (Input.GetAxis("Xbox P1 Press A") != 0)
                {
                    Marker1[0].SetActive(false);
                    Marker2[0].SetActive(false);
                    Marker3[0].SetActive(false);
                    Marker4[0].SetActive(true);
                    B1 = false;
                    XB1 = false;
                    Y1 = false;
                    A1 = true;
                }
                if (Input.GetAxis("Xbox P2 Press B") != 0)
                {
                    Marker1[1].SetActive(true);
                    Marker2[1].SetActive(false);
                    Marker3[1].SetActive(false);
                    Marker4[1].SetActive(false);
                    B2 = true;
                    XB2 = false;
                    Y2 = false;
                    A2 = false;
                }
                if (Input.GetAxis("Xbox P2 Press X") != 0)
                {
                    Marker1[1].SetActive(false);
                    Marker2[1].SetActive(true);
                    Marker3[1].SetActive(false);
                    Marker4[1].SetActive(false);
                    B2 = false;
                    XB2 = true;
                    Y2 = false;
                    A2 = false;
                }
                if (Input.GetAxis("Xbox P2 Press Y") != 0)
                {
                    Marker1[1].SetActive(false);
                    Marker2[1].SetActive(false);
                    Marker3[1].SetActive(true);
                    Marker4[1].SetActive(false);
                    B2 = false;
                    XB2 = false;
                    Y2 = true;
                    A2 = false;
                }
                if (Input.GetAxis("Xbox P2 Press A") != 0)
                {
                    Marker1[1].SetActive(false);
                    Marker2[1].SetActive(false);
                    Marker3[1].SetActive(false);
                    Marker4[1].SetActive(true);
                    B2 = false;
                    XB2 = false;
                    Y2 = false;
                    A2 = true;
                }
            }
            else
            {
                if (Input.GetAxis("Xbox Solo P1 Press B") != 0)
                {
                    Marker1[0].SetActive(true);
                    Marker2[0].SetActive(false);
                    Marker3[0].SetActive(false);
                    Marker4[0].SetActive(false);
                    B1 = true;
                    XB1 = false;
                    Y1 = false;
                    A1 = false;
                }
                if (Input.GetAxis("Xbox Solo P1 Press X") != 0)
                {
                    Marker1[0].SetActive(false);
                    Marker2[0].SetActive(true);
                    Marker3[0].SetActive(false);
                    Marker4[0].SetActive(false);
                    B1 = false;
                    XB1 = true;
                    Y1 = false;
                    A1 = false;
                }
                if (Input.GetAxis("Xbox Solo P1 Press Y") != 0)
                {
                    Marker1[0].SetActive(false);
                    Marker2[0].SetActive(false);
                    Marker3[0].SetActive(true);
                    Marker4[0].SetActive(false);
                    B1 = false;
                    XB1 = false;
                    Y1 = true;
                    A1 = false;
                }
                if (Input.GetAxis("Xbox Solo P1 Press A") != 0)
                {
                    Marker1[0].SetActive(false);
                    Marker2[0].SetActive(false);
                    Marker3[0].SetActive(false);
                    Marker4[0].SetActive(true);
                    B1 = false;
                    XB1 = false;
                    Y1 = false;
                    A1 = true;
                }
                if (Input.GetAxis("Xbox P2 Press B") != 0)
                {
                    Marker1[1].SetActive(true);
                    Marker2[1].SetActive(false);
                    Marker3[1].SetActive(false);
                    Marker4[1].SetActive(false);
                    B2 = true;
                    XB2 = false;
                    Y2 = false;
                    A2 = false;
                }
                if (Input.GetAxis("Xbox P2 Press X") != 0)
                {
                    Marker1[1].SetActive(false);
                    Marker2[1].SetActive(true);
                    Marker3[1].SetActive(false);
                    Marker4[1].SetActive(false);
                    B2 = false;
                    XB2 = true;
                    Y2 = false;
                    A2 = false;
                }
                if (Input.GetAxis("Xbox P2 Press Y") != 0)
                {
                    Marker1[1].SetActive(false);
                    Marker2[1].SetActive(false);
                    Marker3[1].SetActive(true);
                    Marker4[1].SetActive(false);
                    B2 = false;
                    XB2 = false;
                    Y2 = true;
                    A2 = false;
                }
                if (Input.GetAxis("Xbox P2 Press A") != 0)
                {
                    Marker1[1].SetActive(false);
                    Marker2[1].SetActive(false);
                    Marker3[1].SetActive(false);
                    Marker4[1].SetActive(true);
                    B2 = false;
                    XB2 = false;
                    Y2 = false;
                    A2 = true;
                }
            }
        }
        if (DualController && DN_MainMenuMannager.Ps4 && TopLeft && TopRight && BotLeft && BotRight)
        {
            
            for (int i = 0; i < KeyboardKey.Length; i++)
            {
                KeyboardKey[i].SetActive(false);
            }
            for (int i = 0; i < PS4Buttons.Length; i++)
            {
                PS4Buttons[i].SetActive(true);
            }
            for (int i = 0; i < XboxButtons.Length; i++)
            {
                XboxButtons[i].SetActive(false);
            }
            if (UsbExtender)
            {
                if (Input.GetAxis("P1 Press Circle") != 0)
                {
                    Marker1[0].SetActive(true);
                    Marker2[0].SetActive(false);
                    Marker3[0].SetActive(false);
                    Marker4[0].SetActive(false);
                    O1 = true;
                    Square1 = false;
                    Triangle1 = false;
                    X1 = false;
                }
                if (Input.GetAxis("P1 Press Square") != 0)
                {
                    Marker1[0].SetActive(false);
                    Marker2[0].SetActive(true);
                    Marker3[0].SetActive(false);
                    Marker4[0].SetActive(false);
                    O1 = false;
                    Square1 = true;
                    Triangle1 = false;
                    X1 = false;
                }
                if (Input.GetAxis("P1 Press Triangle") != 0)
                {
                    Marker1[0].SetActive(false);
                    Marker2[0].SetActive(false);
                    Marker3[0].SetActive(true);
                    Marker4[0].SetActive(false);
                    O1 = false;
                    Square1 = false;
                    Triangle1 = true;
                    X1 = false;
                }
                if (Input.GetAxis("P1 Press X") != 0)
                {
                    Marker1[0].SetActive(false);
                    Marker2[0].SetActive(false);
                    Marker3[0].SetActive(false);
                    Marker4[0].SetActive(true);
                    O1 = false;
                    Square1 = false;
                    Triangle1 = false;
                    X1 = true;
                }
                if (Input.GetAxis("P2 Press Circle") != 0)
                {
                    Marker1[1].SetActive(true);
                    Marker2[1].SetActive(false);
                    Marker3[1].SetActive(false);
                    Marker4[1].SetActive(false);
                    O2 = true;
                    Square2 = false;
                    Triangle2 = false;
                    X2 = false;
                }
                if (Input.GetAxis("P2 Press Square") != 0)
                {
                    Marker1[1].SetActive(false);
                    Marker2[1].SetActive(true);
                    Marker3[1].SetActive(false);
                    Marker4[1].SetActive(false);
                    O2 = false;
                    Square2 = true;
                    Triangle2 = false;
                    X2 = false;
                }
                if (Input.GetAxis("P2 Press Triangle") != 0)
                {
                    Marker1[1].SetActive(false);
                    Marker2[1].SetActive(false);
                    Marker3[1].SetActive(true);
                    Marker4[1].SetActive(false);
                    O2 = false;
                    Square2 = false;
                    Triangle2 = true;
                    X2 = false;
                }
                if (Input.GetAxis("P2 Press X") != 0)
                {
                    Marker1[1].SetActive(false);
                    Marker2[1].SetActive(false);
                    Marker3[1].SetActive(false);
                    Marker4[1].SetActive(true);
                    O2 = false;
                    Square2 = false;
                    Triangle2 = false;
                    X2 = true;
                }
            }
            else
            {
                if (Input.GetAxis("Solo P1 Press Circle") != 0)
                {
                    Marker1[0].SetActive(true);
                    Marker2[0].SetActive(false);
                    Marker3[0].SetActive(false);
                    Marker4[0].SetActive(false);
                    O1 = true;
                    Square1 = false;
                    Triangle1 = false;
                    X1 = false;
                }
                if (Input.GetAxis("Solo P1 Press Square") != 0)
                {
                    Marker1[0].SetActive(false);
                    Marker2[0].SetActive(true);
                    Marker3[0].SetActive(false);
                    Marker4[0].SetActive(false);
                    O1 = false;
                    Square1 = true;
                    Triangle1 = false;
                    X1 = false;
                }
                if (Input.GetAxis("Solo P1 Press Triangle") != 0)
                {
                    Marker1[0].SetActive(false);
                    Marker2[0].SetActive(false);
                    Marker3[0].SetActive(true);
                    Marker4[0].SetActive(false);
                    O1 = false;
                    Square1 = false;
                    Triangle1 = true;
                    X1 = false;
                }
                if (Input.GetAxis("Solo P1 Press X") != 0)
                {
                    Marker1[0].SetActive(false);
                    Marker2[0].SetActive(false);
                    Marker3[0].SetActive(false);
                    Marker4[0].SetActive(true);
                    O1 = false;
                    Square1 = false;
                    Triangle1 = false;
                    X1 = true;
                }
                if (Input.GetAxis("P2 Press Circle") != 0)
                {
                    Marker1[1].SetActive(true);
                    Marker2[1].SetActive(false);
                    Marker3[1].SetActive(false);
                    Marker4[1].SetActive(false);
                    O2 = true;
                    Square2 = false;
                    Triangle2 = false;
                    X2 = false;
                }
                if (Input.GetAxis("P2 Press Square") != 0)
                {
                    Marker1[1].SetActive(false);
                    Marker2[1].SetActive(true);
                    Marker3[1].SetActive(false);
                    Marker4[1].SetActive(false);
                    O2 = false;
                    Square2 = true;
                    Triangle2 = false;
                    X2 = false;
                }
                if (Input.GetAxis("P2 Press Triangle") != 0)
                {
                    Marker1[1].SetActive(false);
                    Marker2[1].SetActive(false);
                    Marker3[1].SetActive(true);
                    Marker4[1].SetActive(false);
                    O2 = false;
                    Square2 = false;
                    Triangle2 = true;
                    X2 = false;
                }
                if (Input.GetAxis("P2 Press X") != 0)
                {
                    Marker1[1].SetActive(false);
                    Marker2[1].SetActive(false);
                    Marker3[1].SetActive(false);
                    Marker4[1].SetActive(true);
                    O2 = false;
                    Square2 = false;
                    Triangle2 = false;
                    X2 = true;
                }
            }
        }
        if (ThreeController && DN_MainMenuMannager.Ps4 && TopLeft && TopRight && BotLeft && BotRight)
        {
            for (int i = 0; i < KeyboardKey.Length; i++)
            {
                KeyboardKey[i].SetActive(false);
            }
            for (int i = 0; i < PS4Buttons.Length; i++)
            {
                PS4Buttons[i].SetActive(true);
            }
            for (int i = 0; i < XboxButtons.Length; i++)
            {
                XboxButtons[i].SetActive(false);
            }
            if (Input.GetAxis("P1 Press Circle") != 0)
            {
                Marker1[0].SetActive(true);
                Marker2[0].SetActive(false);
                Marker3[0].SetActive(false);
                Marker4[0].SetActive(false);
                O1 = true;
                Square1 = false;
                Triangle1 = false;
                X1 = false;
            }
            if (Input.GetAxis("P1 Press Square") != 0)
            {
                Marker1[0].SetActive(false);
                Marker2[0].SetActive(true);
                Marker3[0].SetActive(false);
                Marker4[0].SetActive(false);
                O1 = false;
                Square1 = true;
                Triangle1 = false;
                X1 = false;
            }
            if (Input.GetAxis("P1 Press Triangle") != 0)
            {
                Marker1[0].SetActive(false);
                Marker2[0].SetActive(false);
                Marker3[0].SetActive(true);
                Marker4[0].SetActive(false);
                O1 = false;
                Square1 = false;
                Triangle1 = true;
                X1 = false;
            }
            if (Input.GetAxis("P1 Press X") != 0)
            {
                Marker1[0].SetActive(false);
                Marker2[0].SetActive(false);
                Marker3[0].SetActive(false);
                Marker4[0].SetActive(true);
                O1 = false;
                Square1 = false;
                Triangle1 = false;
                X1 = true;
            }
            if (Input.GetAxis("P2 Press Circle") != 0)
            {
                Marker1[1].SetActive(true);
                Marker2[1].SetActive(false);
                Marker3[1].SetActive(false);
                Marker4[1].SetActive(false);
                O2 = true;
                Square2 = false;
                Triangle2 = false;
                X2 = false;
            }
            if (Input.GetAxis("P2 Press Square") != 0)
            {
                Marker1[1].SetActive(false);
                Marker2[1].SetActive(true);
                Marker3[1].SetActive(false);
                Marker4[1].SetActive(false);
                O2 = false;
                Square2 = true;
                Triangle2 = false;
                X2 = false;
            }
            if (Input.GetAxis("P2 Press Triangle") != 0)
            {
                Marker1[1].SetActive(false);
                Marker2[1].SetActive(false);
                Marker3[1].SetActive(true);
                Marker4[1].SetActive(false);
                O2 = false;
                Square2 = false;
                Triangle2 = true;
                X2 = false;
            }
            if (Input.GetAxis("P2 Press X") != 0)
            {
                Marker1[1].SetActive(false);
                Marker2[1].SetActive(false);
                Marker3[1].SetActive(false);
                Marker4[1].SetActive(true);
                O2 = false;
                Square2 = false;
                Triangle2 = false;
                X2 = true;
            }
            if (Input.GetAxis("P3 Press Circle") != 0)
            {
                Marker1[2].SetActive(true);
                Marker2[2].SetActive(false);
                Marker3[2].SetActive(false);
                Marker4[2].SetActive(false);
                O3 = true;
                Square3 = false;
                Triangle3 = false;
                X3 = false;
            }
            if (Input.GetAxis("P3 Press Square") != 0)
            {
                Marker1[2].SetActive(false);
                Marker2[2].SetActive(true);
                Marker3[2].SetActive(false);
                Marker4[2].SetActive(false);
                O3 = false;
                Square3 = true;
                Triangle3 = false;
                X3 = false;
            }
            if (Input.GetAxis("P3 Press Triangle") != 0)
            {
                Marker1[2].SetActive(false);
                Marker2[2].SetActive(false);
                Marker3[2].SetActive(true);
                Marker4[2].SetActive(false);
                O3 = false;
                Square3 = false;
                Triangle3 = true;
                X3 = false;
            }
            if (Input.GetAxis("P3 Press X") != 0)
            {
                Marker1[2].SetActive(false);
                Marker2[2].SetActive(false);
                Marker3[2].SetActive(false);
                Marker4[2].SetActive(true);
                O3 = false;
                Square3 = false;
                Triangle3 = false;
                X3 = true;
            }
        }
        if (ThreeController && DN_MainMenuMannager.Xbox && TopLeft && TopRight && BotLeft && BotRight)
        {
            for (int i = 0; i < KeyboardKey.Length; i++)
            {
                KeyboardKey[i].SetActive(false);
            }
            for (int i = 0; i < PS4Buttons.Length; i++)
            {
                PS4Buttons[i].SetActive(false);
            }
            for (int i = 0; i < XboxButtons.Length; i++)
            {
                XboxButtons[i].SetActive(true);
            }
            if (Input.GetAxis("Xbox P1 Press B") != 0)
            {
                Marker1[0].SetActive(true);
                Marker2[0].SetActive(false);
                Marker3[0].SetActive(false);
                Marker4[0].SetActive(false);
                B1 = true;
                XB1 = false;
                Y1 = false;
                A1 = false;
            }
            if (Input.GetAxis("Xbox P1 Press X") != 0)
            {
                Marker1[0].SetActive(false);
                Marker2[0].SetActive(true);
                Marker3[0].SetActive(false);
                Marker4[0].SetActive(false);
                B1 = false;
                XB1 = true;
                Y1 = false;
                A1 = false;
            }
            if (Input.GetAxis("Xbox P1 Press Y") != 0)
            {
                Marker1[0].SetActive(false);
                Marker2[0].SetActive(false);
                Marker3[0].SetActive(true);
                Marker4[0].SetActive(false);
                B1 = false;
                XB1 = false;
                Y1 = true;
                A1 = false;
            }
            if (Input.GetAxis("Xbox P1 Press A") != 0)
            {
                Marker1[0].SetActive(false);
                Marker2[0].SetActive(false);
                Marker3[0].SetActive(false);
                Marker4[0].SetActive(true);
                B1 = false;
                XB1 = false;
                Y1 = false;
                A1 = true;
            }
            if (Input.GetAxis("Xbox P2 Press B") != 0)
            {
                Marker1[1].SetActive(true);
                Marker2[1].SetActive(false);
                Marker3[1].SetActive(false);
                Marker4[1].SetActive(false);
                B2 = true;
                XB2 = false;
                Y2 = false;
                A2 = false;
            }
            if (Input.GetAxis("Xbox P2 Press X") != 0)
            {
                Marker1[1].SetActive(false);
                Marker2[1].SetActive(true);
                Marker3[1].SetActive(false);
                Marker4[1].SetActive(false);
                B2 = false;
                XB2 = true;
                Y2 = false;
                A2 = false;
            }
            if (Input.GetAxis("Xbox P2 Press Y") != 0)
            {
                Marker1[1].SetActive(false);
                Marker2[1].SetActive(false);
                Marker3[1].SetActive(true);
                Marker4[1].SetActive(false);
                B2 = false;
                XB2 = false;
                Y2 = true;
                A2 = false;
            }
            if (Input.GetAxis("Xbox P2 Press A") != 0)
            {
                Marker1[1].SetActive(false);
                Marker2[1].SetActive(false);
                Marker3[1].SetActive(false);
                Marker4[1].SetActive(true);
                B2 = false;
                XB2 = false;
                Y2 = false;
                A2 = true;
            }
            if (Input.GetAxis("Xbox P3 Press B") != 0)
            {
                Marker1[2].SetActive(true);
                Marker2[2].SetActive(false);
                Marker3[2].SetActive(false);
                Marker4[2].SetActive(false);
                B3 = true;
                XB3 = false;
                Y3 = false;
                A3 = false;
            }
            if (Input.GetAxis("Xbox P3 Press X") != 0)
            {
                Marker1[2].SetActive(false);
                Marker2[2].SetActive(true);
                Marker3[2].SetActive(false);
                Marker4[2].SetActive(false);
                B3 = false;
                XB3 = true;
                Y3 = false;
                A3 = false;
            }
            if (Input.GetAxis("Xbox P3 Press Y") != 0)
            {
                Marker1[2].SetActive(false);
                Marker2[2].SetActive(false);
                Marker3[2].SetActive(true);
                Marker4[2].SetActive(false);
                B3 = false;
                XB3 = false;
                Y3 = true;
                A3 = false;
            }
            if (Input.GetAxis("Xbox P3 Press A") != 0)
            {
                Marker1[2].SetActive(false);
                Marker2[2].SetActive(false);
                Marker3[2].SetActive(false);
                Marker4[2].SetActive(true);
                B3 = false;
                XB3 = false;
                Y3 = false;
                A3 = true;
            }
        }
        if (FourController && DN_MainMenuMannager.Ps4 && TopLeft && TopRight && BotLeft && BotRight)
        {
            for (int i = 0; i < KeyboardKey.Length; i++)
            {
                KeyboardKey[i].SetActive(false);
            }
            for (int i = 0; i < PS4Buttons.Length; i++)
            {
                PS4Buttons[i].SetActive(true);
            }
            for (int i = 0; i < XboxButtons.Length; i++)
            {
                XboxButtons[i].SetActive(false);
            }
            if (Input.GetAxis("P1 Press Circle") != 0)
            {
                Marker1[0].SetActive(true);
                Marker2[0].SetActive(false);
                Marker3[0].SetActive(false);
                Marker4[0].SetActive(false);
                O1 = true;
                Square1 = false;
                Triangle1 = false;
                X1 = false;
            }
            if (Input.GetAxis("P1 Press Square") != 0)
            {
                Marker1[0].SetActive(false);
                Marker2[0].SetActive(true);
                Marker3[0].SetActive(false);
                Marker4[0].SetActive(false);
                O1 = false;
                Square1 = true;
                Triangle1 = false;
                X1 = false;
            }
            if (Input.GetAxis("P1 Press Triangle") != 0)
            {
                Marker1[0].SetActive(false);
                Marker2[0].SetActive(false);
                Marker3[0].SetActive(true);
                Marker4[0].SetActive(false);
                O1 = false;
                Square1 = false;
                Triangle1 = true;
                X1 = false;
            }
            if (Input.GetAxis("P1 Press X") != 0)
            {
                Marker1[0].SetActive(false);
                Marker2[0].SetActive(false);
                Marker3[0].SetActive(false);
                Marker4[0].SetActive(true);
                O1 = false;
                Square1 = false;
                Triangle1 = false;
                X1 = true;
            }
            if (Input.GetAxis("P2 Press Circle") != 0)
            {
                Marker1[1].SetActive(true);
                Marker2[1].SetActive(false);
                Marker3[1].SetActive(false);
                Marker4[1].SetActive(false);
                O2 = true;
                Square2 = false;
                Triangle2 = false;
                X2 = false;
            }
            if (Input.GetAxis("P2 Press Square") != 0)
            {
                Marker1[1].SetActive(false);
                Marker2[1].SetActive(true);
                Marker3[1].SetActive(false);
                Marker4[1].SetActive(false);
                O2 = false;
                Square2 = true;
                Triangle2 = false;
                X2 = false;
            }
            if (Input.GetAxis("P2 Press Triangle") != 0)
            {
                Marker1[1].SetActive(false);
                Marker2[1].SetActive(false);
                Marker3[1].SetActive(true);
                Marker4[1].SetActive(false);
                O2 = false;
                Square2 = false;
                Triangle2 = true;
                X2 = false;
            }
            if (Input.GetAxis("P2 Press X") != 0)
            {
                Marker1[1].SetActive(false);
                Marker2[1].SetActive(false);
                Marker3[1].SetActive(false);
                Marker4[1].SetActive(true);
                O2 = false;
                Square2 = false;
                Triangle2 = false;
                X2 = true;
            }
            if (Input.GetAxis("P3 Press Circle") != 0)
            {
                Marker1[2].SetActive(true);
                Marker2[2].SetActive(false);
                Marker3[2].SetActive(false);
                Marker4[2].SetActive(false);
                O3 = true;
                Square3 = false;
                Triangle3 = false;
                X3 = false;
            }
            if (Input.GetAxis("P3 Press Square") != 0)
            {
                Marker1[2].SetActive(false);
                Marker2[2].SetActive(true);
                Marker3[2].SetActive(false);
                Marker4[2].SetActive(false);
                O3 = false;
                Square3 = true;
                Triangle3 = false;
                X3 = false;
            }
            if (Input.GetAxis("P3 Press Triangle") != 0)
            {
                Marker1[2].SetActive(false);
                Marker2[2].SetActive(false);
                Marker3[2].SetActive(true);
                Marker4[2].SetActive(false);
                O3 = false;
                Square3 = false;
                Triangle3 = true;
                X3 = false;
            }
            if (Input.GetAxis("P3 Press X") != 0)
            {
                Marker1[2].SetActive(false);
                Marker2[2].SetActive(false);
                Marker3[2].SetActive(false);
                Marker4[2].SetActive(true);
                O3 = false;
                Square3 = false;
                Triangle3 = false;
                X3 = true;
            }
            if (Input.GetAxis("P4 Press Circle") != 0)
            {
                Marker1[3].SetActive(true);
                Marker2[3].SetActive(false);
                Marker3[3].SetActive(false);
                Marker4[3].SetActive(false);
                O4 = true;
                Square4 = false;
                Triangle4 = false;
                X4 = false;
            }
            if (Input.GetAxis("P4 Press Square") != 0)
            {
                Marker1[3].SetActive(false);
                Marker2[3].SetActive(true);
                Marker3[3].SetActive(false);
                Marker4[3].SetActive(false);
                O4 = false;
                Square4 = true;
                Triangle4 = false;
                X4 = false;
            }
            if (Input.GetAxis("P4 Press Triangle") != 0)
            {
                Marker1[3].SetActive(false);
                Marker2[3].SetActive(false);
                Marker3[3].SetActive(true);
                Marker4[3].SetActive(false);
                O3 = false;
                Square3 = false;
                Triangle4 = true;
                X3 = false;
            }
            if (Input.GetAxis("P4 Press X") != 0)
            {
                Marker1[3].SetActive(false);
                Marker2[3].SetActive(false);
                Marker3[3].SetActive(false);
                Marker4[3].SetActive(true);
                O4 = false;
                Square4 = false;
                Triangle4 = false;
                X4 = true;
            }
        }
        if (FourController && DN_MainMenuMannager.Xbox && TopLeft && TopRight && BotLeft && BotRight)
        {
            for (int i = 0; i < KeyboardKey.Length; i++)
            {
                KeyboardKey[i].SetActive(false);
            }
            for (int i = 0; i < PS4Buttons.Length; i++)
            {
                PS4Buttons[i].SetActive(false);
            }
            for (int i = 0; i < XboxButtons.Length; i++)
            {
                XboxButtons[i].SetActive(true);
            }
            if (Input.GetAxis("Xbox P1 Press B") != 0)
            {
                Marker1[0].SetActive(true);
                Marker2[0].SetActive(false);
                Marker3[0].SetActive(false);
                Marker4[0].SetActive(false);
                B1 = true;
                XB1 = false;
                Y1 = false;
                A1 = false;
            }
            if (Input.GetAxis("Xbox P1 Press X") != 0)
            {
                Marker1[0].SetActive(false);
                Marker2[0].SetActive(true);
                Marker3[0].SetActive(false);
                Marker4[0].SetActive(false);
                B1 = false;
                XB1 = true;
                Y1 = false;
                A1 = false;
            }
            if (Input.GetAxis("Xbox P1 Press Y") != 0)
            {
                Marker1[0].SetActive(false);
                Marker2[0].SetActive(false);
                Marker3[0].SetActive(true);
                Marker4[0].SetActive(false);
                B1 = false;
                XB1 = false;
                Y1 = true;
                A1 = false;
            }
            if (Input.GetAxis("Xbox P1 Press A") != 0)
            {
                Marker1[0].SetActive(false);
                Marker2[0].SetActive(false);
                Marker3[0].SetActive(false);
                Marker4[0].SetActive(true);
                B1 = false;
                XB1 = false;
                Y1 = false;
                A1 = true;
            }
            if (Input.GetAxis("Xbox P2 Press B") != 0)
            {
                Marker1[1].SetActive(true);
                Marker2[1].SetActive(false);
                Marker3[1].SetActive(false);
                Marker4[1].SetActive(false);
                B2 = true;
                XB2 = false;
                Y2 = false;
                A2 = false;
            }
            if (Input.GetAxis("Xbox P2 Press X") != 0)
            {
                Marker1[1].SetActive(false);
                Marker2[1].SetActive(true);
                Marker3[1].SetActive(false);
                Marker4[1].SetActive(false);
                B2 = false;
                XB2 = true;
                Y2 = false;
                A2 = false;
            }
            if (Input.GetAxis("Xbox P2 Press Y") != 0)
            {
                Marker1[1].SetActive(false);
                Marker2[1].SetActive(false);
                Marker3[1].SetActive(true);
                Marker4[1].SetActive(false);
                B2 = false;
                XB2 = false;
                Y2 = true;
                A2 = false;
            }
            if (Input.GetAxis("Xbox P2 Press A") != 0)
            {
                Marker1[1].SetActive(false);
                Marker2[1].SetActive(false);
                Marker3[1].SetActive(false);
                Marker4[1].SetActive(true);
                B2 = false;
                XB2 = false;
                Y2 = false;
                A2 = true;
            }
            if (Input.GetAxis("Xbox P3 Press B") != 0)
            {
                Marker1[2].SetActive(true);
                Marker2[2].SetActive(false);
                Marker3[2].SetActive(false);
                Marker4[2].SetActive(false);
                B3 = true;
                XB3 = false;
                Y3 = false;
                A3 = false;
            }
            if (Input.GetAxis("Xbox P3 Press X") != 0)
            {
                Marker1[2].SetActive(false);
                Marker2[2].SetActive(true);
                Marker3[2].SetActive(false);
                Marker4[2].SetActive(false);
                B3 = false;
                XB3 = true;
                Y3 = false;
                A3 = false;
            }
            if (Input.GetAxis("Xbox P3 Press Y") != 0)
            {
                Marker1[2].SetActive(false);
                Marker2[2].SetActive(false);
                Marker3[2].SetActive(true);
                Marker4[2].SetActive(false);
                B3 = false;
                XB3 = false;
                Y3 = true;
                A3 = false;
            }
            if (Input.GetAxis("Xbox P3 Press A") != 0)
            {
                Marker1[2].SetActive(false);
                Marker2[2].SetActive(false);
                Marker3[2].SetActive(false);
                Marker4[2].SetActive(true);
                B3 = false;
                XB3 = false;
                Y3 = false;
                A3 = true;
            }
            if (Input.GetAxis("Xbox P4 Press B") != 0)
            {
                Marker1[3].SetActive(true);
                Marker2[3].SetActive(false);
                Marker3[3].SetActive(false);
                Marker4[3].SetActive(false);
                B4 = true;
                XB4 = false;
                Y4 = false;
                A4 = false;
            }
            if (Input.GetAxis("Xbox P4 Press X") != 0)
            {
                Marker1[3].SetActive(false);
                Marker2[3].SetActive(true);
                Marker3[3].SetActive(false);
                Marker4[3].SetActive(false);
                B4 = false;
                XB4 = true;
                Y4 = false;
                A4 = false;
            }
            if (Input.GetAxis("Xbox P4 Press Y") != 0)
            {
                Marker1[3].SetActive(false);
                Marker2[3].SetActive(false);
                Marker3[3].SetActive(true);
                Marker4[3].SetActive(false);
                B4 = false;
                XB4 = false;
                Y4 = true;
                A4 = false;
            }
            if (Input.GetAxis("Xbox P4 Press A") != 0)
            {
                Marker1[3].SetActive(false);
                Marker2[3].SetActive(false);
                Marker3[3].SetActive(false);
                Marker4[3].SetActive(true);
                B4 = false;
                XB4 = false;
                Y4 = false;
                A4 = true;
            }
        }
        buttonCooldown--;
        if (canMove)
        {
            pos = transform.position;
            if (SoloController)
            {
                SoloPlayerMove();
            }
            if (SoloKeyBoard)
            {

                SoloKeyboardMove();

            }
            if (DualController)
            {
                TwoPlayerMove1();
                TwoPlayerMove2();
                TwoPlayerMove3();
                TwoPlayerMove4();
            }
            if (ThreeController)
            {
                ThreePlayerMove1();
                ThreePlayerMove2();
                ThreePlayerMove3();
                ThreePlayerMove4();
            }
            if (FourController)
            {
                FourPlayerMove1();
                FourPlayerMove2();
                FourPlayerMove3();
                FourPlayerMove4();
            }
        }
        if (moving)
        {
            if (transform.position == pos)
            {
                moving = false;
                canMove = true;
                if (SoloController)
                {
                    if (TopLeft && TopRight && BotLeft && BotRight)
                    {
                        KillerTrigger1.SetActive(true);
                        KillerTrigger2.SetActive(true);
                        Bouncewall.SetActive(false);
                        SoloPlayerMove();
                    }
                    
                }
                if (SoloKeyBoard)
                {
                    if (TopLeft && TopRight && BotLeft && BotRight)
                    {
                        KillerTrigger1.SetActive(true);
                        KillerTrigger2.SetActive(true);
                        Bouncewall.SetActive(false);
                        SoloKeyboardMove();
                    }

                }
                if (DualController)
                {

                    if (TopLeft && TopRight && BotLeft && BotRight)
                    {
                        KillerTrigger1.SetActive(true);
                        KillerTrigger2.SetActive(true);
                        Bouncewall.SetActive(false);
                        TwoPlayerMove1();
                        TwoPlayerMove3();
                        TwoPlayerMove4();
                        TwoPlayerMove2();
                    }
                   
                }
                if (ThreeController)
                {
                    if (TopLeft && TopRight && BotLeft && BotRight)
                    {
                        KillerTrigger1.SetActive(true);
                        KillerTrigger2.SetActive(true);
                        Bouncewall.SetActive(false);
                        ThreePlayerMove1();
                        ThreePlayerMove2();
                        ThreePlayerMove3();
                        ThreePlayerMove4();
                    }
                   
                }
                if (FourController)
                {
                    if (TopLeft && TopRight && BotLeft && BotRight)
                    {
                        KillerTrigger1.SetActive(true);
                        KillerTrigger2.SetActive(true);
                        Bouncewall.SetActive(false);
                        FourPlayerMove1();
                        FourPlayerMove2();
                        FourPlayerMove3();
                        FourPlayerMove4();
                    }
                    
                }
            }
            transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * speed);
        }
    }
    private void SoloKeyboardMove()
    {

        if (buttonCooldown <= 0)
        {
            if (P1 && O1)
            {
                if (Input.GetKey(KeyCode.UpArrow) && StopTop == false)
                {
                    if (dir != DIRECTION.UP)
                    {
                        dir = DIRECTION.UP;
                        buttonCooldown = cooldownforbutton;
                    }
                    else
                    {
                        MovingUp = true;
                        canMove = false;
                        moving = true;
                        pos += Vector3.forward;
                    }

                }
                //if (Input.GetKey(KeyCode.DownArrow) && StopBot == false && Square1)
                //{

                //    if (dir != DIRECTION.DOWN)
                //    {
                //        buttonCooldown = cooldownforbutton;
                //        dir = DIRECTION.DOWN;
                //    }
                //    else
                //    {
                //        MovingDown = true;
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.back;
                //    }
                //}
                //if (Input.GetKey(KeyCode.LeftArrow) && StopLeft == false && Square1)
                //{

                //    if (dir != DIRECTION.LEFT)
                //    {
                //        buttonCooldown = cooldownforbutton;
                //        dir = DIRECTION.LEFT;
                //    }
                //    else
                //    {
                //        MovingLeft = true;
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.left;
                //    }
                //}
                //if (Input.GetKey(KeyCode.RightArrow) && StopRight == false && Square1)
                //{

                //    if (dir != DIRECTION.RIGHT)
                //    {
                //        buttonCooldown = cooldownforbutton;
                //        dir = DIRECTION.RIGHT;
                //    }
                //    else
                //    {
                //        MovingRight = true;
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.right;

                //    }
                //}
            }
            if (P2 && Square1)
            {
                //if (Input.GetKey(KeyCode.UpArrow) && StopTop == false && O1)
                //{
                //    if (dir != DIRECTION.UP)
                //    {
                //        dir = DIRECTION.UP;
                //        buttonCooldown = cooldownforbutton;
                //    }
                //    else
                //    {
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.forward;
                //    }

                //}
                //if (Input.GetKey(KeyCode.DownArrow) && StopBot == false && O1)
                //{

                //    if (dir != DIRECTION.DOWN)
                //    {
                //        buttonCooldown = cooldownforbutton;
                //        dir = DIRECTION.DOWN;
                //    }
                //    else
                //    {
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.back;
                //    }
                //}
                //if (Input.GetKey(KeyCode.LeftArrow) && StopLeft == false && O1)
                //{

                //    if (dir != DIRECTION.LEFT)
                //    {
                //        buttonCooldown = cooldownforbutton;
                //        dir = DIRECTION.LEFT;
                //    }
                //    else
                //    {
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.left;
                //    }
                //}
                if (Input.GetKey(KeyCode.RightArrow) && StopRight == false)
                {

                    if (dir != DIRECTION.RIGHT)
                    {
                        buttonCooldown = cooldownforbutton;
                        dir = DIRECTION.RIGHT;
                    }
                    else
                    {

                        canMove = false;
                        moving = true;
                        pos += Vector3.right;

                    }
                }
            }
            if (P3 && X1)
            {
                //if (Input.GetKey(KeyCode.UpArrow) && StopTop == false && Triangle1)
                //{
                //    if (dir != DIRECTION.UP)
                //    {
                //        dir = DIRECTION.UP;
                //        buttonCooldown = cooldownforbutton;
                //    }
                //    else
                //    {
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.forward;
                //    }

                //}
                //if (Input.GetKey(KeyCode.DownArrow) && StopBot == false && Triangle1)
                //{

                //    if (dir != DIRECTION.DOWN)
                //    {
                //        buttonCooldown = cooldownforbutton;
                //        dir = DIRECTION.DOWN;
                //    }
                //    else
                //    {
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.back;
                //    }
                //}
                if (Input.GetKey(KeyCode.LeftArrow) && StopLeft == false)
                {

                    if (dir != DIRECTION.LEFT)
                    {
                        buttonCooldown = cooldownforbutton;
                        dir = DIRECTION.LEFT;
                    }
                    else
                    {
                        canMove = false;
                        moving = true;
                        pos += Vector3.left;
                    }
                }
                //if (Input.GetKey(KeyCode.RightArrow) && StopRight == false && Triangle1)
                //{

                //    if (dir != DIRECTION.RIGHT)
                //    {
                //        buttonCooldown = cooldownforbutton;
                //        dir = DIRECTION.RIGHT;
                //    }
                //    else
                //    {

                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.right;

                //    }
                //}
            }
            if (P4 && Triangle1)
            {
                //if (Input.GetKey(KeyCode.UpArrow) && StopTop == false && X1)
                //{
                //    if (dir != DIRECTION.UP)
                //    {
                //        dir = DIRECTION.UP;
                //        buttonCooldown = cooldownforbutton;
                //    }
                //    else
                //    {
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.forward;
                //    }

                //}
                if (Input.GetKey(KeyCode.DownArrow) && StopBot == false)
                {

                    if (dir != DIRECTION.DOWN)
                    {
                        buttonCooldown = cooldownforbutton;
                        dir = DIRECTION.DOWN;
                    }
                    else
                    {
                        canMove = false;
                        moving = true;
                        pos += Vector3.back;
                    }
                }
                //if (Input.GetKey(KeyCode.LeftArrow) && StopLeft == false && X1)
                //{

                //    if (dir != DIRECTION.LEFT)
                //    {
                //        buttonCooldown = cooldownforbutton;
                //        dir = DIRECTION.LEFT;
                //    }
                //    else
                //    {
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.left;
                //    }
                //}
                //if (Input.GetKey(KeyCode.RightArrow) && StopRight == false && X1)
                //{

                //    if (dir != DIRECTION.RIGHT)
                //    {
                //        buttonCooldown = cooldownforbutton;
                //        dir = DIRECTION.RIGHT;
                //    }
                //    else
                //    {

                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.right;

                //    }
                //}
            }
        }
    }
    private void SoloPlayerMove()
    {
        if (buttonCooldown <= 0)
        {
            if (P1 && O1)
            {
                if (Input.GetAxis("Solo P1 Press Up Arrow") == 0  && Input.GetAxis("Solo P1 Press Right Arrow") == 0 && Input.GetAxis("Solo P1 Press Left Arrow") == 0 && Input.GetAxis("Solo P1 Press Down Arrow") == 0 && DN_MainMenuMannager.Ps4)
                {
                    MechIdle.SetActive(true);
                        MechMoveRNL.SetActive(false);
                       MechMoveUND.SetActive(false);
                }
               
                if (Input.GetAxis("Solo P1 Press Up Arrow") == 1 && StopTop == false /*&& Square1*/ && DN_MainMenuMannager.Ps4)
                {
                    if (dir != DIRECTION.UP)
                    {
                        dir = DIRECTION.UP;
                        buttonCooldown = cooldownforbutton;
                        MechIdle.SetActive(false);
                        MechMoveRNL.SetActive(false);
                        MechMoveUND.SetActive(true);
                        
                    }
                    else
                    {
                       
                        canMove = false;
                        moving = true;
                        pos += Vector3.forward;
                    }

                }
                //if (Input.GetAxis("Solo P1 Press Down Arrow") == 1 && StopBot == false && Square1 && DN_MainMenuMannager.Ps4)
                //{

                //    if (dir != DIRECTION.DOWN)
                //    {
                //        buttonCooldown = cooldownforbutton;
                //        dir = DIRECTION.DOWN;
                //    }
                //    else
                //    {
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.back;
                //    }
                //}
                //if (Input.GetAxis("Solo P1 Press Left Arrow") == 1 && StopLeft == false && Square1 && DN_MainMenuMannager.Ps4)
                //{

                //    if (dir != DIRECTION.LEFT)
                //    {
                //        buttonCooldown = cooldownforbutton;
                //        dir = DIRECTION.LEFT;
                //    }
                //    else
                //    {
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.left;
                //    }
                //}
                //if (Input.GetAxis("Solo P1 Press Right Arrow") == 1 && StopRight == false && Square1 && DN_MainMenuMannager.Ps4)
                //{

                //    if (dir != DIRECTION.RIGHT)
                //    {
                //        buttonCooldown = cooldownforbutton;
                //        dir = DIRECTION.RIGHT;
                //    }
                //    else
                //    {

                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.right;

                //    }
                //}
              
                //if (Input.GetAxis("Xbox Solo P1 Press Down Dpad") == 1 && StopBot == false && XB1 && DN_MainMenuMannager.Xbox)
                //{
                //    if (dir != DIRECTION.DOWN)
                //    {
                //        buttonCooldown = cooldownforbutton;
                //        dir = DIRECTION.DOWN;
                //    }
                //    else
                //    {
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.back;
                //    }
                //}
                //if (Input.GetAxis("Xbox Solo P1 Press Left Dpad") == 1 && StopLeft == false && XB1 && DN_MainMenuMannager.Xbox)
                //{
                //    if (dir != DIRECTION.LEFT)
                //    {
                //        buttonCooldown = cooldownforbutton;
                //        dir = DIRECTION.LEFT;
                //    }
                //    else
                //    {
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.left;
                //    }
                //}
                //if (Input.GetAxis("Xbox Solo P1 Press Right Dpad") == 1 && StopRight == false && XB1 && DN_MainMenuMannager.Xbox)
                //{
                //    if (dir != DIRECTION.RIGHT)
                //    {
                //        buttonCooldown = cooldownforbutton;
                //        dir = DIRECTION.RIGHT;
                //    }
                //    else
                //    {

                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.right;

                //    }
                //}
            }
            if(P1 && B1)
            {
         
                if (Input.GetAxis("Xbox Solo P1 Press Up Dpad") == 0 && Input.GetAxis("Xbox Solo P1 Press Down Dpad") == 0 && Input.GetAxis("Xbox Solo P1 Press Right Dpad") == 0 && Input.GetAxis("Xbox Solo P1 Press Left Dpad") == 0 && DN_MainMenuMannager.Xbox)
                {
                    MechIdle.SetActive(true);
                    MechMoveRNL.SetActive(false);
                    MechMoveUND.SetActive(false);
                }
                if (Input.GetAxis("Xbox Solo P1 Press Up Dpad") == 1 && StopTop == false  && DN_MainMenuMannager.Xbox)
                {
                    if (dir != DIRECTION.UP)
                    {
                        dir = DIRECTION.UP;
                        buttonCooldown = cooldownforbutton;
                    }
                    else
                    {
                        MechIdle.SetActive(false);
                        MechMoveRNL.SetActive(false);
                        MechMoveUND.SetActive(true);
                        canMove = false;
                        moving = true;
                        pos += Vector3.forward;
                    }
                }
            }
            if (P2 && Square1)
            {
                //if (Input.GetAxis("Solo P1 Press Up Arrow") == 1 && StopTop == false && O1 && DN_MainMenuMannager.Ps4)
                //{
                //    if (dir != DIRECTION.UP)
                //    {
                //        dir = DIRECTION.UP;
                //        buttonCooldown = cooldownforbutton;
                //    }
                //    else
                //    {
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.forward;
                //    }

                //}
                //if (Input.GetAxis("Xbox Solo P1 Press Up Dpad") == 1 && StopTop == false && B1 && DN_MainMenuMannager.Xbox)
                //{
                //    if (dir != DIRECTION.UP)
                //    {
                //        dir = DIRECTION.UP;
                //        buttonCooldown = cooldownforbutton;
                //    }
                //    else
                //    {
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.forward;
                //    }
                //}
                //if (Input.GetAxis("Solo P1 Press Down Arrow") == 1 && StopBot == false && O1 && DN_MainMenuMannager.Ps4)
                //{

                //    if (dir != DIRECTION.DOWN)
                //    {
                //        buttonCooldown = cooldownforbutton;
                //        dir = DIRECTION.DOWN;
                //    }
                //    else
                //    {
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.back;
                //    }
                //}
                //if (Input.GetAxis("Xbox Solo P1 Press Down Dpad") == 1 && StopBot == false && B1 && DN_MainMenuMannager.Xbox)
                //{
                //    if (dir != DIRECTION.DOWN)
                //    {
                //        buttonCooldown = cooldownforbutton;
                //        dir = DIRECTION.DOWN;
                //    }
                //    else
                //    {
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.back;
                //    }
                //}

                //if (Input.GetAxis("Solo P1 Press Left Arrow") == 1 && StopLeft == false && O1 && DN_MainMenuMannager.Ps4)
                //{

                //    if (dir != DIRECTION.LEFT)
                //    {
                //        buttonCooldown = cooldownforbutton;
                //        dir = DIRECTION.LEFT;
                //    }
                //    else
                //    {
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.left;
                //    }
                //}
                //if (Input.GetAxis("Xbox Solo P1 Press Left Dpad") == 1 && StopLeft == false && B1 && DN_MainMenuMannager.Xbox)
                //{
                //    if (dir != DIRECTION.LEFT)
                //    {
                //        buttonCooldown = cooldownforbutton;
                //        dir = DIRECTION.LEFT;
                //    }
                //    else
                //    {
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.left;
                //    }
                //}
                if (Input.GetAxis("Solo P1 Press Up Arrow") == 0 && Input.GetAxis("Solo P1 Press Right Arrow") == 0 && Input.GetAxis("Solo P1 Press Left Arrow") == 0 && Input.GetAxis("Solo P1 Press Down Arrow") == 0 && DN_MainMenuMannager.Ps4)
                {
                    MechIdle.SetActive(true);
                    MechMoveRNL.SetActive(false);
                    MechMoveUND.SetActive(false);
                }
                if (Input.GetAxis("Solo P1 Press Right Arrow") == 1 && StopRight == false /*&& O1*/ && DN_MainMenuMannager.Ps4)
                {

                    if (dir != DIRECTION.RIGHT)
                    {
                        buttonCooldown = cooldownforbutton;
                        dir = DIRECTION.RIGHT;
                        MechIdle.SetActive(false);
                        MechMoveRNL.SetActive(true);
                        MechMoveUND.SetActive(false);
                    }
                    else
                    {
                      
                        canMove = false;
                        moving = true;
                        pos += Vector3.right;

                    }
                }
                //    if (Input.GetAxis("Xbox Solo P1 Press Right Dpad") == 1 && StopRight == false && B1 && DN_MainMenuMannager.Xbox)
                //    {
                //        if (dir != DIRECTION.RIGHT)
                //        {
                //            buttonCooldown = cooldownforbutton;
                //            dir = DIRECTION.RIGHT;
                //        }
                //        else
                //        {

                //            canMove = false;
                //            moving = true;
                //            pos += Vector3.right;

                //        }
                //    }
            }
            if (P2 && XB1)
            {
                if (Input.GetAxis("Xbox Solo P1 Press Up Dpad") == 0 && Input.GetAxis("Xbox Solo P1 Press Down Dpad") == 0 && Input.GetAxis("Xbox Solo P1 Press Right Dpad") == 0 && Input.GetAxis("Xbox Solo P1 Press Left Dpad") == 0 && DN_MainMenuMannager.Xbox)
                {
                    MechIdle.SetActive(true);
                    MechMoveRNL.SetActive(false);
                    MechMoveUND.SetActive(false);
                }
                if (Input.GetAxis("Xbox Solo P1 Press Right Dpad") == 1 && StopRight == false && DN_MainMenuMannager.Xbox)
                {
                    if (dir != DIRECTION.RIGHT)
                    {
                        dir = DIRECTION.RIGHT;
                        buttonCooldown = cooldownforbutton;
                    }
                    else
                    {
                        MechIdle.SetActive(false);
                        MechMoveRNL.SetActive(true);
                        MechMoveUND.SetActive(false);
                        canMove = false;
                        moving = true;
                        pos += Vector3.right;
                    }
                }
            }
            if (P3 && X1)
                {
                //if (Input.GetAxis("Solo P1 Press Up Arrow") == 1 && StopTop == false && Triangle1 && DN_MainMenuMannager.Ps4)
                //{
                //    if (dir != DIRECTION.UP)
                //    {
                //        dir = DIRECTION.UP;
                //        buttonCooldown = cooldownforbutton;
                //    }
                //    else
                //    {
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.forward;
                //    }

                //}
                //if (Input.GetAxis("Xbox Solo P1 Press Up Dpad") == 1 && StopTop == false && Y1 && DN_MainMenuMannager.Xbox)
                //{
                //    if (dir != DIRECTION.UP)
                //    {
                //        dir = DIRECTION.UP;
                //        buttonCooldown = cooldownforbutton;
                //    }
                //    else
                //    {
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.forward;
                //    }
                //}

                //if (Input.GetAxis("Solo P1 Press Down Arrow") == 1 && StopBot == false && Triangle1 && DN_MainMenuMannager.Ps4)
                //{

                //    if (dir != DIRECTION.DOWN)
                //    {
                //        buttonCooldown = cooldownforbutton;
                //        dir = DIRECTION.DOWN;
                //    }
                //    else
                //    {
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.back;
                //    }
                //}
                //if (Input.GetAxis("Xbox Solo P1 Press Down Dpad") == 1 && StopBot == false && Y1 && DN_MainMenuMannager.Xbox)
                //{
                //    if (dir != DIRECTION.DOWN)
                //    {
                //        buttonCooldown = cooldownforbutton;
                //        dir = DIRECTION.DOWN;
                //    }
                //    else
                //    {
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.back;
                //    }
                //}
                if (Input.GetAxis("Solo P1 Press Up Arrow") == 0 && Input.GetAxis("Solo P1 Press Right Arrow") == 0 && Input.GetAxis("Solo P1 Press Left Arrow") == 0 && Input.GetAxis("Solo P1 Press Down Arrow") == 0 && DN_MainMenuMannager.Ps4)
                {
                    MechIdle.SetActive(true);
                    MechMoveRNL.SetActive(false);
                    MechMoveUND.SetActive(false);
                }
                if (Input.GetAxis("Solo P1 Press Left Arrow") == 1 && StopLeft == false /*&& Triangle1*/ && DN_MainMenuMannager.Ps4)
                    {

                        if (dir != DIRECTION.LEFT)
                        {
                            buttonCooldown = cooldownforbutton;
                            dir = DIRECTION.LEFT;
                        MechIdle.SetActive(false);
                        MechMoveRNL.SetActive(true);
                        MechMoveUND.SetActive(false);
                    }
                        else
                        {
                       
                        canMove = false;
                            moving = true;
                            pos += Vector3.left;
                        }
                    }
                    //if (Input.GetAxis("Xbox Solo P1 Press Left Dpad") == 1 && StopLeft == false && Y1 && DN_MainMenuMannager.Xbox)
                    //{
                    //    if (dir != DIRECTION.LEFT)
                    //    {
                    //        buttonCooldown = cooldownforbutton;
                    //        dir = DIRECTION.LEFT;
                    //    }
                    //    else
                    //    {
                    //        canMove = false;
                    //        moving = true;
                    //        pos += Vector3.left;
                    //    }
                    //}
                    //if (Input.GetAxis("Solo P1 Press Right Arrow") == 1 && StopRight == false && Triangle1 && DN_MainMenuMannager.Ps4)
                    //{

                    //    if (dir != DIRECTION.RIGHT)
                    //    {
                    //        buttonCooldown = cooldownforbutton;
                    //        dir = DIRECTION.RIGHT;
                    //    }
                    //    else
                    //    {

                    //        canMove = false;
                    //        moving = true;
                    //        pos += Vector3.right;

                    //    }
                    //}
                    //if (Input.GetAxis("Xbox Solo P1 Press Right Dpad") == 1 && StopRight == false && Y1 && DN_MainMenuMannager.Xbox)
                    //{
                    //    if (dir != DIRECTION.RIGHT)
                    //    {
                    //        buttonCooldown = cooldownforbutton;
                    //        dir = DIRECTION.RIGHT;
                    //    }
                    //    else
                    //    {

                    //        canMove = false;
                    //        moving = true;
                    //        pos += Vector3.right;

                    //    }
                    //}
                }
            if (P3 && A1)
            {
                if (Input.GetAxis("Xbox Solo P1 Press Up Dpad") == 0 && Input.GetAxis("Xbox Solo P1 Press Down Dpad") == 0 && Input.GetAxis("Xbox Solo P1 Press Right Dpad") == 0 && Input.GetAxis("Xbox Solo P1 Press Left Dpad") == 0 && DN_MainMenuMannager.Xbox)
                {
                    MechIdle.SetActive(true);
                    MechMoveRNL.SetActive(false);
                    MechMoveUND.SetActive(false);
                }
                if (Input.GetAxis("Xbox Solo P1 Press Left Dpad") == 1 && StopLeft == false && DN_MainMenuMannager.Xbox)
                {
                    if (dir != DIRECTION.LEFT)
                    {
                        dir = DIRECTION.LEFT;
                        buttonCooldown = cooldownforbutton;
                    }
                    else
                    {
                        MechIdle.SetActive(false);
                        MechMoveRNL.SetActive(true);
                        MechMoveUND.SetActive(false);
                        canMove = false;
                        moving = true;
                        pos += Vector3.left;
                    }
                }
            }
            if (P4 && Triangle1)
            {
                //if (Input.GetAxis("Solo P1 Press Up Arrow") == 1 && StopTop == false && X1 && DN_MainMenuMannager.Ps4)
                //{
                //    if (dir != DIRECTION.UP)
                //    {
                //        dir = DIRECTION.UP;
                //        buttonCooldown = cooldownforbutton;
                //    }
                //    else
                //    {
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.forward;
                //    }

                //}
                //if (Input.GetAxis("Xbox Solo P1 Press Up Dpad") == 1 && StopTop == false && A1 && DN_MainMenuMannager.Xbox)
                //{
                //    if (dir != DIRECTION.UP)
                //    {
                //        dir = DIRECTION.UP;
                //        buttonCooldown = cooldownforbutton;
                //    }
                //    else
                //    {
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.forward;
                //    }
                //}
                if (Input.GetAxis("Solo P1 Press Up Arrow") == 0 && Input.GetAxis("Solo P1 Press Right Arrow") == 0 && Input.GetAxis("Solo P1 Press Left Arrow") == 0 && Input.GetAxis("Solo P1 Press Down Arrow") == 0 && DN_MainMenuMannager.Ps4)
                {
                    MechIdle.SetActive(true);
                    MechMoveRNL.SetActive(false);
                    MechMoveUND.SetActive(false);
                }
                if (Input.GetAxis("Solo P1 Press Down Arrow") == 1 && StopBot == false /*&& X1*/ && DN_MainMenuMannager.Ps4)
                    {

                        if (dir != DIRECTION.DOWN)
                        {
                            buttonCooldown = cooldownforbutton;
                            dir = DIRECTION.DOWN;
                        MechIdle.SetActive(false);
                        MechMoveRNL.SetActive(false);
                        MechMoveUND.SetActive(true);
                    }
                        else
                        {
                      
                        canMove = false;
                            moving = true;
                            pos += Vector3.back;
                        }
                    }
                    //if (Input.GetAxis("Xbox Solo P1 Press Down Dpad") == 1 && StopBot == false && A1 && DN_MainMenuMannager.Xbox)
                    //{
                    //    if (dir != DIRECTION.DOWN)
                    //    {
                    //        buttonCooldown = cooldownforbutton;
                    //        dir = DIRECTION.DOWN;
                    //    }
                    //    else
                    //    {
                    //        canMove = false;
                    //        moving = true;
                    //        pos += Vector3.back;
                    //    }
                    //}
                    //if (Input.GetAxis("Solo P1 Press Left Arrow") == 1 && StopLeft == false && X1 && DN_MainMenuMannager.Ps4)
                    //{

                    //    if (dir != DIRECTION.LEFT)
                    //    {
                    //        buttonCooldown = cooldownforbutton;
                    //        dir = DIRECTION.LEFT;
                    //    }
                    //    else
                    //    {
                    //        canMove = false;
                    //        moving = true;
                    //        pos += Vector3.left;
                    //    }
                    //}
                    //if (Input.GetAxis("Xbox Solo P1 Press Left Dpad") == 1 && StopLeft == false && A1 && DN_MainMenuMannager.Xbox)
                    //{
                    //    if (dir != DIRECTION.LEFT)
                    //    {
                    //        buttonCooldown = cooldownforbutton;
                    //        dir = DIRECTION.LEFT;
                    //    }
                    //    else
                    //    {
                    //        canMove = false;
                    //        moving = true;
                    //        pos += Vector3.left;
                    //    }
                    //}
                    //if (Input.GetAxis("Solo P1 Press Right Arrow") == 1 && StopRight == false && X1 && DN_MainMenuMannager.Ps4)
                    //{

                    //    if (dir != DIRECTION.RIGHT)
                    //    {
                    //        buttonCooldown = cooldownforbutton;
                    //        dir = DIRECTION.RIGHT;
                    //    }
                    //    else
                    //    {

                    //        canMove = false;
                    //        moving = true;
                    //        pos += Vector3.right;

                    //    }
                    //}
                    //if (Input.GetAxis("Xbox Solo P1 Press Right Dpad") == 1 && StopRight == false && A1 && DN_MainMenuMannager.Xbox)
                    //{
                    //    if (dir != DIRECTION.RIGHT)
                    //    {
                    //        buttonCooldown = cooldownforbutton;
                    //        dir = DIRECTION.RIGHT;
                    //    }
                    //    else
                    //    {

                    //        canMove = false;
                    //        moving = true;
                    //        pos += Vector3.right;

                    //    }
                }
            if (P4 && Y1)
            {
                if (Input.GetAxis("Xbox Solo P1 Press Up Dpad") == 0 && Input.GetAxis("Xbox Solo P1 Press Down Dpad") == 0 && Input.GetAxis("Xbox Solo P1 Press Right Dpad") == 0 && Input.GetAxis("Xbox Solo P1 Press Left Dpad") == 0 && DN_MainMenuMannager.Xbox)
                {
                    MechIdle.SetActive(true);
                    MechMoveRNL.SetActive(false);
                    MechMoveUND.SetActive(false);
                }
                if (Input.GetAxis("Xbox Solo P1 Press Down Dpad") == 1 && StopBot == false && DN_MainMenuMannager.Xbox)
                {
                    if (dir != DIRECTION.DOWN)
                    {
                        dir = DIRECTION.DOWN;
                        buttonCooldown = cooldownforbutton;
                    }
                    else
                    {
                        MechIdle.SetActive(false);
                        MechMoveRNL.SetActive(false);
                        MechMoveUND.SetActive(true);
                        canMove = false;
                        moving = true;
                        pos += Vector3.back;
                    }
                }
            }
        }
            }
            //}
    private void TwoPlayerMove1()
    {
        if (P1)
        {
            if (buttonCooldown <= 0)
            {
                if (UsbExtender)
                {
                    if (Input.GetAxis("P1 Press Up Arrow") == 0 && Input.GetAxis("P2 Press Right Arrow") == 0 && Input.GetAxis("P1 Press Left Arrow") == 0 && Input.GetAxis("P2 Press Down Arrow") == 0 && O1 && DN_MainMenuMannager.Ps4)
                    {
                        MechIdle.SetActive(true);
                        MechMoveRNL.SetActive(false);
                        MechMoveUND.SetActive(false);
                    }
                    if (Input.GetAxis("Xbox P1 Press Up Dpad") == 0 && Input.GetAxis("Xbox P2 Press Right Dpad") == 0 && Input.GetAxis("Xbox P1 Press Left Dpad") == 0 && Input.GetAxis("Xbox P2 Press Down Dpad") == 0 && B1 && DN_MainMenuMannager.Xbox)
                    {
                        MechIdle.SetActive(true);
                        MechMoveRNL.SetActive(false);
                        MechMoveUND.SetActive(false);
                    }
                    //if (Input.GetAxis("P1 Press Left Arrow") == 1 && StopLeft == false && Square1 && DN_MainMenuMannager.Ps4)
                    //{

                    //    if (dir != DIRECTION.LEFT)
                    //    {
                    //        buttonCooldown = cooldownforbutton;
                    //        dir = DIRECTION.LEFT;
                    //    }
                    //    else
                    //    {
                    //        canMove = false;
                    //        moving = true;
                    //        pos += Vector3.left;
                    //    }

                    //}

                    if (Input.GetAxis("P1 Press Up Arrow") == 1 && StopTop == false && O1 && DN_MainMenuMannager.Ps4)
                    {

                        if (dir != DIRECTION.UP)
                        {
                            dir = DIRECTION.UP;
                            buttonCooldown = cooldownforbutton;
                            MechIdle.SetActive(false);
                            MechMoveRNL.SetActive(false);
                            MechMoveUND.SetActive(true);
                        }
                        else
                        {
                            
                            canMove = false;
                            moving = true;
                            pos += Vector3.forward;
                        }
                    }
                  
                        
                    if (Input.GetAxis("Xbox P1 Press Up Dpad") == 1 && B1 && StopTop == false && DN_MainMenuMannager.Xbox)
                    {
                        if (dir != DIRECTION.UP)
                        {
                            dir = DIRECTION.UP;
                            buttonCooldown = cooldownforbutton;
                        }
                        else
                        {
                            MechIdle.SetActive(false);
                            MechMoveRNL.SetActive(false);
                            MechMoveUND.SetActive(true);
                            canMove = false;
                            moving = true;
                            pos += Vector3.forward;
                        }
                    }
     
                    //else if (Input.GetAxis("P2 Press Down Arrow") == 1 && StopBot == false && Square2 && DN_MainMenuMannager.Ps4)
                    //{

                    //    if (dir != DIRECTION.DOWN)
                    //    {
                    //        buttonCooldown = cooldownforbutton;
                    //        dir = DIRECTION.DOWN;
                    //    }
                    //    else
                    //    {
                    //        canMove = false;
                    //        moving = true;
                    //        pos += Vector3.back;
                    //    }
                    //}
                    //else if (Input.GetAxis("P2 Press Right Arrow") == 1 && StopRight == false && Square2 && DN_MainMenuMannager.Ps4)
                    //{

                    //    if (dir != DIRECTION.RIGHT)
                    //    {
                    //        buttonCooldown = cooldownforbutton;
                    //        dir = DIRECTION.RIGHT;
                    //    }
                    //    else
                    //    {

                    //        canMove = false;
                    //        moving = true;
                    //        pos += Vector3.right;

                    //    }
                    //}
                    //if (Input.GetAxis("Xbox P1 Press Up Dpad") == 1 && StopTop == false && XB1 && DN_MainMenuMannager.Xbox)
                    //{
                    //    if (dir != DIRECTION.UP)
                    //    {
                    //        dir = DIRECTION.UP;
                    //        buttonCooldown = cooldownforbutton;
                    //    }
                    //    else
                    //    {
                    //        canMove = false;
                    //        moving = true;
                    //        pos += Vector3.forward;
                    //    }
                    //}
                    //if (Input.GetAxis("Xbox P1 Press Left Dpad") == 1 && StopLeft == false && XB1 && DN_MainMenuMannager.Xbox)
                    //{
                    //    if (dir != DIRECTION.LEFT)
                    //    {
                    //        buttonCooldown = cooldownforbutton;
                    //        dir = DIRECTION.LEFT;
                    //    }
                    //    else
                    //    {
                    //        canMove = false;
                    //        moving = true;
                    //        pos += Vector3.left;
                    //    }

                    //}
                    //if (Input.GetAxis("Xbox P2 Press Down Dpad") == 1 && StopBot == false && XB2 && DN_MainMenuMannager.Xbox)
                    //{
                    //    if (dir != DIRECTION.DOWN)
                    //    {
                    //        buttonCooldown = cooldownforbutton;
                    //        dir = DIRECTION.DOWN;
                    //    }
                    //    else
                    //    {
                    //        canMove = false;
                    //        moving = true;
                    //        pos += Vector3.back;
                    //    }
                    //}
                    //if (Input.GetAxis("Xbox P2 Press Right Dpad") == 1 && StopRight == false && XB2 && DN_MainMenuMannager.Xbox)
                    //{
                    //    if (dir != DIRECTION.RIGHT)
                    //    {
                    //        buttonCooldown = cooldownforbutton;
                    //        dir = DIRECTION.RIGHT;
                    //    }
                    //    else
                    //    {

                    //        canMove = false;
                    //        moving = true;
                    //        pos += Vector3.right;

                    //    }
                    //}
                }
                else
                {
                    //if (Input.GetAxis("Solo P1 Press Left Arrow") == 1 && StopLeft == false && Square1 && DN_MainMenuMannager.Ps4)
                    //{

                    //    if (dir != DIRECTION.LEFT)
                    //    {
                    //        buttonCooldown = cooldownforbutton;
                    //        dir = DIRECTION.LEFT;
                    //    }
                    //    else
                    //    {
                    //        canMove = false;
                    //        moving = true;
                    //        pos += Vector3.left;
                    //    }

                    //}
                    if (Input.GetAxis("Solo P1 Press Up Arrow") == 0 && Input.GetAxis("P2 Press Right Arrow") == 0 && Input.GetAxis("Solo P1 Press Left Arrow") == 0 && Input.GetAxis("P2 Press Down Arrow") == 0 && O1 && DN_MainMenuMannager.Ps4)
                    {
                        MechIdle.SetActive(true);
                        MechMoveRNL.SetActive(false);
                        MechMoveUND.SetActive(false);
                    }

                    if (Input.GetAxis("Xbox Solo P1 Press Up Dpad") == 0 && Input.GetAxis("Xbox P2 Press Right Dpad") == 0 && Input.GetAxis("Xbox Solo P1 Press Left Dpad") == 0 && Input.GetAxis("Xbox P2 Press Down Dpad") == 0 && B1 && DN_MainMenuMannager.Xbox)
                    {
                        MechIdle.SetActive(true);
                        MechMoveRNL.SetActive(false);
                        MechMoveUND.SetActive(false);
                    }
                    if (Input.GetAxis("Solo P1 Press Up Arrow") == 1 && StopTop == false && O1/*&& Square1*/ && DN_MainMenuMannager.Ps4)
                    {

                        if (dir != DIRECTION.UP)
                        {
                            dir = DIRECTION.UP;
                            buttonCooldown = cooldownforbutton;
                            MechIdle.SetActive(false);
                            MechMoveRNL.SetActive(false);
                            MechMoveUND.SetActive(true);
                        }
                        else
                        {
                          
                            canMove = false;
                            moving = true;
                            pos += Vector3.forward;
                        }
                    }
                   
                    if (Input.GetAxis("Xbox Solo P1 Press Up Dpad") == 1 && B1 && StopTop == false && DN_MainMenuMannager.Xbox)
                    {
                        if (dir != DIRECTION.UP)
                        {
                            dir = DIRECTION.UP;
                            buttonCooldown = cooldownforbutton;
                        }
                        else
                        {
                            MechIdle.SetActive(false);
                            MechMoveRNL.SetActive(false);
                            MechMoveUND.SetActive(true);
                            canMove = false;
                            moving = true;
                            pos += Vector3.forward;
                        }
                    }
                    //else if (Input.GetAxis("P2 Press Down Arrow") == 1 && StopBot == false && Square2 && DN_MainMenuMannager.Ps4)
                    //{

                    //    if (dir != DIRECTION.DOWN)
                    //    {
                    //        buttonCooldown = cooldownforbutton;
                    //        dir = DIRECTION.DOWN;
                    //    }
                    //    else
                    //    {
                    //        canMove = false;
                    //        moving = true;
                    //        pos += Vector3.back;
                    //    }
                    //}
                    //else if (Input.GetAxis("P2 Press Right Arrow") == 1 && StopRight == false && Square2 && DN_MainMenuMannager.Ps4)
                    //{

                    //    if (dir != DIRECTION.RIGHT)
                    //    {
                    //        buttonCooldown = cooldownforbutton;
                    //        dir = DIRECTION.RIGHT;
                    //    }
                    //    else
                    //    {

                    //        canMove = false;
                    //        moving = true;
                    //        pos += Vector3.right;

                    //    }
                    //}
                    //if (Input.GetAxis("Xbox Solo P1 Press Up Dpad") == 1 && StopTop == false && XB1 && DN_MainMenuMannager.Xbox)
                    //{
                    //    if (dir != DIRECTION.UP)
                    //    {
                    //        dir = DIRECTION.UP;
                    //        buttonCooldown = cooldownforbutton;
                    //    }
                    //    else
                    //    {
                    //        canMove = false;
                    //        moving = true;
                    //        pos += Vector3.forward;
                    //    }
                    //}
                    //if (Input.GetAxis("Xbox Solo P1 Press Left Dpad") == 1 && StopLeft == false && XB1 && DN_MainMenuMannager.Xbox)
                    //{
                    //    if (dir != DIRECTION.LEFT)
                    //    {
                    //        dir = DIRECTION.LEFT;
                    //        buttonCooldown = cooldownforbutton;

                    //    }
                    //    else
                    //    {
                    //        canMove = false;
                    //        moving = true;
                    //        pos += Vector3.left;
                    //    }

                    //}
                    //if (Input.GetAxis("Xbox P2 Press Down Dpad") == 1 && StopBot == false && XB2 && DN_MainMenuMannager.Xbox)
                    //{
                    //    if (dir != DIRECTION.DOWN)
                    //    {
                    //        buttonCooldown = cooldownforbutton;
                    //        dir = DIRECTION.DOWN;
                    //    }
                    //    else
                    //    {
                    //        canMove = false;
                    //        moving = true;
                    //        pos += Vector3.back;
                    //    }
                    //}
                    //if (Input.GetAxis("Xbox P2 Press Right Dpad") == 1 && StopRight == false && XB2 && DN_MainMenuMannager.Xbox)
                    //{
                    //    if (dir != DIRECTION.RIGHT)
                    //    {
                    //        buttonCooldown = cooldownforbutton;
                    //        dir = DIRECTION.RIGHT;
                    //    }
                    //    else
                    //    {

                    //        canMove = false;
                    //        moving = true;
                    //        pos += Vector3.right;

                    //    }
                    //}
                }
            }

        }
    }
    private void TwoPlayerMove2()
    {
        if (P2 )
        {
            if (buttonCooldown <= 0)
            {
                if (UsbExtender)
                {
                    //if (Input.GetAxis("P1 Press Left Arrow") == 1 && StopLeft == false && O1 && DN_MainMenuMannager.Ps4)
                    //{

                    //    if (dir != DIRECTION.LEFT)
                    //    {
                    //        buttonCooldown = cooldownforbutton;
                    //        dir = DIRECTION.LEFT;
                    //    }
                    //    else
                    //    {
                    //        canMove = false;
                    //        moving = true;
                    //        pos += Vector3.left;
                    //    }

                    //}
                    //else if (Input.GetAxis("P1 Press Up Arrow") == 1 && StopTop == false && O1 && DN_MainMenuMannager.Ps4)
                    //{

                    //    if (dir != DIRECTION.UP)
                    //    {
                    //        dir = DIRECTION.UP;
                    //        buttonCooldown = cooldownforbutton;
                    //    }
                    //    else
                    //    {
                    //        canMove = false;
                    //        moving = true;
                    //        pos += Vector3.forward;
                    //    }
                    //}
                    //else if (Input.GetAxis("P2 Press Down Arrow") == 1 && StopBot == false && O2 && DN_MainMenuMannager.Ps4)
                    //{

                    //    if (dir != DIRECTION.DOWN)
                    //    {
                    //        buttonCooldown = cooldownforbutton;
                    //        dir = DIRECTION.DOWN;
                    //    }
                    //    else
                    //    {
                    //        canMove = false;
                    //        moving = true;
                    //        pos += Vector3.back;
                    //    }
                    //}
                    if (Input.GetAxis("P1 Press Up Arrow") == 0 && Input.GetAxis("P2 Press Right Arrow") == 0 && Input.GetAxis("P1 Press Left Arrow") == 0 && Input.GetAxis("P2 Press Down Arrow") == 0 && Square2 && DN_MainMenuMannager.Ps4)
                    {
                        MechIdle.SetActive(true);
                        MechMoveRNL.SetActive(false);
                        MechMoveUND.SetActive(false);
                    }
                    if (Input.GetAxis("Xbox P1 Press Up Dpad") == 0 && Input.GetAxis("Xbox P2 Press Right Dpad") == 0 && Input.GetAxis("Xbox P1 Press Left Dpad") == 0 && Input.GetAxis("Xbox P2 Press Down Dpad") == 0 && XB2 && DN_MainMenuMannager.Xbox)
                    {
                        MechIdle.SetActive(true);
                        MechMoveRNL.SetActive(false);
                        MechMoveUND.SetActive(false);
                    }
                    if (Input.GetAxis("P2 Press Right Arrow") == 1 && StopRight == false && Square2  /*&& O2*/ && DN_MainMenuMannager.Ps4)
                    {

                        if (dir != DIRECTION.RIGHT)
                        {
                            buttonCooldown = cooldownforbutton;
                            dir = DIRECTION.RIGHT;
                            MechIdle.SetActive(false);
                            MechMoveRNL.SetActive(true);
                            MechMoveUND.SetActive(false);
                        }
                        else
                        {
                           
                            canMove = false;
                            moving = true;
                            pos += Vector3.right;

                        }
                    }
               
                    if (Input.GetAxis("Xbox P2 Press Right Dpad") == 1 && XB2 && StopRight == false && DN_MainMenuMannager.Xbox)
                    {
                        if (dir != DIRECTION.RIGHT)
                        {
                            dir = DIRECTION.RIGHT;
                            buttonCooldown = cooldownforbutton;
                        }
                        else
                        {
                            MechIdle.SetActive(false);
                            MechMoveRNL.SetActive(true);
                            MechMoveUND.SetActive(false);
                            canMove = false;
                            moving = true;
                            pos += Vector3.right;
                        }
                    }

                    //if (Input.GetAxis("Xbox P1 Press Up Dpad") == 1 && StopTop == false && B1 && DN_MainMenuMannager.Xbox)
                    //{
                    //    if (dir != DIRECTION.UP)
                    //    {
                    //        dir = DIRECTION.UP;
                    //        buttonCooldown = cooldownforbutton;
                    //    }
                    //    else
                    //    {
                    //        canMove = false;
                    //        moving = true;
                    //        pos += Vector3.forward;
                    //    }
                    //}
                    //if (Input.GetAxis("Xbox P1 Press Left Dpad") == 1 && StopLeft == false && B1 && DN_MainMenuMannager.Xbox)
                    //{
                    //    if (dir != DIRECTION.LEFT)
                    //    {
                    //        dir = DIRECTION.LEFT;
                    //        buttonCooldown = cooldownforbutton;

                    //    }
                    //    else
                    //    {
                    //        canMove = false;
                    //        moving = true;
                    //        pos += Vector3.left;
                    //    }

                    //}
                    //if (Input.GetAxis("Xbox P2 Press Down Dpad") == 1 && StopBot == false && B2 && DN_MainMenuMannager.Xbox)
                    //{
                    //    if (dir != DIRECTION.DOWN)
                    //    {
                    //        buttonCooldown = cooldownforbutton;
                    //        dir = DIRECTION.DOWN;
                    //    }
                    //    else
                    //    {
                    //        canMove = false;
                    //        moving = true;
                    //        pos += Vector3.back;
                    //    }
                    //}
                    //if (Input.GetAxis("Xbox P2 Press Right Dpad") == 1 && StopRight == false && B2 && DN_MainMenuMannager.Xbox)
                    //{
                    //    if (dir != DIRECTION.RIGHT)
                    //    {
                    //        buttonCooldown = cooldownforbutton;
                    //        dir = DIRECTION.RIGHT;
                    //    }
                    //    else
                    //    {

                    //        canMove = false;
                    //        moving = true;
                    //        pos += Vector3.right;

                    //    }
                    //}
                }
                else
                {
                    //if (Input.GetAxis("Solo P1 Press Left Arrow") == 1 && StopLeft == false && O1 && DN_MainMenuMannager.Ps4)
                    //{

                    //    if (dir != DIRECTION.LEFT)
                    //    {
                    //        buttonCooldown = cooldownforbutton;
                    //        dir = DIRECTION.LEFT;
                    //    }
                    //    else
                    //    {
                    //        canMove = false;
                    //        moving = true;
                    //        pos += Vector3.left;
                    //    }

                    //}
                    //else if (Input.GetAxis("Solo P1 Press Up Arrow") == 1 && StopTop == false && O1 && DN_MainMenuMannager.Ps4)
                    //{

                    //    if (dir != DIRECTION.UP)
                    //    {
                    //        dir = DIRECTION.UP;
                    //        buttonCooldown = cooldownforbutton;
                    //    }
                    //    else
                    //    {
                    //        canMove = false;
                    //        moving = true;
                    //        pos += Vector3.forward;
                    //    }
                    //}
                    //else if (Input.GetAxis("P2 Press Down Arrow") == 1 && StopBot == false && O2 && DN_MainMenuMannager.Ps4)
                    //{

                    //    if (dir != DIRECTION.DOWN)
                    //    {
                    //        buttonCooldown = cooldownforbutton;
                    //        dir = DIRECTION.DOWN;
                    //    }
                    //    else
                    //    {
                    //        canMove = false;
                    //        moving = true;
                    //        pos += Vector3.back;
                    //    }
                    //}
                    if (Input.GetAxis("Solo P1 Press Up Arrow") == 0 && Input.GetAxis("P2 Press Right Arrow") == 0 && Input.GetAxis("Solo P1 Press Left Arrow") == 0 && Input.GetAxis("P2 Press Down Arrow") == 0 && Square2 && DN_MainMenuMannager.Ps4)
                    {
                        MechIdle.SetActive(true);
                        MechMoveRNL.SetActive(false);
                        MechMoveUND.SetActive(false);
                    }

                    if (Input.GetAxis("Xbox Solo P1 Press Up Dpad") == 0 && Input.GetAxis("Xbox P2 Press Right Dpad") == 0 && Input.GetAxis("Xbox Solo P1 Press Left Dpad") == 0 && Input.GetAxis("Xbox P2 Press Down Dpad") == 0 && XB2 && DN_MainMenuMannager.Xbox)
                    {
                        MechIdle.SetActive(true);
                        MechMoveRNL.SetActive(false);
                        MechMoveUND.SetActive(false);
                    }
                    if (Input.GetAxis("P2 Press Right Arrow") == 1 && StopRight == false && Square2 /*&& O2*/ && DN_MainMenuMannager.Ps4)
                    {

                        if (dir != DIRECTION.RIGHT)
                        {
                            MechIdle.SetActive(false);
                            MechMoveRNL.SetActive(true);
                            MechMoveUND.SetActive(false);
                            buttonCooldown = cooldownforbutton;
                            dir = DIRECTION.RIGHT;
                        }
                        else
                        {
                            
                            canMove = false;
                            moving = true;
                            pos += Vector3.right;

                        }
                    }
                   
                    if (Input.GetAxis("Xbox P2 Press Right Dpad") == 1 && XB2 && StopRight == false && DN_MainMenuMannager.Xbox)
                    {
                        if (dir != DIRECTION.RIGHT)
                        {
                            dir = DIRECTION.RIGHT;
                            buttonCooldown = cooldownforbutton;
                        }
                        else
                        {
                            MechIdle.SetActive(false);
                            MechMoveRNL.SetActive(true);
                            MechMoveUND.SetActive(false);
                            canMove = false;
                            moving = true;
                            pos += Vector3.right;
                        }
                    }
                    //if (Input.GetAxis("Xbox Solo P1 Press Up Dpad") == 1 && StopTop == false && B1 && DN_MainMenuMannager.Xbox)
                    //{
                    //    if (dir != DIRECTION.UP)
                    //    {
                    //        dir = DIRECTION.UP;
                    //        buttonCooldown = cooldownforbutton;
                    //    }
                    //    else
                    //    {
                    //        canMove = false;
                    //        moving = true;
                    //        pos += Vector3.forward;
                    //    }
                    //}
                    //if (Input.GetAxis("Xbox Solo P1 Press Left Dpad") == 1 && StopLeft == false && B1 && DN_MainMenuMannager.Xbox)
                    //{
                    //    if (dir != DIRECTION.LEFT)
                    //    {
                    //        dir = DIRECTION.LEFT;
                    //        buttonCooldown = cooldownforbutton;

                    //    }
                    //    else
                    //    {
                    //        canMove = false;
                    //        moving = true;
                    //        pos += Vector3.left;
                    //    }

                    //}
                    //if (Input.GetAxis("Xbox P2 Press Down Dpad") == 1 && StopBot == false && B2 && DN_MainMenuMannager.Xbox)
                    //{
                    //    if (dir != DIRECTION.DOWN)
                    //    {
                    //        buttonCooldown = cooldownforbutton;
                    //        dir = DIRECTION.DOWN;
                    //    }
                    //    else
                    //    {
                    //        canMove = false;
                    //        moving = true;
                    //        pos += Vector3.back;
                    //    }
                    //}
                    //if (Input.GetAxis("Xbox P2 Press Right Dpad") == 1 && StopRight == false && B2 && DN_MainMenuMannager.Xbox)
                    //{
                    //    if (dir != DIRECTION.RIGHT)
                    //    {
                    //        buttonCooldown = cooldownforbutton;
                    //        dir = DIRECTION.RIGHT;
                    //    }
                    //    else
                    //    {

                    //        canMove = false;
                    //        moving = true;
                    //        pos += Vector3.right;

                    //    }
                    //}
                }
            }
        }
    }
    private void TwoPlayerMove3()
    {
        if (P3)
        {
            if (buttonCooldown <= 0)
            {
                if (UsbExtender)
                {
                    if (Input.GetAxis("P1 Press Up Arrow") == 0 && Input.GetAxis("P2 Press Right Arrow") == 0 && Input.GetAxis("P1 Press Left Arrow") == 0 && Input.GetAxis("P2 Press Down Arrow") == 0 && X1 && DN_MainMenuMannager.Ps4)
                    {
                        MechIdle.SetActive(true);
                        MechMoveRNL.SetActive(false);
                        MechMoveUND.SetActive(false);
                    }
                    if (Input.GetAxis("Xbox P1 Press Up Dpad") == 0 && Input.GetAxis("Xbox P2 Press Right Dpad") == 0 && Input.GetAxis("Xbox P1 Press Left Dpad") == 0 && Input.GetAxis("Xbox P2 Press Down Dpad") == 0 && A1 && DN_MainMenuMannager.Xbox)
                    {
                        MechIdle.SetActive(true);
                        MechMoveRNL.SetActive(false);
                        MechMoveUND.SetActive(false);
                    }

                    if (Input.GetAxis("P1 Press Left Arrow") == 1 && StopLeft == false && X1 /*&& Triangle1*/ && DN_MainMenuMannager.Ps4)
                    {

                        if (dir != DIRECTION.LEFT)
                        {
                            buttonCooldown = cooldownforbutton;
                            dir = DIRECTION.LEFT;
                            MechIdle.SetActive(false);
                            MechMoveRNL.SetActive(true);
                            MechMoveUND.SetActive(false);
                        }
                        else
                        {
                           
                            canMove = false;
                            moving = true;
                            pos += Vector3.left;
                        }

                    }
                  
                    if (Input.GetAxis("Xbox P1 Press Left Dpad") == 1 && A1 && StopLeft == false && DN_MainMenuMannager.Xbox)
                    {
                        if (dir != DIRECTION.LEFT)
                        {
                            dir = DIRECTION.LEFT;
                            buttonCooldown = cooldownforbutton;
                        }
                        else
                        {
                            MechIdle.SetActive(false);
                            MechMoveRNL.SetActive(true);
                            MechMoveUND.SetActive(false);
                            canMove = false;
                            moving = true;
                            pos += Vector3.left;
                        }
                    }
                    //else if (Input.GetAxis("P1 Press Up Arrow") == 1 && StopTop == false && Triangle1 && DN_MainMenuMannager.Ps4)
                    //{
                    //    if (dir != DIRECTION.UP)
                    //    {
                    //        dir = DIRECTION.UP;
                    //        buttonCooldown = cooldownforbutton;
                    //    }
                    //    else
                    //    {
                    //        canMove = false;
                    //        moving = true;
                    //        pos += Vector3.forward;
                    //    }
                    //}
                    //else if (Input.GetAxis("P2 Press Down Arrow") == 1 && StopBot == false && Triangle2 && DN_MainMenuMannager.Ps4)
                    //{

                    //    if (dir != DIRECTION.DOWN)
                    //    {
                    //        buttonCooldown = cooldownforbutton;
                    //        dir = DIRECTION.DOWN;
                    //    }
                    //    else
                    //    {
                    //        canMove = false;
                    //        moving = true;
                    //        pos += Vector3.back;
                    //    }
                    //}
                    //else if (Input.GetAxis("P2 Press Right Arrow") == 1 && StopRight == false && Triangle2 && DN_MainMenuMannager.Ps4)
                    //{

                    //    if (dir != DIRECTION.RIGHT)
                    //    {
                    //        buttonCooldown = cooldownforbutton;
                    //        dir = DIRECTION.RIGHT;
                    //    }
                    //    else
                    //    {

                    //        canMove = false;
                    //        moving = true;
                    //        pos += Vector3.right;

                    //    }
                    //}
                    //if (Input.GetAxis("Xbox P1 Press Up Dpad") == 1 && StopTop == false && Y1 && DN_MainMenuMannager.Xbox)
                    //{
                    //    if (dir != DIRECTION.UP)
                    //    {
                    //        dir = DIRECTION.UP;
                    //        buttonCooldown = cooldownforbutton;
                    //    }
                    //    else
                    //    {
                    //        canMove = false;
                    //        moving = true;
                    //        pos += Vector3.forward;
                    //    }
                    //}
                    //if (Input.GetAxis("Xbox P1 Press Left Dpad") == 1 && StopLeft == false && Y1 && DN_MainMenuMannager.Xbox)
                    //{
                    //    if (dir != DIRECTION.LEFT)
                    //    {
                    //        buttonCooldown = cooldownforbutton;
                    //        dir = DIRECTION.LEFT;
                    //    }
                    //    else
                    //    {
                    //        canMove = false;
                    //        moving = true;
                    //        pos += Vector3.left;
                    //    }

                    //}
                    //if (Input.GetAxis("Xbox P2 Press Down Dpad") == 1 && StopBot == false && Y2 && DN_MainMenuMannager.Xbox)
                    //{
                    //    if (dir != DIRECTION.DOWN)
                    //    {
                    //        buttonCooldown = cooldownforbutton;
                    //        dir = DIRECTION.DOWN;
                    //    }
                    //    else
                    //    {
                    //        canMove = false;
                    //        moving = true;
                    //        pos += Vector3.back;
                    //    }
                    //}
                    //if (Input.GetAxis("Xbox P2 Press Right Dpad") == 1 && StopRight == false && Y2 && DN_MainMenuMannager.Xbox)
                    //{
                    //    if (dir != DIRECTION.RIGHT)
                    //    {
                    //        buttonCooldown = cooldownforbutton;
                    //        dir = DIRECTION.RIGHT;
                    //    }
                    //    else
                    //    {

                    //        canMove = false;
                    //        moving = true;
                    //        pos += Vector3.right;

                    //    }
                    //}
                }
                else
                {
                    if (Input.GetAxis("Solo P1 Press Up Arrow") == 0 && Input.GetAxis("P2 Press Right Arrow") == 0 && Input.GetAxis("Solo P1 Press Left Arrow") == 0 && Input.GetAxis("P2 Press Down Arrow") == 0 && X1 && DN_MainMenuMannager.Ps4)
                    {
                        MechIdle.SetActive(true);
                        MechMoveRNL.SetActive(false);
                        MechMoveUND.SetActive(false);
                    }

                    if (Input.GetAxis("Xbox Solo P1 Press Up Dpad") == 0 && Input.GetAxis("Xbox P2 Press Right Dpad") == 0 && Input.GetAxis("Xbox Solo P1 Press Left Dpad") == 0 && Input.GetAxis("Xbox P2 Press Down Dpad") == 0 && A1 && DN_MainMenuMannager.Xbox)
                    {
                        MechIdle.SetActive(true);
                        MechMoveRNL.SetActive(false);
                        MechMoveUND.SetActive(false);
                    }
                    if (Input.GetAxis("Solo P1 Press Left Arrow") == 1 && StopLeft == false && X1 /*&& Triangle1 */&& DN_MainMenuMannager.Ps4)
                    {

                        if (dir != DIRECTION.LEFT)
                        {
                            buttonCooldown = cooldownforbutton;
                            dir = DIRECTION.LEFT;
                            MechIdle.SetActive(false);
                            MechMoveRNL.SetActive(true);
                            MechMoveUND.SetActive(false);
                        }
                        else
                        {
                           
                            canMove = false;
                            moving = true;
                            pos += Vector3.left;
                        }

                    }
                   
                    if (Input.GetAxis("Xbox Solo P1 Press Left Dpad") == 1 && A1 && StopLeft == false && DN_MainMenuMannager.Xbox)
                    {
                        if (dir != DIRECTION.LEFT)
                        {
                            dir = DIRECTION.LEFT;
                            buttonCooldown = cooldownforbutton;
                        }
                        else
                        {
                            MechIdle.SetActive(false);
                            MechMoveRNL.SetActive(true);
                            MechMoveUND.SetActive(false);
                            canMove = false;
                            moving = true;
                            pos += Vector3.left;
                        }
                    }
                    //else if (Input.GetAxis("Solo P1 Press Up Arrow") == 1 && StopTop == false && Triangle1 && DN_MainMenuMannager.Ps4)
                    //{

                    //    if (dir != DIRECTION.UP)
                    //    {
                    //        dir = DIRECTION.UP;
                    //        buttonCooldown = cooldownforbutton;
                    //    }
                    //    else
                    //    {
                    //        canMove = false;
                    //        moving = true;
                    //        pos += Vector3.forward;
                    //    }
                    //}
                    //else if (Input.GetAxis("P2 Press Down Arrow") == 1 && StopBot == false && Triangle2 && DN_MainMenuMannager.Ps4)
                    //{

                    //    if (dir != DIRECTION.DOWN)
                    //    {
                    //        buttonCooldown = cooldownforbutton;
                    //        dir = DIRECTION.DOWN;
                    //    }
                    //    else
                    //    {
                    //        canMove = false;
                    //        moving = true;
                    //        pos += Vector3.back;
                    //    }
                    //}
                    //else if (Input.GetAxis("P2 Press Right Arrow") == 1 && StopRight == false && Triangle2 && DN_MainMenuMannager.Ps4)
                    //{

                    //    if (dir != DIRECTION.RIGHT)
                    //    {
                    //        buttonCooldown = cooldownforbutton;
                    //        dir = DIRECTION.RIGHT;
                    //    }
                    //    else
                    //    {

                    //        canMove = false;
                    //        moving = true;
                    //        pos += Vector3.right;

                    //    }
                    //}
                    //if (Input.GetAxis("Xbox Solo P1 Press Up Dpad") == 1 && StopTop == false && Y1 && DN_MainMenuMannager.Xbox)
                    //{
                    //    if (dir != DIRECTION.UP)
                    //    {
                    //        dir = DIRECTION.UP;
                    //        buttonCooldown = cooldownforbutton;
                    //    }
                    //    else
                    //    {
                    //        canMove = false;
                    //        moving = true;
                    //        pos += Vector3.forward;
                    //    }
                    //}
                    //if (Input.GetAxis("Xbox Solo P1 Press Left Dpad") == 1 && StopLeft == false && Y1 && DN_MainMenuMannager.Xbox)
                    //{
                    //    if (dir != DIRECTION.LEFT)
                    //    {
                    //        buttonCooldown = cooldownforbutton;
                    //        dir = DIRECTION.LEFT;
                    //    }
                    //    else
                    //    {
                    //        canMove = false;
                    //        moving = true;
                    //        pos += Vector3.left;
                    //    }

                    //}
                    //if (Input.GetAxis("Xbox P2 Press Down Dpad") == 1 && StopBot == false && Y2 && DN_MainMenuMannager.Xbox)
                    //{
                    //    if (dir != DIRECTION.DOWN)
                    //    {
                    //        buttonCooldown = cooldownforbutton;
                    //        dir = DIRECTION.DOWN;
                    //    }
                    //    else
                    //    {
                    //        canMove = false;
                    //        moving = true;
                    //        pos += Vector3.back;
                    //    }
                    //}
                    //if (Input.GetAxis("Xbox P2 Press Right Dpad") == 1 && StopRight == false && Y2 && DN_MainMenuMannager.Xbox)
                    //{
                    //    if (dir != DIRECTION.RIGHT)
                    //    {
                    //        buttonCooldown = cooldownforbutton;
                    //        dir = DIRECTION.RIGHT;
                    //    }
                    //    else
                    //    {

                    //        canMove = false;
                    //        moving = true;
                    //        pos += Vector3.right;

                    //    }
                    //}
                }
            }
        }
    }

    private void TwoPlayerMove4()
    {
        if (P4 )
        {
            if (buttonCooldown <= 0)
            {
                if (UsbExtender)
                {
                    //if (Input.GetAxis("P1 Press Left Arrow") == 1 && StopLeft == false && X1 && DN_MainMenuMannager.Ps4)
                    //{

                    //    if (dir != DIRECTION.LEFT)
                    //    {
                    //        buttonCooldown = cooldownforbutton;
                    //        dir = DIRECTION.LEFT;
                    //    }
                    //    else
                    //    {
                    //        canMove = false;
                    //        moving = true;
                    //        pos += Vector3.left;
                    //    }

                    //}
                    //else if (Input.GetAxis("P1 Press Up Arrow") == 1 && StopTop == false && X1 && DN_MainMenuMannager.Ps4)
                    //{
                    //    if (dir != DIRECTION.UP)
                    //    {
                    //        dir = DIRECTION.UP;
                    //        buttonCooldown = cooldownforbutton;
                    //    }
                    //    else
                    //    {
                    //        canMove = false;
                    //        moving = true;
                    //        pos += Vector3.forward;
                    //    }
                    //}
                    if (Input.GetAxis("P1 Press Up Arrow") == 0 && Input.GetAxis("P2 Press Right Arrow") == 0 && Input.GetAxis("P1 Press Left Arrow") == 0 && Input.GetAxis("P2 Press Down Arrow") == 0 && Triangle2 && DN_MainMenuMannager.Ps4)
                    {
                        MechIdle.SetActive(true);
                        MechMoveRNL.SetActive(false);
                        MechMoveUND.SetActive(false);
                    }
                    if (Input.GetAxis("Xbox P1 Press Up Dpad") == 0 && Input.GetAxis("Xbox P2 Press Right Dpad") == 0 && Input.GetAxis("Xbox P1 Press Left Dpad") == 0 && Input.GetAxis("Xbox P2 Press Down Dpad") == 0 && Y2 && DN_MainMenuMannager.Xbox)
                    {
                        MechIdle.SetActive(true);
                        MechMoveRNL.SetActive(false);
                        MechMoveUND.SetActive(false);
                    }
                    if (Input.GetAxis("P2 Press Down Arrow") == 1 && StopBot == false &&Triangle2 /*&& X2*/ && DN_MainMenuMannager.Ps4)
                    {

                        if (dir != DIRECTION.DOWN)
                        {
                            buttonCooldown = cooldownforbutton;
                            dir = DIRECTION.DOWN;
                            MechIdle.SetActive(false);
                            MechMoveRNL.SetActive(false);
                            MechMoveUND.SetActive(true);
                        }
                        else
                        {
                          
                            canMove = false;
                            moving = true;
                            pos += Vector3.back;
                        }
                    }
                 
                    if (Input.GetAxis("Xbox P2 Press Down Dpad") == 1 && Y2 && StopBot == false && DN_MainMenuMannager.Xbox)
                    {
                        if (dir != DIRECTION.DOWN)
                        {
                            dir = DIRECTION.DOWN;
                            buttonCooldown = cooldownforbutton;
                        }
                        else
                        {
                            MechIdle.SetActive(false);
                            MechMoveRNL.SetActive(false);
                            MechMoveUND.SetActive(true);
                            canMove = false;
                            moving = true;
                            pos += Vector3.back;
                        }
                    }
                    //else if (Input.GetAxis("P2 Press Right Arrow") == 1 && StopRight == false && X2 && DN_MainMenuMannager.Ps4)
                    //{

                    //    if (dir != DIRECTION.RIGHT)
                    //    {
                    //        buttonCooldown = cooldownforbutton;
                    //        dir = DIRECTION.RIGHT;
                    //    }
                    //    else
                    //    {

                    //        canMove = false;
                    //        moving = true;
                    //        pos += Vector3.right;

                    //    }
                    //}
                    //if (Input.GetAxis("Xbox P1 Press Up Dpad") == 1 && StopTop == false && A1 && DN_MainMenuMannager.Xbox)
                    //{
                    //    if (dir != DIRECTION.UP)
                    //    {
                    //        dir = DIRECTION.UP;
                    //        buttonCooldown = cooldownforbutton;
                    //    }
                    //    else
                    //    {
                    //        canMove = false;
                    //        moving = true;
                    //        pos += Vector3.forward;
                    //    }
                    //}
                    //if (Input.GetAxis("Xbox P1 Press Left Dpad") == 1 && StopLeft == false && A1 && DN_MainMenuMannager.Xbox)
                    //{
                    //    if (dir != DIRECTION.LEFT)
                    //    {
                    //        buttonCooldown = cooldownforbutton;
                    //        dir = DIRECTION.LEFT;
                    //    }
                    //    else
                    //    {
                    //        canMove = false;
                    //        moving = true;
                    //        pos += Vector3.left;
                    //    }

                    //}
                    //if (Input.GetAxis("Xbox P2 Press Down Dpad") == 1 && StopBot == false && A2 && DN_MainMenuMannager.Xbox)
                    //{
                    //    if (dir != DIRECTION.DOWN)
                    //    {
                    //        buttonCooldown = cooldownforbutton;
                    //        dir = DIRECTION.DOWN;
                    //    }
                    //    else
                    //    {
                    //        canMove = false;
                    //        moving = true;
                    //        pos += Vector3.back;
                    //    }
                    //}
                    //if (Input.GetAxis("Xbox P2 Press Right Dpad") == 1 && StopRight == false && A2 && DN_MainMenuMannager.Xbox)
                    //{
                    //    if (dir != DIRECTION.RIGHT)
                    //    {
                    //        buttonCooldown = cooldownforbutton;
                    //        dir = DIRECTION.RIGHT;
                    //    }
                    //    else
                    //    {

                    //        canMove = false;
                    //        moving = true;
                    //        pos += Vector3.right;

                    //    }
                    //}
                }
                else
                {
                    //if (Input.GetAxis("Solo P1 Press Left Arrow") == 1 && StopLeft == false && X1 && DN_MainMenuMannager.Ps4)
                    //{

                    //    if (dir != DIRECTION.LEFT)
                    //    {
                    //        buttonCooldown = cooldownforbutton;
                    //        dir = DIRECTION.LEFT;
                    //    }
                    //    else
                    //    {
                    //        canMove = false;
                    //        moving = true;
                    //        pos += Vector3.left;
                    //    }

                    //}
                    //else if (Input.GetAxis("Solo P1 Press Up Arrow") == 1 && StopTop == false && X1 && DN_MainMenuMannager.Ps4)
                    //{

                    //    if (dir != DIRECTION.UP)
                    //    {
                    //        dir = DIRECTION.UP;
                    //        buttonCooldown = cooldownforbutton;
                    //    }
                    //    else
                    //    {
                    //        canMove = false;
                    //        moving = true;
                    //        pos += Vector3.forward;
                    //    }
                    //}
                    if (Input.GetAxis("Solo P1 Press Up Arrow") == 0 && Input.GetAxis("P2 Press Right Arrow") == 0 && Input.GetAxis("Solo P1 Press Left Arrow") == 0 && Input.GetAxis("P2 Press Down Arrow") == 0 && Triangle2 && DN_MainMenuMannager.Ps4)
                    {
                        MechIdle.SetActive(true);
                        MechMoveRNL.SetActive(false);
                        MechMoveUND.SetActive(false);
                    }

                    if (Input.GetAxis("Xbox Solo P1 Press Up Dpad") == 0 && Input.GetAxis("Xbox P2 Press Right Dpad") == 0 && Input.GetAxis("Xbox Solo P1 Press Left Dpad") == 0 && Input.GetAxis("Xbox P2 Press Down Dpad") == 0 && Y2 && DN_MainMenuMannager.Xbox)
                    {
                        MechIdle.SetActive(true);
                        MechMoveRNL.SetActive(false);
                        MechMoveUND.SetActive(false);
                    }
                    if (Input.GetAxis("P2 Press Down Arrow") == 1 && StopBot == false && Triangle2 /*&& X2*/ && DN_MainMenuMannager.Ps4)
                    {

                        if (dir != DIRECTION.DOWN)
                        {
                            buttonCooldown = cooldownforbutton;
                            dir = DIRECTION.DOWN;
                            MechIdle.SetActive(false);
                            MechMoveRNL.SetActive(false);
                            MechMoveUND.SetActive(true);
                        }
                        else
                        {
                          
                            canMove = false;
                            moving = true;
                            pos += Vector3.back;
                        }
                    }
                   
                    if (Input.GetAxis("Xbox P2 Press Down Dpad") == 1 && Y2 && StopBot == false && DN_MainMenuMannager.Xbox)
                    {
                        if (dir != DIRECTION.DOWN)
                        {
                            dir = DIRECTION.DOWN;
                            buttonCooldown = cooldownforbutton;
                        }
                        else
                        {
                            MechIdle.SetActive(false);
                            MechMoveRNL.SetActive(false);
                            MechMoveUND.SetActive(true);
                            canMove = false;
                            moving = true;
                            pos += Vector3.back;
                        }
                    }
                    //else if (Input.GetAxis("P2 Press Right Arrow") == 1 && StopRight == false && X2 && DN_MainMenuMannager.Ps4)
                    //{

                    //    if (dir != DIRECTION.RIGHT)
                    //    {
                    //        buttonCooldown = cooldownforbutton;
                    //        dir = DIRECTION.RIGHT;
                    //    }
                    //    else
                    //    {

                    //        canMove = false;
                    //        moving = true;
                    //        pos += Vector3.right;

                    //    }
                    //}
                    //if (Input.GetAxis("Xbox Solo P1 Press Up Dpad") == 1 && StopTop == false && A1 && DN_MainMenuMannager.Xbox)
                    //{
                    //    if (dir != DIRECTION.UP)
                    //    {
                    //        dir = DIRECTION.UP;
                    //        buttonCooldown = cooldownforbutton;
                    //    }
                    //    else
                    //    {
                    //        canMove = false;
                    //        moving = true;
                    //        pos += Vector3.forward;
                    //    }
                    //}
                    //if (Input.GetAxis("Xbox Solo P1 Press Left Dpad") == 1 && StopLeft == false && A1 && DN_MainMenuMannager.Xbox)
                    //{
                    //    if (dir != DIRECTION.LEFT)
                    //    {
                    //        buttonCooldown = cooldownforbutton;
                    //        dir = DIRECTION.LEFT;
                    //    }
                    //    else
                    //    {
                    //        canMove = false;
                    //        moving = true;
                    //        pos += Vector3.left;
                    //    }

                    //}
                    //if (Input.GetAxis("Xbox P2 Press Down Dpad") == 1 && StopBot == false && A2 && DN_MainMenuMannager.Xbox)
                    //{
                    //    if (dir != DIRECTION.DOWN)
                    //    {
                    //        buttonCooldown = cooldownforbutton;
                    //        dir = DIRECTION.DOWN;
                    //    }
                    //    else
                    //    {
                    //        canMove = false;
                    //        moving = true;
                    //        pos += Vector3.back;
                    //    }
                    //}
                    //if (Input.GetAxis("Xbox P2 Press Right Dpad") == 1 && StopRight == false && A2 && DN_MainMenuMannager.Xbox)
                    //{
                    //    if (dir != DIRECTION.RIGHT)
                    //    {
                    //        buttonCooldown = cooldownforbutton;
                    //        dir = DIRECTION.RIGHT;
                    //    }
                    //    else
                    //    {

                    //        canMove = false;
                    //        moving = true;
                    //        pos += Vector3.right;

                    //    }
                    //}
                }
            }
        }
    }
    private void ThreePlayerMove1()
    {
        if (P1)
        {
            if (buttonCooldown <= 0)
            {
                //if (Input.GetAxis("P1 Press Left Arrow") == 1 && StopLeft == false && Square1)
                //{

                //    if (dir != DIRECTION.LEFT)
                //    {
                //        buttonCooldown = cooldownforbutton;
                //        dir = DIRECTION.LEFT;
                //    }
                //    else
                //    {
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.left;
                //    }

                //}
                if (Input.GetAxis("P1 Press Up Arrow") == 0 && Input.GetAxis("P1 Press Left Arrow") == 0 && Input.GetAxis("P3 Press Right Arrow") == 0 && Input.GetAxis("P2 Press Down Arrow") == 0 && O1 && DN_MainMenuMannager.Ps4)
                {
                    MechIdle.SetActive(true);
                    MechMoveRNL.SetActive(false);
                    MechMoveUND.SetActive(false);
                }
                if (Input.GetAxis("Xbox P1 Press Up Dpad") == 0 && Input.GetAxis("Xbox P3 Press Right Dpad") == 0 && Input.GetAxis("Xbox P1 Press Left Dpad") == 0 && Input.GetAxis("Xbox P2 Press Down Dpad") == 0 && B1 && DN_MainMenuMannager.Xbox)
                {
                    MechIdle.SetActive(true);
                    MechMoveRNL.SetActive(false);
                    MechMoveUND.SetActive(false);
                }

                if (Input.GetAxis("P1 Press Up Arrow") == 1 && StopTop == false && O1 /*&& Square1 &&*/ && DN_MainMenuMannager.Ps4)
                {
                    if (dir != DIRECTION.UP)
                    {
                        dir = DIRECTION.UP;
                        buttonCooldown = cooldownforbutton;
                        MechIdle.SetActive(false);
                        MechMoveRNL.SetActive(false);
                        MechMoveUND.SetActive(true);
                    }
                    else
                    {
                      
                        canMove = false;
                        moving = true;
                        pos += Vector3.forward;
                    }
                }
              
                if (Input.GetAxis("Xbox P1 Press Up Dpad") == 1 && B1 && StopTop == false && DN_MainMenuMannager.Xbox)
                {
                    if (dir != DIRECTION.UP)
                    {
                        dir = DIRECTION.UP;
                        buttonCooldown = cooldownforbutton;
                    }
                    else
                    {
                        MechIdle.SetActive(false);
                        MechMoveRNL.SetActive(false);
                        MechMoveUND.SetActive(true);
                        canMove = false;
                        moving = true;
                        pos += Vector3.forward;
                    }
                }
                //else if (Input.GetAxis("P2 Press Down Arrow") == 1 && StopBot == false && Square2)
                //{

                //    if (dir != DIRECTION.DOWN)
                //    {
                //        buttonCooldown = cooldownforbutton;
                //        dir = DIRECTION.DOWN;
                //    }
                //    else
                //    {
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.back;
                //    }
                //}
                //if (Input.GetAxis("P3 Press Right Arrow") == 1 && StopRight == false && Square3)
                //{

                //    if (dir != DIRECTION.RIGHT)
                //    {
                //        buttonCooldown = cooldownforbutton;
                //        dir = DIRECTION.RIGHT;
                //    }
                //    else
                //    {

                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.right;

                //    }
                //}
                //if (Input.GetAxis("Xbox P1 Press Up Dpad") == 1 && StopTop == false && XB1 && DN_MainMenuMannager.Xbox)
                //{
                //    if (dir != DIRECTION.UP)
                //    {
                //        dir = DIRECTION.UP;
                //        buttonCooldown = cooldownforbutton;
                //    }
                //    else
                //    {
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.forward;
                //    }
                //}
                //if (Input.GetAxis("Xbox P1 Press Left Dpad") == 1 && StopLeft == false && XB1 && DN_MainMenuMannager.Xbox)
                //{
                //    if (dir != DIRECTION.LEFT)
                //    {
                //        buttonCooldown = cooldownforbutton;
                //        dir = DIRECTION.LEFT;
                //    }
                //    else
                //    {
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.left;
                //    }

                //}
                //if (Input.GetAxis("Xbox P2 Press Down Dpad") == 1 && StopBot == false && XB2 && DN_MainMenuMannager.Xbox)
                //{
                //    if (dir != DIRECTION.DOWN)
                //    {
                //        buttonCooldown = cooldownforbutton;
                //        dir = DIRECTION.DOWN;
                //    }
                //    else
                //    {
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.back;
                //    }
                //}
                //if (Input.GetAxis("Xbox P3 Press Right Dpad") == 1 && StopRight == false && XB3 && DN_MainMenuMannager.Xbox)
                //{
                //    if (dir != DIRECTION.RIGHT)
                //    {
                //        buttonCooldown = cooldownforbutton;
                //        dir = DIRECTION.RIGHT;
                //    }
                //    else
                //    {

                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.right;

                //    }
                //}
            }
        }
    }
    private void ThreePlayerMove2()
    {
        if (P2 )
        {
            if (buttonCooldown <= 0)
            {
                //if (Input.GetAxis("P1 Press Left Arrow") == 1 && StopLeft == false && O1)
                //{

                //    if (dir != DIRECTION.LEFT)
                //    {
                //        buttonCooldown = cooldownforbutton;
                //        dir = DIRECTION.LEFT;
                //    }
                //    else
                //    {
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.left;
                //    }

                //}
                //else if (Input.GetAxis("P1 Press Up Arrow") == 1 && StopTop == false && O1)
                //{
                //    if (dir != DIRECTION.UP)
                //    {
                //        dir = DIRECTION.UP;
                //        buttonCooldown = cooldownforbutton;
                //    }
                //    else
                //    {
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.forward;
                //    }
                //}
                //else if (Input.GetAxis("P2 Press Down Arrow") == 1 && StopBot == false && O2)
                //{

                //    if (dir != DIRECTION.DOWN)
                //    {
                //        buttonCooldown = cooldownforbutton;
                //        dir = DIRECTION.DOWN;
                //    }
                //    else
                //    {
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.back;
                //    }
                //}
                if (Input.GetAxis("P1 Press Up Arrow") == 0 && Input.GetAxis("P1 Press Left Arrow") == 0 && Input.GetAxis("P3 Press Right Arrow") == 0 && Input.GetAxis("P2 Press Down Arrow") == 0 && Square3 && DN_MainMenuMannager.Ps4)
                {
                    MechIdle.SetActive(true);
                    MechMoveRNL.SetActive(false);
                    MechMoveUND.SetActive(false);
                }
                if (Input.GetAxis("Xbox P1 Press Up Dpad") == 0 && Input.GetAxis("Xbox P3 Press Right Dpad") == 0 && Input.GetAxis("Xbox P1 Press Left Dpad") == 0 && Input.GetAxis("Xbox P2 Press Down Dpad") == 0 && XB3 && DN_MainMenuMannager.Xbox)
                {
                    MechIdle.SetActive(true);
                    MechMoveRNL.SetActive(false);
                    MechMoveUND.SetActive(false);
                }
                if (Input.GetAxis("P3 Press Right Arrow") == 1 && StopRight == false && Square3 /*&& O3*/ && DN_MainMenuMannager.Ps4)
                {

                    if (dir != DIRECTION.RIGHT)
                    {
                        buttonCooldown = cooldownforbutton;
                        dir = DIRECTION.RIGHT;
                        MechIdle.SetActive(false);
                        MechMoveRNL.SetActive(true);
                        MechMoveUND.SetActive(false);
                    }
                    else
                    {
                       
                        canMove = false;
                        moving = true;
                        pos += Vector3.right;

                    }
                }
               
                if (Input.GetAxis("Xbox P3 Press Right Dpad") == 1 && XB3 && StopRight == false && DN_MainMenuMannager.Xbox)
                {
                    if (dir != DIRECTION.RIGHT)
                    {
                        dir = DIRECTION.RIGHT;
                        buttonCooldown = cooldownforbutton;
                    }
                    else
                    {
                        MechIdle.SetActive(false);
                        MechMoveRNL.SetActive(true);
                        MechMoveUND.SetActive(false);
                        canMove = false;
                        moving = true;
                        pos += Vector3.right;
                    }
                }
                //if (Input.GetAxis("Xbox P1 Press Up Dpad") == 1 && StopTop == false && B1 && DN_MainMenuMannager.Xbox)
                //{
                //    if (dir != DIRECTION.UP)
                //    {
                //        dir = DIRECTION.UP;
                //        buttonCooldown = cooldownforbutton;
                //    }
                //    else
                //    {
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.forward;
                //    }
                //}
                //if (Input.GetAxis("Xbox P1 Press Left Dpad") == 1 && StopLeft == false && B1 && DN_MainMenuMannager.Xbox)
                //{
                //    if (dir != DIRECTION.LEFT)
                //    {
                //        buttonCooldown = cooldownforbutton;
                //        dir = DIRECTION.LEFT;
                //    }
                //    else
                //    {
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.left;
                //    }

                //}
                //if (Input.GetAxis("Xbox P2 Press Down Dpad") == 1 && StopBot == false && B2 && DN_MainMenuMannager.Xbox)
                //{
                //    if (dir != DIRECTION.DOWN)
                //    {
                //        buttonCooldown = cooldownforbutton;
                //        dir = DIRECTION.DOWN;
                //    }
                //    else
                //    {
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.back;
                //    }
                //}
                //if (Input.GetAxis("Xbox P3 Press Right Dpad") == 1 && StopRight == false && B3 && DN_MainMenuMannager.Xbox)
                //{
                //    if (dir != DIRECTION.RIGHT)
                //    {
                //        buttonCooldown = cooldownforbutton;
                //        dir = DIRECTION.RIGHT;
                //    }
                //    else
                //    {

                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.right;

                //    }
                //}
            }
        }
    }
    private void ThreePlayerMove3()
    {
        if (P3)
        {
            if (buttonCooldown <= 0)
            {
                if (Input.GetAxis("P1 Press Up Arrow") == 0 && Input.GetAxis("P1 Press Left Arrow") == 0 && Input.GetAxis("P3 Press Right Arrow") == 0 && Input.GetAxis("P2 Press Down Arrow") == 0 && X1 && DN_MainMenuMannager.Ps4)
                {
                    MechIdle.SetActive(true);
                    MechMoveRNL.SetActive(false);
                    MechMoveUND.SetActive(false);
                }
                if (Input.GetAxis("Xbox P1 Press Up Dpad") == 0 && Input.GetAxis("Xbox P3 Press Right Dpad") == 0 && Input.GetAxis("Xbox P1 Press Left Dpad") == 0 && Input.GetAxis("Xbox P2 Press Down Dpad") == 0 && A1 && DN_MainMenuMannager.Xbox)
                {
                    MechIdle.SetActive(true);
                    MechMoveRNL.SetActive(false);
                    MechMoveUND.SetActive(false);
                }
                if (Input.GetAxis("P1 Press Left Arrow") == 1 && StopLeft == false && X1 /*&& Triangle1*/ && DN_MainMenuMannager.Ps4)
                {

                    if (dir != DIRECTION.LEFT)
                    {
                        buttonCooldown = cooldownforbutton;
                        dir = DIRECTION.LEFT;
                        MechIdle.SetActive(false);
                        MechMoveRNL.SetActive(true);
                        MechMoveUND.SetActive(false);
                    }
                    else
                    {
                      
                        canMove = false;
                        moving = true;
                        pos += Vector3.left;
                    }

                }
                
                if (Input.GetAxis("Xbox P1 Press Left Dpad") == 1 && A1 && StopLeft == false && DN_MainMenuMannager.Xbox)
                {
                    if (dir != DIRECTION.LEFT)
                    {
                        dir = DIRECTION.LEFT;
                        buttonCooldown = cooldownforbutton;
                    }
                    else
                    {
                        MechIdle.SetActive(false);
                        MechMoveRNL.SetActive(true);
                        MechMoveUND.SetActive(false);
                        canMove = false;
                        moving = true;
                        pos += Vector3.left;
                    }
                }
                //else if (Input.GetAxis("P1 Press Up Arrow") == 1 && StopTop == false && Triangle1)
                //{
                //    if (dir != DIRECTION.UP)
                //    {
                //        dir = DIRECTION.UP;
                //        buttonCooldown = cooldownforbutton;
                //    }
                //    else
                //    {
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.forward;
                //    }
                //}
                //else if (Input.GetAxis("P2 Press Down Arrow") == 1 && StopBot == false && Triangle2)
                //{

                //    if (dir != DIRECTION.DOWN)
                //    {
                //        buttonCooldown = cooldownforbutton;
                //        dir = DIRECTION.DOWN;
                //    }
                //    else
                //    {
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.back;
                //    }
                //}
                //else if (Input.GetAxis("P3 Press Right Arrow") == 1 && StopRight == false && Triangle3)
                //{

                //    if (dir != DIRECTION.RIGHT)
                //    {
                //        buttonCooldown = cooldownforbutton;
                //        dir = DIRECTION.RIGHT;
                //    }
                //    else
                //    {

                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.right;

                //    }
                //}
                //if (Input.GetAxis("Xbox P1 Press Up Dpad") == 1 && StopTop == false && Y1 && DN_MainMenuMannager.Xbox)
                //{
                //    if (dir != DIRECTION.UP)
                //    {
                //        dir = DIRECTION.UP;
                //        buttonCooldown = cooldownforbutton;
                //    }
                //    else
                //    {
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.forward;
                //    }
                //}
                //if (Input.GetAxis("Xbox P1 Press Left Dpad") == 1 && StopLeft == false && Y1 && DN_MainMenuMannager.Xbox)
                //{
                //    if (dir != DIRECTION.LEFT)
                //    {
                //        buttonCooldown = cooldownforbutton;
                //        dir = DIRECTION.LEFT;
                //    }
                //    else
                //    {
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.left;
                //    }

                //}
                //if (Input.GetAxis("Xbox P2 Press Down Dpad") == 1 && StopBot == false && Y2 && DN_MainMenuMannager.Xbox)
                //{
                //    if (dir != DIRECTION.DOWN)
                //    {
                //        buttonCooldown = cooldownforbutton;
                //        dir = DIRECTION.DOWN;
                //    }
                //    else
                //    {
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.back;
                //    }
                //}
                //if (Input.GetAxis("Xbox P3 Press Right Dpad") == 1 && StopRight == false && Y3 && DN_MainMenuMannager.Xbox)
                //{
                //    if (dir != DIRECTION.RIGHT)
                //    {
                //        buttonCooldown = cooldownforbutton;
                //        dir = DIRECTION.RIGHT;
                //    }
                //    else
                //    {

                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.right;

                //    }
                //}
            }
        }
    }
    private void ThreePlayerMove4()
    {
        if (P4 )
        {
            if (buttonCooldown <= 0)
            {
                //if (Input.GetAxis("P1 Press Left Arrow") == 1 && StopLeft == false && X1)
                //{

                //    if (dir != DIRECTION.LEFT)
                //    {
                //        buttonCooldown = cooldownforbutton;
                //        dir = DIRECTION.LEFT;
                //    }
                //    else
                //    {
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.left;
                //    }

                //}
                //else if (Input.GetAxis("P1 Press Up Arrow") == 1 && StopTop == false && X1)
                //{
                //    if (dir != DIRECTION.UP)
                //    {
                //        dir = DIRECTION.UP;
                //        buttonCooldown = cooldownforbutton;
                //    }
                //    else
                //    {
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.forward;
                //    }
                //}
                if (Input.GetAxis("P1 Press Up Arrow") == 0 && Input.GetAxis("P1 Press Left Arrow") == 0 && Input.GetAxis("P3 Press Right Arrow") == 0 && Input.GetAxis("P2 Press Down Arrow") == 0 && Triangle2 && DN_MainMenuMannager.Ps4)
                {
                    MechIdle.SetActive(true);
                    MechMoveRNL.SetActive(false);
                    MechMoveUND.SetActive(false);
                }
                if (Input.GetAxis("Xbox P1 Press Up Dpad") == 0 && Input.GetAxis("Xbox P3 Press Right Dpad") == 0 && Input.GetAxis("Xbox P1 Press Left Dpad") == 0 && Input.GetAxis("Xbox P2 Press Down Dpad") == 0 && Y2 && DN_MainMenuMannager.Xbox)
                {
                    MechIdle.SetActive(true);
                    MechMoveRNL.SetActive(false);
                    MechMoveUND.SetActive(false);
                }
                if (Input.GetAxis("P2 Press Down Arrow") == 1 && StopBot == false && Triangle2  /*&& X2*/ && DN_MainMenuMannager.Ps4)
                {

                    if (dir != DIRECTION.DOWN)
                    {
                        buttonCooldown = cooldownforbutton;
                        dir = DIRECTION.DOWN;
                        MechIdle.SetActive(false);
                        MechMoveRNL.SetActive(false);
                        MechMoveUND.SetActive(true);
                    }
                    else
                    {
                      
                        canMove = false;
                        moving = true;
                        pos += Vector3.back;
                    }
                }
              
                if (Input.GetAxis("Xbox P2 Press Down Dpad") == 1 && Y2 && StopBot == false && DN_MainMenuMannager.Xbox)
                {
                    if (dir != DIRECTION.DOWN)
                    {
                        dir = DIRECTION.DOWN;
                        buttonCooldown = cooldownforbutton;
                    }
                    else
                    {
                        MechIdle.SetActive(false);
                        MechMoveRNL.SetActive(false);
                        MechMoveUND.SetActive(true);
                        canMove = false;
                        moving = true;
                        pos += Vector3.back;
                    }
                }
                //else if (Input.GetAxis("P3 Press Right Arrow") == 1 && StopRight == false && X3)
                //{

                //    if (dir != DIRECTION.RIGHT)
                //    {
                //        buttonCooldown = cooldownforbutton;
                //        dir = DIRECTION.RIGHT;
                //    }
                //    else
                //    {

                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.right;

                //    }
                //}
                //if (Input.GetAxis("Xbox P1 Press Up Dpad") == 1 && StopTop == false && A1 && DN_MainMenuMannager.Xbox)
                //{
                //    if (dir != DIRECTION.UP)
                //    {
                //        dir = DIRECTION.UP;
                //        buttonCooldown = cooldownforbutton;
                //    }
                //    else
                //    {
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.forward;
                //    }
                //}
                //if (Input.GetAxis("Xbox P1 Press Left Dpad") == 1 && StopLeft == false && A1 && DN_MainMenuMannager.Xbox)
                //{
                //    if (dir != DIRECTION.LEFT)
                //    {
                //        buttonCooldown = cooldownforbutton;
                //        dir = DIRECTION.LEFT;
                //    }
                //    else
                //    {
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.left;
                //    }

                //}
                //if (Input.GetAxis("Xbox P2 Press Down Dpad") == 1 && StopBot == false && A2 && DN_MainMenuMannager.Xbox)
                //{
                //    if (dir != DIRECTION.DOWN)
                //    {
                //        buttonCooldown = cooldownforbutton;
                //        dir = DIRECTION.DOWN;
                //    }
                //    else
                //    {
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.back;
                //    }
                //}
                //if (Input.GetAxis("Xbox P3 Press Right Dpad") == 1 && StopRight == false && A3 && DN_MainMenuMannager.Xbox)
                //{
                //    if (dir != DIRECTION.RIGHT)
                //    {
                //        buttonCooldown = cooldownforbutton;
                //        dir = DIRECTION.RIGHT;
                //    }
                //    else
                //    {

                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.right;

                //    }
                //}
            }
        }
    }
    private void FourPlayerMove1()
    {
        if (P1)
        {
            if (buttonCooldown <= 0)
            {
                if (Input.GetAxis("P1 Press Up Arrow") == 0 && Input.GetAxis("P3 Press Right Arrow") == 0 && Input.GetAxis("P4 Press Left Arrow") == 0 && Input.GetAxis("P2 Press Down Arrow") == 0 && O1 && DN_MainMenuMannager.Ps4)
                {
                    MechIdle.SetActive(true);
                    MechMoveRNL.SetActive(false);
                    MechMoveUND.SetActive(false);
                }
                if (Input.GetAxis("Xbox P1 Press Up Dpad") == 0 && Input.GetAxis("Xbox P3 Press Right Dpad") == 0 && Input.GetAxis("Xbox P4 Press Left Dpad") == 0 && Input.GetAxis("Xbox P2 Press Down Dpad") == 0 && B1 && DN_MainMenuMannager.Xbox)
                {
                    MechIdle.SetActive(true);
                    MechMoveRNL.SetActive(false);
                    MechMoveUND.SetActive(false);
                }
                if (Input.GetAxis("P1 Press Up Arrow") == 1 && StopTop == false && O1/*&& Square1*/ && DN_MainMenuMannager.Ps4)
                {
                    if (dir != DIRECTION.UP)
                    {
                        dir = DIRECTION.UP;
                        buttonCooldown = cooldownforbutton;
                        MechIdle.SetActive(false);
                        MechMoveRNL.SetActive(false);
                        MechMoveUND.SetActive(true);
                    }
                    else
                    {
                        
                        canMove = false;
                        moving = true;
                        pos += Vector3.forward;
                    }

                }
                
                if (Input.GetAxis("Xbox P1 Press Up Dpad") == 1 && B1 && StopTop == false && DN_MainMenuMannager.Xbox)
                {
                    if (dir != DIRECTION.UP)
                    {
                        dir = DIRECTION.UP;
                        buttonCooldown = cooldownforbutton;
                    }
                    else
                    {
                        MechIdle.SetActive(false);
                        MechMoveRNL.SetActive(false);
                        MechMoveUND.SetActive(true);
                        canMove = false;
                        moving = true;
                        pos += Vector3.forward;
                    }
                }
                //else if (Input.GetAxis("P2 Press Down Arrow") == 1 && StopBot == false && Square2)
                //{

                //    if (dir != DIRECTION.DOWN)
                //    {
                //        buttonCooldown = cooldownforbutton;
                //        dir = DIRECTION.DOWN;
                //    }
                //    else
                //    {
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.back;
                //    }
                //}
                //else if (Input.GetAxis("P4 Press Left Arrow") == 1 && StopLeft == false && Square4)
                //{

                //    if (dir != DIRECTION.LEFT)
                //    {
                //        buttonCooldown = cooldownforbutton;
                //        dir = DIRECTION.LEFT;
                //    }
                //    else
                //    {
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.left;
                //    }

                //}
                //else if (Input.GetAxis("P3 Press Right Arrow") == 1 && StopRight == false && Square3)
                //{

                //    if (dir != DIRECTION.RIGHT)
                //    {
                //        buttonCooldown = cooldownforbutton;
                //        dir = DIRECTION.RIGHT;
                //    }
                //    else
                //    {

                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.right;

                //    }
                //}
                //if (Input.GetAxis("Xbox P1 Press Up Dpad") == 1 && StopTop == false && XB1 && DN_MainMenuMannager.Xbox)
                //{
                //    if (dir != DIRECTION.UP)
                //    {
                //        dir = DIRECTION.UP;
                //        buttonCooldown = cooldownforbutton;
                //    }
                //    else
                //    {
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.forward;
                //    }
                //}

                //if (Input.GetAxis("Xbox P2 Press Down Dpad") == 1 && StopBot == false && XB2 && DN_MainMenuMannager.Xbox)
                //{
                //    if (dir != DIRECTION.DOWN)
                //    {
                //        buttonCooldown = cooldownforbutton;
                //        dir = DIRECTION.DOWN;
                //    }
                //    else
                //    {
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.back;
                //    }
                //}
                //if (Input.GetAxis("Xbox P3 Press Right Dpad") == 1 && StopRight == false && XB3 && DN_MainMenuMannager.Xbox)
                //{
                //    if (dir != DIRECTION.RIGHT)
                //    {
                //        buttonCooldown = cooldownforbutton;
                //        dir = DIRECTION.RIGHT;
                //    }
                //    else
                //    {

                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.right;

                //    }
                //}
                //if (Input.GetAxis("Xbox P4 Press Left Dpad") == 1 && StopLeft == false && XB4 && DN_MainMenuMannager.Xbox)
                //{
                //    if (dir != DIRECTION.LEFT)
                //    {
                //        buttonCooldown = cooldownforbutton;
                //        dir = DIRECTION.LEFT;
                //    }
                //    else
                //    {
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.left;
                //    }

                //}

            }
        }
    }
    private void FourPlayerMove2()
    {
        if (P2)
        {
            if (buttonCooldown <= 0)
            {
                //if (Input.GetAxis("P1 Press Up Arrow") == 1 && StopTop == false && O1)
                //{
                //    if (dir != DIRECTION.UP)
                //    {
                //        dir = DIRECTION.UP;
                //        buttonCooldown = cooldownforbutton;
                //    }
                //    else
                //    {
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.forward;
                //    }

                //}
                //else if (Input.GetAxis("P2 Press Down Arrow") == 1 && StopBot == false && O2)
                //{

                //    if (dir != DIRECTION.DOWN)
                //    {
                //        buttonCooldown = cooldownforbutton;
                //        dir = DIRECTION.DOWN;
                //    }
                //    else
                //    {
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.back;
                //    }

                //}
                //else if (Input.GetAxis("P4 Press Left Arrow") == 1 && StopLeft == false && O4)
                //{

                //    if (dir != DIRECTION.LEFT)
                //    {
                //        buttonCooldown = cooldownforbutton;
                //        dir = DIRECTION.LEFT;
                //    }
                //    else
                //    {
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.left;
                //    }

                //}
                if (Input.GetAxis("P1 Press Up Arrow") == 0 && Input.GetAxis("P3 Press Right Arrow") == 0 && Input.GetAxis("P4 Press Left Arrow") == 0 && Input.GetAxis("P2 Press Down Arrow") == 0 && Square3 && DN_MainMenuMannager.Ps4)
                {
                    MechIdle.SetActive(true);
                    MechMoveRNL.SetActive(false);
                    MechMoveUND.SetActive(false);
                }
                if (Input.GetAxis("Xbox P1 Press Up Dpad") == 0 && Input.GetAxis("Xbox P3 Press Right Dpad") == 0 && Input.GetAxis("Xbox P4 Press Left Dpad") == 0 && Input.GetAxis("Xbox P2 Press Down Dpad") == 0 && XB3 && DN_MainMenuMannager.Xbox)
                {
                    MechIdle.SetActive(true);
                    MechMoveRNL.SetActive(false);
                    MechMoveUND.SetActive(false);
                }
                if (Input.GetAxis("P3 Press Right Arrow") == 1 && StopRight == false && Square3 && /*&& O3*/ DN_MainMenuMannager.Ps4)
                {

                    if (dir != DIRECTION.RIGHT)
                    {
                        buttonCooldown = cooldownforbutton;
                        dir = DIRECTION.RIGHT;
                        MechIdle.SetActive(false);
                        MechMoveRNL.SetActive(true);
                        MechMoveUND.SetActive(false);
                    }
                    else
                    {
                       
                        canMove = false;
                        moving = true;
                        pos += Vector3.right;

                    }
                }
               
                if (Input.GetAxis("Xbox P3 Press Right Dpad") == 1 && XB3 && StopRight == false && DN_MainMenuMannager.Xbox)
                {
                    if (dir != DIRECTION.RIGHT)
                    {
                        dir = DIRECTION.RIGHT;
                        buttonCooldown = cooldownforbutton;
                    }
                    else
                    {
                        MechIdle.SetActive(false);
                        MechMoveRNL.SetActive(true);
                        MechMoveUND.SetActive(false);
                        canMove = false;
                        moving = true;
                        pos += Vector3.right;
                    }
                }
                //if (Input.GetAxis("Xbox P1 Press Up Dpad") == 1 && StopTop == false && B1 && DN_MainMenuMannager.Xbox)
                //{
                //    if (dir != DIRECTION.UP)
                //    {
                //        dir = DIRECTION.UP;
                //        buttonCooldown = cooldownforbutton;
                //    }
                //    else
                //    {
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.forward;
                //    }
                //}

                //if (Input.GetAxis("Xbox P2 Press Down Dpad") == 1 && StopBot == false && B2 && DN_MainMenuMannager.Xbox)
                //{
                //    if (dir != DIRECTION.DOWN)
                //    {
                //        buttonCooldown = cooldownforbutton;
                //        dir = DIRECTION.DOWN;
                //    }
                //    else
                //    {
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.back;
                //    }
                //}
                //if (Input.GetAxis("Xbox P3 Press Right Dpad") == 1 && StopRight == false && B3 && DN_MainMenuMannager.Xbox)
                //{
                //    if (dir != DIRECTION.RIGHT)
                //    {
                //        buttonCooldown = cooldownforbutton;
                //        dir = DIRECTION.RIGHT;
                //    }
                //    else
                //    {

                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.right;

                //    }
                //}
                //if (Input.GetAxis("Xbox P4 Press Left Dpad") == 1 && StopLeft == false && B4 && DN_MainMenuMannager.Xbox)
                //{
                //    if (dir != DIRECTION.LEFT)
                //    {
                //        buttonCooldown = cooldownforbutton;
                //        dir = DIRECTION.LEFT;
                //    }
                //    else
                //    {
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.left;
                //    }

                //}
            }
        }
    }
    private void FourPlayerMove3()
    {
        if (P3)
        {
            if (buttonCooldown <= 0)
            {
                //if (Input.GetAxis("P1 Press Up Arrow") == 1 && StopTop == false && Triangle1)
                //{
                //    if (dir != DIRECTION.UP)
                //    {
                //        dir = DIRECTION.UP;
                //        buttonCooldown = cooldownforbutton;
                //    }
                //    else
                //    {
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.forward;
                //    }

                //}
                //else if (Input.GetAxis("P2 Press Down Arrow") == 1 && StopBot == false && Triangle2)
                //{

                //    if (dir != DIRECTION.DOWN)
                //    {
                //        buttonCooldown = cooldownforbutton;
                //        dir = DIRECTION.DOWN;
                //    }
                //    else
                //    {
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.back;
                //    }

                //}
                if (Input.GetAxis("P1 Press Up Arrow") == 0 && Input.GetAxis("P3 Press Right Arrow") == 0 && Input.GetAxis("P4 Press Left Arrow") == 0 && Input.GetAxis("P2 Press Down Arrow") == 0 && X4 && DN_MainMenuMannager.Ps4)
                {
                    MechIdle.SetActive(true);
                    MechMoveRNL.SetActive(false);
                    MechMoveUND.SetActive(false);
                }
                if (Input.GetAxis("Xbox P1 Press Up Dpad") == 0 && Input.GetAxis("Xbox P3 Press Right Dpad") == 0 && Input.GetAxis("Xbox P4 Press Left Dpad") == 0 && Input.GetAxis("Xbox P2 Press Down Dpad") == 0 && A4 && DN_MainMenuMannager.Xbox)
                {
                    MechIdle.SetActive(true);
                    MechMoveRNL.SetActive(false);
                    MechMoveUND.SetActive(false);
                }
                if (Input.GetAxis("P4 Press Left Arrow") == 1 && StopLeft == false && X4 /*&& Triangle4*/ && DN_MainMenuMannager.Ps4)
                {

                    if (dir != DIRECTION.LEFT)
                    {
                        buttonCooldown = cooldownforbutton;
                        dir = DIRECTION.LEFT;
                        MechIdle.SetActive(false);
                        MechMoveRNL.SetActive(true);
                        MechMoveUND.SetActive(false);
                    }
                    else
                    {
                       
                        canMove = false;
                        moving = true;
                        pos += Vector3.left;
                    }

                }
               
                if (Input.GetAxis("Xbox P4 Press Left Dpad") == 1 && A4 && StopLeft == false && DN_MainMenuMannager.Xbox)
                {
                    if (dir != DIRECTION.LEFT)
                    {
                        dir = DIRECTION.LEFT;
                        buttonCooldown = cooldownforbutton;
                    }
                    else
                    {
                        MechIdle.SetActive(false);
                        MechMoveRNL.SetActive(true);
                        MechMoveUND.SetActive(false);
                        canMove = false;
                        moving = true;
                        pos += Vector3.left;
                    }
                }
                //else if (Input.GetAxis("P3 Press Right Arrow") == 1 && StopRight == false && Triangle3)
                //{

                //    if (dir != DIRECTION.RIGHT)
                //    {
                //        buttonCooldown = cooldownforbutton;
                //        dir = DIRECTION.RIGHT;
                //    }
                //    else
                //    {

                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.right;

                //    }
                //}
                //if (Input.GetAxis("Xbox P1 Press Up Dpad") == 1 && StopTop == false && Y1 && DN_MainMenuMannager.Xbox)
                //{
                //    if (dir != DIRECTION.UP)
                //    {
                //        dir = DIRECTION.UP;
                //        buttonCooldown = cooldownforbutton;
                //    }
                //    else
                //    {
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.forward;
                //    }
                //}

                //if (Input.GetAxis("Xbox P2 Press Down Dpad") == 1 && StopBot == false && Y2 && DN_MainMenuMannager.Xbox)
                //{
                //    if (dir != DIRECTION.DOWN)
                //    {
                //        buttonCooldown = cooldownforbutton;
                //        dir = DIRECTION.DOWN;
                //    }
                //    else
                //    {
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.back;
                //    }
                //}
                //if (Input.GetAxis("Xbox P3 Press Right Dpad") == 1 && StopRight == false && Y3 && DN_MainMenuMannager.Xbox)
                //{
                //    if (dir != DIRECTION.RIGHT)
                //    {
                //        buttonCooldown = cooldownforbutton;
                //        dir = DIRECTION.RIGHT;
                //    }
                //    else
                //    {

                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.right;

                //    }
                //}
                //if (Input.GetAxis("Xbox P4 Press Left Dpad") == 1 && StopLeft == false && Y4 && DN_MainMenuMannager.Xbox)
                //{
                //    if (dir != DIRECTION.LEFT)
                //    {
                //        buttonCooldown = cooldownforbutton;
                //        dir = DIRECTION.LEFT;
                //    }
                //    else
                //    {
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.left;
                //    }

                //}
            }
        }
    }
    private void FourPlayerMove4()
    {
        if (P4 )
        {
            if (buttonCooldown <= 0)
            {
                //if (Input.GetAxis("P1 Press Up Arrow") == 1 && StopTop == false && X1)
                //{
                //    if (dir != DIRECTION.UP)
                //    {
                //        dir = DIRECTION.UP;
                //        buttonCooldown = cooldownforbutton;
                //    }
                //    else
                //    {
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.forward;
                //    }

                //}
                if (Input.GetAxis("P1 Press Up Arrow") == 0 && Input.GetAxis("P3 Press Right Arrow") == 0 && Input.GetAxis("P4 Press Left Arrow") == 0 && Input.GetAxis("P2 Press Down Arrow") == 0 && Triangle2 && DN_MainMenuMannager.Ps4)
                {
                    MechIdle.SetActive(true);
                    MechMoveRNL.SetActive(false);
                    MechMoveUND.SetActive(false);
                }
                if (Input.GetAxis("Xbox P1 Press Up Dpad") == 0 && Input.GetAxis("Xbox P3 Press Right Dpad") == 0 && Input.GetAxis("Xbox P4 Press Left Dpad") == 0 && Input.GetAxis("Xbox P2 Press Down Dpad") == 0 && Y2 && DN_MainMenuMannager.Xbox)
                {
                    MechIdle.SetActive(true);
                    MechMoveRNL.SetActive(false);
                    MechMoveUND.SetActive(false);
                }
                if (Input.GetAxis("P2 Press Down Arrow") == 1 && StopBot == false && Triangle2 /*&& X2*/ && DN_MainMenuMannager.Ps4)
                {

                    if (dir != DIRECTION.DOWN)
                    {
                        MechIdle.SetActive(false);
                        MechMoveRNL.SetActive(false);
                        MechMoveUND.SetActive(true);
                        buttonCooldown = cooldownforbutton;
                        dir = DIRECTION.DOWN;
                    }
                    else
                    {
                       
                        canMove = false;
                        moving = true;
                        pos += Vector3.back;
                    }

                }
    
                if (Input.GetAxis("Xbox P2 Press Down Dpad") == 1 && Y2 && StopBot == false && DN_MainMenuMannager.Xbox)
                {
                    if (dir != DIRECTION.DOWN)
                    {
                        dir = DIRECTION.DOWN;
                        buttonCooldown = cooldownforbutton;
                    }
                    else
                    {
                        MechIdle.SetActive(false);
                        MechMoveRNL.SetActive(false);
                        MechMoveUND.SetActive(true);
                        canMove = false;
                        moving = true;
                        pos += Vector3.back;
                    }
                }
                //else if (Input.GetAxis("P4 Press Left Arrow") == 1 && StopLeft == false && X4)
                //{

                //    if (dir != DIRECTION.LEFT)
                //    {
                //        buttonCooldown = cooldownforbutton;
                //        dir = DIRECTION.LEFT;
                //    }
                //    else
                //    {
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.left;
                //    }

                //}
                //else if (Input.GetAxis("P3 Press Right Arrow") == 1 && StopRight == false && X3)
                //{

                //    if (dir != DIRECTION.RIGHT)
                //    {
                //        buttonCooldown = cooldownforbutton;
                //        dir = DIRECTION.RIGHT;
                //    }
                //    else
                //    {

                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.right;

                //    }
                //}
                //if (Input.GetAxis("Xbox P1 Press Up Dpad") == 1 && StopTop == false && A1 && DN_MainMenuMannager.Xbox)
                //{
                //    if (dir != DIRECTION.UP)
                //    {
                //        dir = DIRECTION.UP;
                //        buttonCooldown = cooldownforbutton;
                //    }
                //    else
                //    {
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.forward;
                //    }
                //}

                //if (Input.GetAxis("Xbox P2 Press Down Dpad") == 1 && StopBot == false && A2 && DN_MainMenuMannager.Xbox)
                //{
                //    if (dir != DIRECTION.DOWN)
                //    {
                //        buttonCooldown = cooldownforbutton;
                //        dir = DIRECTION.DOWN;
                //    }
                //    else
                //    {
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.back;
                //    }
                //}
                //if (Input.GetAxis("Xbox P3 Press Right Dpad") == 1 && StopRight == false && A3 && DN_MainMenuMannager.Xbox)
                //{
                //    if (dir != DIRECTION.RIGHT)
                //    {
                //        buttonCooldown = cooldownforbutton;
                //        dir = DIRECTION.RIGHT;
                //    }
                //    else
                //    {

                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.right;

                //    }
                //}
                //if (Input.GetAxis("Xbox P4 Press Left Dpad") == 1 && StopLeft == false && A4 && DN_MainMenuMannager.Xbox)
                //{
                //    if (dir != DIRECTION.LEFT)
                //    {
                //        buttonCooldown = cooldownforbutton;
                //        dir = DIRECTION.LEFT;
                //    }
                //    else
                //    {
                //        canMove = false;
                //        moving = true;
                //        pos += Vector3.left;
                //    }

                //}
            }
        }
    }
    //private void OnTriggerEnter(Collider other)
    //{
    //    //if (other.tag == "Fire")
    //    //{
    //    //    DN_GameManager.Death = true;
    //    //}
    //    //if (other.tag == "Guard1")
    //    //{
    //    //    DN_GameManager.Death = true;
    //    //}
    //    //if (other.tag == "Guard2")
    //    //{
    //    //    DN_GameManager.Death = true;
    //    //}
    //    //if (other.tag == "Guard3")
    //    //{
    //    //    DN_GameManager.Death = true;
    //    //}
    //    //if (other.tag == "Guard4")
    //    //{
    //    //    DN_GameManager.Death = true;
    //    //}
    //}
}
