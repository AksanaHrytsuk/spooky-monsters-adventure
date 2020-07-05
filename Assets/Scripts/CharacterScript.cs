﻿using UnityEngine;

public class CharacterScript : BaseClass
{
    private void Update()
    {
        DoDamage();
    }

    void DoDamage()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Animator.Play("Player_Attack");
            
            RaycastHit2D hit2D = Physics2D.Raycast(transform.position, GetAttackDirection(), attackRadius, selectObjectsToHit);
            if (hit2D.collider != null)
            {
                EnemyScript damageOwner = hit2D.collider.GetComponent<EnemyScript>();
                damageOwner.GetDamage(damage);
            }
        }
    }
}
