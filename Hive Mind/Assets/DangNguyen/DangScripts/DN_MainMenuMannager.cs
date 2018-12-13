using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DN_MainMenuMannager : MonoBehaviour {
    public GameObject[] MainMenuButtons;
    public GameObject[] PlayerActivate;
    public GameObject[] USbOption;
    public GameObject[] Credits;
    public GameObject backButton;
    public GameObject KeyBoard;
    public GameObject Ps4Controller;
    public GameObject XboxController;
    public GameObject Ps4ControllerSolo;
    public GameObject XboxControllerSolo;
    public static bool Ps4;
    public static bool Xbox;
    public static bool PC;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }
    public void PressStart()
    {
        backButton.SetActive(true);
        for (int i = 0; i < MainMenuButtons.Length; i++)
        {
            MainMenuButtons[i].SetActive(false);
        }
        for (int i = 0; i < PlayerActivate.Length; i++)
        {
            PlayerActivate[i].SetActive(true);
        }
    }
    public void PressQuit()
    {
        Application.Quit();
  
    }
    public void BackMainMenu()
    {
        for (int i = 0; i < Credits.Length; i++)
        {
            Credits[i].SetActive(false);
        }
        for (int i = 0; i < MainMenuButtons.Length; i++)
        {
            MainMenuButtons[i].SetActive(true);
        }
        for (int i = 0; i < PlayerActivate.Length; i++)
        {
            PlayerActivate[i].SetActive(false);
        }
        for (int i = 0; i < USbOption.Length; i++)
        {
            USbOption[i].SetActive(false);
        }
        DN_PlayerMovement.UsbExtender = false;
        DN_PlayerMovement.SoloController = false;
        DN_PlayerMovement.DualController = false;
        DN_PlayerMovement.ThreeController = false;
        DN_PlayerMovement.FourController = false;
        DN_PlayerMovement.SoloKeyBoard = false;
        Ps4ControllerSolo.SetActive(false);
        XboxControllerSolo.SetActive(false);
        KeyBoard.SetActive(false);
        Ps4Controller.SetActive(false);
        XboxController.SetActive(false);
        backButton.SetActive(false);
        Ps4 = false;
        Xbox = false;
        PC = false;
    }
    public void PlayerOne()
    {
        DN_PlayerMovement.SoloController = true;
        DN_PlayerMovement.DualController = false;
        DN_PlayerMovement.ThreeController = false;
        DN_PlayerMovement.FourController = false;
        for (int i = 0; i < PlayerActivate.Length; i++)
        {
            PlayerActivate[i].SetActive(false);
        }
        KeyBoard.SetActive(true);
        Ps4ControllerSolo.SetActive(true);
        XboxControllerSolo.SetActive(true);
    }
    public void PlayerTwo()
    {
        DN_PlayerMovement.SoloController = false;
        DN_PlayerMovement.DualController = true;
        DN_PlayerMovement.ThreeController = false;
        DN_PlayerMovement.FourController = false;
        for (int i = 0; i < PlayerActivate.Length; i++)
        {
            PlayerActivate[i].SetActive(false);
        }
        KeyBoard.SetActive(false);
        Ps4Controller.SetActive(true);
        XboxController.SetActive(true);
    }
    public void PlayerThree()
    {
        DN_PlayerMovement.SoloController = false;
        DN_PlayerMovement.DualController = false;
        DN_PlayerMovement.ThreeController = true;
        DN_PlayerMovement.FourController = false;
        for (int i = 0; i < PlayerActivate.Length; i++)
        {
            PlayerActivate[i].SetActive(false);
        }
        KeyBoard.SetActive(false);
        Ps4Controller.SetActive(true);
        XboxController.SetActive(true);
    }
    public void PlayerFour()
    {
        DN_PlayerMovement.SoloController = false;
        DN_PlayerMovement.DualController = false;
        DN_PlayerMovement.ThreeController = false;
        DN_PlayerMovement.FourController = true;
        for (int i = 0; i < PlayerActivate.Length; i++)
        {
            PlayerActivate[i].SetActive(false);
        }
        KeyBoard.SetActive(false);
        Ps4Controller.SetActive(true);
        XboxController.SetActive(true);
    }
    public void USBExtenderOptionPs4()
    {
        Ps4 = true;
        KeyBoard.SetActive(false);
        Ps4Controller.SetActive(false);
        XboxController.SetActive(false);
        for (int i = 0; i < USbOption.Length; i++)
        {
            USbOption[i].SetActive(true);
        }
    }
    public void USBExtenderOptionXbox()
    {
        Xbox = true;
        KeyBoard.SetActive(false);
        Ps4Controller.SetActive(false);
        XboxController.SetActive(false);
        for (int i = 0; i < USbOption.Length; i++)
        {
            USbOption[i].SetActive(true);
        }
    }
  
    public void GameBeginKeyBoard()
    {
        PC = true;
        DN_PlayerMovement.SoloController = false;
        DN_PlayerMovement.UsbExtender = false;
        DN_PlayerMovement.SoloKeyBoard = true;
        SceneManager.LoadScene(1);
    }
    public void GameBeginPs4()
    {
        Ps4 = true;
        DN_PlayerMovement.SoloController = true;
        DN_PlayerMovement.UsbExtender = false;
        DN_PlayerMovement.SoloKeyBoard = false;
        SceneManager.LoadScene(1);
    }
    public void GameBeginXbox()
    {
        Xbox = true;
        DN_PlayerMovement.SoloController = true;
        DN_PlayerMovement.UsbExtender = false;
        DN_PlayerMovement.SoloKeyBoard = false;
        SceneManager.LoadScene(1);
    }
    public void YesUsbExtender()
    {
        DN_PlayerMovement.SoloKeyBoard = false;
        DN_PlayerMovement.UsbExtender = true;
        SceneManager.LoadScene(1);
    }
    public void NoUsbExtender()
    {
        DN_PlayerMovement.SoloKeyBoard = false;
        DN_PlayerMovement.UsbExtender = false;
        SceneManager.LoadScene(1);
    }
    public void Credit()
    {
        for (int i = 0; i < Credits.Length; i++)
        {
            Credits[i].SetActive(true);
        }
        backButton.SetActive(true);
        for (int i = 0; i < MainMenuButtons.Length; i++)
        {
            MainMenuButtons[i].SetActive(false);
        }
    }

}
