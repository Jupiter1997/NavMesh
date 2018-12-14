﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class AsteroidShooter : MonoBehaviour {
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    // Use this for initialization
    void Start () {
        InvokeRepeating("Shoot", 1, 1);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawn.transform.position, bulletSpawn.transform.rotation);
        NetworkServer.Spawn(bullet);
        Destroy(bullet, 3.0f);
    }
}