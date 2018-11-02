using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombController : MonoBehaviour {

    public GameObject explo;

	// Use this for initialization
	void Start () {
        StartCoroutine(WaitThreeExplode());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    IEnumerator WaitThreeExplode()
    {
        yield return new WaitForSeconds(3);
        Debug.Log("3 seconds");
        Instantiate(explo, this.transform.position, this.transform.rotation);
        Destroy(this.gameObject);
    }
}
