using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreTracker : MonoBehaviour
{
    private int score;
    public TextMeshProUGUI scoreText;

    void Start()
    {
        score = 0;
        UpdateScore();
    }

    void UpdateScore()
    {
        scoreText.text = "Score: " + score;
        Debug.Log("score updated!");
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Lasagna"))
        {
            Debug.Log("Compared Lasagna Tag");
            IncreaseScore(1);
            UpdateScore();
        }
    }

    void IncreaseScore(int points)
    {
        score += points;
        Debug.Log("score increased!");
    }
}
