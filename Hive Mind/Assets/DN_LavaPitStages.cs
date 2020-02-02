using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DN_LavaPitStages : MonoBehaviour {
    public GameObject Stage1;
    public GameObject Stage2;
    public GameObject Stage3;
    public GameObject Stage4;
    public GameObject Stage5;
    public GameObject Stage6;
    public float lavaTimer;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        lavaTimer += Time.deltaTime;
        if(lavaTimer <=11)
        {
            Stage1.SetActive(true);
        }
        if(lavaTimer >11 && lavaTimer <=22)
        {
            Stage1.SetActive(false);
            Stage2.SetActive(true);
        }
        if (lavaTimer > 22 && lavaTimer <= 33)
        {
            Stage2.SetActive(false);
            Stage3.SetActive(true);
        }
        if (lavaTimer > 33 && lavaTimer <= 44)
        {
            Stage3.SetActive(false);
            Stage4.SetActive(true);
        }
        if (lavaTimer > 44 && lavaTimer <= 55)
        {
            Stage4.SetActive(false);
            Stage5.SetActive(true);
        }
        if (lavaTimer > 55)
        {
            Stage5.SetActive(false);
            Stage6.SetActive(true);
        }
    }
}
