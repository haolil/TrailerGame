using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            Swipe();
        }
    }
    void Swipe()
    {
        //play attack anim
        animator.SetTrigger("Attack");
        //detect enemies in range of attack

        //damage

    }
}
