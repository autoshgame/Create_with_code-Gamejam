using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButton : MonoBehaviour
{
    protected Button levelButton;

    protected GameManager gameManager;

    protected SpawnManager spawnManager;

    [SerializeField] protected float difficulty;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        spawnManager = GameObject.Find("Spawn Manager").GetComponent<SpawnManager>();
        levelButton = this.GetComponent<Button>();
        levelButton.onClick.AddListener(SetDifficulty);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    void SetDifficulty()
    {
        gameManager.StartGame();
        spawnManager.StartSpawning(difficulty);
    }
}
