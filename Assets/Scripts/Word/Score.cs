using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private WordManager score;
    public Text scoreText;

    void Start()
    {
        score = GameObject.Find("WordManager").GetComponent<WordManager>();
        
    }

    
    void Update()
    {
        scoreText.text = score.score.ToString();
       // Debug.Log(score.score);
    }
}
