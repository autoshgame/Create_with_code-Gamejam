using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] protected GameManager gameManager;

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

    protected float healthyPoint = 50;
    public float HealthyPoint
    {
        get
        {
            return healthyPoint;
        }
    }
    [SerializeField] protected float maxFitnessPoint = 100;

    [SerializeField] protected TextMeshProUGUI scoreText;
    [SerializeField] protected TextMeshProUGUI totalScore;
    [SerializeField] protected TextMeshProUGUI livesText;

    [SerializeField] protected Slider fitnessSlide; 


    // Start is called before the first frame update
    void Start()
    {
        UpdateLives();
        fitnessSlide.maxValue = maxFitnessPoint;
        fitnessSlide.minValue = 0;
        fitnessSlide.value = healthyPoint;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnGUI()
    {
        UpdateLives();
        UpdateHealthyPoint();
    }


    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score : " + score.ToString();
    }


    public void UpdateLives()
    {
        livesText.text = "Lives : " + (lives).ToString();
    }


    public void SetTotalPoint()
    {
        totalScore.text = "Total score : " + score.ToString();
    }


    public void DecreaseLives()
    {
        if (lives <= 1)
            gameManager.GameOver();
        else
            lives--;
    }


    public void IncreaseLives()
    {
        lives++;
    }


    public void DecreaseHealthy()
    {
        if (HealthyPoint >= 0)
            healthyPoint -= 10;
        else if (HealthyPoint < 0)
        {
            DecreaseLives();
            ResetHealthyPoint(100);
        }
    }


    public void IncreaseHeathy()
    {
        if(HealthyPoint <= 100)
            healthyPoint += 10;
        else if (HealthyPoint > 100)
        {
            IncreaseLives();
            ResetHealth();
        }
    }


    public void UpdateHealthyPoint()
    {
        fitnessSlide.value = healthyPoint;
    }


    public void ResetHealth()
    {
        healthyPoint = 0;
    }


    public void ResetHealthyPoint(float value)
    {
        healthyPoint = value;
    }
}
