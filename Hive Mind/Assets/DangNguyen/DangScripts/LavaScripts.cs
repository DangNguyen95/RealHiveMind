using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaScripts : MonoBehaviour {
    public Animator LavaAnim;
    private float RandomNumber;
    public float RandCD;
    public float RandMax;
	// Use this for initialization
	void Start () {
        LavaAnim = gameObject.GetComponent<Animator>();
        RandCD = RandMax;
	}
	
	// Update is called once per frame
	void Update () {
        RandCD -= Time.deltaTime;
        RandMax = Random.Range(0, 20);
        if (RandCD <= 0)
        {
            RandomNumber = Random.Range(0, 8);
            RandCD = RandMax;
        }
        if(RandomNumber == 0)
        {
            LavaAnim.SetBool("Lava1", true);
        }
        if (RandomNumber == 1)
        {
            LavaAnim.SetBool("Lava2", true);
        }
        if (RandomNumber == 2)
        {
            LavaAnim.SetBool("Lava3", true);
        }
        if (RandomNumber == 3)
        {
            LavaAnim.SetBool("Lava4", true);
        }
        if (RandomNumber == 4)
        {
            LavaAnim.SetBool("Lava5", true);
        }
        if (RandomNumber == 5)
        {
            LavaAnim.SetBool("Lava6", true);
        }
        if (RandomNumber == 6)
        {
            LavaAnim.SetBool("Lava7", true);
        }
        if (RandomNumber == 7)
        {
            LavaAnim.SetBool("Lava8", true);
        }
    }
}
