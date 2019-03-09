using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DN_Bullet : MonoBehaviour, ISpawnEvent
{
    public GameObject[] Boss;
    private DN_BossShip BossScripts;
    private DN_SpaceShipControl ShipScripts;
    public GameObject[] Camera;
    public bool Enemy;
    public GameObject[] SpawnerObject;
    private WaveSpawner SpawnScripts;

    //public enum CollisionTarget { ENEMIES }
    //public CollisionTarget collisionTarget;
    public float MoveSpeed;
    ObjectPool pool;
    public float DistanceToPool;
    // Use this for initialization
    void Start()
    {
        if (!Enemy)
        {
            SpawnerObject = GameObject.FindGameObjectsWithTag("Spawner");
            SpawnScripts = SpawnerObject[0].GetComponent<WaveSpawner>();
            if (SpawnScripts.nextWave == 4)
            {
                this.transform.parent = null;
                Boss = GameObject.FindGameObjectsWithTag("BossShip");
                BossScripts = Boss[0].GetComponent<DN_BossShip>();
            }
        }
        if(Enemy)
        {
                Camera = GameObject.FindGameObjectsWithTag("Camera");
                ShipScripts = Camera[0].GetComponent<DN_SpaceShipControl>();
                transform.parent = Camera[0].transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x < -DistanceToPool)
        {
            pool.Despawn(this.gameObject);
        }
        if (this.transform.position.x > DistanceToPool)
        {
            pool.Despawn(this.gameObject);
        }
        if (this.transform.position.y > DistanceToPool)
        {
            pool.Despawn(this.gameObject);
        }
        if (this.transform.position.y < -DistanceToPool)
        {
            pool.Despawn(this.gameObject);
        }
        if (this.transform.position.z > DistanceToPool)
        {
            pool.Despawn(this.gameObject);
        }
        if (this.transform.position.z < -DistanceToPool)
        {
            pool.Despawn(this.gameObject);
        }
        MoveForward();
    }
    void MoveForward()
    {
        transform.position -=
                transform.forward * Time.deltaTime * MoveSpeed;

    }
    private void OnCollisionEnter(Collision collision)
    { 
        if(Enemy)
        {
            if (collision.gameObject.tag == "PlayersShipWall")
            {
                if (ShipScripts.ReducingEnergy ==false)
                {
                    ShipScripts.Currenthealth -= 1;
                }
                pool.Despawn(this.gameObject);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (!Enemy)
        {
            if (other.tag == "SpaceForce")
            {
                other.gameObject.SetActive(false);
            }
            if(other.tag == "BossShip")
            {
                
                pool.Despawn(this.gameObject);
            }
            if (other.tag == "BossTurret")
            {
                BossScripts.BossCurrenthealth -= 5;
                other.gameObject.GetComponent<DN_BossTurret>().CurTurretHealth -= 1;
                pool.Despawn(this.gameObject);
            }
            if(other.tag == "BossCore")
            {
                BossScripts.BossCurrenthealth -= 5;
                pool.Despawn(this.gameObject);
            }
        }
    }
    public void OnSpawned(GameObject targetGameObject, ObjectPool sender)
    {
        pool = sender;
    }
}

