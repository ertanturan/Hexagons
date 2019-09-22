using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hexagon : MonoBehaviour,IPooledObject
{

    private Rigidbody2D _rb;

    public float ShrinkSpeeed = 3f;

    void Start()
    {
 Init();
    }

    private void Init()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rb.rotation = Random.Range(0f, 360f);
        transform.localScale = Vector3.one * 10f;
    }

    void Update()
    {
        transform.localScale -= Vector3.one * ShrinkSpeeed * Time.deltaTime;

        if (transform.localScale.x<.5f)
        {
            ObjectPooler.Instance.Despawn(PooledObjectType.Hexagon);
        }
    }


    public void OnObjectSpawn()
    {
        Init();
    }

    public void OnObjectDespawn()
    {
        transform.localScale = Vector3.one * 10f;
    }
}
