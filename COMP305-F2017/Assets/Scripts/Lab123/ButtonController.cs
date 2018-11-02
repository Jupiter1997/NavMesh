using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour {
    //Dress 'Em Up Code
    public Sprite Dresser;
    public GameObject Jupiter;
	// Use this for initialization
	void Start () {
        Jupiter = GameObject.Find("JupiterDefault");
	}
	
	// Update is called once per frame
	void Update () {
        
		
	}
     void OnMouseDown()
    {
        Jupiter.GetComponent<SpriteRenderer>().sprite = Dresser;
    }
}
