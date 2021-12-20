using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Game : MonoBehaviour
{
    public float TotalScore;
    public TMP_Text scoreText;
    public List<AudioSource> collisionSounds;

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
        //collisionSound.Play();
        System.Random random = new System.Random();
        int a = random.Next(0,2);
        collisionSounds[a].Play();

        scoreText.text = $"Score : " + TotalScore;
    }
}
