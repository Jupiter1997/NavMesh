using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Networking;

public class PlayerInstantiate : NetworkBehaviour {

    // Use this for initialization
    public GameObject[] PlayerPrefabs;
    int selectedindex;

	void Start () {
        selectedindex = PlayerPrefs.GetInt("SelectedShip");

        GameObject childObject = Instantiate(PlayerPrefabs[selectedindex -1]) as GameObject;
        Debug.Log("Selectedship " + selectedindex);
        //childObject.transform.parent = this.transform;
        childObject.transform.SetParent(this.transform);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
