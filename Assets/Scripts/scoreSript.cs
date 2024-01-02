using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class scoreSript : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int currentScore;
    public float timer;
    private float _originalTimer;
    
    private void Start()
    {
        _originalTimer = timer;
    }
    
    private void FixedUpdate()
    {
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            currentScore += 1;
            timer = _originalTimer;
        }

        scoreText.text = "Score: " + currentScore.ToString();
    }


}
