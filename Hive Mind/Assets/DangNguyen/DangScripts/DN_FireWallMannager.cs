using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DN_FireWallMannager : MonoBehaviour {
    private float fireCountdown = 0f;
    DictionaryObjectPool _objectpool;
    public Transform[] ShootPoint;
    public bool PartOne;
    public bool PartTwo;
    public bool PartThree;
    [SerializeField]
    GameObject[] Bullets;
    [SerializeField]
    int numberstospawn = 1000;
    public float fireRate;
    public float FireWaveCount;
    public float FireWaveCount2;
    public float FireWaveCount3;
    public GameObject Trigger1;
    public GameObject Trigger2;
    public GameObject Trigger3;
    public GameObject Trigger4;
    private DN_PlayerCubeBlockTrigger TriggerScript1;
    private DN_PlayerCubeBlockTrigger TriggerScript2;
    private DN_PlayerCubeBlockTrigger TriggerScript3;
    private DN_PlayerCubeBlockTrigger TriggerScript4;
    public GameObject WallBlocker;
    public GameObject Trigger5;
    public GameObject Trigger6;
    public GameObject Trigger7;
    public GameObject Trigger8;
    private DN_PlayerCubeBlockTrigger TriggerScript5;
    private DN_PlayerCubeBlockTrigger TriggerScript6;
    private DN_PlayerCubeBlockTrigger TriggerScript7;
    private DN_PlayerCubeBlockTrigger TriggerScript8;
    public GameObject FinalTile1;
    public GameObject FinalTile2;
    public GameObject FinalTile3;
    public GameObject FinalTile4;
    private DN_YellowTiles FinalTile1Script;
    private DN_YellowTiles FinalTile2Script;
    private DN_YellowTiles FinalTile3Script;
    private DN_YellowTiles FinalTile4Script;
    public GameObject WallBlocker2;
    public bool SpawnBLockOnce;
    public bool SpawnBLockOnce2;
    //public GameObject GameMangerOBJ;
    //public DN_GameManager GameManagerScript;
    public GameObject[] BlockAppear;
    public MeshRenderer[] BlockMesh;
    public BoxCollider[] BlockCollider;
    public SpriteRenderer[] PushSprite;
    public GameObject[] TimePickups;
    private float BoolCD;

    // Use this for initialization
    void Start()
    {
        BoolCD = 1;
        BlockMesh[0] = BlockAppear[0].GetComponent<MeshRenderer>();
        BlockMesh[1] = BlockAppear[1].GetComponent<MeshRenderer>();
        BlockMesh[2] = BlockAppear[2].GetComponent<MeshRenderer>();
        BlockMesh[3] = BlockAppear[3].GetComponent<MeshRenderer>();
        BlockMesh[4] = BlockAppear[4].GetComponent<MeshRenderer>();
        BlockMesh[5] = BlockAppear[5].GetComponent<MeshRenderer>();
        BlockMesh[6] = BlockAppear[6].GetComponent<MeshRenderer>();
        BlockMesh[7] = BlockAppear[7].GetComponent<MeshRenderer>();
        BlockCollider[0] = BlockAppear[0].GetComponent<BoxCollider>();
        BlockCollider[1] = BlockAppear[1].GetComponent<BoxCollider>();
        BlockCollider[2] = BlockAppear[2].GetComponent<BoxCollider>();
        BlockCollider[3] = BlockAppear[3].GetComponent<BoxCollider>();
        BlockCollider[4] = BlockAppear[4].GetComponent<BoxCollider>();
        BlockCollider[5] = BlockAppear[5].GetComponent<BoxCollider>();
        BlockCollider[6] = BlockAppear[6].GetComponent<BoxCollider>();
        BlockCollider[7] = BlockAppear[7].GetComponent<BoxCollider>();
        TriggerScript1 = Trigger1.GetComponent<DN_PlayerCubeBlockTrigger>();
        TriggerScript2 = Trigger2.GetComponent<DN_PlayerCubeBlockTrigger>();
        TriggerScript3 = Trigger3.GetComponent<DN_PlayerCubeBlockTrigger>();
        TriggerScript4 = Trigger4.GetComponent<DN_PlayerCubeBlockTrigger>();
        TriggerScript5 = Trigger5.GetComponent<DN_PlayerCubeBlockTrigger>();
        TriggerScript6 = Trigger6.GetComponent<DN_PlayerCubeBlockTrigger>();
        TriggerScript7 = Trigger7.GetComponent<DN_PlayerCubeBlockTrigger>();
        TriggerScript8 = Trigger8.GetComponent<DN_PlayerCubeBlockTrigger>();
        FinalTile1Script = FinalTile1.GetComponent<DN_YellowTiles>();
        FinalTile2Script = FinalTile2.GetComponent<DN_YellowTiles>();
        FinalTile3Script = FinalTile3.GetComponent<DN_YellowTiles>();
        FinalTile4Script = FinalTile4.GetComponent<DN_YellowTiles>();
        //GameManagerScript = GameMangerOBJ.GetComponent<DN_GameManager>();
        _objectpool = new DictionaryObjectPool();
        _objectpool.AddObjectPool("FireBullet", Bullets[0], ShootPoint[0].transform, 100);
        _objectpool.AddObjectPool("FireBullet", Bullets[0], ShootPoint[1].transform, 100);
        _objectpool.AddObjectPool("FireBullet", Bullets[0], ShootPoint[2].transform, 100);
        _objectpool.AddObjectPool("FireBullet", Bullets[0], ShootPoint[3].transform, 100);
        _objectpool.AddObjectPool("FireBullet", Bullets[0], ShootPoint[4].transform, 100);
        _objectpool.AddObjectPool("FireBullet", Bullets[0], ShootPoint[5].transform, 100);
        _objectpool.AddObjectPool("FireBullet", Bullets[0], ShootPoint[6].transform, 100);
        _objectpool.AddObjectPool("FireBullet", Bullets[0], ShootPoint[7].transform, 100);
        _objectpool.AddObjectPool("FireBullet", Bullets[0], ShootPoint[8].transform, 100);
        _objectpool.AddObjectPool("FireBullet", Bullets[0], ShootPoint[9].transform, 100);
        _objectpool.AddObjectPool("FireBullet", Bullets[0], ShootPoint[10].transform, 100);
        _objectpool.AddObjectPool("FireBullet", Bullets[0], ShootPoint[11].transform, 100);
        _objectpool.AddObjectPool("FireBullet", Bullets[0], ShootPoint[12].transform, 100);
        _objectpool.AddObjectPool("FireBullet", Bullets[0], ShootPoint[13].transform, 100);
        _objectpool.AddObjectPool("FireBullet", Bullets[0], ShootPoint[14].transform, 100);
        _objectpool.AddObjectPool("FireBullet", Bullets[0], ShootPoint[15].transform, 100);
        _objectpool.AddObjectPool("FireBullet", Bullets[0], ShootPoint[16].transform, 100);
        _objectpool.AddObjectPool("FireBullet", Bullets[0], ShootPoint[17].transform, 100);
        _objectpool.AddObjectPool("FireBullet", Bullets[0], ShootPoint[18].transform, 100);
        _objectpool.AddObjectPool("FireBullet", Bullets[0], ShootPoint[19].transform, 100);
        _objectpool.AddObjectPool("FireBullet", Bullets[0], ShootPoint[20].transform, 100);
        _objectpool.AddObjectPool("FireBullet", Bullets[0], ShootPoint[21].transform, 100);
        _objectpool.AddObjectPool("FireBullet", Bullets[0], ShootPoint[22].transform, 100);
        _objectpool.AddObjectPool("FireBullet", Bullets[0], ShootPoint[23].transform, 100);
        _objectpool.AddObjectPool("FireBullet", Bullets[0], ShootPoint[25].transform, 100);
        _objectpool.AddObjectPool("FireBullet", Bullets[0], ShootPoint[26].transform, 100);
        _objectpool.AddObjectPool("FireBullet", Bullets[0], ShootPoint[27].transform, 100);
        _objectpool.AddObjectPool("FireBullet", Bullets[0], ShootPoint[28].transform, 100);
        _objectpool.AddObjectPool("FireBullet", Bullets[0], ShootPoint[29].transform, 100);
        _objectpool.AddObjectPool("FireBullet", Bullets[0], ShootPoint[30].transform, 100);
        _objectpool.AddObjectPool("FireBullet", Bullets[0], ShootPoint[31].transform, 100);
        _objectpool.AddObjectPool("FireBullet", Bullets[0], ShootPoint[32].transform, 100);
        _objectpool.AddObjectPool("FireBullet", Bullets[0], ShootPoint[33].transform, 100);
        _objectpool.AddObjectPool("FireBullet", Bullets[0], ShootPoint[34].transform, 100);
        _objectpool.AddObjectPool("FireBullet", Bullets[0], ShootPoint[35].transform, 100);
        _objectpool.AddObjectPool("FireBullet", Bullets[0], ShootPoint[36].transform, 100);
        _objectpool.AddObjectPool("FireBullet", Bullets[0], ShootPoint[37].transform, 100);
        _objectpool.AddObjectPool("FireBullet", Bullets[0], ShootPoint[38].transform, 100);
        _objectpool.AddObjectPool("FireBullet", Bullets[0], ShootPoint[39].transform, 100);
        _objectpool.AddObjectPool("FireBullet", Bullets[0], ShootPoint[40].transform, 100);
        _objectpool.AddObjectPool("FireBullet", Bullets[0], ShootPoint[41].transform, 100);
        _objectpool.AddObjectPool("FireBullet", Bullets[0], ShootPoint[42].transform, 100);
        _objectpool.AddObjectPool("FireBullet", Bullets[0], ShootPoint[43].transform, 100);
        _objectpool.AddObjectPool("FireBullet", Bullets[0], ShootPoint[44].transform, 100);
        _objectpool.AddObjectPool("FireBullet", Bullets[0], ShootPoint[45].transform, 100);
        _objectpool.AddObjectPool("FireBullet", Bullets[0], ShootPoint[46].transform, 100);
        _objectpool.AddObjectPool("FireBullet", Bullets[0], ShootPoint[47].transform, 100);
        _objectpool.AddObjectPool("FireBullet", Bullets[0], ShootPoint[48].transform, 100);
        _objectpool.AddObjectPool("FireBullet", Bullets[0], ShootPoint[49].transform, 100);
        _objectpool.AddObjectPool("FireBullet", Bullets[0], ShootPoint[50].transform, 100);
        _objectpool.AddObjectPool("FireBullet", Bullets[0], ShootPoint[51].transform, 100);
        _objectpool.AddObjectPool("FireBullet", Bullets[0], ShootPoint[52].transform, 100);
        _objectpool.AddObjectPool("FireBullet", Bullets[0], ShootPoint[53].transform, 100);
        _objectpool.AddObjectPool("FireBullet", Bullets[0], ShootPoint[54].transform, 100);
        _objectpool.AddObjectPool("FireBullet", Bullets[0], ShootPoint[55].transform, 100);
        _objectpool.AddObjectPool("FireBullet", Bullets[0], ShootPoint[56].transform, 100);
        _objectpool.AddObjectPool("FireBullet", Bullets[0], ShootPoint[57].transform, 100);
        _objectpool.AddObjectPool("FireBullet", Bullets[0], ShootPoint[58].transform, 100);
        _objectpool.AddObjectPool("FireBullet", Bullets[0], ShootPoint[59].transform, 100);
        _objectpool.AddObjectPool("FireBullet", Bullets[0], ShootPoint[60].transform, 100);
        _objectpool.AddObjectPool("FireBullet", Bullets[0], ShootPoint[61].transform, 100);
        _objectpool.AddObjectPool("FireBullet", Bullets[0], ShootPoint[52].transform, 100);
    }

    // Update is called once per frame
    void Update()
    {
        if(FinalTile1Script.TileDone && FinalTile2Script.TileDone && FinalTile3Script.TileDone && FinalTile4Script.TileDone)
        {

            DN_GameManager.SquareHome = true;
            DN_GameManager.XHome = true;
            DN_GameManager.TriangleHome = true;
            DN_GameManager.OHome = true;
            PartThree = false;
           
           
        }
        if(TriggerScript1.Player1InPlace && TriggerScript2.Player2InPlace && TriggerScript3.Player3InPlace && TriggerScript4.Player4InPlace)
        {
            Trigger1.SetActive(false);
            Trigger2.SetActive(false);
            Trigger3.SetActive(false);
            Trigger4.SetActive(false);
            WallBlocker.SetActive(true);
            PartOne = false;
            BoolCD -= Time.deltaTime;
            
            if (SpawnBLockOnce == false)
            {
                TimePickups[0].SetActive(true);
                TimePickups[1].SetActive(true);
                PushSprite[0].enabled = true;
                    PushSprite[1].enabled = true;
                    PushSprite[2].enabled = true;
                    PushSprite[3].enabled = true;
                    BlockMesh[0].enabled = true;
                    BlockMesh[1].enabled = true;
                    BlockMesh[2].enabled = true;
                    BlockMesh[3].enabled = true;
                    BlockCollider[0].enabled = true;
                    BlockCollider[1].enabled = true;
                    BlockCollider[2].enabled = true;
                    BlockCollider[3].enabled = true;
                    

                    PartTwo = true;
                if (BoolCD <= 0)
                {
                    SpawnBLockOnce = true;
                    BoolCD = 1;
                }
                
            }
        }
        if (TriggerScript5.Player1InPlace && TriggerScript6.Player2InPlace && TriggerScript7.Player3InPlace && TriggerScript8.Player4InPlace)
        {
            BoolCD -= Time.deltaTime;
            Trigger5.SetActive(false);
            Trigger6.SetActive(false);
            Trigger7.SetActive(false);
            Trigger8.SetActive(false);
            PartTwo = false;
            WallBlocker2.SetActive(true);
            PartOne = false;
            if (SpawnBLockOnce2 == false)
            {
                TimePickups[2].SetActive(true);
                TimePickups[3].SetActive(true);
                TimePickups[4].SetActive(true);
                PushSprite[4].enabled = true;
                PushSprite[5].enabled = true;
                PushSprite[6].enabled = true;
                PushSprite[7].enabled = true;
                BlockMesh[4].enabled = true;
                BlockMesh[5].enabled = true;
                BlockMesh[6].enabled = true;
                BlockMesh[7].enabled = true;
                BlockCollider[4].enabled = true;
                BlockCollider[5].enabled = true;
                BlockCollider[6].enabled = true;
                BlockCollider[7].enabled = true;
                PartThree = true;
                if (BoolCD <= 0)
                {
                    SpawnBLockOnce2 = true;
                    BoolCD = 1;
                }
                
            }
           
        }
        if (FireWaveCount2>=55)
        {
            FireWaveCount2 = 0;
        }
        if(FireWaveCount >= 20)
        {
            FireWaveCount = 0;
        }
        if(FireWaveCount3 >=440)
        {
            FireWaveCount3 = 0;
        }

        fireCountdown -= Time.deltaTime;
        if (PartOne)
        {
            FireWaveCount += Time.deltaTime;
            if (fireCountdown <= 0)
            {
                if (_objectpool["FireBullet"].Count < numberstospawn)
                {
                    if (FireWaveCount < 5)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[0].transform.position, ShootPoint[0].transform.rotation);
                        _objectpool["FireBullet"].Spawn(ShootPoint[1].transform.position, ShootPoint[1].transform.rotation);
                    }
                    if (FireWaveCount > 5 && FireWaveCount < 10)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[2].transform.position, ShootPoint[2].transform.rotation);
                        _objectpool["FireBullet"].Spawn(ShootPoint[3].transform.position, ShootPoint[3].transform.rotation);
                    }
                    if (FireWaveCount > 10 && FireWaveCount < 15)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[4].transform.position, ShootPoint[4].transform.rotation);
                        _objectpool["FireBullet"].Spawn(ShootPoint[5].transform.position, ShootPoint[5].transform.rotation);
                    }
                    if (FireWaveCount > 15 && FireWaveCount < 20)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[6].transform.position, ShootPoint[6].transform.rotation);
                        _objectpool["FireBullet"].Spawn(ShootPoint[7].transform.position, ShootPoint[7].transform.rotation);
                    }
                }
                fireCountdown = 1f / fireRate;
            }
        }
        if(PartTwo)
        {
            FireWaveCount2 += Time.deltaTime *4;
            if (fireCountdown <= 0)
            {
                if (_objectpool["FireBullet"].Count < numberstospawn)
                {
                    if (FireWaveCount2 < 5)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[8].transform.position, ShootPoint[8].transform.rotation);
                    }
                    if (FireWaveCount2 > 5 && FireWaveCount2 < 10)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[9].transform.position, ShootPoint[9].transform.rotation);
                        
                    }
                    if (FireWaveCount2 > 10 && FireWaveCount2 < 15)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[10].transform.position, ShootPoint[10].transform.rotation);
                    }
                    if (FireWaveCount2 > 15 && FireWaveCount2 < 20)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[11].transform.position, ShootPoint[11].transform.rotation);
                    }
                    if (FireWaveCount2 >20 && FireWaveCount2<25)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[12].transform.position, ShootPoint[12].transform.rotation);
                    }
                    if (FireWaveCount2 > 25 && FireWaveCount2 < 30)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[13].transform.position, ShootPoint[13].transform.rotation);
                    }
                    if (FireWaveCount2 > 30 && FireWaveCount2 < 35)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[14].transform.position, ShootPoint[14].transform.rotation);
                    }
                    if (FireWaveCount2 > 35 && FireWaveCount2 < 40)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[15].transform.position, ShootPoint[15].transform.rotation);
                    }
                    if (FireWaveCount2 > 40 && FireWaveCount2 < 45)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[16].transform.position, ShootPoint[16].transform.rotation);
                    }
                    if (FireWaveCount2 > 45 && FireWaveCount2 < 50)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[17].transform.position, ShootPoint[17].transform.rotation);
                    }
                    if (FireWaveCount2 > 50 && FireWaveCount2 < 55)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[18].transform.position, ShootPoint[18].transform.rotation);
                    }

                }
                fireCountdown = 1f / fireRate;
            }
        }
        if(PartThree)
        {
            FireWaveCount3 += Time.deltaTime * 6;
            if (fireCountdown <= 0)
            {
                if (_objectpool["FireBullet"].Count < numberstospawn)
                {
                    if (FireWaveCount3 < 5)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[19].transform.position, ShootPoint[19].transform.rotation);
                    }
                    if (FireWaveCount3 > 5 && FireWaveCount3 < 10)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[20].transform.position, ShootPoint[20].transform.rotation);

                    }
                    if (FireWaveCount3 > 10 && FireWaveCount3 < 15)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[21].transform.position, ShootPoint[21].transform.rotation);
                    }
                    if (FireWaveCount3 > 15 && FireWaveCount3 < 20)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[22].transform.position, ShootPoint[22].transform.rotation);
                    }
                    if (FireWaveCount3 > 20 && FireWaveCount3 < 25)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[23].transform.position, ShootPoint[23].transform.rotation);
                    }
                    if (FireWaveCount3 > 25 && FireWaveCount3 < 30)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[24].transform.position, ShootPoint[24].transform.rotation);
                    }
                    if (FireWaveCount3 > 30 && FireWaveCount3 < 35)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[25].transform.position, ShootPoint[25].transform.rotation);
                    }
                    if (FireWaveCount3 > 35 && FireWaveCount3 < 40)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[26].transform.position, ShootPoint[26].transform.rotation);
                    }
                    if (FireWaveCount3 > 40 && FireWaveCount3 < 45)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[27].transform.position, ShootPoint[27].transform.rotation);
                    }
                    if (FireWaveCount3 > 45 && FireWaveCount3 < 50)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[28].transform.position, ShootPoint[28].transform.rotation);
                    }
                    if (FireWaveCount3 > 50 && FireWaveCount3 < 55)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[29].transform.position, ShootPoint[29].transform.rotation);
                    }
                    if (FireWaveCount3 > 55 && FireWaveCount3 < 60)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[30].transform.position, ShootPoint[30].transform.rotation);

                    }
                    if (FireWaveCount3 > 60 && FireWaveCount3 < 65)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[31].transform.position, ShootPoint[31].transform.rotation);
                    }
                    if (FireWaveCount3 > 65 && FireWaveCount3 < 70)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[32].transform.position, ShootPoint[32].transform.rotation);
                    }
                    if (FireWaveCount3 > 70 && FireWaveCount3 < 75)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[33].transform.position, ShootPoint[33].transform.rotation);
                    }
                    if (FireWaveCount3 > 75 && FireWaveCount3 < 80)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[34].transform.position, ShootPoint[34].transform.rotation);
                    }
                    if (FireWaveCount3 > 80 && FireWaveCount3 < 85)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[35].transform.position, ShootPoint[35].transform.rotation);
                    }
                    if (FireWaveCount3 > 85 && FireWaveCount3 < 90)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[36].transform.position, ShootPoint[36].transform.rotation);
                    }
                    if (FireWaveCount3 > 90 && FireWaveCount3 < 95)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[37].transform.position, ShootPoint[37].transform.rotation);
                    }
                    if (FireWaveCount3 > 95 && FireWaveCount3 < 100)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[38].transform.position, ShootPoint[38].transform.rotation);
                    }
                    if (FireWaveCount3 > 100 && FireWaveCount3 < 105)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[39].transform.position, ShootPoint[39].transform.rotation);
                    }
                    if (FireWaveCount3 > 105 && FireWaveCount3 < 110)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[40].transform.position, ShootPoint[40].transform.rotation);
                    }
                    if (FireWaveCount3 > 110 && FireWaveCount3 < 115)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[41].transform.position, ShootPoint[41].transform.rotation);
                    }
                    if (FireWaveCount3 > 115 && FireWaveCount3 < 120)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[42].transform.position, ShootPoint[42].transform.rotation);
                    }
                    if (FireWaveCount3 > 120 && FireWaveCount3 < 125)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[43].transform.position, ShootPoint[43].transform.rotation);
                    }
                    if (FireWaveCount3 > 125 && FireWaveCount3 < 130)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[44].transform.position, ShootPoint[44].transform.rotation);
                    }
                    if (FireWaveCount3 > 130 && FireWaveCount3 < 135)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[45].transform.position, ShootPoint[45].transform.rotation);
                    }
                    if (FireWaveCount3 > 135 && FireWaveCount3 < 140)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[46].transform.position, ShootPoint[46].transform.rotation);
                    }
                    if (FireWaveCount3 > 140 && FireWaveCount3 < 145)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[47].transform.position, ShootPoint[47].transform.rotation);
                    }
                    if (FireWaveCount3 > 145 && FireWaveCount3 < 150)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[48].transform.position, ShootPoint[48].transform.rotation);
                    }
                    if (FireWaveCount3 > 150 && FireWaveCount3 < 155)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[49].transform.position, ShootPoint[49].transform.rotation);
                    }
                    if (FireWaveCount3 > 155 && FireWaveCount3 < 160)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[50].transform.position, ShootPoint[50].transform.rotation);
                    }
                    if (FireWaveCount3 > 160 && FireWaveCount3 < 165)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[51].transform.position, ShootPoint[51].transform.rotation);
                    }
                    if (FireWaveCount3 > 165 && FireWaveCount3 < 170)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[52].transform.position, ShootPoint[52].transform.rotation);
                    }
                    if (FireWaveCount3 > 170 && FireWaveCount3 < 175)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[53].transform.position, ShootPoint[53].transform.rotation);
                    }
                    if (FireWaveCount3 > 175 && FireWaveCount3 < 180)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[54].transform.position, ShootPoint[54].transform.rotation);
                    }
                    if (FireWaveCount3 > 180 && FireWaveCount3 < 185)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[55].transform.position, ShootPoint[55].transform.rotation);
                    }
                    if (FireWaveCount3 > 185 && FireWaveCount3 < 190)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[56].transform.position, ShootPoint[56].transform.rotation);
                    }
                    if (FireWaveCount3 > 190 && FireWaveCount3 < 195)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[57].transform.position, ShootPoint[57].transform.rotation);
                    }
                    if (FireWaveCount3 > 195 && FireWaveCount3 < 200)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[58].transform.position, ShootPoint[58].transform.rotation);
                    }
                    if (FireWaveCount3 > 200 && FireWaveCount3 < 205)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[59].transform.position, ShootPoint[59].transform.rotation);
                    }
                    if (FireWaveCount3 > 205 && FireWaveCount3 < 210)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[60].transform.position, ShootPoint[60].transform.rotation);
                    }
                    if (FireWaveCount3 > 210 && FireWaveCount3 < 215)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[61].transform.position, ShootPoint[61].transform.rotation);
                    }
                    if (FireWaveCount3 > 215 && FireWaveCount3 < 220)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[62].transform.position, ShootPoint[62].transform.rotation);
                    }
                    if (FireWaveCount3 > 220 && FireWaveCount3 < 225)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[63].transform.position, ShootPoint[63].transform.rotation);
                    }
                    if (FireWaveCount3 > 225 && FireWaveCount3 < 230)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[64].transform.position, ShootPoint[64].transform.rotation);
                    }
                    if (FireWaveCount3 > 230 && FireWaveCount3 < 235)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[65].transform.position, ShootPoint[65].transform.rotation);
                    }
                    if (FireWaveCount3 > 235 && FireWaveCount3 < 240)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[66].transform.position, ShootPoint[66].transform.rotation);
                    }
                    if (FireWaveCount3 > 240 && FireWaveCount3 < 245)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[67].transform.position, ShootPoint[67].transform.rotation);
                    }
                    if (FireWaveCount3 > 245 && FireWaveCount3 < 250)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[68].transform.position, ShootPoint[68].transform.rotation);
                    }
                    if (FireWaveCount3 > 250 && FireWaveCount3 < 255)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[69].transform.position, ShootPoint[69].transform.rotation);
                    }
                    if (FireWaveCount3 > 255 && FireWaveCount3 < 260)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[70].transform.position, ShootPoint[70].transform.rotation);
                    }
                    if (FireWaveCount3 > 260 && FireWaveCount3 < 265)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[71].transform.position, ShootPoint[71].transform.rotation);
                    }
                    if (FireWaveCount3 > 265 && FireWaveCount3 < 270)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[72].transform.position, ShootPoint[72].transform.rotation);
                    }
                    if (FireWaveCount3 > 270 && FireWaveCount3 < 275)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[73].transform.position, ShootPoint[73].transform.rotation);
                    }
                    if (FireWaveCount3 > 275 && FireWaveCount3 < 280)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[74].transform.position, ShootPoint[74].transform.rotation);
                    }
                    if (FireWaveCount3 > 280 && FireWaveCount3 < 285)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[75].transform.position, ShootPoint[75].transform.rotation);
                    }
                    if (FireWaveCount3 > 285 && FireWaveCount3 < 290)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[76].transform.position, ShootPoint[76].transform.rotation);
                    }
                    if (FireWaveCount3 > 290 && FireWaveCount3 < 295)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[77].transform.position, ShootPoint[77].transform.rotation);
                    }
                    if (FireWaveCount3 > 295 && FireWaveCount3 < 300)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[78].transform.position, ShootPoint[78].transform.rotation);
                    }
                    if (FireWaveCount3 > 300 && FireWaveCount3 < 305)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[79].transform.position, ShootPoint[79].transform.rotation);
                    }
                    if (FireWaveCount3 > 305 && FireWaveCount3 < 310)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[80].transform.position, ShootPoint[80].transform.rotation);
                    }
                    if (FireWaveCount3 > 310 && FireWaveCount3 < 315)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[81].transform.position, ShootPoint[81].transform.rotation);
                    }
                    if (FireWaveCount3 > 315 && FireWaveCount3 < 320)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[82].transform.position, ShootPoint[82].transform.rotation);
                    }
                    if (FireWaveCount3 > 320 && FireWaveCount3 < 325)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[83].transform.position, ShootPoint[83].transform.rotation);
                    }
                    if (FireWaveCount3 > 325 && FireWaveCount3 < 330)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[84].transform.position, ShootPoint[84].transform.rotation);
                    }
                    if (FireWaveCount3 > 330 && FireWaveCount3 < 335)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[85].transform.position, ShootPoint[85].transform.rotation);
                    }
                    if (FireWaveCount3 > 335 && FireWaveCount3 < 340)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[86].transform.position, ShootPoint[86].transform.rotation);
                    }
                    if (FireWaveCount3 > 340 && FireWaveCount3 < 345)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[87].transform.position, ShootPoint[87].transform.rotation);
                    }
                    if (FireWaveCount3 > 345 && FireWaveCount3 < 350)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[88].transform.position, ShootPoint[88].transform.rotation);
                    }
                    if (FireWaveCount3 > 350 && FireWaveCount3 < 355)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[89].transform.position, ShootPoint[89].transform.rotation);
                    }
                    if (FireWaveCount3 > 355 && FireWaveCount3 < 360)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[90].transform.position, ShootPoint[90].transform.rotation);
                    }
                    if (FireWaveCount3 > 360 && FireWaveCount3 < 365)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[91].transform.position, ShootPoint[91].transform.rotation);
                    }
                    if (FireWaveCount3 > 365 && FireWaveCount3 < 370)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[92].transform.position, ShootPoint[92].transform.rotation);
                    }
                    if (FireWaveCount3 > 370 && FireWaveCount3 < 375)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[93].transform.position, ShootPoint[93].transform.rotation);
                    }
                    if (FireWaveCount3 > 375 && FireWaveCount3 < 380)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[94].transform.position, ShootPoint[94].transform.rotation);
                    }
                    if (FireWaveCount3 > 380 && FireWaveCount3 < 385)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[95].transform.position, ShootPoint[95].transform.rotation);
                    }
                    if (FireWaveCount3 > 385 && FireWaveCount3 < 390)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[96].transform.position, ShootPoint[96].transform.rotation);
                    }
                    if (FireWaveCount3 > 390 && FireWaveCount3 < 395)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[97].transform.position, ShootPoint[97].transform.rotation);
                    }
                    if (FireWaveCount3 > 395 && FireWaveCount3 < 400)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[98].transform.position, ShootPoint[98].transform.rotation);
                    }
                    if (FireWaveCount3 > 400 && FireWaveCount3 < 405)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[99].transform.position, ShootPoint[99].transform.rotation);
                    }
                    if (FireWaveCount3 > 405 && FireWaveCount3 < 410)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[100].transform.position, ShootPoint[100].transform.rotation);
                    }
                    if (FireWaveCount3 > 410 && FireWaveCount3 < 415)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[101].transform.position, ShootPoint[101].transform.rotation);
                    }
                    if (FireWaveCount3 > 415 && FireWaveCount3 < 420)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[102].transform.position, ShootPoint[102].transform.rotation);
                    }
                    if (FireWaveCount3 > 420 && FireWaveCount3 < 425)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[103].transform.position, ShootPoint[103].transform.rotation);
                    }
                    if (FireWaveCount3 > 425 && FireWaveCount3 < 430)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[104].transform.position, ShootPoint[104].transform.rotation);
                    }
                    if (FireWaveCount3 > 430 && FireWaveCount3 < 435)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[105].transform.position, ShootPoint[105].transform.rotation);
                    }
                    if (FireWaveCount3 > 435 && FireWaveCount3 < 440)
                    {
                        _objectpool["FireBullet"].Spawn(ShootPoint[106].transform.position, ShootPoint[106].transform.rotation);
                    }
                }
                fireCountdown = 1f / fireRate;
            }
        }
    }
}
