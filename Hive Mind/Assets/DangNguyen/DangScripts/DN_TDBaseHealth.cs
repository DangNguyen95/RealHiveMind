using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DN_TDBaseHealth : MonoBehaviour {
    public Text BaseHealthText;
    public float TDHealth;
    // Use this for initialization
    void Start () {
        BaseHealthText = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        BaseHealthText.text = "Health: " + TDHealth.ToString();
        if(TDHealth <=0)
        {
            DN_GameManager.Death = true;
        }
	}
}
