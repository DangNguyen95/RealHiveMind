using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DN_Meteor : MonoBehaviour {
    private DN_SpaceShipControl ShipScripts;
    public GameObject[] PlayerShip;
    // Use this for initialization
    void Start () {
        PlayerShip = GameObject.FindGameObjectsWithTag("Camera");
        ShipScripts = PlayerShip[0].GetComponent<DN_SpaceShipControl>();
        transform.parent = PlayerShip[0].transform;
    }
	
	// Update is called once per frame
	void Update () {
        transform.position += Vector3.left * Time.deltaTime;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "OuterWall")
        {
            gameObject.SetActive(false);
        }
        if (other.tag == "PlayersShipWall")
        {
            if (ShipScripts.ReducingEnergy == false)
            {
                ShipScripts.Currenthealth -= 50;
            }
            gameObject.SetActive(false);
        }
    }
}
