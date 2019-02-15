using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NM_CRandomizer : MonoBehaviour {
    [SerializeField]
    public List<Color> Mycolors = new List<Color>();

    [SerializeField]
    List<GameObject> Colorplates = new List<GameObject>();
    [SerializeField]
    GameObject[] escape;
    public Color[] Rcolors;
   // public Color[] Scolors;
    public Color InputColor;
    public GameObject cubeobject;
    public int startnum;
  public int CCCheck = 0; //current color check number

	// Use this for initialization
	void Start () {
        startnum = 0;
      
       
        NM_ColorPlate[] nm_colorplate = FindObjectsOfType<NM_ColorPlate>();
        foreach (NM_ColorPlate element in nm_colorplate)
        {
            Colorplates.Add(element.gameObject);
            //element.gameObject.SetActive(false);
        }
    }
	
    public void callq()
    {
        StartCoroutine(pauseamoment());
    }
	// Update is called once per frame
	void Update () {
		
	}

    public void CheckColor()
    {
        if (InputColor == Mycolors[CCCheck])
        {
            CCCheck++;

            if (CCCheck >= Mycolors.Count)
            {
                if (Mycolors.Count < 8)
                {
                    Colorplates = new List<GameObject>();
                    if (Colorplates.Count <= 0)
                    {
                        NM_ColorPlate[] nm_colorplate = FindObjectsOfType<NM_ColorPlate>();
                        foreach (NM_ColorPlate element in nm_colorplate)
                        {
                            Colorplates.Add(element.gameObject);


                            //element.gameObject.SetActive(false);
                        }
                    }
                    Mycolors.Add(Color.white);
                    Mycolors.Add(Color.white);
                    Mycolors.Add(Color.white);
                    Mycolors.Add(Color.white);
                    startnum++;
                    CCCheck = 0;
                    StartCoroutine(RepeatColors());
                }

                else
                {
                    for (int i = 0; i < escape.Length; i++)
                    {
                        escape[i].SetActive(true);
                    }
                }
            }

        }
        else {

            CCCheck = 0;
         DN_Time dn_time = FindObjectOfType<DN_Time>();
            dn_time.Timer = dn_time.Timer - 20; 
            Colorplates = new List<GameObject>();
            if (Colorplates.Count <= 0)
            {
                NM_ColorPlate[] nm_colorplate = FindObjectsOfType<NM_ColorPlate>();
                foreach (NM_ColorPlate element in nm_colorplate)
                {
                    Colorplates.Add(element.gameObject);


                    //element.gameObject.SetActive(false);
                }

                StartCoroutine(resetcolors());
            }

          

        }
       
    }
    IEnumerator resetcolors()
    {
        yield return new WaitForSeconds(1);
        for (int i = 0; i < Colorplates.Count; i++)
        {

            Colorplates[i].GetComponent<NM_ColorPlate>().backtothatcolor();
        }
     
        StopCoroutine(resetcolors());

    }
    IEnumerator pauseamoment()
    {
      //  yield return new WaitForSeconds(1);
        for (int i =startnum; i < Mycolors.Count; i++)
        {
            yield return new WaitForSeconds(.2f);
            startnum = i;
            Mycolors[i] = Rcolors[Random.Range(0, 4)];
            cubeobject.GetComponent<Renderer>().material.color = Mycolors[i];
            yield return new WaitForSeconds(1);
            cubeobject.GetComponent<Renderer>().material.color = Color.white;
            // yield return new WaitForSeconds(2);


           
            
            
        }
        StartCoroutine(ColorThePlates());
        StopCoroutine(pauseamoment());





    }

    IEnumerator RepeatColors()
    {
        yield return new WaitForSeconds(1);
        for (int i = 0; i < 4; i++)
        {

            yield return new WaitForSeconds(.2f);
            cubeobject.GetComponent<Renderer>().material.color = Mycolors[i];
            yield return new WaitForSeconds(1);
            cubeobject.GetComponent<Renderer>().material.color = Color.white;

        
            
            //yield return new WaitForSeconds(5);
        
            //for (int a = startnum; a <= Mycolors.Count; a++)
            //{
            //    yield return new WaitForSeconds(.2f);
            //    startnum = a;
            //    Mycolors[a] = Rcolors[Random.Range(0, 4)];
            //    cubeobject.GetComponent<Renderer>().material.color = Mycolors[a];
            //    yield return new WaitForSeconds(1);
            //    cubeobject.GetComponent<Renderer>().material.color = Color.white;
            //    //


            //    StartCoroutine(ColorThePlates());
                

            //}
            //yield return new WaitForSeconds(2);
       
        }
        StartCoroutine(pauseamoment());
        StopCoroutine(RepeatColors());




    }
    int savenymver = 0;
    IEnumerator ColorThePlates()
    {
       // yield return new WaitForSeconds(5f);
        for (int i = 0; i < Mycolors.Count; i++)
        {

            
            int removeplate = Random.Range(0, Colorplates.Count);
            
            Colorplates[removeplate].GetComponent<Renderer>().material.color = Mycolors[i];
            Colorplates[removeplate].GetComponent<NM_ColorPlate>().thisiscolornow();
            //savenymver++;
            Colorplates.Remove(Colorplates[removeplate]);
          
        }
        yield return new WaitForSeconds(4);

        StopCoroutine(ColorThePlates());
    }

    public void fixtest()
    {
     
       
        // cubeobject.GetComponent<Renderer>().material.color = Mycolors[i];


    }

}
