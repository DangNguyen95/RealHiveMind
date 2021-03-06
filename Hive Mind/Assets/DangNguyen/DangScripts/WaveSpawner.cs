﻿using UnityEngine;
using System.Collections;

public class WaveSpawner : MonoBehaviour
{



    public enum SpawnState { SPAWNING, WAITING, COUNTING };

    [System.Serializable]
    public class Wave
    {
        public string name;
        public Transform enemy;
        public int count;
        public float rate;
    }
    public string UnitBeingSpawn;
    public string UnitBeingSpawn2;

    public Wave[] waves;
    public int nextWave = 0;
    public int NextWave
    {
        get { return nextWave + 1; }
    }

    public Transform[] spawnPoints;
    public Transform[] MeteorspawnPoints;
    public Transform[] BossSpawnPoint;

    public float timeBetweenWaves = 5f;
    private float waveCountdown;
    public float WaveCountdown
    {
        get { return waveCountdown; }
    }

    private float searchCountdown = 1f;

    private SpawnState state = SpawnState.COUNTING;
    public SpawnState State
    {
        get { return state; }
    }
    public GameObject Boss;
    void Start()
    {
        
        if (spawnPoints.Length == 0)
        {
            Debug.LogError("No spawn points referenced.");
        }
        if (MeteorspawnPoints.Length == 0)
        {
            Debug.LogError("No spawn points referenced.");
        }

        waveCountdown = timeBetweenWaves;
    }


    void Update()
    {
        if (NextWave == 5)
        {
                searchCountdown -= Time.deltaTime;
                if (searchCountdown <= 0f)
                {
                    searchCountdown = 1f;
                    if (GameObject.FindGameObjectWithTag(UnitBeingSpawn2) == null)
                    {
                        Boss.SetActive(true);
                    }
                }

        }
        if (state == SpawnState.WAITING)
        {
            if (!EnemyIsAlive())
            {
                WaveCompleted();
            }
            else
            {
                return;
            }
        }

        if (waveCountdown <= 0)
        {
            if (state != SpawnState.SPAWNING)
            {
                StartCoroutine(SpawnWave(waves[nextWave]));
            }
        }
        else
        {
            waveCountdown -= Time.deltaTime;
        }

    }

    void WaveCompleted()
    {
        Debug.Log("Wave Completed!");

        state = SpawnState.COUNTING;
        waveCountdown = timeBetweenWaves;

        if (nextWave + 1 > waves.Length - 1)
        {
            nextWave = 0;
            Debug.Log("ALL WAVES COMPLETE! Looping...");
        }
        else
        {
            nextWave++;
        }
    }

    bool EnemyIsAlive()
    {
        searchCountdown -= Time.deltaTime;
        if (searchCountdown <= 0f)
        {
            if (nextWave == 0 || nextWave == 2)
            {
                searchCountdown = 1f;
                if (GameObject.FindGameObjectWithTag(UnitBeingSpawn) == null)
                {
                    return false;
                }
            }
                if (nextWave == 1 || nextWave == 3)
            {
                searchCountdown = 1f;
                if (GameObject.FindGameObjectWithTag(UnitBeingSpawn2) == null)
                {
                    return false;
                }
            }
            
        }
        return true;
    }

    IEnumerator SpawnWave(Wave _wave)
    {
        Debug.Log("Spawning Wave: " + _wave.name);
        state = SpawnState.SPAWNING;

        for (int i = 0; i < _wave.count; i++)
        {
            SpawnEnemy(_wave.enemy);
            yield return new WaitForSeconds(2f/ _wave.rate);
        }

        state = SpawnState.WAITING;

        yield break;
    }

    void SpawnEnemy(Transform _enemy)
    {
        Debug.Log("Spawning Enemy: " + _enemy.name);

        if (nextWave == 1 || nextWave == 3)
        {
            Transform _sp2 = MeteorspawnPoints[Random.Range(0, MeteorspawnPoints.Length)];
            Instantiate(_enemy, _sp2.position, _sp2.rotation);
        }
        if (nextWave == 0 || nextWave == 2)
        {
            Transform _sp = spawnPoints[Random.Range(0, spawnPoints.Length)];
            Instantiate(_enemy, _sp.position, _sp.rotation);
        }
      
    }

}

