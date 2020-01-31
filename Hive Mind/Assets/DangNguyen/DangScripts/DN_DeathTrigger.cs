using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DN_DeathTrigger : MonoBehaviour {
    public GameObject EnemyGuard;
    private DN_Guard GuardScript;
	// Use this for initialization
	void Start () {
        GuardScript = EnemyGuard.GetComponent<DN_Guard>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void GuardDeath()
    {
        GuardScript.Death = true;
    }
}
