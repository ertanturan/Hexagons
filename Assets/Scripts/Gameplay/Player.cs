using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float MoveSpeed = 600f;

    private float _movement = 0f;

    private void Update()
    {
        _movement = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward,
            _movement * Time.fixedDeltaTime * -MoveSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("PLAYER FAILED..");
        Spawner.Instance.IsSpawnable = false;
        StartCoroutine(DelayedPause());
        Time.timeScale = 0;
    }

    private IEnumerator DelayedPause()
    {
        yield return new WaitForSecondsRealtime(.25f);
    
    }
}
