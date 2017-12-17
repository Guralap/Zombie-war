using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class update1 : MonoBehaviour {

    // Use this for initialization
    public Text Scoretext;
    int score = 0;

    public void UpdateScore()
    {
        score++;
        Scoretext.text = "SCORE:" + score;
    }

    public void UpdateScore(int newScore)
    {
        score++;
        Scoretext.text = "Score:" + score;
    }
}
