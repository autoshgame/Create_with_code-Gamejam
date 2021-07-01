using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    protected float horizontalInput;
    [Range(0, 100)] [SerializeField] protected float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        OutOfRange();
    }


    public void Move()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        this.transform.Translate(Vector3.right * speed * horizontalInput * Time.deltaTime);
    }


    public void OutOfRange()
    {
        if(this.transform.position.x <= -4)
        {
            this.transform.position = new Vector3(-4, this.transform.position.y, this.transform.position.z);
        }
        else if(this.transform.position.x >= 4)
        {
            this.transform.position = new Vector3(4, this.transform.position.y, this.transform.position.z);
        }
    }
}
