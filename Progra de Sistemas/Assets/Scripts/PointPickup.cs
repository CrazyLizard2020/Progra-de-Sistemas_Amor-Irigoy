using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointPickup : MonoBehaviour
{
    [SerializeField] private string id;
    [SerializeField] private int score = 1;

    public string ID => id;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ScoreManager.Instance.AddScore(score);
            this.gameObject.SetActive(false);
        }
    }
}
