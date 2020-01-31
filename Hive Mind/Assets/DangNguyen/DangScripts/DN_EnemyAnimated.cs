using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DN_EnemyAnimated : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "UpTrigger")
        {
            gameObject.GetComponent<Animator>().SetBool("BadMechMoveUp", true);
            gameObject.GetComponent<Animator>().SetBool("BadMechMoveDown", false);
            gameObject.GetComponent<Animator>().SetBool("BadMechMoveRight", false);
            gameObject.GetComponent<Animator>().SetBool("BadMechMoveIdle", false);
        }
        if (other.tag == "DownTrigger")
        {
            gameObject.GetComponent<Animator>().SetBool("BadMechMoveUp", false);
            gameObject.GetComponent<Animator>().SetBool("BadMechMoveDown", true);
            gameObject.GetComponent<Animator>().SetBool("BadMechMoveRight", false);
            gameObject.GetComponent<Animator>().SetBool("BadMechMoveIdle", false);
        }
        if (other.tag == "RightTrigger")
        {
            gameObject.GetComponent<Animator>().SetBool("BadMechMoveUp", false);
            gameObject.GetComponent<Animator>().SetBool("BadMechMoveDown", false);
            gameObject.GetComponent<Animator>().SetBool("BadMechMoveRight", true);
            gameObject.GetComponent<Animator>().SetBool("BadMechMoveIdle", false);
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
        if (other.tag == "LeftTrigger")
        {
            gameObject.GetComponent<Animator>().SetBool("BadMechMoveUp", false);
            gameObject.GetComponent<Animator>().SetBool("BadMechMoveDown", false);
            gameObject.GetComponent<Animator>().SetBool("BadMechMoveRight", true);
            gameObject.GetComponent<Animator>().SetBool("BadMechMoveIdle", false);
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "UpTrigger")
        {
            gameObject.GetComponent<Animator>().SetBool("BadMechMoveUp", true);
            gameObject.GetComponent<Animator>().SetBool("BadMechMoveDown", false);
            gameObject.GetComponent<Animator>().SetBool("BadMechMoveRight", false);
            gameObject.GetComponent<Animator>().SetBool("BadMechMoveIdle", false);
        }
        if (other.tag == "DownTrigger")
        {
            gameObject.GetComponent<Animator>().SetBool("BadMechMoveUp", false);
            gameObject.GetComponent<Animator>().SetBool("BadMechMoveDown", true);
            gameObject.GetComponent<Animator>().SetBool("BadMechMoveRight", false);
            gameObject.GetComponent<Animator>().SetBool("BadMechMoveIdle", false);
        }
        if (other.tag == "RightTrigger")
        {
            gameObject.GetComponent<Animator>().SetBool("BadMechMoveUp", false);
            gameObject.GetComponent<Animator>().SetBool("BadMechMoveDown", false);
            gameObject.GetComponent<Animator>().SetBool("BadMechMoveRight", true);
            gameObject.GetComponent<Animator>().SetBool("BadMechMoveIdle", false);
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
        if (other.tag == "LeftTrigger")
        {
            gameObject.GetComponent<Animator>().SetBool("BadMechMoveUp", false);
            gameObject.GetComponent<Animator>().SetBool("BadMechMoveDown", false);
            gameObject.GetComponent<Animator>().SetBool("BadMechMoveRight", true);
            gameObject.GetComponent<Animator>().SetBool("BadMechMoveIdle", false);
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
    }
}
