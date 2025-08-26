using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    static private ScoreManager instance;
    [SerializeField] private int currentScore = 0;

    public static ScoreManager Instance => instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    public void AddScore(int score)
    {
        currentScore += score;
    }

    public int GetCurrentScore()
    {
        return currentScore;
    }
}
