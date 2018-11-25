using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class PlayerSceneManager : NetworkBehaviour {

    private int playerCount;
  //  public GameObject[] Ships;

    NetworkClient network;

    public Text PCount;


    // Use this for initialization
    void Start()
    {
        //reads the index of ship selected
      
      //  Debug.Log(PlayerPrefs.GetInt("SelectedShip") + shipSprite[selectedShipIndex-1].name);

        playerCount = PlayerPrefs.GetInt("PlayerCount");
        Debug.Log(PlayerPrefs.GetInt("PlayerCount"));

        //Sets the sprite to player prefab

       


        //Starts Host
        if (playerCount == 1)
        {
            network = GetComponent<NetworkManager>().StartHost();
        }
        if(playerCount == 2)
        {
            network = GetComponent<NetworkManager>().StartClient();  
        }
       

       

    }
    // Update is called once per frame
    void Update () {
        PCount.text = "Player count: " + playerCount;
		
	}


}
