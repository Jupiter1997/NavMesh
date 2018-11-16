using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSceneManager : MonoBehaviour {

    private int selectedShipIndex;

    public GameObject[] Ships;
	// Use this for initialization
	void Start () {
        Debug.Log(PlayerPrefs.GetInt("SelectedShip"));
        selectedShipIndex = PlayerPrefs.GetInt("SelectedShip");

        Instantiate(Ships[selectedShipIndex -1], this.transform.position, this.transform.rotation);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
