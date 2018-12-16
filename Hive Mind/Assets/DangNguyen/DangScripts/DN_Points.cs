using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DN_Points : MonoBehaviour {
    public Text points;
    public float PointsNumber;
    // Use this for initialization
    void Start () {
        points = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        points.text = "Points: " + PointsNumber.ToString();
        if(PointsNumber >= 296f)
        {
            DN_GameManager.SquareHome = true;
            DN_GameManager.OHome = true;
            DN_GameManager.TriangleHome = true;
            DN_GameManager.XHome = true;
        }
    }
}
