using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DN_ButtonsIndicator : MonoBehaviour
{
    private Animator ThisAnimator;
    public bool Setting;
    public bool Keyboard;
    public bool OnePlayer;
    public bool TwoPlayer;
    public bool ThreePlayer;
    public bool FourPlayer;
    // Use this for initialization
    void Start()
    {
        ThisAnimator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
      
        if (Keyboard)
        {
            if (Input.GetKey(KeyCode.UpArrow) == false && Input.GetKey(KeyCode.DownArrow) == false && Input.GetKey(KeyCode.RightArrow) == false && Input.GetKey(KeyCode.LeftArrow) == false)
            {
                ThisAnimator.SetBool("KeyIdle", true);
                ThisAnimator.SetBool("KeyUp", false);
                ThisAnimator.SetBool("KeyDown", false);
                ThisAnimator.SetBool("KeyRight", false);
                ThisAnimator.SetBool("KeyLeft", false);
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                ThisAnimator.SetBool("KeyIdle", false);
                ThisAnimator.SetBool("KeyUp", true);
                ThisAnimator.SetBool("KeyDown", false);
                ThisAnimator.SetBool("KeyRight", false);
                ThisAnimator.SetBool("KeyLeft", false);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                ThisAnimator.SetBool("KeyIdle", false);
                ThisAnimator.SetBool("KeyUp", false);
                ThisAnimator.SetBool("KeyDown", true);
                ThisAnimator.SetBool("KeyRight", false);
                ThisAnimator.SetBool("KeyLeft", false);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                ThisAnimator.SetBool("KeyIdle", false);
                ThisAnimator.SetBool("KeyUp", false);
                ThisAnimator.SetBool("KeyDown", false);
                ThisAnimator.SetBool("KeyRight", true);
                ThisAnimator.SetBool("KeyLeft", false);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                ThisAnimator.SetBool("KeyIdle", false);
                ThisAnimator.SetBool("KeyUp", false);
                ThisAnimator.SetBool("KeyDown", false);
                ThisAnimator.SetBool("KeyRight", false);
                ThisAnimator.SetBool("KeyLeft", true);
            }
        }
        if (OnePlayer)
        {
            if (DN_MainMenuMannager.Ps4)
            {
                if (Input.GetAxis("Solo P1 Press Up Arrow") == 0 && Input.GetAxis("Solo P1 Press Down Arrow") == 0 && Input.GetAxis("Solo P1 Press Left Arrow") == 0 && Input.GetAxis("Solo P1 Press Right Arrow") == 0)
                {
                    ThisAnimator.SetBool("PadIdle", true);
                    ThisAnimator.SetBool("PadUp", false);
                    ThisAnimator.SetBool("PadDown", false);
                    ThisAnimator.SetBool("PadRight", false);
                    ThisAnimator.SetBool("PadLeft", false);

                }
                if (Input.GetAxis("Solo P1 Press Up Arrow") == 1)
                {
                    ThisAnimator.SetBool("PadIdle", false);
                    ThisAnimator.SetBool("PadUp", true);
                    ThisAnimator.SetBool("PadDown", false);
                    ThisAnimator.SetBool("PadRight", false);
                    ThisAnimator.SetBool("PadLeft", false);
                }
                if (Input.GetAxis("Solo P1 Press Down Arrow") == 1)
                {
                    ThisAnimator.SetBool("PadIdle", false);
                    ThisAnimator.SetBool("PadUp", false);
                    ThisAnimator.SetBool("PadDown", true);
                    ThisAnimator.SetBool("PadRight", false);
                    ThisAnimator.SetBool("PadLeft", false);
                }
                if (Input.GetAxis("Solo P1 Press Right Arrow") == 1)
                {
                    ThisAnimator.SetBool("PadIdle", false);
                    ThisAnimator.SetBool("PadUp", false);
                    ThisAnimator.SetBool("PadDown", false);
                    ThisAnimator.SetBool("PadRight", true);
                    ThisAnimator.SetBool("PadLeft", false);
                }
                if (Input.GetAxis("Solo P1 Press Left Arrow") == 1)
                {
                    ThisAnimator.SetBool("PadIdle", false);
                    ThisAnimator.SetBool("PadUp", false);
                    ThisAnimator.SetBool("PadDown", false);
                    ThisAnimator.SetBool("PadRight", false);
                    ThisAnimator.SetBool("PadLeft", true);
                }
            }
            if (DN_MainMenuMannager.Xbox)
            {
                if (Input.GetAxis("Xbox Solo P1 Press Up Dpad") == 0 && Input.GetAxis("Xbox Solo P1 Press Down Dpad") == 0 && Input.GetAxis("Xbox Solo P1 Press Right Dpad") == 0 && Input.GetAxis("Xbox Solo P1 Press Left Dpad") == 0)
                {
                    ThisAnimator.SetBool("PadIdle", true);
                    ThisAnimator.SetBool("PadUp", false);
                    ThisAnimator.SetBool("PadDown", false);
                    ThisAnimator.SetBool("PadRight", false);
                    ThisAnimator.SetBool("PadLeft", false);
                }
                if (Input.GetAxis("Xbox Solo P1 Press Up Dpad") == 1)
                {
                    ThisAnimator.SetBool("PadIdle", false);
                    ThisAnimator.SetBool("PadUp", true);
                    ThisAnimator.SetBool("PadDown", false);
                    ThisAnimator.SetBool("PadRight", false);
                    ThisAnimator.SetBool("PadLeft", false);
                }
                if (Input.GetAxis("Xbox Solo P1 Press Down Dpad") == 1)
                {
                    ThisAnimator.SetBool("PadIdle", false);
                    ThisAnimator.SetBool("PadUp", false);
                    ThisAnimator.SetBool("PadDown", true);
                    ThisAnimator.SetBool("PadRight", false);
                    ThisAnimator.SetBool("PadLeft", false);
                }
                if (Input.GetAxis("Xbox Solo P1 Press Right Dpad") == 1)
                {
                    ThisAnimator.SetBool("PadIdle", false);
                    ThisAnimator.SetBool("PadUp", false);
                    ThisAnimator.SetBool("PadDown", false);
                    ThisAnimator.SetBool("PadRight", true);
                    ThisAnimator.SetBool("PadLeft", false);
                }
                if (Input.GetAxis("Xbox Solo P1 Press Left Dpad") == 1)
                {
                    ThisAnimator.SetBool("PadIdle", false);
                    ThisAnimator.SetBool("PadUp", false);
                    ThisAnimator.SetBool("PadDown", false);
                    ThisAnimator.SetBool("PadRight", false);
                    ThisAnimator.SetBool("PadLeft", true);
                }
            }
        }
        if (TwoPlayer)
        {
            if (DN_MainMenuMannager.Ps4)
            {
                if (DN_PlayerMovement.UsbExtender)
                {
                    if (Input.GetAxis("P1 Press Left Arrow") == 0 && Input.GetAxis("P1 Press Up Arrow") == 0 && Input.GetAxis("P2 Press Down Arrow") == 0 && Input.GetAxis("P2 Press Right Arrow") == 0)
                    {
                        ThisAnimator.SetBool("PadIdle", true);
                        ThisAnimator.SetBool("PadUp", false);
                        ThisAnimator.SetBool("PadDown", false);
                        ThisAnimator.SetBool("PadRight", false);
                        ThisAnimator.SetBool("PadLeft", false);
                    }
                    if (Input.GetAxis("P1 Press Left Arrow") == 1)
                    {
                        ThisAnimator.SetBool("PadIdle", false);
                        ThisAnimator.SetBool("PadUp", false);
                        ThisAnimator.SetBool("PadDown", false);
                        ThisAnimator.SetBool("PadRight", false);
                        ThisAnimator.SetBool("PadLeft", true);
                    }
                    if (Input.GetAxis("P1 Press Up Arrow") == 1)
                    {
                        ThisAnimator.SetBool("PadIdle", false);
                        ThisAnimator.SetBool("PadUp", true);
                        ThisAnimator.SetBool("PadDown", false);
                        ThisAnimator.SetBool("PadRight", false);
                        ThisAnimator.SetBool("PadLeft", false);
                    }
                    if (Input.GetAxis("P2 Press Down Arrow") == 1)
                    {
                        ThisAnimator.SetBool("PadIdle", false);
                        ThisAnimator.SetBool("PadUp", false);
                        ThisAnimator.SetBool("PadDown", true);
                        ThisAnimator.SetBool("PadRight", false);
                        ThisAnimator.SetBool("PadLeft", false);
                    }
                    if (Input.GetAxis("P2 Press Right Arrow") == 1)
                    {
                        ThisAnimator.SetBool("PadIdle", false);
                        ThisAnimator.SetBool("PadUp", false);
                        ThisAnimator.SetBool("PadDown", false);
                        ThisAnimator.SetBool("PadRight", true);
                        ThisAnimator.SetBool("PadLeft", false);
                    }
                }
                else
                {
                    if (Input.GetAxis("Solo P1 Press Left Arrow") == 0 && Input.GetAxis("Solo P1 Press Up Arrow") == 0 && Input.GetAxis("P2 Press Down Arrow") == 0 && Input.GetAxis("P2 Press Right Arrow") == 0)
                    {
                        ThisAnimator.SetBool("PadIdle", true);
                        ThisAnimator.SetBool("PadUp", false);
                        ThisAnimator.SetBool("PadDown", false);
                        ThisAnimator.SetBool("PadRight", false);
                        ThisAnimator.SetBool("PadLeft", false);
                    }
                    if (Input.GetAxis("Solo P1 Press Left Arrow") == 1)
                    {
                        ThisAnimator.SetBool("PadIdle", false);
                        ThisAnimator.SetBool("PadUp", false);
                        ThisAnimator.SetBool("PadDown", false);
                        ThisAnimator.SetBool("PadRight", false);
                        ThisAnimator.SetBool("PadLeft", true);
                    }
                    if (Input.GetAxis("Solo P1 Press Up Arrow") == 1)
                    {
                        ThisAnimator.SetBool("PadIdle", false);
                        ThisAnimator.SetBool("PadUp", true);
                        ThisAnimator.SetBool("PadDown", false);
                        ThisAnimator.SetBool("PadRight", false);
                        ThisAnimator.SetBool("PadLeft", false);
                    }
                    if (Input.GetAxis("P2 Press Down Arrow") == 1)
                    {
                        ThisAnimator.SetBool("PadIdle", false);
                        ThisAnimator.SetBool("PadUp", false);
                        ThisAnimator.SetBool("PadDown", true);
                        ThisAnimator.SetBool("PadRight", false);
                        ThisAnimator.SetBool("PadLeft", false);
                    }
                    if (Input.GetAxis("P2 Press Right Arrow") == 1)
                    {
                        ThisAnimator.SetBool("PadIdle", false);
                        ThisAnimator.SetBool("PadUp", false);
                        ThisAnimator.SetBool("PadDown", false);
                        ThisAnimator.SetBool("PadRight", true);
                        ThisAnimator.SetBool("PadLeft", false);
                    }
                }
            }
            if (DN_MainMenuMannager.Xbox)
            {
                if (DN_PlayerMovement.UsbExtender)
                {
                    if (Input.GetAxis("Xbox P1 Press Up Dpad") == 0 && Input.GetAxis("Xbox P1 Press Left Dpad") == 0 && Input.GetAxis("Xbox P2 Press Down Dpad") == 0 && Input.GetAxis("Xbox P2 Press Right Dpad") == 0)
                    {
                        ThisAnimator.SetBool("PadIdle", true);
                        ThisAnimator.SetBool("PadUp", false);
                        ThisAnimator.SetBool("PadDown", false);
                        ThisAnimator.SetBool("PadRight", false);
                        ThisAnimator.SetBool("PadLeft", false);
                    }
                    if (Input.GetAxis("Xbox P1 Press Up Dpad") == 1)
                    {
                        ThisAnimator.SetBool("PadIdle", false);
                        ThisAnimator.SetBool("PadUp", true);
                        ThisAnimator.SetBool("PadDown", false);
                        ThisAnimator.SetBool("PadRight", false);
                        ThisAnimator.SetBool("PadLeft", false);
                    }
                    if (Input.GetAxis("Xbox P1 Press Left Dpad") == 1)
                    {
                        ThisAnimator.SetBool("PadIdle", false);
                        ThisAnimator.SetBool("PadUp", false);
                        ThisAnimator.SetBool("PadDown", false);
                        ThisAnimator.SetBool("PadRight", false);
                        ThisAnimator.SetBool("PadLeft", true);
                    }
                    if (Input.GetAxis("Xbox P2 Press Down Dpad") == 1)
                    {
                        ThisAnimator.SetBool("PadIdle", false);
                        ThisAnimator.SetBool("PadUp", false);
                        ThisAnimator.SetBool("PadDown", true);
                        ThisAnimator.SetBool("PadRight", false);
                        ThisAnimator.SetBool("PadLeft", false);
                    }
                    if (Input.GetAxis("Xbox P2 Press Right Dpad") == 1)
                    {
                        ThisAnimator.SetBool("PadIdle", false);
                        ThisAnimator.SetBool("PadUp", false);
                        ThisAnimator.SetBool("PadDown", false);
                        ThisAnimator.SetBool("PadRight", true);
                        ThisAnimator.SetBool("PadLeft", false);
                    }
                }
                else
                {
                    if (Input.GetAxis("Xbox Solo P1 Press Up Dpad") == 0 && Input.GetAxis("Xbox Solo P1 Press Left Dpad") == 0 && Input.GetAxis("Xbox P2 Press Down Dpad") == 0 && Input.GetAxis("Xbox P2 Press Right Dpad") == 0)
                    {
                        ThisAnimator.SetBool("PadIdle", true);
                        ThisAnimator.SetBool("PadUp", false);
                        ThisAnimator.SetBool("PadDown", false);
                        ThisAnimator.SetBool("PadRight", false);
                        ThisAnimator.SetBool("PadLeft", false);
                    }
                    if (Input.GetAxis("Xbox Solo P1 Press Up Dpad") == 1)
                    {
                        ThisAnimator.SetBool("PadIdle", false);
                        ThisAnimator.SetBool("PadUp", true);
                        ThisAnimator.SetBool("PadDown", false);
                        ThisAnimator.SetBool("PadRight", false);
                        ThisAnimator.SetBool("PadLeft", false);
                    }
                    if (Input.GetAxis("Xbox Solo P1 Press Left Dpad") == 1)
                    {
                        ThisAnimator.SetBool("PadIdle", false);
                        ThisAnimator.SetBool("PadUp", false);
                        ThisAnimator.SetBool("PadDown", false);
                        ThisAnimator.SetBool("PadRight", false);
                        ThisAnimator.SetBool("PadLeft", true);
                    }
                    if (Input.GetAxis("Xbox P2 Press Down Dpad") == 1)
                    {
                        ThisAnimator.SetBool("PadIdle", false);
                        ThisAnimator.SetBool("PadUp", false);
                        ThisAnimator.SetBool("PadDown", true);
                        ThisAnimator.SetBool("PadRight", false);
                        ThisAnimator.SetBool("PadLeft", false);
                    }
                    if (Input.GetAxis("Xbox P2 Press Right Dpad") == 1)
                    {
                        ThisAnimator.SetBool("PadIdle", false);
                        ThisAnimator.SetBool("PadUp", false);
                        ThisAnimator.SetBool("PadDown", false);
                        ThisAnimator.SetBool("PadRight", true);
                        ThisAnimator.SetBool("PadLeft", false);
                    }
                }
            }
        }
        if (ThreePlayer)
        {
            if (DN_MainMenuMannager.Ps4)
            {
                if (Input.GetAxis("P1 Press Left Arrow") == 0 && Input.GetAxis("P1 Press Up Arrow") == 0 && Input.GetAxis("P2 Press Down Arrow") == 0 && Input.GetAxis("P3 Press Right Arrow") == 0)
                {
                    ThisAnimator.SetBool("PadIdle", true);
                    ThisAnimator.SetBool("PadUp", false);
                    ThisAnimator.SetBool("PadDown", false);
                    ThisAnimator.SetBool("PadRight", false);
                    ThisAnimator.SetBool("PadLeft", false);
                }
                if (Input.GetAxis("P1 Press Left Arrow") == 1)
                {
                    ThisAnimator.SetBool("PadIdle", false);
                    ThisAnimator.SetBool("PadUp", false);
                    ThisAnimator.SetBool("PadDown", false);
                    ThisAnimator.SetBool("PadRight", false);
                    ThisAnimator.SetBool("PadLeft", true);
                }
                if (Input.GetAxis("P1 Press Up Arrow") == 1)
                {
                    ThisAnimator.SetBool("PadIdle", false);
                    ThisAnimator.SetBool("PadUp", true);
                    ThisAnimator.SetBool("PadDown", false);
                    ThisAnimator.SetBool("PadRight", false);
                    ThisAnimator.SetBool("PadLeft", false);
                }
                if (Input.GetAxis("P2 Press Down Arrow") == 1)
                {
                    ThisAnimator.SetBool("PadIdle", false);
                    ThisAnimator.SetBool("PadUp", false);
                    ThisAnimator.SetBool("PadDown", true);
                    ThisAnimator.SetBool("PadRight", false);
                    ThisAnimator.SetBool("PadLeft", false);
                }
                if (Input.GetAxis("P3 Press Right Arrow") == 1)
                {
                    ThisAnimator.SetBool("PadIdle", false);
                    ThisAnimator.SetBool("PadUp", false);
                    ThisAnimator.SetBool("PadDown", false);
                    ThisAnimator.SetBool("PadRight", true);
                    ThisAnimator.SetBool("PadLeft", false);
                }
            }
            if (DN_MainMenuMannager.Xbox)
            {
                if (Input.GetAxis("Xbox P1 Press Up Dpad") == 0 && Input.GetAxis("Xbox P1 Press Left Dpad") == 0 && Input.GetAxis("Xbox P2 Press Down Dpad") == 0 && Input.GetAxis("Xbox P3 Press Right Dpad") == 0)
                {
                    ThisAnimator.SetBool("PadIdle", true);
                    ThisAnimator.SetBool("PadUp", false);
                    ThisAnimator.SetBool("PadDown", false);
                    ThisAnimator.SetBool("PadRight", false);
                    ThisAnimator.SetBool("PadLeft", false);
                }
                if (Input.GetAxis("Xbox P1 Press Up Dpad") == 1)
                {
                    ThisAnimator.SetBool("PadIdle", false);
                    ThisAnimator.SetBool("PadUp", true);
                    ThisAnimator.SetBool("PadDown", false);
                    ThisAnimator.SetBool("PadRight", false);
                    ThisAnimator.SetBool("PadLeft", false);
                }
                if (Input.GetAxis("Xbox P1 Press Left Dpad") == 1)
                {
                    ThisAnimator.SetBool("PadIdle", false);
                    ThisAnimator.SetBool("PadUp", false);
                    ThisAnimator.SetBool("PadDown", false);
                    ThisAnimator.SetBool("PadRight", false);
                    ThisAnimator.SetBool("PadLeft", true);
                }
                if (Input.GetAxis("Xbox P3 Press Right Dpad") == 1)
                {
                    ThisAnimator.SetBool("PadIdle", false);
                    ThisAnimator.SetBool("PadUp", false);
                    ThisAnimator.SetBool("PadDown", false);
                    ThisAnimator.SetBool("PadRight", true);
                    ThisAnimator.SetBool("PadLeft", false);
                }
                if (Input.GetAxis("Xbox P2 Press Down Dpad") == 1)
                {
                    ThisAnimator.SetBool("PadIdle", false);
                    ThisAnimator.SetBool("PadUp", false);
                    ThisAnimator.SetBool("PadDown", true);
                    ThisAnimator.SetBool("PadRight", false);
                    ThisAnimator.SetBool("PadLeft", false);
                }
            }
        }
        if (FourPlayer)
        {
            if (DN_MainMenuMannager.Ps4)
            {
                if (Input.GetAxis("P1 Press Up Arrow") == 0 && Input.GetAxis("P2 Press Down Arrow") == 0 && Input.GetAxis("P3 Press Right Arrow") == 0 && Input.GetAxis("P4 Press Left Arrow") == 0)
                {
                    ThisAnimator.SetBool("PadIdle", true);
                    ThisAnimator.SetBool("PadUp", false);
                    ThisAnimator.SetBool("PadDown", false);
                    ThisAnimator.SetBool("PadRight", false);
                    ThisAnimator.SetBool("PadLeft", false);
                }
                if (Input.GetAxis("P1 Press Up Arrow") == 1)
                {
                    ThisAnimator.SetBool("PadIdle", false);
                    ThisAnimator.SetBool("PadUp", true);
                    ThisAnimator.SetBool("PadDown", false);
                    ThisAnimator.SetBool("PadRight", false);
                    ThisAnimator.SetBool("PadLeft", false);
                }
                if (Input.GetAxis("P2 Press Down Arrow") == 1)
                {
                    ThisAnimator.SetBool("PadIdle", false);
                    ThisAnimator.SetBool("PadUp", false);
                    ThisAnimator.SetBool("PadDown", true);
                    ThisAnimator.SetBool("PadRight", false);
                    ThisAnimator.SetBool("PadLeft", false);
                }
                if (Input.GetAxis("P3 Press Right Arrow") == 1)
                {
                    ThisAnimator.SetBool("PadIdle", false);
                    ThisAnimator.SetBool("PadUp", false);
                    ThisAnimator.SetBool("PadDown", false);
                    ThisAnimator.SetBool("PadRight", true);
                    ThisAnimator.SetBool("PadLeft", false);
                }
                if (Input.GetAxis("P4 Press Left Arrow") == 1)
                {
                    ThisAnimator.SetBool("PadIdle", false);
                    ThisAnimator.SetBool("PadUp", false);
                    ThisAnimator.SetBool("PadDown", false);
                    ThisAnimator.SetBool("PadRight", false);
                    ThisAnimator.SetBool("PadLeft", true);
                }
            }
            if (DN_MainMenuMannager.Xbox)
            {
                if (Input.GetAxis("Xbox P1 Press Up Dpad") == 0 && Input.GetAxis("Xbox P2 Press Down Dpad") == 0 && Input.GetAxis("Xbox P3 Press Right Dpad") == 0 && Input.GetAxis("Xbox P4 Press Left Dpad") == 0)
                {
                    ThisAnimator.SetBool("PadIdle", true);
                    ThisAnimator.SetBool("PadUp", false);
                    ThisAnimator.SetBool("PadDown", false);
                    ThisAnimator.SetBool("PadRight", false);
                    ThisAnimator.SetBool("PadLeft", false);
                }
                if (Input.GetAxis("Xbox P1 Press Up Dpad") == 1)
                {
                    ThisAnimator.SetBool("PadIdle", false);
                    ThisAnimator.SetBool("PadUp", true);
                    ThisAnimator.SetBool("PadDown", false);
                    ThisAnimator.SetBool("PadRight", false);
                    ThisAnimator.SetBool("PadLeft", false);
                }
                if(Input.GetAxis("Xbox P2 Press Down Dpad") == 1)
                {
                    ThisAnimator.SetBool("PadIdle", false);
                    ThisAnimator.SetBool("PadUp", false);
                    ThisAnimator.SetBool("PadDown", true);
                    ThisAnimator.SetBool("PadRight", false);
                    ThisAnimator.SetBool("PadLeft", false);
                }
                if(Input.GetAxis("Xbox P3 Press Right Dpad") == 1)
                {
                    ThisAnimator.SetBool("PadIdle", false);
                    ThisAnimator.SetBool("PadUp", false);
                    ThisAnimator.SetBool("PadDown", false);
                    ThisAnimator.SetBool("PadRight", true);
                    ThisAnimator.SetBool("PadLeft", false);
                }
                if(Input.GetAxis("Xbox P4 Press Left Dpad") == 1)
                {
                    ThisAnimator.SetBool("PadIdle", false);
                    ThisAnimator.SetBool("PadUp", false);
                    ThisAnimator.SetBool("PadDown", false);
                    ThisAnimator.SetBool("PadRight", false);
                    ThisAnimator.SetBool("PadLeft", true);
                }

            }
        }
    }
    public void MouseHover()
    {
        if(Setting)
        {
            ThisAnimator.SetBool("SettingTurningOn", true);
            ThisAnimator.SetBool("SettingOff", false);
        }
    }
    public void MouseUP()
    {
        if (Setting)
        {
            ThisAnimator.SetBool("SettingOff", true);
            ThisAnimator.SetBool("SettingOn", false);
            ThisAnimator.SetBool("SettingTurningOn", false);
        }
    }
    public void SettingActivate()
    {
        if (Setting)
        {
            ThisAnimator.SetBool("SettingOn", true);
        }
    }
}
