using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AL_FireManager : MonoBehaviour {
    [SerializeField]
    List<GameObject> lavaTraps = new List<GameObject>();

    [System.Serializable]
    public class myPatternNumbers
    {
        [SerializeField]
        public int[] myNumbers;
    }
    [SerializeField]
    int blach = 1;
    GameObject myPatternObject;
    int[] myNumbsRef;
    public List<myPatternNumbers> myPattern = new List<myPatternNumbers>();

    public delegate void FiresToListen();
    public static event FiresToListen FiresToReach;


    // Use this for initialization
    void Start () {
        
        AL_FirePit[] aL_FirePit = FindObjectsOfType<AL_FirePit>();

        foreach(AL_FirePit element in aL_FirePit)
        {
            lavaTraps.Add(element.gameObject);
            //element.gameObject.SetActive(false);
        }
        lavaTraps.Sort(delegate (GameObject a, GameObject b)
        {
            return (a.GetComponent<AL_FirePit>().fireNumber).CompareTo(b.GetComponent<AL_FirePit>().fireNumber);
        });

        StartCoroutine(kickOOF());
        //firePatternStarter(myPattern[0]);
    }
    IEnumerator kickOOF()
    {
        blach = blach + 1;
        yield return new WaitForSeconds(1);
        blach = blach + 1;
        firePatternStarter(myPattern[0]);
        //StopCoroutine(kickOOF());
    }
    // Update is called once per frame
    void Update () {
        //FiresToReach.Invoke();
    }


    void firePatternStarter(myPatternNumbers myNumbs)
    {
        foreach(int element in myNumbs.myNumbers)
        {
            
            GameObject myObject = lavaTraps.Find(x => x.GetComponent<AL_FirePit>().fireNumber == element);
            myObject.GetComponent<AL_FirePit>().fireOn = false;
            
        }
        FiresToReach.Invoke();
        //StopCoroutine(kickOOF());
    }
}
