using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] protected GameObject tileScreen;
    [SerializeField] protected GameObject pauseScreen;
    [SerializeField] protected GameObject middldeScreen;
    [SerializeField] protected GameObject endScreen;
    [SerializeField] protected GameObject player;
    [SerializeField] protected List<GameObject> targets;

    [SerializeField] protected bool isGameOver;

    [SerializeField] protected Button mediumButton;
    [SerializeField] protected Button hardButton;
    [SerializeField] protected Button exitButton;

    [SerializeField] protected PlayerUI playerUI;



    private void Awake()
    {
        player.gameObject.SetActive(false);
        tileScreen.gameObject.SetActive(true);
        endScreen.gameObject.SetActive(false);
        middldeScreen.gameObject.SetActive(false);
        exitButton.gameObject.SetActive(true);
        pauseScreen.gameObject.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

     // Update is called once per frame
    void Update()
    {
        
    }


    public bool IsGameOver()
    {
        return isGameOver;
    }


    public void GameOver()
    {
        isGameOver = true;
        middldeScreen.gameObject.SetActive(false);
        endScreen.gameObject.SetActive(true);

        //Let the scoretext move to another position because of having bug in rendering
        middldeScreen.gameObject.transform.position = new Vector3(-999, 699, 0);

        playerUI.SetTotalPoint();
    }
    

    public void StartGame()
    {
        isGameOver = false;
        tileScreen.gameObject.SetActive(false);
        middldeScreen.gameObject.SetActive(true);
        player.gameObject.SetActive(true);
        exitButton.gameObject.SetActive(false);
        playerUI.UpdateScore(0);
    }


    public void PauseGame()
    {
        Time.timeScale = 0;
        pauseScreen.gameObject.SetActive(true);
        middldeScreen.gameObject.SetActive(false);
    }


    public void ReloadGame()
    {
        SceneManager.LoadScene("Prototype 5");
        Time.timeScale = 1;
        isGameOver = false;
    }


    public void ReturnGame()
    {
        Time.timeScale = 1;
        pauseScreen.gameObject.SetActive(false);
        middldeScreen.gameObject.SetActive(true);
    }


    public void ExitApplication()
    {
        Application.Quit();
    }



}
