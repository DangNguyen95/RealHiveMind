using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DN_Pellets : MonoBehaviour {
    public GameObject PointText;
    private DN_Points PointsScripts;
    public GameObject ThisGameObject;
    private Animator ChipAnimator;
    private SpriteRenderer ChipSprite;
    private float RandomNumber;
    public AudioSource ChipSound;
    private bool PlayChipSoundOnce;
    private bool Death;
    private float DTimer = 2;
    // Use this for initialization
    void Start () {
        PointsScripts = PointText.GetComponent<DN_Points>();
        ChipAnimator = gameObject.GetComponent<Animator>();
        ChipSprite = gameObject.GetComponent<SpriteRenderer>();
        RandomNumber = Random.Range(0, 3);
        if (RandomNumber == 0)
        {
            ChipAnimator.SetBool("Chip1", true);
        }
        if (RandomNumber == 1)
        {
            ChipAnimator.SetBool("Chip2", true);
        }
        if (RandomNumber == 2)
        {
            ChipAnimator.SetBool("Chip3", true);
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (Death)
        {
            DTimer -= Time.deltaTime;
            if (DTimer <= 0)
            {

                gameObject.SetActive(false);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "X" ||other.tag == "Square" || other.tag == "O" || other.tag == "Triangle")
        {
            gameObject.GetComponent<SphereCollider>().enabled = false;
         if(PlayChipSoundOnce==false)
            {
                ChipSound.Play();
                PlayChipSoundOnce = true;
            }
            ChipAnimator.SetBool("ChipPicked", true);
            ChipSprite.sortingOrder = 3;
            PointsScripts.PointsNumber += 1;
            Death = true;
           
        }
    }
    public void ChipAway()
    {
        ThisGameObject.SetActive(false);
    }

}
