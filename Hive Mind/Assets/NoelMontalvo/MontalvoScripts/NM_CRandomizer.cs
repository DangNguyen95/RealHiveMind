using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NM_CRandomizer : MonoBehaviour {


    public Color[] Rcolors;
    public Color[] Scolors;
    public GameObject cubeobject;
    public int startnum;
	// Use this for initialization
	void Start () {
        startnum = 0;
        StartCoroutine(pauseamoment());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void RandomMyColors()
    {
       
       
    }

    IEnumerator pauseamoment()
    {
        for (int i =startnum; i < Scolors.Length; i++)
        {
            startnum = i;
            Scolors[i] = Rcolors[Random.Range(0, 4)];
            cubeobject.GetComponent<Renderer>().material.color = Scolors[i];
            yield return new WaitForSeconds(1);
            cubeobject.GetComponent<Renderer>().material.color = Color.white;
            yield return new WaitForSeconds(1);

          if(i >= Scolors.Length)
            {
                StopCoroutine(pauseamoment());

            }
        }

        
       
       


    }
}
