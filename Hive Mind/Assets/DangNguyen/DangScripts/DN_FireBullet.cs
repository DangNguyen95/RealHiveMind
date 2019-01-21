using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DN_FireBullet : MonoBehaviour, ISpawnEvent
{
    //public enum CollisionTarget { ENEMIES }
    //public CollisionTarget collisionTarget;
    public float MoveSpeed;
    ObjectPool pool;
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
    public void OnSpawned(GameObject targetGameObject, ObjectPool sender)
    {
        pool = sender;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Wall")
        {
            pool.Despawn(this.gameObject);
        }
        if(other.tag == "YellowBlock")
        {
            pool.Despawn(this.gameObject);
        }
        if (other.tag == "BlueBlock")
        {
            pool.Despawn(this.gameObject);
        }
        if (other.tag == "PurpleBlock")
        {
            pool.Despawn(this.gameObject);
        }
        if (other.tag == "GreenBlock")
        {
            pool.Despawn(this.gameObject);
        }
    }
}
