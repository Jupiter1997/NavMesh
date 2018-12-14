using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldScript : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(this.gameObject);
        Debug.Log(this.gameObject.name);
    }
}
