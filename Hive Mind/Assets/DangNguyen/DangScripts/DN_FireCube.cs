using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DN_FireCube : MonoBehaviour {
    public float FireCoolDown;
    public float SetCooldown;
    public GameObject FireTrap;
    private Animator FireTrapAnim;
	// Use this for initialization
	void Start () {
        FireCoolDown = SetCooldown;
        FireTrapAnim = FireTrap.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        FireCoolDown -= Time.deltaTime;
		if(FireCoolDown <=7)
        {
            FireTrapAnim.SetBool("TrapOpen", true);
            FireTrapAnim.SetBool("TrapClose", false);

        }
        if (FireCoolDown > 7)
        {

            FireTrapAnim.SetBool("TrapOpen", false);
            FireTrapAnim.SetBool("TrapClose", true);
        }
        if(FireCoolDown <= 0)
        {
            FireCoolDown = SetCooldown;
        }
	}
}
