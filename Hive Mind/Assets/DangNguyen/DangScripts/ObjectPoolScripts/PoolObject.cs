using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolObject : MonoBehaviour, ISpawnEvent
{
    public float DistanceToPool;
    ObjectPool pool;
    private void Start()
    {
        gameObject.transform.parent = null;
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
    }

    public void OnSpawned(GameObject targetGameObject, ObjectPool sender)
    {
        pool = sender;
    }
}