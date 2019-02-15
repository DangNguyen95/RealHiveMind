using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NM_WallMove : MonoBehaviour {
    int speed = 1;
    private Vector3 pos;
    public float waittime = 1;
    public bool Back, Forward, Left, Right;

    // Use this for initialization
    void Start () {
        StartCoroutine(trial());
        pos = Vector3.back;
    }
	
	// Update is called once per frame
	void Update () {
        //  transform.localPosition = Vector3.MoveTowards(transform.localPosition, PositionB, Time.deltaTime * speed);
        // transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * speed);

        //positioning();
    }

    IEnumerator trial()
    {
        for(int i = 0; i < 5; i++)
        {
          //  yield return new WaitForSeconds(1);
            i = 0;
           // transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * speed);
            transform.position += pos * speed;
            yield return new WaitForSeconds(waittime);
        }
    
    }

    public void positioning()
    {
        if(Back)
        {
            pos = Vector3.back;
        }
        if (Forward)
        {
            pos = Vector3.forward;
        }
        if(Right)
        {
            pos = Vector3.right;
        }
        if (Left)
        {
            pos = Vector3.left;
        }

    }
}
