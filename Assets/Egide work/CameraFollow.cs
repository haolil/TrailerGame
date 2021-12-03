using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform car;
    public Vector3 offset;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //  transform.position = car.position + offset;
        transform.position = Vector3.Lerp(transform.position, car.position, 0.1f) + new Vector3(0, 0, -1);
    }
}
