using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class ShipController : NetworkBehaviour {

    public float accelerationSpeed = 5f;
    public float rotateSpeed = 180f;
    private float shipBoundaryRadius = 0.5f;
    //Shoot
    public GameObject bulletPrefab;
    public Transform bulletSpawn;

    public GameObject[] Shields;

    public float fireRate = 0.5f;
    private float nextFire;


    [SyncVar]
    public int ShipIndex;

    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = MyNetworkManager.m_Singleton.ship[ShipIndex];
        var myNewSmoke = Instantiate(Shields[ShipIndex], this.transform.position, Quaternion.identity);
        myNewSmoke.transform.parent = gameObject.transform;
    }
    // Update is called once per frame
    void FixedUpdate() {
        if (!isLocalPlayer)
        {
            return;
        }

        var hori = Input.GetAxis("Horizontal");
        var vert = Input.GetAxis("Vertical");

        //ROTATIONS
        Quaternion rot = transform.rotation;
        float z = rot.eulerAngles.z;
        z -= hori * rotateSpeed * Time.deltaTime;
        rot = Quaternion.Euler(0, 0, z);

        transform.rotation = rot;

        //MOVEMENTS
        Vector3 pos = transform.position;
        Vector3 velocity = new Vector3(vert * accelerationSpeed * Time.deltaTime, 0, 0);
        pos += rot * velocity;

        //Boundary
        if (pos.y - shipBoundaryRadius >= Camera.main.orthographicSize || pos.y + shipBoundaryRadius <= -Camera.main.orthographicSize)
        {
            pos.y = -pos.y;
        }
        float screenRatio = (float)Screen.width / (float)Screen.height;
        float widthOrtho = Camera.main.orthographicSize * screenRatio;
        if (pos.x - shipBoundaryRadius >= widthOrtho || pos.x + shipBoundaryRadius <= -widthOrtho)
        {
            pos.x = -pos.x;
        }

        transform.position = pos;





        if (Input.GetKey("space") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            CmdShoot();
        }

    }
    [Command]
    void CmdShoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawn.transform.position, bulletSpawn.transform.rotation);
        NetworkServer.Spawn(bullet);
        Destroy(bullet, 3.0f);
    }

}
