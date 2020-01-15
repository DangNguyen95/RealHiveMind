using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DN_DoorTransition : MonoBehaviour {
    public GameObject OtherDoor;
    public bool ThisDoor;
    public bool ThatDoor;
    private DN_DoorTransition DoorScripts;
    public GameObject DoorClose;
    public bool ThisCloseDoor;
    public GameObject RightDoor;
    public GameObject LeftDoor;
    private DN_DoorTransition LeftdoorScript;
    private DN_DoorTransition RightdoorScript;
    public bool ReOpen;
    public GameObject Manager;
    private DN_MainMenuMannager MenuScript;
	// Use this for initialization
	void Start () {
        MenuScript = Manager.GetComponent<DN_MainMenuMannager>();
        if (ThisCloseDoor == false)
        {
            DoorScripts = OtherDoor.GetComponent<DN_DoorTransition>();
            //gameObject.GetComponent<Animator>().SetBool("Close", true);
            //gameObject.GetComponent<Animator>().SetBool("Open", false);
        }
        if(ThisCloseDoor)
        {
            LeftdoorScript = LeftDoor.GetComponent<DN_DoorTransition>();
            RightdoorScript = RightDoor.GetComponent<DN_DoorTransition>();
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (ThisCloseDoor == false && ReOpen == false)
        {
            ThatDoor = DoorScripts.ThisDoor;
        }
        if (ThisDoor && ThatDoor && ThisCloseDoor == false && ReOpen == false)
        {
            DoorClose.SetActive(true);
            
            gameObject.SetActive(false);
        }
        if(ReOpen)
        {
            gameObject.GetComponent<Animator>().SetBool("Open", true);
            gameObject.GetComponent<Animator>().SetBool("Close", false);
            ReOpen = false;
        }

    }
    public void ThisDoorActivate()
    {
        ThisDoor = true;
    }
    public void ActivateClosing()
    {
        gameObject.GetComponent<Animator>().SetBool("Close", true);
        gameObject.GetComponent<Animator>().SetBool("Open", false);
    }
    public void OpenThemDoor()
    {
       
        LeftdoorScript.ThisDoor = false;
        LeftdoorScript.ThatDoor = false;
        RightdoorScript.ThisDoor = false;
        RightdoorScript.ThatDoor = false;
        LeftdoorScript.ReOpen = true;
        RightdoorScript.ReOpen = true;
        RightDoor.SetActive(true);
        LeftDoor.SetActive(true);
      
        gameObject.SetActive(false);
    }
    public void TriggerButton()
    {
        if(MenuScript.StartNow)
        {
          MenuScript.backButton.SetActive(true);
            for (int i = 0; i < MenuScript.MainMenuButtons.Length; i++)
            {
                MenuScript.MainMenuButtons[i].SetActive(false);
            }
            for (int i = 0; i < MenuScript.PlayerActivate.Length; i++)
            {
                MenuScript.PlayerActivate[i].SetActive(true);
            }
            MenuScript.PlayerActivate[0].GetComponent<Button>().enabled = true;
            MenuScript.PlayerActivate[1].GetComponent<Button>().enabled = true;
            MenuScript.PlayerActivate[2].GetComponent<Button>().enabled = true;
            MenuScript.PlayerActivate[3].GetComponent<Button>().enabled = true;
            MenuScript.backButton.GetComponent<Button>().enabled = true;
            //Transcripts.TransitionStart = false;
            MenuScript.StartNow = false;
        }
        if (MenuScript.CreditNow)
        {
           
            for (int i = 0; i < MenuScript.Credits.Length; i++)
            {
                MenuScript.Credits[i].SetActive(true);
            }
            MenuScript.backButton.SetActive(true);
            for (int i = 0; i < MenuScript.MainMenuButtons.Length; i++)
            {
                MenuScript.MainMenuButtons[i].SetActive(false);
            }
            MenuScript.PlayerActivate[0].GetComponent<Button>().enabled = true;
            MenuScript.PlayerActivate[1].GetComponent<Button>().enabled = true;
            MenuScript.PlayerActivate[2].GetComponent<Button>().enabled = true;
            MenuScript.PlayerActivate[3].GetComponent<Button>().enabled = true;
            MenuScript.backButton.GetComponent<Button>().enabled = true;

            MenuScript.CreditNow = false;
           
        }
        if (MenuScript.BackNow)
        {
         
            for (int i = 0; i < MenuScript.Credits.Length; i++)
            {
                MenuScript.Credits[i].SetActive(false);
            }
            for (int i = 0; i < MenuScript.MainMenuButtons.Length; i++)
            {
                MenuScript.MainMenuButtons[i].SetActive(true);
            }
            for (int i = 0; i < MenuScript.PlayerActivate.Length; i++)
            {
                MenuScript.PlayerActivate[i].SetActive(false);
            }
            for (int i = 0; i < MenuScript.USbOption.Length; i++)
            {
                MenuScript.USbOption[i].SetActive(false);
            }
            for (int i = 0; i < MenuScript.Mode.Length; i++)
            {
                MenuScript.Mode[i].SetActive(false);
            }
            MenuScript.LevelsSelector.SetActive(false);
            MenuScript.MainMenuButtons[0].GetComponent<Button>().enabled = true;
            MenuScript.MainMenuButtons[1].GetComponent<Button>().enabled = true;
            MenuScript.MainMenuButtons[2].GetComponent<Button>().enabled = true;
            DN_PlayerMovement.UsbExtender = false;
            DN_PlayerMovement.SoloController = false;
            DN_PlayerMovement.DualController = false;
            DN_PlayerMovement.ThreeController = false;
            DN_PlayerMovement.FourController = false;
            DN_PlayerMovement.SoloKeyBoard = false;
            MenuScript.Ps4ControllerSolo.SetActive(false);
            MenuScript.XboxControllerSolo.SetActive(false);
            MenuScript.KeyBoard.SetActive(false);
            MenuScript.Ps4Controller.SetActive(false);
            MenuScript.XboxController.SetActive(false);
            MenuScript.backButton.SetActive(false);
            DN_MainMenuMannager.Ps4 = false;
            DN_MainMenuMannager.Xbox = false;
            DN_MainMenuMannager.PC = false;
            DN_MainMenuMannager.Scenarios = false;
            MenuScript.BlooperLevelsSelector.SetActive(false);
            MenuScript.BackNow = false;
          
        }
        if (MenuScript.P1Now)
        {
           
            DN_PlayerMovement.SoloController = true;
            DN_PlayerMovement.DualController = false;
            DN_PlayerMovement.ThreeController = false;
            DN_PlayerMovement.FourController = false;
            for (int i = 0; i < MenuScript.PlayerActivate.Length; i++)
            {
                MenuScript.PlayerActivate[i].SetActive(false);
            }
            MenuScript.KeyBoard.SetActive(true);
            MenuScript.Ps4ControllerSolo.SetActive(true);
            MenuScript.XboxControllerSolo.SetActive(true);
            MenuScript.KeyBoard.GetComponent<Button>().enabled = true;
            MenuScript.Ps4ControllerSolo.GetComponent<Button>().enabled = true;
            MenuScript.XboxControllerSolo.GetComponent<Button>().enabled = true;
            MenuScript.backButton.GetComponent<Button>().enabled = true;
           
            MenuScript.P1Now = false;
          
        }
        if (MenuScript.P2Now)
        {
           

            DN_PlayerMovement.SoloController = false;
            DN_PlayerMovement.DualController = true;
            DN_PlayerMovement.ThreeController = false;
            DN_PlayerMovement.FourController = false;
            for (int i = 0; i < MenuScript.PlayerActivate.Length; i++)
            {
                MenuScript.PlayerActivate[i].SetActive(false);
            }
            for (int i = 0; i < MenuScript.Mode.Length; i++)
            {
                MenuScript.Mode[i].SetActive(true);
            }
            MenuScript.backButton.GetComponent<Button>().enabled = true;
            MenuScript.Mode[1].GetComponent<Toggle>().enabled = true;
            MenuScript.Mode[2].GetComponent<Button>().enabled = true;
          
            MenuScript.P2Now = false;
         
        }
        if (MenuScript.P3Now)
        {
            

            DN_PlayerMovement.SoloController = false;
            DN_PlayerMovement.DualController = false;
            DN_PlayerMovement.ThreeController = true;
            DN_PlayerMovement.FourController = false;
            for (int i = 0; i < MenuScript.PlayerActivate.Length; i++)
            {
                MenuScript.PlayerActivate[i].SetActive(false);
            }

            for (int i = 0; i < MenuScript.Mode.Length; i++)
            {
                MenuScript.Mode[i].SetActive(true);
            }
            MenuScript.Mode[1].GetComponent<Toggle>().enabled = true;
            MenuScript.Mode[2].GetComponent<Button>().enabled = true;
            MenuScript.backButton.GetComponent<Button>().enabled = true;
           
            MenuScript.P3Now = false;
         
        }
        if (MenuScript.P4Now)
        {
      
            DN_PlayerMovement.SoloController = false;
            DN_PlayerMovement.DualController = false;
            DN_PlayerMovement.ThreeController = false;
            DN_PlayerMovement.FourController = true;
            for (int i = 0; i < MenuScript.PlayerActivate.Length; i++)
            {
                MenuScript.PlayerActivate[i].SetActive(false);
            }

            for (int i = 0; i < MenuScript.Mode.Length; i++)
            {
                MenuScript.Mode[i].SetActive(true);
            }
            MenuScript.backButton.GetComponent<Button>().enabled = true;
            MenuScript.Mode[1].GetComponent<Toggle>().enabled = true;
            MenuScript.Mode[2].GetComponent<Button>().enabled = true;
         
            MenuScript.P4Now = false;

        }
        if (MenuScript.ContinueNow)
        {
     
            for (int i = 0; i < MenuScript.Mode.Length; i++)
            {
                MenuScript.Mode[i].SetActive(false);
            }
            MenuScript.KeyBoard.SetActive(false);
            MenuScript.Ps4Controller.SetActive(true);
            MenuScript.XboxController.SetActive(true);
            MenuScript.Ps4Controller.GetComponent<Button>().enabled = true;
            MenuScript.XboxController.GetComponent<Button>().enabled = true;
            MenuScript.backButton.GetComponent<Button>().enabled = true;
       
            MenuScript.ContinueNow = false;
 
        }
        if (MenuScript.Ps4BeginNow)
        {
        
            DN_MainMenuMannager.Ps4 = true;
            MenuScript.KeyBoard.SetActive(false);
            MenuScript.Ps4Controller.SetActive(false);
            MenuScript.XboxController.SetActive(false);
            for (int i = 0; i < MenuScript.USbOption.Length; i++)
            {
                MenuScript.USbOption[i].SetActive(true);
            }
            MenuScript.USbOption[1].GetComponent<Button>().enabled = true;
            MenuScript.USbOption[2].GetComponent<Button>().enabled = true;
            MenuScript.Ps4BeginNow = false;
            
            MenuScript.backButton.GetComponent<Button>().enabled = true;
        
        }
      
        if (MenuScript.XboxBeginNow)
        {

            MenuScript.KeyBoard.SetActive(false);
            MenuScript.Ps4Controller.SetActive(false);
            MenuScript.XboxController.SetActive(false);
            for (int i = 0; i < MenuScript.USbOption.Length; i++)
            {
                MenuScript.USbOption[i].SetActive(true);
            }
            MenuScript.USbOption[1].GetComponent<Button>().enabled = true;
            MenuScript.USbOption[2].GetComponent<Button>().enabled = true;
            MenuScript.backButton.GetComponent<Button>().enabled = true;
            MenuScript.XboxBeginNow = false;
            
        }
        if (MenuScript.LevelSelectNow)
        {
          
            MenuScript.LevelSelectorButtons[0].GetComponent<Button>().enabled = true;
            MenuScript.LevelSelectorButtons[1].GetComponent<Button>().enabled = true;
            MenuScript.LevelSelectorButtons[2].GetComponent<Button>().enabled = true;
            MenuScript.backButton.GetComponent<Button>().enabled = true;
            MenuScript.KeyBoard.SetActive(false);
            MenuScript.Ps4ControllerSolo.SetActive(false);
            MenuScript.XboxControllerSolo.SetActive(false);
            MenuScript.LevelsSelector.SetActive(true);
            for (int i = 0; i < MenuScript.USbOption.Length; i++)
            {
                MenuScript.USbOption[i].SetActive(false);
            }
           
            MenuScript.LevelSelectNow = false;
           
        }
        if(MenuScript.BlooperLevelSelectNow)
        {
            MenuScript.BlooperLevelSelectorButtons[0].GetComponent<Button>().enabled = true;
            MenuScript.BlooperLevelSelectorButtons[1].GetComponent<Button>().enabled = true;
            MenuScript.BlooperLevelSelectorButtons[2].GetComponent<Button>().enabled = true;
            MenuScript.backButton.GetComponent<Button>().enabled = true;
            MenuScript.KeyBoard.SetActive(false);
            MenuScript.Ps4ControllerSolo.SetActive(false);
            MenuScript.XboxControllerSolo.SetActive(false);
            MenuScript.BlooperLevelsSelector.SetActive(true);
            for (int i = 0; i < MenuScript.USbOption.Length; i++)
            {
                MenuScript.USbOption[i].SetActive(false);
            }
            MenuScript.BlooperLevelSelectNow = false;
            
        }
    }
}
