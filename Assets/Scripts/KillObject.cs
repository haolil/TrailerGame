using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillObject : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name != "Blimp(Clone)")
        {
            collision.transform.GetComponent<DealDamage>().damage = 0;
            collision.transform.GetComponent<Animator>().Play("Explode");
            //Destroy(collision.gameObject);
        }

    }
}
