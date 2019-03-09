using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DN_BossShip : MonoBehaviour {
    public float MoveTimer;
    public float BossCurrenthealth;
    public Slider BossHealthBar;
    public GameObject BossHealthSlider;
    public float BossTurretGroup1CD;
    public float BossTurretGroup1CDMax;
    public float MoveOut1;
    public float MaxMoveOut1;
    public float BossTurretGroup2CD;
    public float BossTurretGroup2CDMax;
    public float MoveOut2;
    public float MaxMoveOut2;
    public float BossCannonGroupCD;
    public float BossCannonGroupCDMax;
    public float MoveOut3;
    public float MaxMoveOut3;
    public float BossCoreGroupCD;
    public float BossCoreGroupCDMax;
    public float MoveOut4;
    public float MaxMoveOut4;
    public GameObject TGroup1;
    public GameObject TGroup2;
    public bool TGroup1Shoot;
    public bool TGroup2Shoot;
    public float TurretCDMax;
    public float searchCountdown;
    public bool PhaseOne;
    public bool PhaseTwo;
    public bool PhaseThree;
    public GameObject CannonGroup;
    public GameObject BossCore;
    public GameObject[] IndiTurret;
    public GameObject[] Camera;
    // Use this for initialization
    void Start () {
        PhaseOne = true;
        MoveOut1 = MaxMoveOut1;
        MoveOut2 = MaxMoveOut2;
        MoveOut3 = MaxMoveOut3;
        MoveOut4 = MaxMoveOut4;
        Camera = GameObject.FindGameObjectsWithTag("Camera");
        transform.parent = Camera[0].transform;
    }
	
	// Update is called once per frame
	void Update () {
       
        BossHealthBar.value = BossCurrenthealth;
        MoveTimer -= Time.deltaTime;
        if (BossCurrenthealth <= 0)
        {
            DN_GameManager.XHome = true;
            DN_GameManager.SquareHome = true;
            DN_GameManager.OHome = true;
            DN_GameManager.TriangleHome = true;
            BossCurrenthealth = 0;
        }
        if (MoveTimer <= 0)
        {
            MoveTimer = 0;
            if (PhaseOne)
            {
                searchCountdown -= Time.deltaTime;
                if (searchCountdown <= 0f)
                {
                    searchCountdown = 1f;
                    if (GameObject.FindGameObjectWithTag("BossTurret") == null)
                    {
                        PhaseTwo = true;
                        PhaseOne = false;
                        PhaseThree = false;
                        MoveOut3 = MaxMoveOut3;
                        BossCannonGroupCD = BossCannonGroupCDMax;

                    }
                }
                BossTurretGroup1CD -= Time.deltaTime;
                BossTurretGroup2CD -= Time.deltaTime;
                if (BossTurretGroup1CD < 15)
                {
                    MoveOut1 += Time.deltaTime;
                    if (MoveOut1 < 1)
                    {
                        TGroup1.transform.position += Vector3.right * Time.deltaTime * 2;
                    }
                    if (MoveOut1 >= 1)
                    {
                        MoveOut1 = 1;
                    }
                }
                if (BossTurretGroup1CD > 15)
                {
                    MoveOut1 -= Time.deltaTime;
                    if (MoveOut1 > 0)
                    {
                        TGroup1.transform.position += Vector3.left * Time.deltaTime * 2;
                    }
                    if (MoveOut1 <= 0)
                    {
                        MoveOut1 = 0;
                    }
                }
                if (BossTurretGroup1CD <= 0)
                {
                    BossTurretGroup1CD = BossTurretGroup1CDMax;
                }
                if (BossTurretGroup1CD == 15)
                {
                    MoveOut1 = MaxMoveOut1;
                }
                if (BossTurretGroup2CD < 15)
                {
                    MoveOut2 += Time.deltaTime;
                    if (MoveOut2 < 1)
                    {
                        TGroup2.transform.position += Vector3.left * Time.deltaTime * 2;
                    }
                    if (MoveOut2 >= 1)
                    {
                        MoveOut2 = 1;
                    }
                }
                if (BossTurretGroup2CD > 15)
                {
                    MoveOut2 -= Time.deltaTime;
                    if (MoveOut2 > 0)
                    {
                        TGroup2.transform.position += Vector3.right * Time.deltaTime * 2;
                    }
                    if (MoveOut2 <= 0)
                    {
                        MoveOut2 = 0;
                    }
                }
                if (BossTurretGroup2CD <= 0)
                {
                    BossTurretGroup2CD = BossTurretGroup2CDMax;
                }
                if (BossTurretGroup2CD == 15)
                {
                    MoveOut2 = MaxMoveOut2;
                }
            }
        }
        if(MoveTimer > 0)
        {
            transform.position += Vector3.left * Time.deltaTime*2.5f;
        }
        if(PhaseTwo)
        {
            BossCannonGroupCD -= Time.deltaTime;
            if (BossCannonGroupCD <= 0)
            {
                MoveOut3 += Time.deltaTime;
                if (MoveOut3 < 1)
                {
                    CannonGroup.transform.position += Vector3.right * Time.deltaTime * 3;   
                }
                if (MoveOut3 >= 1)
                {
                    PhaseTwo = false;
                    PhaseThree = true;
                    MoveOut4 = MaxMoveOut4;
                    BossCoreGroupCD = BossCoreGroupCDMax;

                }
            }
            if (BossCannonGroupCD > 20)
            {
                MoveOut3 -= Time.deltaTime;
                if (MoveOut3 > 0)
                {
                    CannonGroup.transform.position += Vector3.left * Time.deltaTime * 3;
                }
                if (MoveOut3 <= 0)
                {
                    MoveOut3 = 0;
                }
            }
            if (BossCannonGroupCD == 15)
            {
                MoveOut3 = MaxMoveOut3;
            }
        }
        if(PhaseThree)
        {
            BossCoreGroupCD -= Time.deltaTime;
            if(BossCoreGroupCD <=0)
            {
                MoveOut4 += Time.deltaTime;
                if(MoveOut4 <1)
                {
                    BossCore.transform.position += Vector3.right * Time.deltaTime * 2.5f;
                }
                if(MoveOut4 >=1)
                {
                 
                    for (int i = 0; i < IndiTurret.Length; i++)
                    {
                        IndiTurret[i].SetActive(true);
                    }
                    PhaseThree = false;
                    PhaseOne = true;
                    BossTurretGroup1CD = BossTurretGroup1CDMax;
                    BossTurretGroup2CD = BossTurretGroup2CDMax;
                    MoveOut1 = MaxMoveOut1;
                }
            }
            if (BossCoreGroupCD > 0)
            {
                MoveOut4 -= Time.deltaTime;
                if (MoveOut4 > 0)
                {
                    BossCore.transform.position += Vector3.left * Time.deltaTime * 2.5f;
                }
                if (MoveOut4 <= 0)
                {
                    MoveOut4 = 0;
                }
            }
            if (BossCoreGroupCD == 15)
            {
                MoveOut4 = MaxMoveOut4;
            }
        }
	}
}
