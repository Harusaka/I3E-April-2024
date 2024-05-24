using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    int currentScore = 0;
    public void IncreaseScore(int scoreToAdd)
    {
        currentScore += scoreToAdd;

        scoreText.text = currentScore.ToString();
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
