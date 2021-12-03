using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddforceEnemies : MonoBehaviour
{
    Rigidbody2D rb;

    public float speed = 10f;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(-transform.right * speed);
    }
}
