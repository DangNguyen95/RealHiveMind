using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DN_Shootbox : MonoBehaviour {
    private float fireCountdown = 0f;
    DictionaryObjectPool _objectpool;
    public Transform[] ShootPoint;
    public bool Shooting;
    [SerializeField]
    GameObject[] Bullets;
    [SerializeField]
    int numberstospawn = 1000;
    public float fireRate = 1f;

    // Use this for initialization
    void Start () {
        _objectpool = new DictionaryObjectPool();
        _objectpool.AddObjectPool("TurretBullet", Bullets[0], ShootPoint[0].transform, 100);
        _objectpool.AddObjectPool("TurretBullet", Bullets[0], ShootPoint[1].transform, 100);
        _objectpool.AddObjectPool("TurretBullet", Bullets[0], ShootPoint[2].transform, 100);
    }
	
	// Update is called once per frame
	void Update () {
        fireCountdown -= Time.deltaTime;
        if(Shooting)
        {
            if (fireCountdown <= 0)
            {
                if (_objectpool["TurretBullet"].Count < numberstospawn)
                {
                    _objectpool["TurretBullet"].Spawn(ShootPoint[0].transform.position, ShootPoint[0].transform.rotation);
                    _objectpool["TurretBullet"].Spawn(ShootPoint[1].transform.position, ShootPoint[1].transform.rotation);
                    _objectpool["TurretBullet"].Spawn(ShootPoint[2].transform.position, ShootPoint[2].transform.rotation);
                }
                fireCountdown = 1f / fireRate;
            }
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Square")
        {
            Shooting = true;
        }
        if (other.tag == "X")
        {
            Shooting = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Square")
        {
            Shooting = false;
        }
        if (other.tag == "X")
        {
            Shooting = false;
        }
    }
}
