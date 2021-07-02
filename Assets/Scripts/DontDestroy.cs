using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DontDestroy : MonoBehaviour
{
    protected GameObject[] gameObjects;
    [SerializeField] protected Slider soundSlide;

    private void Awake()
    {
        gameObjects = GameObject.FindGameObjectsWithTag("music");
        DontDestroyOnLoad(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
