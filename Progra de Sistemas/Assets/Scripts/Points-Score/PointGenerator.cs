using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointGenerator : MonoBehaviour
{
    [SerializeField] private PointPickup pointPickup;
    [SerializeField] private int pointSpawnTime = 3;

    float currentTime = 0;

    private void Update()
    {
        currentTime += Time.deltaTime;

        if (currentTime >= pointSpawnTime)
        {
            PointPickup newEnemy = Instantiate(pointPickup);

            newEnemy.transform.SetParent(this.gameObject.transform);
            newEnemy.transform.position = new Vector3(Random.Range(-5, 5), 1, Random.Range(-5, 5));
            currentTime = 0;
        }
    }
}
