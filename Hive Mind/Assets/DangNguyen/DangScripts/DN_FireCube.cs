using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DN_FireCube : MonoBehaviour {
    public float FireCoolDown;
    public float SetCooldown;
    public GameObject FireTrap;
    private Animator FireTrapAnim;
    public bool NoneFireCube;
	// Use this for initialization
	void Start () {
        if (NoneFireCube == false)
        {
            FireCoolDown = SetCooldown;
            FireTrapAnim = FireTrap.GetComponent<Animator>();
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (NoneFireCube == false)
        {
            FireCoolDown -= Time.deltaTime;
            if (FireCoolDown <= 7)
            {
                FireTrapAnim.SetBool("TrapOpen", true);
                FireTrapAnim.SetBool("TrapClose", false);

            }
            if (FireCoolDown > 7)
            {

                FireTrapAnim.SetBool("TrapOpen", false);
                FireTrapAnim.SetBool("TrapClose", true);
            }
            if (FireCoolDown <= 0)
            {
                FireCoolDown = SetCooldown;
            }
        }
	}
}
