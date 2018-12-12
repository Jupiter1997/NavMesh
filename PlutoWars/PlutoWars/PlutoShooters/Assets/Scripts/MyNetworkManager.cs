using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MyNetworkManager : NetworkManager {

    public Dictionary<int, int> ShipSelection = new Dictionary<int, int>();

    public Sprite[] ShipsSprite;

	// Use this for initialization
	void Start () {
       // PlayerPrefs.GetInt("SelectedShip");
		
	}

    // Update is called once per frame
    public override void OnServerAddPlayer(NetworkConnection conn, short playerControllerId)
    {
        GameObject playerGB = Instantiate(playerPrefab, Vector3.zero, Quaternion.identity);
        playerGB.GetComponent<SpriteRenderer>().sprite = ShipsSprite[PlayerPrefs.GetInt("SelectedShip") - 1];
        Debug.Log("");
        NetworkServer.AddPlayerForConnection(conn, playerGB, playerControllerId);
    }
}
