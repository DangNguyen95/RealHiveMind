using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DN_Guard : MonoBehaviour {

    //  private DIRECTION dir = DIRECTION.DOWN;
    private bool canMove = true, moving = false;
    public int speed, buttonCooldown = 0;
    public int cooldownforbutton;
    private DIRECTION dir = DIRECTION.DOWN;
    private Vector3 pos;
    public bool StopTop;
    public bool StopRight;
    public bool StopLeft;
    public bool StopBot;
    public bool AutoRun;
    public bool RunDown;
    public GameObject Scaredface;
    public GameObject AngryFace;
    public GameObject Mech;
    private DN_Mech MechScripts;
    // Use this for initialization
    void Start() {
        if (AutoRun)
        {
            MechScripts = Mech.GetComponent<DN_Mech>();
        }
    }

    // Update is called once per frame
    void Update() {
        buttonCooldown--;
        if (AutoRun)
        {
            if (MechScripts.BotLeft && MechScripts.BotRight && MechScripts.TopRight && MechScripts.TopLeft)
            {
                Scaredface.SetActive(true);
                AngryFace.SetActive(false);
            }
            if (RunDown)
            {
                transform.position += Vector3.back * Time.deltaTime * speed;

            }
            else
            {
                transform.position += Vector3.forward * Time.deltaTime * speed;
            }


        }
        else
        {
            if (canMove)
            {
                pos = transform.position;
                if (DN_PlayerMovement.SoloController)
                {
                    SoloPlayerMove();
                }
                if (DN_PlayerMovement.DualController)
                {
                    TwoPlayerMove();
                }
                if (DN_PlayerMovement.ThreeController)
                {
                    ThreePlayerMove();
                }
                if (DN_PlayerMovement.FourController)
                {
                    FourPlayerMove();
                }
                if (DN_PlayerMovement.SoloKeyBoard)
                {
                    SoloKeyboardMove();
                }
            }
            if (moving)
            {
                if (transform.position == pos)
                {
                    moving = false;
                    canMove = true;
                    if (DN_PlayerMovement.SoloController)
                    {
                        SoloPlayerMove();
                    }
                    if (DN_PlayerMovement.DualController)
                    {
                        TwoPlayerMove();
                    }
                    if (DN_PlayerMovement.ThreeController)
                    {
                        ThreePlayerMove();
                    }
                    if (DN_PlayerMovement.FourController)
                    {
                        FourPlayerMove();
                    }
                    if (DN_PlayerMovement.SoloKeyBoard)
                    {
                        SoloKeyboardMove();

                    }
                }
                transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * speed);
            }
        }
       
    }
    void SoloKeyboardMove()
    {
        if (buttonCooldown <= 0)
        { 
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
                if (Input.GetKey(KeyCode.UpArrow) && StopTop == false)
                {
                    if (dir != DIRECTION.UP)
                    {
                        dir = DIRECTION.UP;
                        buttonCooldown = cooldownforbutton;
                    }
                    else
                    {
                        canMove = false;
                        moving = true;
                        pos += Vector3.forward;
                    }
                }
            }
    }
    void SoloPlayerMove()
    {
        if (DN_MainMenuMannager.Ps4)
        {
            if (buttonCooldown <= 0)
            {
                if (Input.GetAxis("Solo P1 Press Up Arrow") == 1 && StopTop == false)
                {
                    if (dir != DIRECTION.UP)
                    {
                        dir = DIRECTION.UP;
                        buttonCooldown = cooldownforbutton;
                    }
                    else
                    {
                        canMove = false;
                        moving = true;
                        pos += Vector3.forward;
                    }

                }
                else if (Input.GetAxis("Solo P1 Press Down Arrow") == 1 && StopBot == false)
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
                else if (Input.GetAxis("Solo P1 Press Left Arrow") == 1 && StopLeft == false)
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
                else if (Input.GetAxis("Solo P1 Press Right Arrow") == 1 && StopRight == false)
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
        }
        if(DN_MainMenuMannager.Xbox)
        {
            if (buttonCooldown <= 0)
            {
                if (Input.GetAxis("Xbox Solo P1 Press Up Dpad") == 1 && StopTop == false)
                {
                    if (dir != DIRECTION.UP)
                    {
                        dir = DIRECTION.UP;
                        buttonCooldown = cooldownforbutton;
                    }
                    else
                    {
                        canMove = false;
                        moving = true;
                        pos += Vector3.forward;
                    }

                }
                else if (Input.GetAxis("Xbox Solo P1 Press Down Dpad") == 1 && StopBot == false)
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
                else if (Input.GetAxis("Xbox Solo P1 Press Left Dpad") == 1 && StopLeft == false)
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
                else if (Input.GetAxis("Xbox Solo P1 Press Right Dpad") == 1 && StopRight == false)
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
        }
    }
    void TwoPlayerMove()
    {
        if(DN_MainMenuMannager.Ps4)
        {
            if (DN_PlayerMovement.UsbExtender)
            {
                if (buttonCooldown <= 0)
                {
                    if (Input.GetAxis("P1 Press Up Arrow") == 1 && StopTop == false)
                    {
                        if (dir != DIRECTION.UP)
                        {
                            dir = DIRECTION.UP;
                            buttonCooldown = cooldownforbutton;
                        }
                        else
                        {
                            canMove = false;
                            moving = true;
                            pos += Vector3.forward;
                        }

                    }
                    else if (Input.GetAxis("P2 Press Down Arrow") == 1 && StopBot == false)
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
                    else if (Input.GetAxis("P1 Press Left Arrow") == 1 && StopLeft == false)
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
                    else if (Input.GetAxis("P2 Press Right Arrow") == 1 && StopRight == false)
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
            }
            else
            {
                if (buttonCooldown <= 0)
                {
                    if (Input.GetAxis("Solo P1 Press Up Arrow") == 1 && StopTop == false)
                    {
                        if (dir != DIRECTION.UP)
                        {
                            dir = DIRECTION.UP;
                            buttonCooldown = cooldownforbutton;
                        }
                        else
                        {
                            canMove = false;
                            moving = true;
                            pos += Vector3.forward;
                        }
                    }
                    else if (Input.GetAxis("P2 Press Down Arrow") == 1 && StopBot == false)
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
                    else if (Input.GetAxis("Solo P1 Press Left Arrow") == 1 && StopLeft == false)
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
                    else if (Input.GetAxis("P2 Press Right Arrow") == 1 && StopRight == false)
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
            }
        }
        if(DN_MainMenuMannager.Xbox)
        {
            if (DN_PlayerMovement.UsbExtender)
            {
                if (buttonCooldown <= 0)
                {
                    if (Input.GetAxis("Xbox P1 Press Up Dpad") == 1 && StopTop == false)
                    {
                        if (dir != DIRECTION.UP)
                        {
                            dir = DIRECTION.UP;
                            buttonCooldown = cooldownforbutton;
                        }
                        else
                        {
                            canMove = false;
                            moving = true;
                            pos += Vector3.forward;
                        }

                    }
                    else if (Input.GetAxis("Xbox P2 Press Down Dpad") == 1 && StopBot == false)
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
                    else if (Input.GetAxis("Xbox P1 Press Left Dpad") == 1 && StopLeft == false)
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
                    else if (Input.GetAxis("Xbox P2 Press Right Dpad") == 1 && StopRight == false)
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
            }
            else
            {
                if (buttonCooldown <= 0)
                {
                    if (Input.GetAxis("Xbox Solo P1 Press Up Dpad") == 1 && StopTop == false)
                    {
                        if (dir != DIRECTION.UP)
                        {
                            dir = DIRECTION.UP;
                            buttonCooldown = cooldownforbutton;
                        }
                        else
                        {
                            canMove = false;
                            moving = true;
                            pos += Vector3.forward;
                        }

                    }
                    else if (Input.GetAxis("Xbox P2 Press Down Dpad") == 1 && StopBot == false)
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
                    else if (Input.GetAxis("Xbox Solo P1 Press Left Dpad") == 1 && StopLeft == false)
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
                    else if (Input.GetAxis("Xbox P2 Press Right Dpad") == 1 && StopRight == false)
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
            }
        }
    }
    void ThreePlayerMove()
    {
        if (DN_MainMenuMannager.Ps4)
        {
            if (DN_PlayerMovement.UsbExtender)
            {
                if (buttonCooldown <= 0)
                {
                    if (Input.GetAxis("P1 Press Up Arrow") == 1 && StopTop == false)
                    {
                        if (dir != DIRECTION.UP)
                        {
                            dir = DIRECTION.UP;
                            buttonCooldown = cooldownforbutton;
                        }
                        else
                        {
                            canMove = false;
                            moving = true;
                            pos += Vector3.forward;
                        }
                    }
                    else if (Input.GetAxis("P2 Press Down Arrow") == 1 && StopBot == false)
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
                    else if (Input.GetAxis("P1 Press Left Arrow") == 1 && StopLeft == false)
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
                    else if (Input.GetAxis("P3 Press Right Arrow") == 1 && StopRight == false)
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
            }
        }
        if(DN_MainMenuMannager.Xbox)
        {
            if (DN_PlayerMovement.UsbExtender)
            {
                if (buttonCooldown <= 0)
                {
                    if (Input.GetAxis("Xbox P1 Press Up Dpad") == 1 && StopTop == false)
                    {
                        if (dir != DIRECTION.UP)
                        {
                            dir = DIRECTION.UP;
                            buttonCooldown = cooldownforbutton;
                        }
                        else
                        {
                            canMove = false;
                            moving = true;
                            pos += Vector3.forward;
                        }

                    }
                    else if (Input.GetAxis("Xbox P1 Press Left Dpad") == 1 && StopLeft == false)
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
                    else if (Input.GetAxis("Xbox P2 Press Down Dpad") == 1 && StopBot == false)
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
                    else if (Input.GetAxis("Xbox P3 Press Right Dpad") == 1 && StopRight == false)
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
            }
        }
    }
    void FourPlayerMove()
    {
        if (DN_MainMenuMannager.Ps4)
        {
            if (DN_PlayerMovement.UsbExtender)
            {
                if (buttonCooldown <= 0)
                {
                    if (Input.GetAxis("P1 Press Up Arrow") == 1 && StopTop == false)
                    {
                        if (dir != DIRECTION.UP)
                        {
                            dir = DIRECTION.UP;
                            buttonCooldown = cooldownforbutton;
                        }
                        else
                        {
                            canMove = false;
                            moving = true;
                            pos += Vector3.forward;
                        }

                    }
                    else if (Input.GetAxis("P2 Press Down Arrow") == 1 && StopBot == false)
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
                    else if (Input.GetAxis("P4 Press Left Arrow") == 1 && StopLeft == false)
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
                    else if (Input.GetAxis("P3 Press Right Arrow") == 1 && StopRight == false)
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
            }
        }
        if (DN_MainMenuMannager.Xbox)
        {
            if (DN_PlayerMovement.UsbExtender)
            {
                if (buttonCooldown <= 0)
                {
                    if (Input.GetAxis("Xbox P1 Press Up Dpad") == 1 && StopTop == false)
                    {
                        if (dir != DIRECTION.UP)
                        {
                            dir = DIRECTION.UP;
                            buttonCooldown = cooldownforbutton;
                        }
                        else
                        {
                            canMove = false;
                            moving = true;
                            pos += Vector3.forward;
                        }

                    }
                    else if (Input.GetAxis("Xbox P4 Press Left Dpad") == 1 && StopLeft == false)
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
                    else if (Input.GetAxis("Xbox P2 Press Down Dpad") == 1 && StopBot == false)
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
                    else if (Input.GetAxis("Xbox P3 Press Right Dpad") == 1 && StopRight == false)
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
            }
        }
    }
}
