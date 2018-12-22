using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DN_Bullet : MonoBehaviour
{
    //public enum CollisionTarget { ENEMIES }
    //public CollisionTarget collisionTarget;
    public float MoveSpeed;
    // Use this for initialization
    void Start()
    {
        this.transform.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
        MoveForward();
    }
    void MoveForward()
    {
        transform.position -=
                transform.forward * Time.deltaTime * MoveSpeed;

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
           // collision.gameObject.GetComponent<NPC_Enemy>().Damage();
        }
    }
}

