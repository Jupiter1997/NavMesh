using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {

    public float exploRadius = 50.0f;
    public float exploForce = 1.0f;

    private RaycastHit2D[] hits;
    // Use this for initialization
    void Start () {

        hits = Physics2D.CircleCastAll(this.transform.position, exploRadius, Vector2.zero);

        foreach (RaycastHit2D h in hits)
        {
            if (h.transform.gameObject.tag == "Crate")
                h.rigidbody.AddForce((h.transform.position - this.transform.position) * exploForce, ForceMode2D.Impulse);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
