using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AL_DoorManager : MonoBehaviour {

    [SerializeField]
    public List<GameObject> numDoors = new List<GameObject>();
    

    // Use this for initialization
    void Start () {
       AL_Door[] doors = FindObjectsOfType<AL_Door>();

        for(int i = 0; i < doors.Length; i++)
        {
            numDoors.Add(doors[i].gameObject);
            
        }
        numDoors.Sort(delegate (GameObject a, GameObject b)
        {
            return (a.GetComponent<AL_Door>().doorNum).CompareTo(b.GetComponent<AL_Door>().doorNum);
        });
    }

    // Update is called once per frame
    void Update () {
		
	}
}
