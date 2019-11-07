using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
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
   // public GameObject Style;
  //  private DN_Transition Transcripts;
    public bool StartNow;
    public bool CreditNow;
    public bool BackNow;
    public bool P1Now;
    public bool P2Now;
    public bool P3Now;
    public bool P4Now;
    public bool ContinueNow;
    public bool Ps4BeginNow;
    public bool XboxBeginNow;
    public bool Ps4BeginNowSolo;
    public bool XboxBeginNowSolo;
    public bool LevelSelectNow;
    public GameObject LevelsSelector;
    public Text LevelText;
    public string LevelsNumber;
    private float LevelsIndicator;
    public GameObject[] LevelsImage;
    public GameObject[] LevelSelectorButtons;
    private int MenuPhase;
    public GameObject LoadingScreen;
    public GameObject ClickButton;
    public Slider slider;
    public Text ProgressText;
    public AudioSource ClickSound;
    //public GameObject RightDoor;
    //public GameObject LeftDoor;
    //private DN_DoorTransition RightDoorScript;
    //private DN_DoorTransition LeftDoorScript;
    // Use this for initialization
    void Start () {
     //   Transcripts = Style.GetComponent<DN_Transition>();
        //RightDoorScript = RightDoor.GetComponent<DN_DoorTransition>();
        //LeftDoorScript = LeftDoor.GetComponent<DN_DoorTransition>();
	}
	
	// Update is called once per frame
	void Update () {
        if(LevelsIndicator <0)
        {
            LevelsIndicator = 0;
        }
        if(LevelsIndicator >14)
        {
            LevelsIndicator = 14;
        }
        //if(StartNow)
        //{
        //    //if (Transcripts.TransitionStart)
        //    //{
        //        backButton.SetActive(true);
        //        for (int i = 0; i < MainMenuButtons.Length; i++)
        //        {
        //            MainMenuButtons[i].SetActive(false);
        //        }
        //        for (int i = 0; i < PlayerActivate.Length; i++)
        //        {
        //            PlayerActivate[i].SetActive(true);
        //        }
        //        PlayerActivate[0].GetComponent<Button>().enabled = true;
        //        PlayerActivate[1].GetComponent<Button>().enabled = true;
        //        PlayerActivate[2].GetComponent<Button>().enabled = true;
        //        PlayerActivate[3].GetComponent<Button>().enabled = true;
        //        backButton.GetComponent<Button>().enabled = true;
        //        //Transcripts.TransitionStart = false;
        //        StartNow = false;
        //    //}
        //}
        //if(CreditNow)
        //{
        //    //if(Transcripts.TransitionStart)
        //    //{
        //        for (int i = 0; i < Credits.Length; i++)
        //        {
        //            Credits[i].SetActive(true);
        //        }
        //        backButton.SetActive(true);
        //        for (int i = 0; i < MainMenuButtons.Length; i++)
        //        {
        //            MainMenuButtons[i].SetActive(false);
        //        }
        //        PlayerActivate[0].GetComponent<Button>().enabled = true;
        //        PlayerActivate[1].GetComponent<Button>().enabled = true;
        //        PlayerActivate[2].GetComponent<Button>().enabled = true;
        //        PlayerActivate[3].GetComponent<Button>().enabled = true;
        //        backButton.GetComponent<Button>().enabled = true;
        //        //Transcripts.TransitionStart = false;
        //        CreditNow = false;
        //    //}
        //}
        //if(BackNow)
        //{
        //    //if(Transcripts.TransitionStart)
        //    //{
        //        for (int i = 0; i < Credits.Length; i++)
        //        {
        //            Credits[i].SetActive(false);
        //        }
        //        for (int i = 0; i < MainMenuButtons.Length; i++)
        //        {
        //            MainMenuButtons[i].SetActive(true);
        //        }
        //        for (int i = 0; i < PlayerActivate.Length; i++)
        //        {
        //            PlayerActivate[i].SetActive(false);
        //        }
        //        for (int i = 0; i < USbOption.Length; i++)
        //        {
        //            USbOption[i].SetActive(false);
        //        }
        //        for (int i = 0; i < Mode.Length; i++)
        //        {
        //            Mode[i].SetActive(false);
        //        }
        //        LevelsSelector.SetActive(false);
        //        MainMenuButtons[0].GetComponent<Button>().enabled = true;
        //        MainMenuButtons[1].GetComponent<Button>().enabled = true;
        //        MainMenuButtons[2].GetComponent<Button>().enabled = true;
        //        //PlayerActivate[0].GetComponent<Button>().enabled = true;
        //        //PlayerActivate[1].GetComponent<Button>().enabled = true;
        //        //PlayerActivate[2].GetComponent<Button>().enabled = true;
        //        //PlayerActivate[3].GetComponent<Button>().enabled = true;
        //        //Mode[1].GetComponent<Button>().enabled = true;
        //        //Mode[2].GetComponent<Button>().enabled = true;
        //        //USbOption[0].GetComponent<Button>().enabled = true;
        //        //USbOption[1].GetComponent<Button>().enabled = true;
        //        //Credits[0].GetComponent<Button>().enabled = true;
        //        //backButton.GetComponent<Button>().enabled = true;
        //        //KeyBoard.GetComponent<Button>().enabled = true;
        //        //Ps4Controller.GetComponent<Button>().enabled = true;
        //        //XboxController.GetComponent<Button>().enabled = true;
        //        //Ps4ControllerSolo.GetComponent<Button>().enabled = true;
        //        //XboxControllerSolo.GetComponent<Button>().enabled = true;
        //        //LevelsSelector.GetComponent<Button>().enabled = true;
        //        //LevelSelectorButtons[0].GetComponent<Button>().enabled = true;
        //        //LevelSelectorButtons[1].GetComponent<Button>().enabled = true;
        //        //LevelSelectorButtons[2].GetComponent<Button>().enabled = true;
        //        DN_PlayerMovement.UsbExtender = false;
        //        DN_PlayerMovement.SoloController = false;
        //        DN_PlayerMovement.DualController = false;
        //        DN_PlayerMovement.ThreeController = false;
        //        DN_PlayerMovement.FourController = false;
        //        DN_PlayerMovement.SoloKeyBoard = false;
        //        Ps4ControllerSolo.SetActive(false);
        //        XboxControllerSolo.SetActive(false);
        //        KeyBoard.SetActive(false);
        //        Ps4Controller.SetActive(false);
        //        XboxController.SetActive(false);
        //        backButton.SetActive(false);
        //        Ps4 = false;
        //        Xbox = false;
        //        PC = false;
        //        Scenarios = false;
        //        //Transcripts.TransitionStart = false;
        //        BackNow = false;
        //    //}
        //}
        //if(P1Now)
        //{
        //    //if(Transcripts.TransitionStart)
        //    //{
        //        DN_PlayerMovement.SoloController = true;
        //        DN_PlayerMovement.DualController = false;
        //        DN_PlayerMovement.ThreeController = false;
        //        DN_PlayerMovement.FourController = false;
        //        for (int i = 0; i < PlayerActivate.Length; i++)
        //        {
        //            PlayerActivate[i].SetActive(false);
        //        }
        //        KeyBoard.SetActive(true);
        //        Ps4ControllerSolo.SetActive(true);
        //        XboxControllerSolo.SetActive(true);
        //        KeyBoard.GetComponent<Button>().enabled = true;
        //        Ps4ControllerSolo.GetComponent<Button>().enabled = true;
        //        XboxControllerSolo.GetComponent<Button>().enabled = true;
        //        backButton.GetComponent<Button>().enabled = true;
        //        //Transcripts.TransitionStart = false;
        //        P1Now = false;
        //    //}
        //}
        //if(P2Now)
        //{
        //    //if(Transcripts.TransitionStart)
        //    //{
               
        //        DN_PlayerMovement.SoloController = false;
        //        DN_PlayerMovement.DualController = true;
        //        DN_PlayerMovement.ThreeController = false;
        //        DN_PlayerMovement.FourController = false;
        //        for (int i = 0; i < PlayerActivate.Length; i++)
        //        {
        //            PlayerActivate[i].SetActive(false);
        //        }
        //        for (int i = 0; i < Mode.Length; i++)
        //        {
        //            Mode[i].SetActive(true);
        //        }
        //        backButton.GetComponent<Button>().enabled = true;
        //        Mode[1].GetComponent<Toggle>().enabled = true;
        //        Mode[2].GetComponent<Button>().enabled = true;
        //        //Transcripts.TransitionStart = false;
        //        P2Now = false;
        //    //}
        //}
        //if(P3Now)
        //{
        //    //if(Transcripts.TransitionStart)
        //    //{
              
        //        DN_PlayerMovement.SoloController = false;
        //        DN_PlayerMovement.DualController = false;
        //        DN_PlayerMovement.ThreeController = true;
        //        DN_PlayerMovement.FourController = false;
        //        for (int i = 0; i < PlayerActivate.Length; i++)
        //        {
        //            PlayerActivate[i].SetActive(false);
        //        }

        //        for (int i = 0; i < Mode.Length; i++)
        //        {
        //            Mode[i].SetActive(true);
        //        }
        //        Mode[1].GetComponent<Toggle>().enabled = true;
        //        Mode[2].GetComponent<Button>().enabled = true;
        //        backButton.GetComponent<Button>().enabled = true;
        //        //Transcripts.TransitionStart = false;
        //        P3Now = false;
        //    //}
        //}
        //if(P4Now)
        //{
        //    //if(Transcripts.TransitionStart)
        //    //{   
        //        DN_PlayerMovement.SoloController = false;
        //        DN_PlayerMovement.DualController = false;
        //        DN_PlayerMovement.ThreeController = false;
        //        DN_PlayerMovement.FourController = true;
        //        for (int i = 0; i < PlayerActivate.Length; i++)
        //        {
        //            PlayerActivate[i].SetActive(false);
        //        }

        //        for (int i = 0; i < Mode.Length; i++)
        //        {
        //            Mode[i].SetActive(true);
        //        }
        //        backButton.GetComponent<Button>().enabled = true;
        //        Mode[1].GetComponent<Toggle>().enabled = true;
        //        Mode[2].GetComponent<Button>().enabled = true;
        //        //Transcripts.TransitionStart = false;
        //        P4Now = false;
        //    //}
        //}
        //if(ContinueNow)
        //{
        //    //if(Transcripts.TransitionStart)
        //    //{
        //        for (int i = 0; i < Mode.Length; i++)
        //        {
        //            Mode[i].SetActive(false);
        //        }
        //        KeyBoard.SetActive(false);
        //        Ps4Controller.SetActive(true);
        //        XboxController.SetActive(true);
        //        Ps4Controller.GetComponent<Button>().enabled = true;
        //        XboxController.GetComponent<Button>().enabled = true;
        //        backButton.GetComponent<Button>().enabled = true;
        //        //Transcripts.TransitionStart = false;
        //        ContinueNow = false;
        //    //}
        //}
        //if(Ps4BeginNow)
        //{
        //    //if (Transcripts.TransitionStart)
        //    //{
        //        Ps4 = true;
        //        KeyBoard.SetActive(false);
        //        Ps4Controller.SetActive(false);
        //        XboxController.SetActive(false);
        //        for (int i = 0; i < USbOption.Length; i++)
        //        {
        //            USbOption[i].SetActive(true);
        //        }
        //        USbOption[1].GetComponent<Button>().enabled = true;
        //        USbOption[2].GetComponent<Button>().enabled = true;
        //        Ps4BeginNow = false;
        //        //Transcripts.TransitionStart = false;
        //        backButton.GetComponent<Button>().enabled = true;
        //    //}
        //}
        ////if(Ps4BeginNowSolo)W
        ////{
        ////    if(Transcripts.TransitionStart)
        ////    {
        ////        Ps4 = true;
        ////        DN_PlayerMovement.SoloController = true;
        ////        DN_PlayerMovement.UsbExtender = false;
        ////        DN_PlayerMovement.SoloKeyBoard = false;
        ////        LevelSelectNow = true;
        ////        Ps4BeginNowSolo = false;
        ////        Transcripts.TransitionStart = false;
        ////    }
        ////}
        //if(XboxBeginNow)
        //{
        //    //if (Transcripts.TransitionStart)
        //    //{
        //        Xbox = true;
        //        KeyBoard.SetActive(false);
        //        Ps4Controller.SetActive(false);
        //        XboxController.SetActive(false);
        //        for (int i = 0; i < USbOption.Length; i++)
        //        {
        //            USbOption[i].SetActive(true);
        //        }
        //        USbOption[1].GetComponent<Button>().enabled = true;
        //        USbOption[2].GetComponent<Button>().enabled = true;
        //        backButton.GetComponent<Button>().enabled = true;
        //        XboxBeginNow = false;
        //        //Transcripts.TransitionStart = false;
        //    //}
        //}
        //if(LevelSelectNow)
        //{
        //    //if(Transcripts.TransitionStart)
        //    //{
        //        LevelSelectorButtons[0].GetComponent<Button>().enabled = true;
        //        LevelSelectorButtons[1].GetComponent<Button>().enabled = true;
        //        LevelSelectorButtons[2].GetComponent<Button>().enabled = true;
        //        backButton.GetComponent<Button>().enabled = true;
        //        KeyBoard.SetActive(false);
        //        Ps4ControllerSolo.SetActive(false);
        //        XboxControllerSolo.SetActive(false);
        //        LevelsSelector.SetActive(true);
        //        for (int i = 0; i < USbOption.Length; i++)
        //        {
        //            USbOption[i].SetActive(false);
        //        }
        //        //Transcripts.TransitionStart = false;
        //        LevelSelectNow = false;  
        //    //}
        //}
        if(LevelsIndicator == 0)
        {
            LevelText.text = LevelsNumber;
            LevelsImage[0].SetActive(true);
            LevelsImage[1].SetActive(false);
            LevelsImage[2].SetActive(false);
            LevelsImage[3].SetActive(false);
            LevelsImage[4].SetActive(false);
            LevelsImage[5].SetActive(false);
            LevelsImage[6].SetActive(false);
            LevelsImage[7].SetActive(false);
            LevelsImage[8].SetActive(false);
            LevelsImage[9].SetActive(false);
            LevelsImage[10].SetActive(false);
            LevelsImage[11].SetActive(false);
            LevelsImage[12].SetActive(false);
            LevelsImage[13].SetActive(false);
            LevelsNumber = "Level 1";
        }
        if (LevelsIndicator == 1)
        {
            LevelText.text = LevelsNumber;
            LevelsImage[0].SetActive(false);
            LevelsImage[1].SetActive(true);
            LevelsImage[2].SetActive(false);
            LevelsImage[3].SetActive(false);
            LevelsImage[4].SetActive(false);
            LevelsImage[5].SetActive(false);
            LevelsImage[6].SetActive(false);
            LevelsImage[7].SetActive(false);
            LevelsImage[8].SetActive(false);
            LevelsImage[9].SetActive(false);
            LevelsImage[10].SetActive(false);
            LevelsImage[11].SetActive(false);
            LevelsImage[12].SetActive(false);
            LevelsImage[13].SetActive(false);
            LevelsNumber = "Level 2";
        }
        if (LevelsIndicator == 2)
        {
            LevelText.text = LevelsNumber;
            LevelsImage[0].SetActive(false);
            LevelsImage[1].SetActive(false);
            LevelsImage[2].SetActive(true);
            LevelsImage[3].SetActive(false);
            LevelsImage[4].SetActive(false);
            LevelsImage[5].SetActive(false);
            LevelsImage[6].SetActive(false);
            LevelsImage[7].SetActive(false);
            LevelsImage[8].SetActive(false);
            LevelsImage[9].SetActive(false);
            LevelsImage[10].SetActive(false);
            LevelsImage[11].SetActive(false);
            LevelsImage[12].SetActive(false);
            LevelsImage[13].SetActive(false);
            LevelsNumber = "Level 3";
        }
        if (LevelsIndicator == 3)
        {
            LevelText.text = LevelsNumber;
            LevelsImage[0].SetActive(false);
            LevelsImage[1].SetActive(false);
            LevelsImage[2].SetActive(false);
            LevelsImage[3].SetActive(true);
            LevelsImage[4].SetActive(false);
            LevelsImage[5].SetActive(false);
            LevelsImage[6].SetActive(false);
            LevelsImage[7].SetActive(false);
            LevelsImage[8].SetActive(false);
            LevelsImage[9].SetActive(false);
            LevelsImage[10].SetActive(false);
            LevelsImage[11].SetActive(false);
            LevelsImage[12].SetActive(false);
            LevelsImage[13].SetActive(false);
            LevelsNumber = "Level 4";
        }
        if (LevelsIndicator == 4)
        {
            LevelText.text = LevelsNumber;
            LevelsImage[0].SetActive(false);
            LevelsImage[1].SetActive(false);
            LevelsImage[2].SetActive(false);
            LevelsImage[3].SetActive(false);
            LevelsImage[4].SetActive(true);
            LevelsImage[5].SetActive(false);
            LevelsImage[6].SetActive(false);
            LevelsImage[7].SetActive(false);
            LevelsImage[8].SetActive(false);
            LevelsImage[9].SetActive(false);
            LevelsImage[10].SetActive(false);
            LevelsImage[11].SetActive(false);
            LevelsImage[12].SetActive(false);
            LevelsImage[13].SetActive(false);
            LevelsNumber = "Level 5";
        }
        if (LevelsIndicator == 5)
        {
            LevelText.text = LevelsNumber;
            LevelsImage[0].SetActive(false);
            LevelsImage[1].SetActive(false);
            LevelsImage[2].SetActive(false);
            LevelsImage[3].SetActive(false);
            LevelsImage[4].SetActive(false);
            LevelsImage[5].SetActive(true);
            LevelsImage[6].SetActive(false);
            LevelsImage[7].SetActive(false);
            LevelsImage[8].SetActive(false);
            LevelsImage[9].SetActive(false);
            LevelsImage[10].SetActive(false);
            LevelsImage[11].SetActive(false);
            LevelsImage[12].SetActive(false);
            LevelsImage[13].SetActive(false);
            LevelsNumber = "Level 6";
        }
        if (LevelsIndicator == 6)
        {
            LevelText.text = LevelsNumber;
            LevelsImage[0].SetActive(false);
            LevelsImage[1].SetActive(false);
            LevelsImage[2].SetActive(false);
            LevelsImage[3].SetActive(false);
            LevelsImage[4].SetActive(false);
            LevelsImage[5].SetActive(false);
            LevelsImage[6].SetActive(true);
            LevelsImage[7].SetActive(false);
            LevelsImage[8].SetActive(false);
            LevelsImage[9].SetActive(false);
            LevelsImage[10].SetActive(false);
            LevelsImage[11].SetActive(false);
            LevelsImage[12].SetActive(false);
            LevelsImage[13].SetActive(false);
            LevelsNumber = "Level 7";
        }
        if (LevelsIndicator == 7)
        {
            LevelText.text = LevelsNumber;
            LevelsImage[0].SetActive(false);
            LevelsImage[1].SetActive(false);
            LevelsImage[2].SetActive(false);
            LevelsImage[3].SetActive(false);
            LevelsImage[4].SetActive(false);
            LevelsImage[5].SetActive(false);
            LevelsImage[6].SetActive(false);
            LevelsImage[7].SetActive(true);
            LevelsImage[8].SetActive(false);
            LevelsImage[9].SetActive(false);
            LevelsImage[10].SetActive(false);
            LevelsImage[11].SetActive(false);
            LevelsImage[12].SetActive(false);
            LevelsImage[13].SetActive(false);
            LevelsNumber = "Level 8";
        }
        if (LevelsIndicator == 8)
        {
            LevelText.text = LevelsNumber;
            LevelsImage[0].SetActive(false);
            LevelsImage[1].SetActive(false);
            LevelsImage[2].SetActive(false);
            LevelsImage[3].SetActive(false);
            LevelsImage[4].SetActive(false);
            LevelsImage[5].SetActive(false);
            LevelsImage[6].SetActive(false);
            LevelsImage[7].SetActive(false);
            LevelsImage[8].SetActive(true);
            LevelsImage[9].SetActive(false);
            LevelsImage[10].SetActive(false);
            LevelsImage[11].SetActive(false);
            LevelsImage[12].SetActive(false);
            LevelsImage[13].SetActive(false);
            LevelsNumber = "Level 9";
        }
        if (LevelsIndicator == 9)
        {
            LevelText.text = LevelsNumber;
            LevelsImage[0].SetActive(false);
            LevelsImage[1].SetActive(false);
            LevelsImage[2].SetActive(false);
            LevelsImage[3].SetActive(false);
            LevelsImage[4].SetActive(false);
            LevelsImage[5].SetActive(false);
            LevelsImage[6].SetActive(false);
            LevelsImage[7].SetActive(false);
            LevelsImage[8].SetActive(false);
            LevelsImage[9].SetActive(true);
            LevelsImage[10].SetActive(false);
            LevelsImage[11].SetActive(false);
            LevelsImage[12].SetActive(false);
            LevelsImage[13].SetActive(false);
            LevelsNumber = "Level 10";
        }
        if (LevelsIndicator == 10)
        {
            LevelText.text = LevelsNumber;
            LevelsImage[0].SetActive(false);
            LevelsImage[1].SetActive(false);
            LevelsImage[2].SetActive(false);
            LevelsImage[3].SetActive(false);
            LevelsImage[4].SetActive(false);
            LevelsImage[5].SetActive(false);
            LevelsImage[6].SetActive(false);
            LevelsImage[7].SetActive(false);
            LevelsImage[8].SetActive(false);
            LevelsImage[9].SetActive(false);
            LevelsImage[10].SetActive(true);
            LevelsImage[11].SetActive(false);
            LevelsImage[12].SetActive(false);
            LevelsImage[13].SetActive(false);
            LevelsNumber = "Level 11";
        }
        if (LevelsIndicator == 11)
        {
            LevelText.text = LevelsNumber;
            LevelsImage[0].SetActive(false);
            LevelsImage[1].SetActive(false);
            LevelsImage[2].SetActive(false);
            LevelsImage[3].SetActive(false);
            LevelsImage[4].SetActive(false);
            LevelsImage[5].SetActive(false);
            LevelsImage[6].SetActive(false);
            LevelsImage[7].SetActive(false);
            LevelsImage[8].SetActive(false);
            LevelsImage[9].SetActive(false);
            LevelsImage[10].SetActive(false);
            LevelsImage[11].SetActive(true);
            LevelsImage[12].SetActive(false);
            LevelsImage[13].SetActive(false);
            LevelsNumber = "Level 12";
        }
        if (LevelsIndicator == 12)
        {
            LevelText.text = LevelsNumber;
            LevelsImage[0].SetActive(false);
            LevelsImage[1].SetActive(false);
            LevelsImage[2].SetActive(false);
            LevelsImage[3].SetActive(false);
            LevelsImage[4].SetActive(false);
            LevelsImage[5].SetActive(false);
            LevelsImage[6].SetActive(false);
            LevelsImage[7].SetActive(false);
            LevelsImage[8].SetActive(false);
            LevelsImage[9].SetActive(false);
            LevelsImage[10].SetActive(false);
            LevelsImage[11].SetActive(false);
            LevelsImage[12].SetActive(true);
            LevelsImage[13].SetActive(false);
            LevelsNumber = "Level 13";
        }
        if (LevelsIndicator == 13)
        {
            LevelText.text = LevelsNumber;
            LevelsImage[0].SetActive(false);
            LevelsImage[1].SetActive(false);
            LevelsImage[2].SetActive(false);
            LevelsImage[3].SetActive(false);
            LevelsImage[4].SetActive(false);
            LevelsImage[5].SetActive(false);
            LevelsImage[6].SetActive(false);
            LevelsImage[7].SetActive(false);
            LevelsImage[8].SetActive(false);
            LevelsImage[9].SetActive(false);
            LevelsImage[10].SetActive(false);
            LevelsImage[11].SetActive(false);
            LevelsImage[12].SetActive(false);
            LevelsImage[13].SetActive(true);
            LevelsNumber = "Level 14";
        }
    }
    public void LoadLevel(int sceneIndex)
    {
        StartCoroutine(LoadAsynchronously(sceneIndex));

    }
    IEnumerator LoadAsynchronously(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
        ClickButton.SetActive(false);
        LoadingScreen.SetActive(true);
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;
            ProgressText.text = progress * 99f + "%";

            yield return null;
        }
    }
    public void PressStart()
    {
        //RightDoorScript.GetComponent<Animator>().SetBool("Close", true);
        //LeftDoorScript.GetComponent<Animator>().SetBool("Open", false);
        ClickSound.Play();
        MenuPhase = 1;
        MainMenuButtons[0].GetComponent<Button>().enabled = false;
        MainMenuButtons[1].GetComponent<Button>().enabled = false;
        MainMenuButtons[2].GetComponent<Button>().enabled = false;
        StartNow = true;
       
    }
    public void AddScenario()
    {
        ClickSound.Play();
        Scenarios = !Scenarios;
    }
    public void PressContinueAfterMode()
    {
        ClickSound.Play();
        MenuPhase = 4;
        backButton.GetComponent<Button>().enabled = false;
        Mode[1].GetComponent<Toggle>().enabled = false;
        Mode[2].GetComponent<Button>().enabled = false;
        ContinueNow = true;
    }
    public void PressQuit()
    {
        ClickSound.Play();
        Application.Quit();
  
    }
    public void BackMainMenu()
    {
        ClickSound.Play();
        if (MenuPhase == 1)
        {
            PlayerActivate[0].GetComponent<Button>().enabled = false;
            PlayerActivate[1].GetComponent<Button>().enabled = false;
            PlayerActivate[2].GetComponent<Button>().enabled = false;
            PlayerActivate[3].GetComponent<Button>().enabled = false;
        }
        if(MenuPhase == 2)
        {
            Ps4ControllerSolo.GetComponent<Button>().enabled = false;
            XboxControllerSolo.GetComponent<Button>().enabled = false;
            KeyBoard.GetComponent<Button>().enabled = false;
        }
        if (MenuPhase == 3)
        {

            Mode[1].GetComponent<Toggle>().enabled = false;
            Mode[2].GetComponent<Button>().enabled = false;
        }
        if (MenuPhase == 4)
        {
            Ps4Controller.GetComponent<Button>().enabled = false;
            XboxController.GetComponent<Button>().enabled = false;
        }
        if(MenuPhase == 5)
        {
            USbOption[1].GetComponent<Button>().enabled = false;
            USbOption[2].GetComponent<Button>().enabled = false;
        }
        if(MenuPhase == 6)
        {
            LevelSelectorButtons[0].GetComponent<Button>().enabled = false;
            LevelSelectorButtons[1].GetComponent<Button>().enabled = false;
            LevelSelectorButtons[2].GetComponent<Button>().enabled = false;
        }
        backButton.GetComponent<Button>().enabled = false;
        BackNow = true;
    }
    public void PlayerOne()
    {
        ClickSound.Play();
        MenuPhase = 2;
        backButton.GetComponent<Button>().enabled = false;
        PlayerActivate[0].GetComponent<Button>().enabled = false;
        PlayerActivate[1].GetComponent<Button>().enabled = false;
        PlayerActivate[2].GetComponent<Button>().enabled = false;
        PlayerActivate[3].GetComponent<Button>().enabled = false;
        P1Now = true;
       
    }
    public void PlayerTwo()
    {
        ClickSound.Play();
        MenuPhase = 3;
        backButton.GetComponent<Button>().enabled = false;
        PlayerActivate[0].GetComponent<Button>().enabled = false;
        PlayerActivate[1].GetComponent<Button>().enabled = false;
        PlayerActivate[2].GetComponent<Button>().enabled = false;
        PlayerActivate[3].GetComponent<Button>().enabled = false;
        P2Now = true;
    }
    public void PlayerThree()
    {
        ClickSound.Play();
        MenuPhase = 3;
        backButton.GetComponent<Button>().enabled = false;
        PlayerActivate[0].GetComponent<Button>().enabled = false;
        PlayerActivate[1].GetComponent<Button>().enabled = false;
        PlayerActivate[2].GetComponent<Button>().enabled = false;
        PlayerActivate[3].GetComponent<Button>().enabled = false;
        P3Now = true;
    }
    public void PlayerFour()
    {
        ClickSound.Play();
        MenuPhase = 3;
        backButton.GetComponent<Button>().enabled = false;
        PlayerActivate[0].GetComponent<Button>().enabled = false;
        PlayerActivate[1].GetComponent<Button>().enabled = false;
        PlayerActivate[2].GetComponent<Button>().enabled = false;
        PlayerActivate[3].GetComponent<Button>().enabled = false;
        P4Now = true;
    }
    public void USBExtenderOptionPs4()
    {
        ClickSound.Play();
        backButton.GetComponent<Button>().enabled = false;
        MenuPhase = 5;
        Ps4Controller.GetComponent<Button>().enabled = false;
        XboxController.GetComponent<Button>().enabled = false;
        Ps4BeginNow = true;
       
    }
    public void USBExtenderOptionXbox()
    {
        ClickSound.Play();
        backButton.GetComponent<Button>().enabled = false;
        MenuPhase = 5;
        Ps4Controller.GetComponent<Button>().enabled = false;
        XboxController.GetComponent<Button>().enabled = false;
        XboxBeginNow = true;
    }
  
    public void GameBeginKeyBoard()
    {
        ClickSound.Play();
        MenuPhase = 6;
        backButton.GetComponent<Button>().enabled = false;
        KeyBoard.GetComponent<Button>().enabled = false;
        Ps4ControllerSolo.GetComponent<Button>().enabled = false;
        XboxControllerSolo.GetComponent<Button>().enabled = false;
        PC = true;
        DN_PlayerMovement.SoloController = false;
        DN_PlayerMovement.UsbExtender = false;
        DN_PlayerMovement.SoloKeyBoard = true;
        LevelSelectNow = true;
    }
    public void GameBeginPs4()
    {
        ClickSound.Play();
        MenuPhase = 6;
        backButton.GetComponent<Button>().enabled = false;
        KeyBoard.GetComponent<Button>().enabled = false;
        Ps4ControllerSolo.GetComponent<Button>().enabled = false;
        XboxControllerSolo.GetComponent<Button>().enabled = false;
        DN_PlayerMovement.SoloController = true;
        DN_PlayerMovement.UsbExtender = false;
        DN_PlayerMovement.SoloKeyBoard = false;
        Ps4 = true;
        LevelSelectNow = true;

    }
    public void GameBeginXbox()
    {
        ClickSound.Play();
        MenuPhase = 6;
        backButton.GetComponent<Button>().enabled = false;
        KeyBoard.GetComponent<Button>().enabled = false;
        Ps4ControllerSolo.GetComponent<Button>().enabled = false;
        XboxControllerSolo.GetComponent<Button>().enabled = false;
        Xbox = true;
        DN_PlayerMovement.SoloController = true;
        DN_PlayerMovement.UsbExtender = false;
        DN_PlayerMovement.SoloKeyBoard = false;
        LevelSelectNow = true;
    }
    public void YesUsbExtender()
    {
        ClickSound.Play();
        MenuPhase = 6;
        backButton.GetComponent<Button>().enabled = false;
        USbOption[1].GetComponent<Button>().enabled = false;
        USbOption[2].GetComponent<Button>().enabled = false;
        DN_PlayerMovement.SoloKeyBoard = false;
        DN_PlayerMovement.UsbExtender = true;
        LevelSelectNow = true;
    }
    public void NoUsbExtender()
    {
        ClickSound.Play();
        MenuPhase = 6;
        backButton.GetComponent<Button>().enabled = false;
        USbOption[1].GetComponent<Button>().enabled = false;
        USbOption[2].GetComponent<Button>().enabled = false;
        DN_PlayerMovement.SoloKeyBoard = false;
        DN_PlayerMovement.UsbExtender = false;
        LevelSelectNow = true;
    }
    public void StartGame()
    {
        ClickSound.Play();
        SceneManager.LoadScene(1);
    }
    public void AddLevel()
    {
        ClickSound.Play();
        LevelsIndicator += 1;
    }
    public void ReduceLevel()
    {
        ClickSound.Play();
        LevelsIndicator -= 1;
    }
    public void Credit()
    {
        ClickSound.Play();
        MenuPhase = 1;
        MainMenuButtons[0].GetComponent<Button>().enabled = false;
        MainMenuButtons[1].GetComponent<Button>().enabled = false;
        MainMenuButtons[2].GetComponent<Button>().enabled = false;
        CreditNow = true;
    }
    public void Quit()
    {
        ClickSound.Play();
        Application.Quit();
    }
    
}
