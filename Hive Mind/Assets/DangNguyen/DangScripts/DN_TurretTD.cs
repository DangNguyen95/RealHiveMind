using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DN_TurretTD : MonoBehaviour
{

    private Transform target;

    [Tooltip("Attributes")]
    public float range = 15f;
    public float fireRate = 1f;
    private float fireCountdown = 0f;
    DictionaryObjectPool _objectpool;
    //private float FireTimer = 0.0f;
    [SerializeField]
    int numberstospawn = 100;
    [Tooltip("Unity Setup Field")]
    public string enemyTag = "Enemy";
    public float turnSpeed = 10.0f;

    public GameObject bulletPrefab;
   

    public Transform firePoint;


    public Transform TurretItSelf;
    // Use this for initialization
    void Start()
    {
        InvokeRepeating("UpdateTarget", 0f, 0.5f);
        _objectpool = new DictionaryObjectPool();
        _objectpool.AddObjectPool("EnemyBullet", bulletPrefab, firePoint.transform, 100);
    }

    void UpdateTarget()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);

        float shortestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;

        foreach (GameObject enemy in enemies)
        {
            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
            if (distanceToEnemy < shortestDistance)
            {
                shortestDistance = distanceToEnemy;
                nearestEnemy = enemy;
            }
        }
        if (nearestEnemy != null && shortestDistance <= range)
        {
            target = nearestEnemy.transform;
        }
        else
        {
            target = null;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null)
            return;
        // target lock on
        Vector3 dir = target.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(dir);
        Vector3 rotation = Quaternion.Lerp(TurretItSelf.rotation, lookRotation, Time.deltaTime * turnSpeed).eulerAngles;
        TurretItSelf.rotation = Quaternion.Euler(0f, rotation.y, 0f);

        if (fireCountdown <= 0f)
        {
            Shoot();
            fireCountdown = 1f / fireRate;

        }

        fireCountdown -= Time.deltaTime;

    }

    void Shoot()
    {
        if (_objectpool["EnemyBullet"].Count < numberstospawn)
        {
            _objectpool["EnemyBullet"].Spawn(firePoint.transform.position, firePoint.transform.rotation);
        }


    }


    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }
}


