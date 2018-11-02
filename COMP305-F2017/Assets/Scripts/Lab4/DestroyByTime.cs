using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByTime : MonoBehaviour {

    public float timeDestroyer = 1.0f;
	// Use this for initialization
	void Start () {
        Destroy(this.gameObject, timeDestroyer);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
