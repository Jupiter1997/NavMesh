using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;


public class PlayerSceneManager : NetworkBehaviour {
    [SyncVar]
    private int playerCount;
  //  public GameObject[] Ships;
    NetworkClient network;
    public Text PCount;


    // Use this for initialization
    void Start()
    {
        playerCount = PlayerPrefs.GetInt("PlayerCount");
        Debug.Log(PlayerPrefs.GetInt("PlayerCount"));


     

    }
    void Update () {

		
	}



}
