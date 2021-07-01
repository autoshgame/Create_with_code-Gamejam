using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{

    protected int score = 0;
    public int Score
    {
        get
        {
            return score;
        }
    }
    private int lives = 3;
    public int Lives
    {
        get
        {
            return lives;
        }
    }
    
    protected float fitnessPoint;
    public float FitnessPoint
    {
        get
        {
            return fitnessPoint;
        }
    }
    [SerializeField] protected float maxFitnessPoint;

    [SerializeField] protected TextMeshProUGUI scoreText;
    [SerializeField] protected TextMeshProUGUI totalScore;
    [SerializeField] protected TextMeshProUGUI livesText;

    [SerializeField] protected Slider fitnessSlide; 


    // Start is called before the first frame update
    void Start()
    {
        UpdateLives();
        fitnessSlide.maxValue = maxFitnessPoint;
        fitnessSlide.minValue = FitnessPoint;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnGUI()
    {
        UpdateLives();
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score : " + score.ToString();
    }


    public void UpdateLives()
    {
        livesText.text = "Lives : " + lives.ToString();
    }


    public void SetTotalPoint()
    {
        totalScore.text = "Total score : " + score.ToString();
    }


    public void DecreaseLives()
    {
        lives--;
    }


    public void IncreaseLives()
    {
        lives++;
    }

    
    public void IncreaseFitness()
    {

    }


    public void DecreaseFitness()
    {

    }
}
