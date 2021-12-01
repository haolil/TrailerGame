using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovementController : MonoBehaviour
{
    public float moveSpeed = 0;
    public float Jumpheight = 4000;

    private Rigidbody2D rb;
    private bool activeCharactercar = false;
    private bool activeCharacterkong = false;
    private bool activeCharacterkiller = false;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
