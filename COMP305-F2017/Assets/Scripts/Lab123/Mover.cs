using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

    public GameObject player;
    Rigidbody2D rb;
    // Use this for initialization
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
       
       
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void FixedUpdate()
    {
        float hMove = Input.GetAxis("Horizontal");
        rb.velocity = new Vector3(hMove * 3, 0, 0);
        float GOAL = this.transform.position.x;
        if (GOAL > 29f )
        {
            this.transform.position = new Vector3(0, 0, 0);
        }


       
          
    }
}
