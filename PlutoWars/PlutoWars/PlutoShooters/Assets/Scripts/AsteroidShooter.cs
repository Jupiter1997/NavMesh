using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class AsteroidShooter : NetworkBehaviour {
    public GameObject bulletPrefab;
    public Transform bulletSpawn;

    public GameObject powerUp;
    // Use this for initialization
    void Start () {
        InvokeRepeating("Shoot", 1, 1);
    }
	
	// Update is called once per frame
	void Update () {
		
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
                Destroy(this.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }

           
        }
        if (other.gameObject.tag == "bullet")
        {
            Destroy(this.gameObject);
            Destroy(other.gameObject);
            GameObject jiabin = Instantiate(powerUp, this.transform.position, this.transform.rotation) as GameObject;
            NetworkServer.Spawn(jiabin);
            
        }
    }
    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawn.transform.position, bulletSpawn.transform.rotation);
        NetworkServer.Spawn(bullet);
        Destroy(bullet, 3.0f);
    }
}
