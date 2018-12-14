using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpController : MonoBehaviour {


    void Start()
    {
        Destroy(this.gameObject, 5.0f);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        var hit = other.gameObject;
        var ship = hit.GetComponent<ShipController>();
        if (other.gameObject.tag == "Player")
        {
            ship.accelerationSpeed = 10.0f;
            Destroy(this.gameObject);
        }

    }




}
