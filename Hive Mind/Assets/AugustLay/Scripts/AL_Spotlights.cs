using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AL_Spotlights : MonoBehaviour {


    GameObject myChildCheckPoints;
    GameObject mySpotlights;

    [SerializeField]
    float coolDownTimer;
    float countDown;
    float speed;

    int myCurrentCheckPoint;

    bool doOnce = false;
    [SerializeField]
    bool usingCheckPoints = true;

    Vector3 myDestination;
    
    enum myStates { startMove, MovetoCheckPoint, ChangeCheckpoint, CoolDown};

    myStates myCurrentState;

	// Use this for initialization
	void Start () {

        myChildCheckPoints = gameObject.transform.GetChild(1).gameObject;
        mySpotlights = gameObject.transform.GetChild(0).gameObject;

        countDown = coolDownTimer;
        //myDestination = myChildCheckPoints.transform.GetChild(0).gameObject.transform.position;
        myCurrentState = myStates.startMove;
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.timeScale == 1 && usingCheckPoints == true)
        {
            speed = Time.deltaTime * 1f;

            switch (myCurrentState)
            {
                case myStates.startMove:
                    startMoving();
                    myCurrentState = myStates.MovetoCheckPoint;
                    myCurrentCheckPoint++;
                    break;

                case myStates.MovetoCheckPoint:
                    moveToCheckpoint();
                    break;
                case myStates.ChangeCheckpoint:
                    changeCheckpoint();
                    break;
                case myStates.CoolDown:
                    CoolDown();
                    break;
            }
        }
	}



    void startMoving()
    {
        myDestination = myChildCheckPoints.GetComponent<AL_Checkpoints>().myCheckpoints[myCurrentCheckPoint].gameObject.transform.position;
        
        
    }

    void moveToCheckpoint()
    {
        if (doOnce == false)
        {
            
            mySpotlights.transform.position = Vector3.MoveTowards(mySpotlights.transform.position, myDestination, speed);
        }
        if(mySpotlights.transform.position == myDestination)
        {
            
            myCurrentState = myStates.CoolDown;
            doOnce = false;
        }
    }

    void changeCheckpoint()
    {
        if (doOnce == false)
        {
            doOnce = true;
            if (myCurrentCheckPoint <= myChildCheckPoints.gameObject.transform.childCount - 1)
            {
                myDestination = myChildCheckPoints.GetComponent<AL_Checkpoints>().myCheckpoints[myCurrentCheckPoint].gameObject.transform.position;
                myCurrentCheckPoint++;
                myCurrentState = myStates.MovetoCheckPoint;
                doOnce = false;
            }
            else
            {
                myCurrentCheckPoint = 0;
                doOnce = false;
                changeCheckpoint();
            }
        }
    }

    void CoolDown()
    {
        
         countDown -= Time.deltaTime;
        if(countDown <= 0)
        {
            myCurrentState = myStates.ChangeCheckpoint;
            countDown = coolDownTimer;
        }

    }
}
