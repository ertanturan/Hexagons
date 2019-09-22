using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public static Spawner Instance;
    public float SpawnRate = 1f;

    private float _nextTimeToSpawn = 0f;

    public bool IsSpawnable = true;


    private void Awake()
    {
        Instance = this;
    }

    void Update()
    {
        if (IsSpawnable)
        {
            if (Time.time >= _nextTimeToSpawn)
            {
                ObjectPooler.Instance.SpawnFromPool(PooledObjectType.Hexagon, Vector3.zero, Quaternion.identity);
                _nextTimeToSpawn = Time.time + 1f / SpawnRate;
            }
        }
        
    }
}
