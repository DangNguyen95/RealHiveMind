using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AL_Bomb : MonoBehaviour {

    GameObject myPlayerRef;
    [SerializeField]
    bool xPlayer = false;
    [SerializeField]
    bool oPlayer = false;
    [SerializeField]
    bool triPlayer = false;
    [SerializeField]
    bool sqaPlayer = false;

	// Use this for initialization
	void Start () {
		if(xPlayer == true) { myPlayerRef = GameObject.FindGameObjectWithTag("X"); }
        else if(oPlayer == true) { myPlayerRef = GameObject.FindGameObjectWithTag("O"); }
        else if (triPlayer == true) { myPlayerRef = GameObject.FindGameObjectWithTag("Triangle"); }
        else if (sqaPlayer == true) { myPlayerRef = GameObject.FindGameObjectWithTag("Square"); }

        playerMatchUp(myPlayerRef);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void playerMatchUp (GameObject playerRef)
    {
        transform.parent = myPlayerRef.transform;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Wall")
        {
            DN_GameManager.Death = true;
        }
        if (other.gameObject.GetComponent<AL_breakableWall>())
        {
            GameObject game = other.gameObject;
            game.SetActive(false);
            gameObject.SetActive(false);
        }
    }
}
