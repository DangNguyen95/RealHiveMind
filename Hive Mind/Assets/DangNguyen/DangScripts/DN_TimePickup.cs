using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DN_TimePickup : MonoBehaviour {
    public GameObject TimeSprite;
    private Animator TimePickupAnim;
    private bool Death;
    private float DTimer = 2;
	// Use this for initialization
	void Start () {
        TimePickupAnim = TimeSprite.GetComponent<Animator>();
        
	}
	
	// Update is called once per frame
	void Update () {
		if(Death)
        {
            DTimer -= Time.deltaTime;
            if(DTimer<=0)
            {
                gameObject.SetActive(false);
            }
        }
	}
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Square")
        {
            FindObjectOfType<DN_Time>().IncreaseTimer();
            TimePickupAnim.SetBool("Picked", true);
            Death = true;
            gameObject.GetComponent<Collider>().enabled = false;

        }
        if (other.tag == "O")
        {
            TimePickupAnim.SetBool("Picked", true);
            FindObjectOfType<DN_Time>().IncreaseTimer();
            Death = true;
            gameObject.GetComponent<Collider>().enabled = false;
        }
        if (other.tag == "X")
        {
            TimePickupAnim.SetBool("Picked", true);
            FindObjectOfType<DN_Time>().IncreaseTimer();
            Death = true;
            gameObject.GetComponent<Collider>().enabled = false;
        }
        if (other.tag == "Triangle")
        {
            TimePickupAnim.SetBool("Picked", true);
            FindObjectOfType<DN_Time>().IncreaseTimer();
            Death = true;
            gameObject.GetComponent<Collider>().enabled = false;
        }
    }
}
