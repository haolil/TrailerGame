using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMoveTowardsPlayer : MonoBehaviour
{
    public GameObject player;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        if(transform.position.x < player.transform.position.x)
        {
            transform.right = (player.transform.position - transform.position);
        }
        else
        {
            transform.right = -(player.transform.position - transform.position);
        }

    }
}
