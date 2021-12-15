using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public float TotalScore;
    private void Start()
    {
        
    }
    private void Update()
    {
        
    }

    public void IncreaseScore(float score)
    {
        TotalScore += score;
        Debug.Log(TotalScore);
    }
}
