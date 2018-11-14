using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour {

    private Rigidbody2D rb;
    
    public float accelerationSpeed = 1.0f;
    public float rotateSpeed = 3.0f;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();

		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        var hori = Input.GetAxis("Horizontal");
        var vert = Input.GetAxis("Vertical");

        // rb.AddForce(transform.right * vert * accelerationSpeed * Time.deltaTime);
        // rb.AddTorque(hori * rotateSpeed, ForceMode2D.Force);

        transform.Rotate(0,0,-hori * rotateSpeed);
        transform.Translate(vert * accelerationSpeed,0,0);

        




    }
}
