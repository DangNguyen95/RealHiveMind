using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NM_ColorPlate : MonoBehaviour
{
    NM_CRandomizer CR;
    public Color newcolor;
	// Use this for initialization
	void Start () {
        CR = FindObjectOfType<NM_CRandomizer>().GetComponent<NM_CRandomizer>();
        thisiscolornow();
	}
	
	// Update is called once per frame
	void Update () {
       // 
    }

    private void OnTriggerEnter(Collider other)
    {
        Color Currentcolor = gameObject.GetComponent<Renderer>().material.color;
        if (Currentcolor != Color.white)
        {
            CR.InputColor = gameObject.GetComponent<Renderer>().material.color;
            CR.CheckColor();
            gameObject.GetComponent<Renderer>().material.color = Color.white;
        }
    }
    
    public void thisiscolornow()
    {
        newcolor = gameObject.GetComponent<Renderer>().material.color;
    }
    public void backtothatcolor()
    {
        gameObject.GetComponent<Renderer>().material.color = newcolor;
    }
}
