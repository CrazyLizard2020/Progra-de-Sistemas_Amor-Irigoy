using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Como lo visto en clase

public class EnemyAbstractFactory : MonoBehaviour
{
    [SerializeField] private EnemyFactory factory;
    private float timer;
    private int factoryIndex = 0;
    private int rnd;

    private void Update()
    {
        timer += Time.deltaTime;
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rnd = Random.Range(0, factory.Enemies.Length);
            factory.CreateEnemy(factory.Enemies[rnd].ID, new Vector3(Random.Range(-3, 3), 1, Random.Range(-3, 3)));
        }

        if (timer >= 5)
        {
            factoryIndex++;
            if (factoryIndex >= transform.childCount)
            {
                factoryIndex = 0;
            }

            factory = transform.GetChild(factoryIndex).gameObject.GetComponent<EnemyFactory>();
            timer = 0;
        }
    }
}
