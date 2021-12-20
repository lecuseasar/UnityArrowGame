using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Game : MonoBehaviour
{
    public float TotalScore;
    public TMP_Text scoreText;
    private void Start()
    {
        
    }
    private void Update()
    {
        
    }

    public void IncreaseScore(float score)
    {
        TotalScore += score;
        // TODO: BURADA CARPISMA OLDUGU AN CARPMSA SESINI OYNAT
        scoreText.text = $"Score : " + TotalScore;
    }
}
