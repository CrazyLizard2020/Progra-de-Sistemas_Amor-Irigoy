using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    [SerializeField] private EnemyFactory enemyFactoryRef;
    [SerializeField] private float enemySpawnTime = 3;
    string rndID;

    float currentTime = 0;

    private void Update()
    {
        currentTime += Time.deltaTime;

        if (currentTime >= enemySpawnTime)
        {
            BasicStateEnemy[] enemiesRef = enemyFactoryRef.Enemies;
            rndID = enemiesRef[Random.Range(0, enemiesRef.Length - 1)].ID;

            BasicStateEnemy newEnemy = enemyFactoryRef.CreateEnemy(rndID);

            newEnemy.transform.SetParent(this.gameObject.transform);
            newEnemy.transform.position = new Vector3(Random.Range(-5, 5), 1, Random.Range(-5, 5));
            currentTime = 0;
        }
    }
}
