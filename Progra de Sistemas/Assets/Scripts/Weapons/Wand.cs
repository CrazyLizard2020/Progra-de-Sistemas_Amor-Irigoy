using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wand : MonoBehaviour, IWeapon
{
    private string wName = "Wand";

    public string Name
    {
        get { return name; }
    }

    public void Attack()
    {
        Debug.Log("Wand attack");
    }
}
