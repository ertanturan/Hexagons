using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hexagon : MonoBehaviour
{

    private Rigidbody2D _rb;

    public float ShrinkSpeeed = 3f;


    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rb.rotation = Random.Range(0f, 360f);
        transform.localScale = Vector3.one * 10f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale -= Vector3.one * ShrinkSpeeed * Time.deltaTime;

        if (transform.localScale.x<.5f)
        {
            Destroy(gameObject);
        }
    }
}
