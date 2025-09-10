using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class OtherEnemy : MonoBehaviour
{
    public EnemyType type;

    private int currentHealth;

    void Awake()
    {
        if (type == null)
        {
            Debug.LogError($"{name} has no EnemyType assigned.");
            return;
        }

        currentHealth = type.maxHealth;
    }

    void Update()
    {
        TakeDamage(1);
        transform.Translate(Vector3.left * type.speed * Time.deltaTime);
    }

    public void TakeDamage(int dmg)
    {
        type.TakeDamage(dmg);
        if (currentHealth <= 0) Die();
    }

    public void Attack()
    {
        type.Attack();
    }

    void Die()
    {
        // dropear si corresponde
        if (type.drop != null) Instantiate(type.drop, transform.position, Quaternion.identity);
        // dar xp, reproducir anim, etc.
        Destroy(gameObject);
    }
}
