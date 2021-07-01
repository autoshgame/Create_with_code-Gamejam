using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    [SerializeField] protected GameManager gameManager;

    [SerializeField] protected AudioSource gameAudio;

    [SerializeField] protected AudioClip gameOverAudio;

    protected bool isGameOverPlayed = false;
    
    // Start is called before the first frame update
    void Start()
    {
        gameAudio.Play();
        gameAudio.loop = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameManager.IsGameOver() && !isGameOverPlayed)
        {
            gameAudio.PlayDelayed(8);
            gameAudio.PlayOneShot(gameOverAudio);
            isGameOverPlayed = true;
        }
    }
}
