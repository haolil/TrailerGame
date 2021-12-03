using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carController : MonoBehaviour
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
        rb.AddForce(transform.right * speed); // Time.deltaTime); 

        if (Input.GetKeyDown(KeyCode.S))
        {
            rb.AddForce(new Vector3(0, -speed, 0));
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(new Vector3(0, speed, 0));
        }
    }

    

}
