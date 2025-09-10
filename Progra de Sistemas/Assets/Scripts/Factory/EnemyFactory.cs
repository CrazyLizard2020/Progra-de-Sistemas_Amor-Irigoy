using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFactory : MonoBehaviour
{
    [SerializeField] private BasicStateEnemy[] enemies;
    private Dictionary<string, BasicStateEnemy> enemiesDict;

    public BasicStateEnemy[] Enemies => enemies;

    private void Start()
    {
        enemiesDict = new Dictionary<string, BasicStateEnemy>();

        foreach (BasicStateEnemy enemy in enemies)
        {
            enemiesDict.Add(enemy.ID, enemy);
        }
    }

    public BasicStateEnemy CreateEnemy(string id)
    {
        if(!enemiesDict.TryGetValue(id, out BasicStateEnemy enemy))
        {
            return null;
        }
        return Instantiate(enemy);
    }

    public BasicStateEnemy CreateEnemy(string id, Vector3 position)
    {
        if (!enemiesDict.TryGetValue(id, out BasicStateEnemy enemy))
        {
            return null;
        }
        return Instantiate(enemy, position, Quaternion.identity);
    }
}
