using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyType", menuName = "Flyweight/EnemyType", order = 1)]
public abstract class EnemyType : ScriptableObject
{
    public int damage;
    public int speed;
    public int maxHealth;
    public int currentHealth;
    public string name;

    public PointPickup drop;

    public virtual void Attack() { }
    public virtual void TakeDamage(int damage) { }
}
