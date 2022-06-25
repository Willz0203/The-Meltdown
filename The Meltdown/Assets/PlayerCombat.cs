using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
   public Animator animator;

   public Transform attackPoint;
   public float attackRange = .05f;
   public LayerMask enemyLayers;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Attack();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            rightWalk();
        }
    }

    void Attack()
    {
        //Attack animation
        animator.SetTrigger("Attack");
        //detect enimies in range
        //damage them

    }

    void rightWalk()
    {
        animator.SetTrigger("rightWalk");
    }
}
