using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    int score;
    int highScore;
    Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText = GetComponent<Text>();
        scoreText.text = score.ToString();
        highScore = PlayerPrefs.GetInt("highscore");
    }
    public void Scored()
    {
        score++;
        scoreText.text = score.ToString();
        if (score > highScore)
        {
            highScore = score;
            Debug.Log("high score");
            PlayerPrefs.SetInt("highscore", highScore);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
