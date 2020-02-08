using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DN_TDEnemyMovement : MonoBehaviour {
    public float deathDistance = 0.5f;
    public float distanceAway;

    public string TopRightToMove;
    public string TopLeftToMove;
    public string BotRightToMove;
    public string BotLeftToMove;
    public Transform target;
    public GameObject[] Color;
    public bool IamRed;
    public bool IamGreen;
    public bool IamYellow;
    public bool IamBlue;
    public bool TopRight;
    public bool TopLeft;
    public bool BotRight;
    public bool BotLeft;
    //public GameObject WorkerSwitch;
    public float RandomNumber;
    private UnityEngine.AI.NavMeshAgent navComponent;
    
    // Use this for initialization
    void Start () {
        //if (TopRight)
        //{
        //    target = GameObject.FindGameObjectWithTag(TopRightToMove).transform;
        //}
        //if(TopLeft)
        //{
        //    target = GameObject.FindGameObjectWithTag(TopLeftToMove).transform;
        //}
        //if(BotLeft)
        //{
        //    target = GameObject.FindGameObjectWithTag(BotLeftToMove).transform;
        //}
        //if(BotRight)
        //{
        //    target = GameObject.FindGameObjectWithTag(BotRightToMove).transform;
        //}
        RandomNumber = Random.Range(0,4);
        if(RandomNumber == 0)
        {
            Color[0].SetActive(true);
            IamRed = true;
        }
        if (RandomNumber == 1)
        {
            Color[1].SetActive(true);
            IamGreen = true;
        }
        if (RandomNumber == 2)
        {
            Color[2].SetActive(true);
            IamYellow = true;
        }
        if (RandomNumber == 3)
        {
            Color[3].SetActive(true);
            IamBlue = true;
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (TopRight)
        {
            
            if (target = GameObject.FindGameObjectWithTag(TopRightToMove).transform)
            {

                navComponent = this.gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>();
                float dist = Vector3.Distance(target.position, transform.position);

                if (target)
                {
                    navComponent.SetDestination(target.position);
                }
            }
        }
        if (TopLeft)
        {
          
            if (target = GameObject.FindGameObjectWithTag(TopLeftToMove).transform)
            {

                navComponent = this.gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>();
                float dist = Vector3.Distance(target.position, transform.position);

                if (target)
                {
                    navComponent.SetDestination(target.position);
                }
            }
        }
        if (BotRight)
        {
            if (target = GameObject.FindGameObjectWithTag(BotRightToMove).transform)
            {

                navComponent = this.gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>();
                float dist = Vector3.Distance(target.position, transform.position);

                if (target)
                {
                    navComponent.SetDestination(target.position);
                }
            }
        }
        if (BotLeft)
        {
            if (target = GameObject.FindGameObjectWithTag(BotLeftToMove).transform)
            {

                navComponent = this.gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>();
                float dist = Vector3.Distance(target.position, transform.position);

                if (target)
                {
                    navComponent.SetDestination(target.position);
                }
            }
        }
    }
  
    private void OnTriggerStay(Collider other)
    {
        if(other.tag=="Start1")
        {
            target = GameObject.FindGameObjectWithTag(TopRightToMove).transform;
            TopRight = true;
        }
        if(other.tag == "Start2")
        {
            target = GameObject.FindGameObjectWithTag(TopLeftToMove).transform;
            TopLeft = true;
        }
        if(other.tag == "Start3")
        {
            target = GameObject.FindGameObjectWithTag(BotLeftToMove).transform;
            BotLeft = true;
        }
        if(other.tag == "Start4")
        {
            target = GameObject.FindGameObjectWithTag(BotRightToMove).transform;
            BotRight = true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Core")
        {
            Destroy(gameObject);
        }
        if (other.tag == "Core2")
        {
            Destroy(gameObject);
        }
        if (other.tag == "Core3")
        {
            Destroy(gameObject);
        }
        if (other.tag == "Core4")
        {
            Destroy(gameObject);
        }
    }
}
