using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PruebaData", menuName = "Flyweight/CosaRancia", order = 1)]

public class Prueba : ScriptableObject
{
    [SerializeField] public int x;
    [SerializeField] public int y;
    [SerializeField] public int z;
    [SerializeField] public string name;
}
