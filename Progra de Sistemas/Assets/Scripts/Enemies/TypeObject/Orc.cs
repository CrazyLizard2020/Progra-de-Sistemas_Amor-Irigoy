using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orc : EnemyType
{
    public override void Attack()
    {
        Debug.Log("PLUMBA! Ataque de " + damage);
    }

    public override void TakeDamage(int damage)
    {
        Debug.Log("Auch, pero no tanto. Soy un orco");
    }
}
