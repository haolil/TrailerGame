using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovementController : MonoBehaviour
{
    public float vertMovespeed = 5;
    public float horiMovespeed = 5;
    public float Jumpheight = 4000;
    public GameObject currentPlayerobject = null;

    private Rigidbody2D rb;

    private bool activeCharactercar = false;
    private bool activeCharacterkong = false;
    private bool activeCharacterkiller = false;
    private bool facingRight = true;
    private float vertMovementdirection = 0;
    private float horiMovementdirection = 0;

    private void Awake()
    {
        
        //grab the current rigid body that the script is attached to
        rb = GetComponent<Rigidbody2D>();
        if(currentPlayerobject.name == "car")
        {
            activeCharactercar = true;
        }
        if (currentPlayerobject.name == "kong")
        {
            activeCharacterkong = true;
        }
        if (currentPlayerobject.name == "killer")
        {
            activeCharacterkiller = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        processInputs();
        //only animate when kong is out
        if(activeCharacterkong == true)
        {
           // Animate();
        }
       
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

    private void Animate()
    {
        if (horiMovementdirection > 0 && !facingRight)
        {
            flipCharacter();
        }
        else if (horiMovementdirection < 0 && facingRight)
        {
            flipCharacter();
        }
    }

    private void flipCharacter()
    {
        facingRight = !facingRight;
        transform.Rotate(0f, 180f, 0f);
    }
}