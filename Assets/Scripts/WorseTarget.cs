using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorseTarget : MonoBehaviour
{
    protected bool isAudioPlayed = false;

    private Rigidbody targetRB;

    [SerializeField] protected int pointValue;

    [SerializeField] protected GameManager gameManager;
    
    [SerializeField] protected PlayerUI playerUI;

    [SerializeField] protected ParticleSystem explosionParticle;

    [SerializeField] protected AudioClip explosionSound;

    [SerializeField] protected AudioSource getAudioSource;




    // Start is called before the first frame update
    void Start()
    {
        targetRB = this.GetComponent<Rigidbody>();
        targetRB.AddTorque(RandomTorque(), ForceMode.Impulse);
        targetRB.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ;
        this.transform.position = RandomPosition();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        getAudioSource = GameObject.Find("Audio Source").GetComponent<AudioSource>();
        playerUI = GameObject.Find("Player UI").GetComponent<PlayerUI>();
    }

    // Update is called once per frame
    void Update()
    {
        OutOfBound();
    }


    public Vector3 RandomPosition()
    {
        return new Vector3(Random.Range(-4, 4), 11, 0);
    }


    public Vector3 RandomTorque()
    {
        return new Vector3(Random.value, Random.value, Random.value);
    }


    public void OutOfBound()
    {
        if (gameManager.IsGameOver() == false && this.transform.position.y <= -3f)
        {
            Destroy(this.gameObject);
        }
        else if (gameManager.IsGameOver())
        {
            Destroy(this.gameObject);
        }
    }


    public void OnMouseDown()
    {
        if (!gameManager.IsGameOver())
        {
            Destroy(this.gameObject);
            Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);
            getAudioSource.PlayOneShot(explosionSound, 1f);
            playerUI.DecreaseLives();
            playerUI.ResetHealth();
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player") && targetRB.velocity.y <= -0.01f)
        {
            Destroy(this.gameObject);
            Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);
            getAudioSource.PlayOneShot(explosionSound, 1f);
            playerUI.DecreaseLives();
            playerUI.ResetHealth();
        }
    }
}
