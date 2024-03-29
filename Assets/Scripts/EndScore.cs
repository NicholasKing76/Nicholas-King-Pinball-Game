﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScore : MonoBehaviour
{
    public Text displayScore;
    public Text displayHighScore;
    private int score;
    private int highscore;
    // Start is called before the first frame update
    void Start()
    {
        highscore = PlayerPrefs.GetInt("HighScore");
        score = PlayerPrefs.GetInt("Score");
        if (score > highscore)
        {
            highscore = score;
        }
        PlayerPrefs.SetInt("HighScore", highscore);
        highscore = PlayerPrefs.GetInt("HighScore");
        displayScore.text = "Score: " + score;
        displayHighScore.text = "High Score: " + highscore;
    }

    // Update is called once per frame
    void Update()
    {
    
    }
}
