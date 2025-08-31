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
        if (newWeapon != weapon)
        {
            weapon = newWeapon;
            Debug.Log("Changed weapon to " + weapon.Name);
        }
    }
}
