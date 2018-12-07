using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
        var hit = other.gameObject;
        var health = hit.GetComponent<Health>();
        if (other.gameObject.tag == "Player")
        {
            if (health != null)
            {
                health.TakeDamage(1);
            }
            
            Destroy(this.gameObject);
        }


    }
}

