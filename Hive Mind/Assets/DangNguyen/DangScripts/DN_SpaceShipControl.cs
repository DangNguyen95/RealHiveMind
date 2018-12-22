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
    // Use this for initialization
    void Start () {
      //  Currenthealth = MaxHealth;
        Currenthealth = 50;
    }
	
	// Update is called once per frame
	void Update () {
        
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
