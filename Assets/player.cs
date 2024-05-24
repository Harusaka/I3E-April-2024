using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    int currentScore = 0;

    public void IncreaseScore(int scoreToAdd)
    {
        currentScore += scoreToAdd;
        Debug.Log(currentScore);

    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
