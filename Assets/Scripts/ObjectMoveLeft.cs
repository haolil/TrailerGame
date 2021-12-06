using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMoveLeft : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position -= new Vector3(1, 0, 0) * speed * Time.deltaTime;
    }
}
