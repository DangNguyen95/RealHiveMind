using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DN_BossCannon : MonoBehaviour {
    [SerializeField]
    GameObject Bullets;
    [SerializeField]
    int numberstospawn;
    public Transform ShootPoint;
    DictionaryObjectPool _objectpool;
    public float fireRate;
    public float fireCountdown;
    public float fireCountdown2;
    public GameObject BossShip;
    private DN_BossShip BossScripts;
    public float firerateMultiply;
    //public float ResetFireRate;
    // Use this for initialization
    void Start () {
        BossScripts = BossShip.GetComponent<DN_BossShip>();
        _objectpool = new DictionaryObjectPool();
        _objectpool.AddObjectPool("EnemyBullet", Bullets, ShootPoint.transform, 100);
    }
	
	// Update is called once per frame
	void Update () {
		if(BossScripts.PhaseTwo && BossScripts.BossCannonGroupCD>40 && BossScripts.MoveOut3 <= 0)
        {
            fireCountdown -= Time.deltaTime;
            if (fireCountdown < 0)
            {
                if (_objectpool["EnemyBullet"].Count < numberstospawn)
                {
                    _objectpool["EnemyBullet"].Spawn(ShootPoint.transform.position, ShootPoint.transform.rotation);
                }
                fireCountdown =  fireRate;
            }
        }
        if (BossScripts.PhaseTwo && BossScripts.BossCannonGroupCD < 35 )
        {
            //ResetFireRate -= Time.deltaTime;
            //if(ResetFireRate >=1)
            //{
            //    fireCountdown2 = firerateMultiply;

            //}

            fireCountdown2 -= Time.deltaTime;
            if (fireCountdown2 < 0)
            {
                if (_objectpool["EnemyBullet"].Count < numberstospawn)
                {
                    _objectpool["EnemyBullet"].Spawn(ShootPoint.transform.position, ShootPoint.transform.rotation);
                }
                fireCountdown2 = firerateMultiply;
            }
        }
    }
}
