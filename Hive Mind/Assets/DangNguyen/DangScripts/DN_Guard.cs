using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//public enum DIRECTION { UP, DOWN, LEFT, RIGHT }
public class DN_Guard : MonoBehaviour {
    //  private DIRECTION dir = DIRECTION.DOWN;
    private bool canMove = true, moving = false;
    private int speed = 5, buttonCooldown = 0;
    public int cooldownforbutton;
    private DIRECTION dir = DIRECTION.DOWN;
    private Vector3 pos;
    public bool StopTop;
    public bool StopRight;
    public bool StopLeft;
    public bool StopBot;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        buttonCooldown--;
        if (canMove)
        {
            pos = transform.position;
            if(DN_PlayerMovement.SoloController)
            {
                SoloPlayerMove();
            }
            if (DN_PlayerMovement.DualController)
            {
                TwoPlayerMove();
            }
            if(DN_PlayerMovement.ThreeController)
            {
                ThreePlayerMove();
            }
            if(DN_PlayerMovement.FourController)
            {
                FourPlayerMove();
            }
            if(DN_PlayerMovement.SoloKeyBoard)
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
    void SoloKeyboardMove()
    {
        if (Input.GetKey(KeyCode.LeftArrow) && StopLeft == false)
        {
            buttonCooldown = cooldownforbutton;
            canMove = false;
            moving = true;
            pos += Vector3.left;
        }
        if (Input.GetKey(KeyCode.RightArrow) && StopRight == false)
        {
            buttonCooldown = cooldownforbutton;
            canMove = false;
            moving = true;
            pos += Vector3.right;
        }
        if (Input.GetKey(KeyCode.DownArrow) && StopBot == false)
        {
            buttonCooldown = cooldownforbutton;
            canMove = false;
            moving = true;
            pos += Vector3.back;
        }
        if (Input.GetKey(KeyCode.UpArrow) && StopTop == false)
        {
            buttonCooldown = cooldownforbutton;
            canMove = false;
            moving = true;
            pos += Vector3.forward;
        }
    }
    void SoloPlayerMove()
    {
        if (DN_MainMenuMannager.Ps4)
        {
            if (Input.GetAxis("Solo P1 Press Up Arrow") == 1 && StopTop == false)
            {
                buttonCooldown = cooldownforbutton;
                canMove = false;
                moving = true;
                pos += Vector3.forward;

            }
            else if (Input.GetAxis("Solo P1 Press Down Arrow") == 1 && StopBot == false)
            {


                buttonCooldown = cooldownforbutton;
                canMove = false;
                moving = true;
                pos += Vector3.back;


            }
            else if (Input.GetAxis("Solo P1 Press Left Arrow") == 1 && StopLeft == false)
            {

                buttonCooldown = cooldownforbutton;
                canMove = false;
                moving = true;
                pos += Vector3.left;


            }
            else if (Input.GetAxis("Solo P1 Press Right Arrow") == 1 && StopRight == false)
            {


                buttonCooldown = cooldownforbutton;
                canMove = false;
                moving = true;
                pos += Vector3.right;


            }
        }
        if(DN_MainMenuMannager.Xbox)
        {
            if (Input.GetAxis("Xbox Solo P1 Press Up Dpad") == 1 && StopTop == false)
            {
                buttonCooldown = cooldownforbutton;
                canMove = false;
                moving = true;
                pos += Vector3.forward;

            }
            else if (Input.GetAxis("Xbox Solo P1 Press Down Dpad") == 1 && StopBot == false)
            {


                buttonCooldown = cooldownforbutton;
                canMove = false;
                moving = true;
                pos += Vector3.back;


            }
            else if (Input.GetAxis("Xbox Solo P1 Press Left Dpad") == 1 && StopLeft == false)
            {

                buttonCooldown = cooldownforbutton;
                canMove = false;
                moving = true;
                pos += Vector3.left;


            }
            else if (Input.GetAxis("Xbox Solo P1 Press Right Dpad") == 1 && StopRight == false)
            {


                buttonCooldown = cooldownforbutton;
                canMove = false;
                moving = true;
                pos += Vector3.right;


            }
        }
    }
    void TwoPlayerMove()
    {
        if(DN_MainMenuMannager.Ps4)
        {
            if (DN_PlayerMovement.UsbExtender)
            {
                if (Input.GetAxis("P1 Press Up Arrow") == 1 && StopTop == false)
                {
                    buttonCooldown = cooldownforbutton;
                    canMove = false;
                    moving = true;
                    pos += Vector3.forward;

                }
                else if (Input.GetAxis("P2 Press Down Arrow") == 1 && StopBot == false)
                {


                    buttonCooldown = cooldownforbutton;
                    canMove = false;
                    moving = true;
                    pos += Vector3.back;


                }
                else if (Input.GetAxis("P1 Press Left Arrow") == 1 && StopLeft == false)
                {

                    buttonCooldown = cooldownforbutton;
                    canMove = false;
                    moving = true;
                    pos += Vector3.left;


                }
                else if (Input.GetAxis("P2 Press Right Arrow") == 1 && StopRight == false)
                {


                    buttonCooldown = cooldownforbutton;
                    canMove = false;
                    moving = true;
                    pos += Vector3.right;


                }
            }
            else
            {
                if (Input.GetAxis("Solo P1 Press Up Arrow") == 1 && StopTop == false)
                {
                    buttonCooldown = cooldownforbutton;
                    canMove = false;
                    moving = true;
                    pos += Vector3.forward;

                }
                else if (Input.GetAxis("P2 Press Down Arrow") == 1 && StopBot == false)
                {


                    buttonCooldown = cooldownforbutton;
                    canMove = false;
                    moving = true;
                    pos += Vector3.back;


                }
                else if (Input.GetAxis("Solo P1 Press Left Arrow") == 1 && StopLeft == false)
                {

                    buttonCooldown = cooldownforbutton;
                    canMove = false;
                    moving = true;
                    pos += Vector3.left;


                }
                else if (Input.GetAxis("P2 Press Right Arrow") == 1 && StopRight == false)
                {


                    buttonCooldown = cooldownforbutton;
                    canMove = false;
                    moving = true;
                    pos += Vector3.right;


                }
            }
        }
        if(DN_MainMenuMannager.Xbox)
        {
            if (DN_PlayerMovement.UsbExtender)
            {
                if (Input.GetAxis("Xbox P1 Press Up Dpad") == 1 && StopTop == false)
                {
                    buttonCooldown = cooldownforbutton;
                    canMove = false;
                    moving = true;
                    pos += Vector3.forward;

                }
                else if (Input.GetAxis("Xbox P2 Press Down Dpad") == 1 && StopBot == false)
                {


                    buttonCooldown = cooldownforbutton;
                    canMove = false;
                    moving = true;
                    pos += Vector3.back;


                }
                else if (Input.GetAxis("Xbox P1 Press Left Dpad") == 1 && StopLeft == false)
                {

                    buttonCooldown = cooldownforbutton;
                    canMove = false;
                    moving = true;
                    pos += Vector3.left;


                }
                else if (Input.GetAxis("Xbox P2 Press Right Dpad") == 1 && StopRight == false)
                {


                    buttonCooldown = cooldownforbutton;
                    canMove = false;
                    moving = true;
                    pos += Vector3.right;


                }
            }
            else
            {
                if (Input.GetAxis("Xbox Solo P1 Press Up Dpad") == 1 && StopTop == false)
                {
                    buttonCooldown = cooldownforbutton;
                    canMove = false;
                    moving = true;
                    pos += Vector3.forward;

                }
                else if (Input.GetAxis("Xbox P2 Press Down Dpad") == 1 && StopBot == false)
                {


                    buttonCooldown = cooldownforbutton;
                    canMove = false;
                    moving = true;
                    pos += Vector3.back;


                }
                else if (Input.GetAxis("Xbox Solo P1 Press Left Dpad") == 1 && StopLeft == false)
                {

                    buttonCooldown = cooldownforbutton;
                    canMove = false;
                    moving = true;
                    pos += Vector3.left;


                }
                else if (Input.GetAxis("Xbox P2 Press Right Dpad") == 1 && StopRight == false)
                {


                    buttonCooldown = cooldownforbutton;
                    canMove = false;
                    moving = true;
                    pos += Vector3.right;


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
                if (Input.GetAxis("P1 Press Up Arrow") == 1 && StopTop == false)
                {
                    buttonCooldown = cooldownforbutton;
                    canMove = false;
                    moving = true;
                    pos += Vector3.forward;

                }
                else if (Input.GetAxis("P2 Press Down Arrow") == 1 && StopBot == false)
                {


                    buttonCooldown = cooldownforbutton;
                    canMove = false;
                    moving = true;
                    pos += Vector3.back;


                }
                else if (Input.GetAxis("P1 Press Left Arrow") == 1 && StopLeft == false)
                {

                    buttonCooldown = cooldownforbutton;
                    canMove = false;
                    moving = true;
                    pos += Vector3.left;


                }
                else if (Input.GetAxis("P3 Press Right Arrow") == 1 && StopRight == false)
                {


                    buttonCooldown = cooldownforbutton;
                    canMove = false;
                    moving = true;
                    pos += Vector3.right;


                }
            }
        }
        if(DN_MainMenuMannager.Xbox)
        {
            if (DN_PlayerMovement.UsbExtender)
            {
                if (Input.GetAxis("Xbox P1 Press Up Dpad") == 1 && StopTop == false)
                {
                    buttonCooldown = cooldownforbutton;
                    canMove = false;
                    moving = true;
                    pos += Vector3.forward;

                }
                else if (Input.GetAxis("Xbox P1 Press Left Dpad") == 1 && StopLeft == false)
                {

                    buttonCooldown = cooldownforbutton;
                    canMove = false;
                    moving = true;
                    pos += Vector3.left;
                }
                else if (Input.GetAxis("Xbox P2 Press Down Dpad") == 1 && StopBot == false)
                {
                    buttonCooldown = cooldownforbutton;
                    canMove = false;
                    moving = true;
                    pos += Vector3.back;
                }
                else if (Input.GetAxis("Xbox P3 Press Right Dpad") == 1 && StopRight == false)
                {

                    buttonCooldown = cooldownforbutton;
                    canMove = false;
                    moving = true;
                    pos += Vector3.right;
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
                if (Input.GetAxis("P1 Press Up Arrow") == 1 && StopTop == false)
                {
                    buttonCooldown = cooldownforbutton;
                    canMove = false;
                    moving = true;
                    pos += Vector3.forward;

                }
                else if (Input.GetAxis("P2 Press Down Arrow") == 1 && StopBot == false)
                {


                    buttonCooldown = cooldownforbutton;
                    canMove = false;
                    moving = true;
                    pos += Vector3.back;


                }
                else if (Input.GetAxis("P4 Press Left Arrow") == 1 && StopLeft == false)
                {

                    buttonCooldown = cooldownforbutton;
                    canMove = false;
                    moving = true;
                    pos += Vector3.left;


                }
                else if (Input.GetAxis("P3 Press Right Arrow") == 1 && StopRight == false)
                {


                    buttonCooldown = cooldownforbutton;
                    canMove = false;
                    moving = true;
                    pos += Vector3.right;
                }
            }
        }
        if (DN_MainMenuMannager.Xbox)
        {
            if (DN_PlayerMovement.UsbExtender)
            {
                if (Input.GetAxis("Xbox P1 Press Up Dpad") == 1 && StopTop == false)
                {
                    buttonCooldown = cooldownforbutton;
                    canMove = false;
                    moving = true;
                    pos += Vector3.forward;

                }
                else if (Input.GetAxis("Xbox P4 Press Left Dpad") == 1 && StopLeft == false)
                {

                    buttonCooldown = cooldownforbutton;
                    canMove = false;
                    moving = true;
                    pos += Vector3.left;
                }
                else if (Input.GetAxis("Xbox P2 Press Down Dpad") == 1 && StopBot == false)
                {
                    buttonCooldown = cooldownforbutton;
                    canMove = false;
                    moving = true;
                    pos += Vector3.back;
                }
                else if (Input.GetAxis("Xbox P3 Press Right Dpad") == 1 && StopRight == false)
                {

                    buttonCooldown = cooldownforbutton;
                    canMove = false;
                    moving = true;
                    pos += Vector3.right;
                }
            }
        }
    }
}
