using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AL_CameraSideScroller : MonoBehaviour {

    AL_EndPoint endPoint;
    [SerializeField]
    GameObject myEndPoint;

    float distanceTraveled;
    [SerializeField]
    float timePassing;
	// Use this for initialization
	void Start () {
        endPoint = FindObjectOfType<AL_EndPoint>();
        myEndPoint = endPoint.gameObject;
        startToMove();
	}
	
	// Update is called once per frame
	void Update () {
        timePassing = Time.deltaTime * 0.01f;
        distanceTraveled = Mathf.Lerp(transform.position.x, myEndPoint.transform.position.x, timePassing);
        transform.position = new Vector3(distanceTraveled, transform.position.y, transform.position.z);
        
    }

    void startToMove()
    {
       // Vector3.MoveTowards(transform.position, myEndPoint.transform.position, timePassing);
    }

}
