using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour, IWeapon
{
    private string wName = "Gun";

    public string Name
    {
        get { return name; }
    }

    public void Attack()
    {
        Debug.Log("Gun attack");
    }
}
