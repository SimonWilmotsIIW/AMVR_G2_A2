using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public Text scoreText; // The UI Text element to display the score
    private int currentScore = 50;

    void Awake()
    {
        // Singleton pattern to ensure there is only one ScoreManager
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddScore(int scoreToAdd)
    {
        currentScore += scoreToAdd;
        UpdateScoreUI();
    }

    private void UpdateScoreUI()
    {
        scoreText.text = "Score: " + currentScore.ToString();
    }
}
