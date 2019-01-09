using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DN_SpaceShipControl : MonoBehaviour {
    public bool UpPad;
    public bool DownPad;
    public bool StopPointDown;
    public bool StopPointUp;
    public bool ShootLeft;
    public bool ShootRight;
    public bool Shield;
    public bool FixShip;
    public bool Grab;
    public float speed;
    public float Currenthealth;
    public float MaxHealth;
    public Slider HealthBar;
    public GameObject HealthSlider;
    public float CurrentEnergy1;
    public float MaxEnergy1;
    public Slider EnergyhBar1;
    public GameObject EngergySlider1;
    public float CurrentEnergy2;
    public float MaxEnergy2;
    public Slider EnergyhBar2;
    public GameObject EngergySlider2;
    public float CurrentEnergy3;
    public float MaxEnergy3;
    public Slider EnergyhBar3;
    public GameObject EngergySlider3;
    public float CurrentEnergy4;
    public float MaxEnergy4;
    public Slider EnergyhBar4;
    public GameObject EngergySlider4;
    //public bool Energy1Empty;
    //public bool Energy2Empty;
    //public bool Energy3Empty;
    //public bool Energy4Empty;
    public bool RegenEnergy;
    public float EnergyReductionRate;
    public float EnergyIncreaseRate;
    public bool ForceEnergyIncrease;
    public Image EnergyFill1;
    public Image EnergyFill2;
    public Image EnergyFill3;
    public Image EnergyFill4;
    // Use this for initialization
    void Start () {
        //  Currenthealth = MaxHealth;
        // Currenthealth = 50;
        //EnergyFill1 = EnergyhBar1.GetComponent<Image>();
        //EnergyFill2 = EnergyhBar2.GetComponent<Image>();
        //EnergyFill3 = EnergyhBar3.GetComponent<Image>();
        //EnergyFill4 = EnergyhBar4.GetComponent<Image>();

        EngergySlider1.GetComponent<Image>().color = new Color32(0, 232, 255, 255);
        EngergySlider2.GetComponent<Image>().color = new Color32(0, 232, 255, 255);
        EngergySlider3.GetComponent<Image>().color = new Color32(0, 232, 255, 255);
        EngergySlider4.GetComponent<Image>().color = new Color32(0, 232, 255, 255);
    }
	
	// Update is called once per frame
	void Update () {
        EnergyhBar1.value = CurrentEnergy1;
        if(CurrentEnergy1 >= MaxEnergy1)
        {
           // Energy1Empty = false;
            CurrentEnergy1 = MaxEnergy1;
        }
   
        if (CurrentEnergy1 <=0)
        {
            RegenEnergy = true;
            ForceEnergyIncrease = true;
            //Energy1Empty = true;
            CurrentEnergy1 = 0;
            EngergySlider1.GetComponent<Image>().color = new Color32(255, 0, 31, 255);
            EngergySlider2.GetComponent<Image>().color = new Color32(255, 0, 31, 255);
            EngergySlider3.GetComponent<Image>().color = new Color32(255, 0, 31, 255);
            EngergySlider4.GetComponent<Image>().color = new Color32(255, 0, 31, 255);
        }
        EnergyhBar2.value = CurrentEnergy2;
        if (CurrentEnergy2 >= MaxEnergy2)
        {
           // Energy2Empty = false;
            CurrentEnergy2 = MaxEnergy2;
        }
        if (CurrentEnergy2 <= 0)
        {

           // Energy2Empty = true;
            CurrentEnergy2 = 0;
        }
       
        EnergyhBar3.value = CurrentEnergy3;
        if (CurrentEnergy3 >= MaxEnergy3)
        {
           // Energy3Empty = false;
            CurrentEnergy3 = MaxEnergy3;
        }
        if (CurrentEnergy3 <= 0)
        {
           // Energy3Empty = true;
            CurrentEnergy3 = 0;
        }
      
        EnergyhBar4.value = CurrentEnergy4;
        if (CurrentEnergy4 >= MaxEnergy4)
        {
            RegenEnergy = false;
          //  Energy4Empty = false;
            CurrentEnergy4 = MaxEnergy4;
            EngergySlider1.GetComponent<Image>().color = new Color32(0, 232, 255, 255);
            EngergySlider2.GetComponent<Image>().color = new Color32(0, 232, 255, 255);
            EngergySlider3.GetComponent<Image>().color = new Color32(0, 232, 255, 255);
            EngergySlider4.GetComponent<Image>().color = new Color32(0, 232, 255, 255);
        }
        if (CurrentEnergy4 <= 0)
        {
           // Energy4Empty = true;
            CurrentEnergy4 = 0;
        }
     
        if (RegenEnergy)
        {
            IncreaseEnergy();
        }

        HealthBar.value = Currenthealth;
        if (Currenthealth >= MaxHealth)
        {
            Currenthealth = MaxHealth;
        }
        if (Currenthealth < 0)
        {
            Currenthealth = 0;
            HealthSlider.GetComponent<Image>().color = new Color32(1, 0, 0, 1);

        }
        //if(StopPointUp)
        //{
        //    MoveBox1.SetActive(false);
        //}
        //else
        //{
        //    MoveBox1.SetActive(true);
        //}
        //if(StopPointDown)
        //{
        //    MoveBox2.SetActive(false);
        //}
        //else
        //{
        //    MoveBox2.SetActive(true);
        //}
        if (UpPad && StopPointDown == false)
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
        if(DownPad && StopPointUp == false)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
	}
    public void Damage()
    {
        Currenthealth -= 1;
    }
    public void IncreaseEnergy()
    {
        if (ForceEnergyIncrease)
        {
            if (CurrentEnergy1 < 100)
            {
                CurrentEnergy1 += Time.deltaTime * EnergyIncreaseRate;
            }
            if (CurrentEnergy1 >= 100 && CurrentEnergy2 < 100 && CurrentEnergy3 <100 && CurrentEnergy4 <100)
            {
                CurrentEnergy2 += Time.deltaTime * EnergyIncreaseRate;
            }
            if (CurrentEnergy1 >= 100 && CurrentEnergy2 >= 100 && CurrentEnergy3 < 100 && CurrentEnergy4 <100)
            {
                CurrentEnergy3 += Time.deltaTime * EnergyIncreaseRate;
            }
            if (CurrentEnergy1 >= 100 && CurrentEnergy2 >= 100 && CurrentEnergy3 >= 100 && CurrentEnergy4 < 100)
            {
                CurrentEnergy4 += Time.deltaTime * EnergyIncreaseRate;
            }
         }
        else
        {
            if (CurrentEnergy1 < 100)
            {
                CurrentEnergy1 += Time.deltaTime * EnergyIncreaseRate;
            }
            if (CurrentEnergy1 >= 100 && CurrentEnergy2 < 100 && CurrentEnergy3 < 100 && CurrentEnergy4 < 100)
            {
                CurrentEnergy2 += Time.deltaTime * EnergyIncreaseRate;
            }
            if (CurrentEnergy1 >= 100 && CurrentEnergy2 >= 100 && CurrentEnergy3 < 100 && CurrentEnergy4 < 100)
            {
                CurrentEnergy3 += Time.deltaTime * EnergyIncreaseRate;
            }
            if (CurrentEnergy1 >= 100 && CurrentEnergy2 >= 100 && CurrentEnergy3 >= 100 && CurrentEnergy4 < 100)
            {
                CurrentEnergy4 += Time.deltaTime * EnergyIncreaseRate;
            }
        }
    //else
    //{
    //    if (Energy1Empty && Energy2Empty && Energy3Empty && Energy4Empty)
    //    {
    //        CurrentEnergy1 += Time.deltaTime * EnergyIncreaseRate;
    //    }
    //    if (Energy1Empty == false && Energy2Empty && Energy3Empty && Energy4Empty)
    //    {
    //        CurrentEnergy2 += Time.deltaTime * EnergyIncreaseRate;
    //    }
    //    if (Energy1Empty == false && Energy2Empty == false && Energy3Empty && Energy4Empty)
    //    {
    //        CurrentEnergy3 += Time.deltaTime * EnergyIncreaseRate;
    //    }
    //    if (Energy1Empty == false && Energy2Empty == false && Energy3Empty == false && Energy4Empty)
    //    {
    //        CurrentEnergy4 += Time.deltaTime * EnergyIncreaseRate;
    //    }
    //}
}
    public void DecreaseEnergy()
    {
        if (RegenEnergy == false)
        {
            //if (Energy1Empty == false && Energy2Empty == false && Energy3Empty == false && Energy4Empty == false)
            //{
            //    CurrentEnergy4 -= Time.deltaTime * EnergyReductionRate;
            //}
            //if (Energy1Empty == false && Energy2Empty == false && Energy3Empty == false && Energy4Empty)
            //{
            //    CurrentEnergy3 -= Time.deltaTime * EnergyReductionRate;
            //}
            //if (Energy1Empty == false && Energy2Empty == false && Energy3Empty && Energy4Empty)
            //{
            //    CurrentEnergy2 -= Time.deltaTime * EnergyReductionRate;
            //}
            //if (Energy1Empty == false && Energy2Empty && Energy3Empty && Energy4Empty)
            //{
            //    CurrentEnergy1 -= Time.deltaTime * EnergyReductionRate;
            //}
            if ( CurrentEnergy2 <=0 && CurrentEnergy3 <=0 && CurrentEnergy4<=0)
            {
                CurrentEnergy1 -= Time.deltaTime * EnergyReductionRate;
            }
            if (CurrentEnergy1 >= 100 && CurrentEnergy3 <=0 && CurrentEnergy4 <=0)
            {
                CurrentEnergy2 -= Time.deltaTime * EnergyReductionRate;
            }
            if (CurrentEnergy1 >= 100 && CurrentEnergy2 >= 100 && CurrentEnergy4 <= 0)
            {
                CurrentEnergy3 -= Time.deltaTime * EnergyReductionRate;
            }
            if (CurrentEnergy1 >= 100 && CurrentEnergy2 >= 100 && CurrentEnergy3 >= 100)
            {
                CurrentEnergy4 -= Time.deltaTime * EnergyReductionRate;
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "StopPointUpper")
        {
            StopPointUp = true;
        }
        if (other.tag == "StopPointUnder")
        {
            StopPointDown = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "StopPointUpper")
        {
            StopPointUp = false;
        }
        if (other.tag == "StopPointUnder")
        {
            StopPointDown = false;
        }
    }

}
