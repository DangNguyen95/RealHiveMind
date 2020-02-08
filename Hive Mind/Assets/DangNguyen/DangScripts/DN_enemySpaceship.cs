using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DN_enemySpaceship : MonoBehaviour {
    public GameObject[] Camera;
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
    public float MoveTimer1;
    public float MoveTimer2;
    public float MoveTimer3;
    public int RandomNumber;
   // public AudioSource ShootSound;
    // Use this for initialization
    void Start () {
        Target = GameObject.FindWithTag("EnemyShootPoint");
        RandomNumber = Random.Range(0, 3);
        Camera = GameObject.FindGameObjectsWithTag("Camera");
        transform.parent = Camera[0].transform;
        _objectpool = new DictionaryObjectPool();
        _objectpool.AddObjectPool("EnemyBullet", Bullets, ShootPoint.transform, 100);
    }
	
	// Update is called once per frame
	void Update () {
        
        if (RandomNumber == 0)
        {
            MoveTimer1 -= Time.deltaTime;
            if(MoveTimer1>0)
            {
                transform.position += Vector3.left * Time.deltaTime*3;
            }
            if (MoveTimer1 <= 0)
            {
                MoveTimer1 = 0;
                Shooting = true;
            }
        }
        if (RandomNumber == 1)
        {
            MoveTimer2 -= Time.deltaTime;
            if (MoveTimer2 > 0)
            {
                transform.position += Vector3.left * Time.deltaTime*3;
            }
            if (MoveTimer2 <= 0)
            {
                MoveTimer2 = 0;
                Shooting = true;
            }
        }
        if (RandomNumber == 2)
        {
            MoveTimer3 -= Time.deltaTime;
            if (MoveTimer3 > 0)
            {
                transform.position += Vector3.left * Time.deltaTime*3;
            }
            if (MoveTimer3 <= 0)
            {
                MoveTimer3 = 0;
                Shooting = true;
            }
        }

        
        fireCountdown -= Time.deltaTime;
        if (Shooting)
        {
            transform.LookAt(Target.transform);
            if (fireCountdown <= 0)
            {
                if (_objectpool["EnemyBullet"].Count < numberstospawn)
                {
                    _objectpool["EnemyBullet"].Spawn(ShootPoint.transform.position, ShootPoint.transform.rotation);
                  //  ShootSound.Play();
                }
                fireCountdown = 1f / fireRate;
            }
        }
    }
}
