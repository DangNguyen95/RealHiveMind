using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
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
    public float OverHeatRate;
    public bool CoolingDown;
    public Slider CDBar;
    public GameObject CDSlider;
    // Use this for initialization
    void Start () {
        
        _objectpool = new DictionaryObjectPool();
        _objectpool.AddObjectPool("TurretBullet", Bullets[0], ShootPoint[0].transform, 100);
        _objectpool.AddObjectPool("TurretBullet", Bullets[0], ShootPoint[1].transform, 100);
        _objectpool.AddObjectPool("TurretBullet", Bullets[0], ShootPoint[2].transform, 100);
        CDSlider.GetComponent<Image>().color = new Color32(154, 242, 25, 255);
    }
	
	// Update is called once per frame
	void Update () {
        CDBar.value = OverHeatRate;
        fireCountdown -= Time.deltaTime;
        
        if (Shooting && CoolingDown == false)
        {
            if (fireCountdown <= 0)
            {
                OverHeatRate -= 5;
                if (_objectpool["TurretBullet"].Count < numberstospawn)
                {
                    _objectpool["TurretBullet"].Spawn(ShootPoint[0].transform.position, ShootPoint[0].transform.rotation);
                    _objectpool["TurretBullet"].Spawn(ShootPoint[1].transform.position, ShootPoint[1].transform.rotation);
                    _objectpool["TurretBullet"].Spawn(ShootPoint[2].transform.position, ShootPoint[2].transform.rotation);
                }
                fireCountdown = 1f / fireRate;
            }
        }
        if(!Shooting && OverHeatRate > 0 && !CoolingDown)
        {
            OverHeatRate += Time.deltaTime *20;
        }
        if(OverHeatRate <= 0)
        {
            OverHeatRate = 0;
            CoolingDown = true;
        }
        if(OverHeatRate >= 100)
        {
            OverHeatRate = 100;
            CoolingDown = false;
            CDSlider.GetComponent<Image>().color = new Color32(154, 242, 25, 255); ;
        }
        if(CoolingDown)
        {
            CDSlider.GetComponent<Image>().color = new Color32(255, 0, 31, 255);
            OverHeatRate += Time.deltaTime *10;
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
        if (other.tag == "Triangle")
        {
            Shooting = true;
        }
        if (other.tag == "O")
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
        if (other.tag == "Triangle")
        {
            Shooting = false;
        }
        if (other.tag == "O")
        {
            Shooting = false;
        }
    }
}
