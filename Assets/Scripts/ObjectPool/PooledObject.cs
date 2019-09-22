using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PooledObject : MonoBehaviour,IPooledObject
{
    [HideInInspector]
    public PooledObjectType Type;

    public void OnObjectSpawn()
    {

    }

    public void OnObjectDespawn()
    {

    }

}
