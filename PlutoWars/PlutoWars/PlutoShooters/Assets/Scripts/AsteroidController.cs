using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class AsteroidController : NetworkBehaviour
{
    public GameObject asteroid;
    
    GameObject asteroidclone;
    public float startIn = 1;
    public float every = 2;
    


    // Use this for initialization
    void Start() {

        
        InvokeRepeating("Rpcspawn", startIn, every);
        

    }

    // Update is called once per frame
    void Update() {
        //Timer -= Time.deltaTime;
        //if (Timer <= 0f)
        //{
        //    asteroidclone = Instantiate(asteroid, new Vector3(Random.Range(-9.0f, 9.0f), Random.Range(-6.0f, 6.0f), 0), Quaternion.Euler(0, 0, Random.Range(-0.0f, 359.0f))) as GameObject;

        //    Timer = 15f;
        //}
        //if (!isLocalPlayer)
        //{
        //    Destroy(asteroidclone);
        //    return;
        //}
    }
    




    [ClientRpc]
    void Rpcspawn()
    {

        asteroidclone = Instantiate(asteroid, new Vector3(Random.Range(-9.0f, 9.0f), Random.Range(-6.0f, 6.0f), 0), Quaternion.Euler(0, 0, Random.Range(-0.0f, 359.0f))) as GameObject;
        asteroidclone.GetComponent<Rigidbody2D>().AddForce(transform.up * Random.Range(-50.0f, 150.0f));
        asteroidclone.GetComponent<Rigidbody2D>().angularVelocity = Random.Range(-0.0f, 360.0f);
        NetworkServer.Spawn(asteroidclone);
        Destroy(asteroidclone, 20.0f);
    }
}