using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackComponent : MonoBehaviour
{
    IWeapon weapon;

    public void Attack()
    {
        if (weapon != null)
        {
            weapon.Attack();
        }
    }

    public void ChangeWeapon(IWeapon newWeapon)
    {
        weapon = newWeapon;
    }
}
