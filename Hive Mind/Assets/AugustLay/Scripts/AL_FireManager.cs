using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AL_FireManager : MonoBehaviour {
    [SerializeField]
    List<GameObject> lavaTraps = new List<GameObject>();


    DN_GameManager managerGame;

    [System.Serializable]
    public class myPatternNumbers
    {
        [SerializeField]
        public int[] myNumbers;
    }
    [SerializeField]
    int myNumbersMax;
    [SerializeField]
    int myCurPat = 0;
    float myCurFireTime = 2;
    bool doOnce = false;
    GameObject myPatternObject;
    int[] myNumbsRef;
    public List<myPatternNumbers> myPattern = new List<myPatternNumbers>();

    public delegate void FiresToListen();
    public static event FiresToListen FiresToReach;
    public static event FiresToListen FirePFIReach;
    public static event FiresToListen FireReset;


    // Use this for initialization
    void Start () {
        //managerGame = FindObjectOfType<DN_GameManager>();
        
        //AL_FirePit[] aL_FirePit = FindObjectsOfType<AL_FirePit>();

        //foreach(AL_FirePit element in aL_FirePit)
        //{
        //    lavaTraps.Add(element.gameObject);
        //    element.gameObject.SetActive(false);
        //}
        //lavaTraps.Sort(delegate (GameObject a, GameObject b)
        //{
        //    return (a.GetComponent<AL_FirePit>().fireNumber).CompareTo(b.GetComponent<AL_FirePit>().fireNumber);
        //});

        //StartCoroutine(kickOOF(myCurPat, myCurFireTime));
        //firePatternStarter(myPattern[0]);
    }
    
    // Update is called once per frame
    void Update () {
        //FiresToReach.Invoke();
        if (Time.timeScale == 1 && doOnce == false)
        {
            doOnce = true;
            myNumbersMax = myPattern.Count;
            AL_FirePit[] aL_FirePit = FindObjectsOfType<AL_FirePit>();

            foreach (AL_FirePit element in aL_FirePit)
            {
                lavaTraps.Add(element.gameObject);
                //element.gameObject.SetActive(false);
            }
            lavaTraps.Sort(delegate (GameObject a, GameObject b)
            {
                return (a.GetComponent<AL_FirePit>().fireNumber).CompareTo(b.GetComponent<AL_FirePit>().fireNumber);
            });

            StartCoroutine(kickOOF(myCurPat, myCurFireTime));
        }
    }
    IEnumerator kickOOF(int myCurrentPattern, float timeToFire)
    {
        //blach = blach + 1;
        firePatternPFIStarter(myPattern[myCurrentPattern]);
        yield return new WaitForSeconds(timeToFire);
        //blach = blach + 1;
        firePatternStarter(myPattern[myCurrentPattern]);
        //StopCoroutine(kickOOF());
    }

    void firePatternStarter(myPatternNumbers myNumbs)
    {
        foreach(int element in myNumbs.myNumbers)
        {
            
            GameObject myObject = lavaTraps.Find(x => x.GetComponent<AL_FirePit>().fireNumber == element);
            myObject.GetComponent<AL_FirePit>().fireOn = false;
            
        }
        FiresToReach.Invoke();
        StopCoroutine(kickOOF(myCurPat, myCurFireTime));
        StartCoroutine(resetingFires());
    }
    void firePatternPFIStarter(myPatternNumbers myNumbs)
    {
        foreach (int element in myNumbs.myNumbers)
        {
            
            GameObject myObject = lavaTraps.Find(x => x.GetComponent<AL_FirePit>().fireNumber == element);
            myObject.GetComponent<AL_FirePit>().firePFIOn = false;

        }
        FirePFIReach.Invoke();
        //StopCoroutine(kickOOF(myCurPat, myCurFireTime));
    }

    IEnumerator resetingFires()
    {

        
            yield return new WaitForSeconds(3);
            myCurPat++;
            FireReset.Invoke();
            yield return new WaitForSeconds(1);
            StopCoroutine(resetingFires());
        if (myCurPat < myNumbersMax)
        {
            StartCoroutine(kickOOF(myCurPat, myCurFireTime));
        }
    }
}
