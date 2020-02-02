using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DN_FireCube : MonoBehaviour {
    public float FireCoolDown;
    public float SetCooldown;
    public GameObject FireTrap;
    private Animator FireTrapAnim;
    public bool NoneFireCube;
    public bool LavaLevel;
    public bool IdlePit;
    public float LavaFireCoolDown;
    public float SetCoolDown2;
	// Use this for initialization
	void Start () {
        if (NoneFireCube == false)
        {
            FireCoolDown = SetCooldown;
            FireTrapAnim = FireTrap.GetComponent<Animator>();
        }
        if(LavaLevel)
        {
            LavaFireCoolDown = SetCoolDown2;

        }
	}
	
	// Update is called once per frame
	void Update () {
        if (NoneFireCube == false)
        {

            if (LavaLevel == false)
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
            if (LavaLevel)
            {
                if (IdlePit)
                {
                    FireTrapAnim.SetBool("TrapOpen", false);
                    FireTrapAnim.SetBool("TrapClose", true);
                }
                else
                {
                    LavaFireCoolDown -= Time.deltaTime;
                    if (LavaFireCoolDown <= 10 && LavaFireCoolDown > 2)
                    {
                        FireTrapAnim.speed = 0.2f;
                        FireTrapAnim.SetBool("TrapOpen", true);
                        FireTrapAnim.SetBool("TrapClose", false);

                    }
                    if(LavaFireCoolDown <=2)
                    {
                        FireTrapAnim.speed = 1f;
                        FireTrapAnim.SetBool("TrapOpen", true);
                        FireTrapAnim.SetBool("TrapClose", false);
                    }
                    if (LavaFireCoolDown > 7)
                    {

                        FireTrapAnim.SetBool("TrapOpen", false);
                        FireTrapAnim.SetBool("TrapClose", true);
                    }
                    if (LavaFireCoolDown <= 0)
                    {
                        LavaFireCoolDown = SetCoolDown2;
                    }
                }

            }
        }
	}
}
