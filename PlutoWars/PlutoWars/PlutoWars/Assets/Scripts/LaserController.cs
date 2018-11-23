using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserController : MonoBehaviour {

    public float speed = 10.0f;
    Rigidbody2D rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
		
	}
	
	// Update is called once per frame
	void Update () {
        rb.velocity = transform.right * speed;
	}
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            Debug.Log("Hit " + other.gameObject.name);
        }
    }
}
