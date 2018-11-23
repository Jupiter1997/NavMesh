using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour {


    
    public float accelerationSpeed = 0.3f;
    public float rotateSpeed = 3.0f;

    //Shoot
    public GameObject bulletPrefab;
    public Transform bulletSpawn;

    private float fireRate = 0.5f;
    private float nextFire;


	void Start () {
//        rb = GetComponent<Rigidbody2D>();
		
	}	
	// Update is called once per frame
	void FixedUpdate () {
        var hori = Input.GetAxis("Horizontal");
        var vert = Input.GetAxis("Vertical");

        // rb.AddForce(transform.right * vert * accelerationSpeed * Time.deltaTime);
        // rb.AddTorque(hori * rotateSpeed, ForceMode2D.Force);

        transform.Rotate(0,0,-hori * rotateSpeed);
        transform.Translate(vert * accelerationSpeed,0,0);
        Boundary();

        if (Input.GetKey("space") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Shoot();
        }




    }
    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawn.transform.position, bulletSpawn.transform.rotation);
        Destroy(bullet, 3.0f);
    }
    void Boundary()
    {
        if (transform.position.x <= -13)
        {
            transform.position = new Vector2(-13, transform.position.y);

        }
        else if (transform.position.x >= 13)
        {
            transform.position = new Vector2(13, transform.position.y);
        }

        if (transform.position.y <= -10)
        {
            transform.position = new Vector2(transform.position.x, -10);

        }
        else if (transform.position.y >= 10)
        {
            transform.position = new Vector2(transform.position.x, 10);
        }
    }
}
