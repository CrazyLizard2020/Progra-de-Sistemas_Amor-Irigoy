using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    static private ScoreManager instance;
    [SerializeField] private int currentScore = 0;
    [SerializeField] private int nextLvlScore;

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

        Debug.Log(currentScore);

        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        if (currentSceneIndex + 1 >= SceneManager.sceneCountInBuildSettings)
        {
            Debug.Log("No hay proximo nivel");
            return;
        }

        if (currentScore % nextLvlScore == 0)
        {
            string nextSceneName = SceneManager.GetSceneByBuildIndex(currentSceneIndex + 1).name;
            Debug.Log("Cambio de escena");
            SceneManager.LoadScene(nextSceneName);
        }
    }

    public int GetCurrentScore()
    {
        return currentScore;
    }
}
