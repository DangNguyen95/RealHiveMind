using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DN_BossTurret : MonoBehaviour {
    public GameObject[] BossShip;
    private DN_BossShip BossScripts;
    DictionaryObjectPool _objectpool;
    public GameObject Target;
    public bool Shooting;
    [SerializeField]
    GameObject Bullets;
    [SerializeField]
    int numberstospawn = 100;
    public float fireRate = 1f;
    private float fireCountdown = 0f;
    public Transform ShootPoint;
    public bool TurretFirstGroup;
    public float CurTurretHealth;
    // Use this for initialization
    void Start () {
        Target = GameObject.FindWithTag("EnemyShootPoint");
        BossShip = GameObject.FindGameObjectsWithTag("BossShip");
        BossScripts = BossShip[0].GetComponent<DN_BossShip>();
        _objectpool = new DictionaryObjectPool();
        _objectpool.AddObjectPool("EnemyBullet", Bullets, ShootPoint.transform, 100);
    }
	
	// Update is called once per frame
	void Update () {
        
        if(CurTurretHealth <= 0)
        {
            CurTurretHealth = 3;
            gameObject.SetActive(false);
        }
        if (BossScripts.MoveOut1 <= 0 && TurretFirstGroup)
        {
            fireCountdown -= Time.deltaTime;
            if (Shooting)
            {
                transform.LookAt(Target.transform);
                if (fireCountdown < 0)
                {
                    if (_objectpool["EnemyBullet"].Count < numberstospawn)
                    {
                        _objectpool["EnemyBullet"].Spawn(ShootPoint.transform.position, ShootPoint.transform.rotation);
                    }
                    fireCountdown = 1f / fireRate;
                }
            }

        }
        if(BossScripts.MoveOut2 >= 1 && TurretFirstGroup == false)
        {
            fireCountdown -= Time.deltaTime;
            if (Shooting)
            {
                transform.LookAt(Target.transform);
                if (fireCountdown <= 0)
                {
                    if (_objectpool["EnemyBullet"].Count < numberstospawn)
                    {
                        _objectpool["EnemyBullet"].Spawn(ShootPoint.transform.position, ShootPoint.transform.rotation);
                    }
                    fireCountdown = 1f / fireRate;
                }
            }
        }
       
    }
}
