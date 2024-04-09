using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text scoreText;
    private static ScoreController instance;
    public static ScoreController Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<ScoreController>();
            }
            return instance;
        }
    }
     public int score = 0;
    public void IncreaseScore(int value)
    {
        score += value;
        Debug.Log("Score Increased! New Score: " + score);
        scoreText.text =  "Score: "+ score.ToString();

    }
}