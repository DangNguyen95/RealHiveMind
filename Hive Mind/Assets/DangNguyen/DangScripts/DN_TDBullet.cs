using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DN_TDBullet : MonoBehaviour, ISpawnEvent
{
    public float MoveSpeed;
    ObjectPool pool;
    
    public float DistanceToPool;
    private DN_TDEnemyMovement EnemyScripts;
    public bool RedBullet;
    public bool GreenBullet;
    public bool YellowBullet;
    public bool BlueBullet;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
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
        transform.position -=
                transform.forward * Time.deltaTime * MoveSpeed;
    }
    private void OnTriggerEnter(Collider other)
    {
           
            if (RedBullet && other.gameObject.GetComponent<DN_TDEnemyMovement>().IamRed)
            {
                Destroy(other.gameObject);
                pool.Despawn(this.gameObject);
            }
            if(BlueBullet && other.gameObject.GetComponent<DN_TDEnemyMovement>().IamBlue)
            {
                Destroy(other.gameObject);
                pool.Despawn(this.gameObject);
            }
            if (GreenBullet && other.gameObject.GetComponent<DN_TDEnemyMovement>().IamGreen)
            {
                Destroy(other.gameObject);
                pool.Despawn(this.gameObject);
            }
            if(YellowBullet && other.gameObject.GetComponent<DN_TDEnemyMovement>().IamYellow)
            {
                Destroy(other.gameObject);
                pool.Despawn(this.gameObject);
            }
      
           
    }
    public void OnSpawned(GameObject targetGameObject, ObjectPool sender)
    {
        pool = sender;
    }
}
