using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab4ClickController : MonoBehaviour {
    public GameObject bomb;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		
	}
    void OnMouseDown()
    {
        Vector3 mousepos = Input.mousePosition;

        Vector3 objPos = Camera.main.ScreenToWorldPoint(mousepos);

        Debug.Log("Accom");
        Instantiate(bomb, new Vector3(objPos.x,objPos.y,0), transform.rotation);
    }
}
