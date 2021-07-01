using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] protected List<GameObject> targets;

    private float spawnDelay = 1.0f;

    [SerializeField] protected GameManager gameManager;


    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
       // Debug.Log(gameManager.IsGameOver());
    }


    IEnumerator SpawnTarget(float difficulty)
    {
        while(gameManager.IsGameOver() == false)
        {
            yield return new WaitForSeconds(spawnDelay/difficulty);
            int targetIndex = Random.Range(0, targets.Count);
            Instantiate(targets[targetIndex], targets[targetIndex].transform.position, targets[targetIndex].transform.rotation );
        }
    }


    public void StartSpawning(float difficulty)
    {
        StartCoroutine(SpawnTarget(difficulty));
    }

}
