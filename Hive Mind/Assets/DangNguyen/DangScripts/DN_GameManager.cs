using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DN_GameManager : MonoBehaviour {
    public static bool SquareHome;
    public static bool OHome;
    public static bool XHome;
    public static bool TriangleHome;
    public static bool Death;
    public GameObject VictoryScreen;
    public GameObject DefeatScreen;
    public GameObject Times;
    private DN_Time timescripts;
    public int RestartSceneNumber;
    public int PreviousSceneNumber;
    public int NextLevelNumber;
    public GameObject RedImage;
    public GameObject OrangeImage;
    public GameObject BlueImage;
    public GameObject GreenImage;
    public GameObject PS4ControllerInstructionScreen;
    public GameObject KeyboardInstructionScreen;
    public GameObject XboxControllerInstructionScreen;
    public GameObject[] KeyboardPFI;
    public GameObject[] ControllerPFI;
    public GameObject[] XboxControllerPFI;
    public GameObject[] Player1PS4PFI;
    public GameObject[] Player1KeyboardPFI;
    public GameObject[] Player2PS4PFI;
    public GameObject[] Player3PS4PFI;
    public GameObject[] Player4PS4PFI;
    public bool therePrison;
    public GameObject ObjectiveIndicator;
    // Use this for initialization
    void Start () {
        timescripts = Times.GetComponent<DN_Time>();
        Time.timeScale = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if(DN_PlayerMovement.SoloController)
        {
            if (therePrison)
            {
                for (int i = 0; i < KeyboardPFI.Length; i++)
                {
                    KeyboardPFI[i].SetActive(false);
                }
                if (DN_MainMenuMannager.Ps4)
                {
                    for (int i = 0; i < ControllerPFI.Length; i++)
                    {
                        ControllerPFI[i].SetActive(true);
                    }
                    for (int i = 0; i < XboxControllerPFI.Length; i++)
                    {
                        XboxControllerPFI[i].SetActive(false);
                    }
                }
                if (DN_MainMenuMannager.Xbox)
                {
                    for (int i = 0; i < XboxControllerPFI.Length; i++)
                    {
                        XboxControllerPFI[i].SetActive(true);
                    }
                    for (int i = 0; i < ControllerPFI.Length; i++)
                    {
                        ControllerPFI[i].SetActive(false);
                    }
                }
            }
            RedImage.SetActive(true);
            OrangeImage.SetActive(false);
            BlueImage.SetActive(false);
            GreenImage.SetActive(false);
            for (int i = 0; i < Player1PS4PFI.Length; i++)
            {
                Player1PS4PFI[i].SetActive(true);
            }
            for (int i = 0; i < Player2PS4PFI.Length; i++)
            {
                Player2PS4PFI[i].SetActive(false);
            }
            for (int i = 0; i < Player1KeyboardPFI.Length; i++)
            {
                Player1KeyboardPFI[i].SetActive(false);
            }
            for (int i = 0; i < Player3PS4PFI.Length; i++)
            {
                Player3PS4PFI[i].SetActive(false);
            }
            for (int i = 0; i < Player3PS4PFI.Length; i++)
            {
                Player4PS4PFI[i].SetActive(false);
            }
        }
        if(DN_PlayerMovement.SoloKeyBoard)
        { 
            RedImage.SetActive(true);
            OrangeImage.SetActive(false);
            BlueImage.SetActive(false);
            GreenImage.SetActive(false);
            if (therePrison)
            {
                for (int i = 0; i < KeyboardPFI.Length; i++)
                {
                    KeyboardPFI[i].SetActive(true);
                }
                if (DN_MainMenuMannager.Ps4)
                {
                    for (int i = 0; i < ControllerPFI.Length; i++)
                    {
                        ControllerPFI[i].SetActive(true);
                    }
                    for (int i = 0; i < XboxControllerPFI.Length; i++)
                    {
                        XboxControllerPFI[i].SetActive(false);
                    }
                }
                if (DN_MainMenuMannager.Xbox)
                {
                    for (int i = 0; i < XboxControllerPFI.Length; i++)
                    {
                        XboxControllerPFI[i].SetActive(true);
                    }
                    for (int i = 0; i < ControllerPFI.Length; i++)
                    {
                        ControllerPFI[i].SetActive(false);
                    }
                }
            }
            for (int i = 0; i < Player1KeyboardPFI.Length; i++)
            {
                Player1KeyboardPFI[i].SetActive(true);
            }
            for (int i = 0; i < Player1PS4PFI.Length; i++)
            {
                Player1PS4PFI[i].SetActive(false);
            }
            for (int i = 0; i < Player2PS4PFI.Length; i++)
            {
                Player2PS4PFI[i].SetActive(false);
            }
            for (int i = 0; i < Player3PS4PFI.Length; i++)
            {
                Player3PS4PFI[i].SetActive(false);
            }
            for (int i = 0; i < Player3PS4PFI.Length; i++)
            {
                Player4PS4PFI[i].SetActive(false);
            }
        }
        if (DN_PlayerMovement.DualController)
        {
            RedImage.SetActive(true);
            OrangeImage.SetActive(true);
            BlueImage.SetActive(false);
            GreenImage.SetActive(false);
            if (therePrison)
            {
                for (int i = 0; i < KeyboardPFI.Length; i++)
                {
                    KeyboardPFI[i].SetActive(false);
                }
                if (DN_MainMenuMannager.Ps4)
                {
                    for (int i = 0; i < ControllerPFI.Length; i++)
                    {
                        ControllerPFI[i].SetActive(true);
                    }
                    for (int i = 0; i < XboxControllerPFI.Length; i++)
                    {
                        XboxControllerPFI[i].SetActive(false);
                    }
                }
                if (DN_MainMenuMannager.Xbox)
                {
                    for (int i = 0; i < XboxControllerPFI.Length; i++)
                    {
                        XboxControllerPFI[i].SetActive(true);
                    }
                    for (int i = 0; i < ControllerPFI.Length; i++)
                    {
                        ControllerPFI[i].SetActive(false);
                    }
                }
            }
            for (int i = 0; i < Player1KeyboardPFI.Length; i++)
            {
                Player1KeyboardPFI[i].SetActive(false);
            }
            for (int i = 0; i < Player1PS4PFI.Length; i++)
            {
                Player1PS4PFI[i].SetActive(false);
            }
            for (int i = 0; i < Player2PS4PFI.Length; i++)
            {
                Player2PS4PFI[i].SetActive(true);
            }
            for (int i = 0; i < Player3PS4PFI.Length; i++)
            {
                Player3PS4PFI[i].SetActive(false);
            }
            for (int i = 0; i < Player3PS4PFI.Length; i++)
            {
                Player4PS4PFI[i].SetActive(false);
            }
        }
        if(DN_PlayerMovement.ThreeController)
        {
            RedImage.SetActive(true);
            OrangeImage.SetActive(true);
            BlueImage.SetActive(true);
            GreenImage.SetActive(false);
            if (therePrison)
            {
                for (int i = 0; i < KeyboardPFI.Length; i++)
                {
                    KeyboardPFI[i].SetActive(false);
                }
                if (DN_MainMenuMannager.Ps4)
                {
                    for (int i = 0; i < ControllerPFI.Length; i++)
                    {
                        ControllerPFI[i].SetActive(true);
                    }
                    for (int i = 0; i < XboxControllerPFI.Length; i++)
                    {
                        XboxControllerPFI[i].SetActive(false);
                    }
                }
                if (DN_MainMenuMannager.Xbox)
                {
                    for (int i = 0; i < XboxControllerPFI.Length; i++)
                    {
                        XboxControllerPFI[i].SetActive(true);
                    }
                    for (int i = 0; i < ControllerPFI.Length; i++)
                    {
                        ControllerPFI[i].SetActive(false);
                    }
                }
            }
            for (int i = 0; i < Player1KeyboardPFI.Length; i++)
            {
                Player1KeyboardPFI[i].SetActive(false);
            }
            for (int i = 0; i < Player1PS4PFI.Length; i++)
            {
                Player1PS4PFI[i].SetActive(false);
            }
            for (int i = 0; i < Player2PS4PFI.Length; i++)
            {
                Player2PS4PFI[i].SetActive(false);
            }
            for (int i = 0; i < Player3PS4PFI.Length; i++)
            {
                Player3PS4PFI[i].SetActive(true);
            }
            for (int i = 0; i < Player3PS4PFI.Length; i++)
            {
                Player4PS4PFI[i].SetActive(false);
            }
        }
        if(DN_PlayerMovement.FourController)
        {
            RedImage.SetActive(true);
            OrangeImage.SetActive(true);
            BlueImage.SetActive(true);
            GreenImage.SetActive(true);
            if (therePrison)
            {
                for (int i = 0; i < KeyboardPFI.Length; i++)
                {
                    KeyboardPFI[i].SetActive(false);
                }
                if (DN_MainMenuMannager.Ps4)
                {
                    for (int i = 0; i < ControllerPFI.Length; i++)
                    {
                        ControllerPFI[i].SetActive(true);
                    }
                    for (int i = 0; i < XboxControllerPFI.Length; i++)
                    {
                        XboxControllerPFI[i].SetActive(false);
                    }

                }
                if (DN_MainMenuMannager.Xbox)
                {
                    for (int i = 0; i < XboxControllerPFI.Length; i++)
                    {
                        XboxControllerPFI[i].SetActive(true);
                    }
                    for (int i = 0; i < ControllerPFI.Length; i++)
                    {
                        ControllerPFI[i].SetActive(false);
                    }
                }
            }
            for (int i = 0; i < Player1KeyboardPFI.Length; i++)
            {
                Player1KeyboardPFI[i].SetActive(false);
            }
            for (int i = 0; i < Player1PS4PFI.Length; i++)
            {
                Player1PS4PFI[i].SetActive(false);
            }
            for (int i = 0; i < Player2PS4PFI.Length; i++)
            {
                Player2PS4PFI[i].SetActive(false);
            }
            for (int i = 0; i < Player3PS4PFI.Length; i++)
            {
                Player3PS4PFI[i].SetActive(false);
            }
            for (int i = 0; i < Player4PS4PFI.Length; i++)
            {
                Player4PS4PFI[i].SetActive(true);
            }
        }
        if (SquareHome && OHome && XHome && TriangleHome)
        {
            DefeatScreen.SetActive(false);
            VictoryScreen.SetActive(true);
            Time.timeScale = 0;
        }
        if(timescripts.Timer <= 0)
        {
            DefeatScreen.SetActive(true);
            VictoryScreen.SetActive(false);
            Time.timeScale = 0;
        }
        if(Death == true)
        {
            DefeatScreen.SetActive(true);
            VictoryScreen.SetActive(false);
            Time.timeScale = 0;
        }

	}
    public void Ok()
    {
        Time.timeScale = 1;
        ObjectiveIndicator.SetActive(false);
    }
    public void Restart()
    { 
        Time.timeScale = 1;
        SquareHome = false;
        XHome = false;
        OHome = false;
        TriangleHome = false;
        Death = false;
        SceneManager.LoadScene(RestartSceneNumber);
    }
    public void NextLevel()
    {
        SceneManager.LoadScene(NextLevelNumber);
        SquareHome = false;
        XHome = false;
        OHome = false;
        TriangleHome = false;
        Death = false;
    }
    public void MainMenu()
    {
        DN_PlayerMovement.SoloKeyBoard = false;
        DN_PlayerMovement.UsbExtender = false;
        DN_PlayerMovement.SoloController = false;
        DN_PlayerMovement.DualController = false;
        DN_PlayerMovement.ThreeController = false;
        DN_PlayerMovement.FourController = false;
        SceneManager.LoadScene(0);
        SquareHome = false;
        XHome = false;
        OHome = false;
        TriangleHome = false;
        Death = false;
        DN_MainMenuMannager.PC = false;
        DN_MainMenuMannager.Ps4 = false;
        DN_MainMenuMannager.Xbox = false;
    }
    public void PreviousScene()
    { 
        SceneManager.LoadScene(PreviousSceneNumber);
        SquareHome = false;
        XHome = false;
        OHome = false;
        TriangleHome = false;
        Death = false;
    }
}
