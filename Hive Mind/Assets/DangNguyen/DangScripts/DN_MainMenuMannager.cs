using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DN_MainMenuMannager : MonoBehaviour {
    public GameObject[] MainMenuButtons;
    public GameObject[] PlayerActivate;
    public GameObject[] Mode;
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
    public static bool Scenarios;
    public GameObject Style;
    private DN_Transition Transcripts;
    private bool StartNow;
    private bool CreditNow;
    private bool BackNow;
    private bool P1Now;
    private bool P2Now;
    private bool P3Now;
    private bool P4Now;
    private bool ContinueNow;
    private bool Ps4BeginNow;
    private bool XboxBeginNow;
    // Use this for initialization
    void Start () {
        Transcripts = Style.GetComponent<DN_Transition>();
	}
	
	// Update is called once per frame
	void Update () {
        if(StartNow)
        {
            if (Transcripts.TransitionStart)
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
                Transcripts.TransitionStart = false;
                StartNow = false;
            }
        }
        if(CreditNow)
        {
            if(Transcripts.TransitionStart)
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
                Transcripts.TransitionStart = false;
                CreditNow = false;
            }
        }
        if(BackNow)
        {
            if(Transcripts.TransitionStart)
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
                for (int i = 0; i < Mode.Length; i++)
                {
                    Mode[i].SetActive(false);
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
                Scenarios = false;
                Transcripts.TransitionStart = false;
                BackNow = false;
            }
        }
        if(P1Now)
        {
            if(Transcripts.TransitionStart)
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
                Transcripts.TransitionStart = false;
                P1Now = false;
            }
        }
        if(P2Now)
        {
            if(Transcripts.TransitionStart)
            {
                DN_PlayerMovement.SoloController = false;
                DN_PlayerMovement.DualController = true;
                DN_PlayerMovement.ThreeController = false;
                DN_PlayerMovement.FourController = false;
                for (int i = 0; i < PlayerActivate.Length; i++)
                {
                    PlayerActivate[i].SetActive(false);
                }
                for (int i = 0; i < Mode.Length; i++)
                {
                    Mode[i].SetActive(true);
                }
                Transcripts.TransitionStart = false;
                P2Now = false;
            }
        }
        if(P3Now)
        {
            if(Transcripts.TransitionStart)
            {
                DN_PlayerMovement.SoloController = false;
                DN_PlayerMovement.DualController = false;
                DN_PlayerMovement.ThreeController = true;
                DN_PlayerMovement.FourController = false;
                for (int i = 0; i < PlayerActivate.Length; i++)
                {
                    PlayerActivate[i].SetActive(false);
                }

                for (int i = 0; i < Mode.Length; i++)
                {
                    Mode[i].SetActive(true);
                }
                Transcripts.TransitionStart = false;
                P3Now = false;
            }
        }
        if(P4Now)
        {
            if(Transcripts.TransitionStart)
            {
                DN_PlayerMovement.SoloController = false;
                DN_PlayerMovement.DualController = false;
                DN_PlayerMovement.ThreeController = false;
                DN_PlayerMovement.FourController = true;
                for (int i = 0; i < PlayerActivate.Length; i++)
                {
                    PlayerActivate[i].SetActive(false);
                }

                for (int i = 0; i < Mode.Length; i++)
                {
                    Mode[i].SetActive(true);
                }
                Transcripts.TransitionStart = false;
                P4Now = false;
            }
        }
        if(ContinueNow)
        {
            if(Transcripts.TransitionStart)
            {
                for (int i = 0; i < Mode.Length; i++)
                {
                    Mode[i].SetActive(false);
                }
                KeyBoard.SetActive(false);
                Ps4Controller.SetActive(true);
                XboxController.SetActive(true);
                Transcripts.TransitionStart = false;
                ContinueNow = false;
            }
        }
        if(Ps4BeginNow)
        {
            if (Transcripts.TransitionStart)
            {
                Ps4 = true;
                KeyBoard.SetActive(false);
                Ps4Controller.SetActive(false);
                XboxController.SetActive(false);
                for (int i = 0; i < USbOption.Length; i++)
                {
                    USbOption[i].SetActive(true);
                }
                Ps4BeginNow = false;
                Transcripts.TransitionStart = false;
            }
        }
        if(XboxBeginNow)
        {
            if (Transcripts.TransitionStart)
            {
                Xbox = true;
                KeyBoard.SetActive(false);
                Ps4Controller.SetActive(false);
                XboxController.SetActive(false);
                for (int i = 0; i < USbOption.Length; i++)
                {
                    USbOption[i].SetActive(true);
                }
                XboxBeginNow = false;
                Transcripts.TransitionStart = false;
            }
        }

    }
    public void PressStart()
    {
        StartNow = true;
    }
    public void AddScenario()
    {
        Scenarios = !Scenarios;
    }
    public void PressContinueAfterMode()
    {
        ContinueNow = true;
    }
    public void PressQuit()
    {
        Application.Quit();
  
    }
    public void BackMainMenu()
    {
        BackNow = true;
    }
    public void PlayerOne()
    {
        P1Now = true;
       
    }
    public void PlayerTwo()
    {
        P2Now = true;
    }
    public void PlayerThree()
    {
        P3Now = true;
    }
    public void PlayerFour()
    {
        P4Now = true;
    }
    public void USBExtenderOptionPs4()
    {
        Ps4BeginNow = true;
    }
    public void USBExtenderOptionXbox()
    {
        XboxBeginNow = true;
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
        CreditNow = true;
    }
    public void Quit()
    {
        Application.Quit();
    }

}
