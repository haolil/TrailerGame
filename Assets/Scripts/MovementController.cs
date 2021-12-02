using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovementController : MonoBehaviour
{
    public float vertMovespeed = 5;
    public float horiMovespeed = 5;
    public float Jumpheight = 4000;

    private Rigidbody2D rb;
    private bool activeCharactercar = false;
    private bool activeCharacterkong = false;
    private bool activeCharacterkiller = false;
    private float vertMovementdirection = 0;
    private float horiMovementdirection = 0;

    private void Awake()
    {
        
        //grab the current rigid body that the script is attached to
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        processInputs();
       
    }
    private void FixedUpdate()
    {
        Movement();
    }
    private void Movement()
    {
        //car movement
        if (activeCharactercar == true)
        {
            rb.velocity = new Vector2(horiMovementdirection * horiMovespeed, vertMovementdirection * vertMovespeed);
        }

        //kong movement
        if (activeCharacterkong == true)
        {
            rb.velocity = new Vector2(0, vertMovementdirection * vertMovespeed);
        }

        //killer movement
        if (activeCharacterkiller == true)
        {
            rb.velocity = new Vector2(horiMovementdirection * horiMovespeed, vertMovementdirection * vertMovespeed);
        }
    }
    private void processInputs()
    {
        horiMovementdirection = Input.GetAxis("Horizontal");
        vertMovementdirection = Input.GetAxis("Vertical");
    }
}
