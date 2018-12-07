using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;


public class PlayerSceneManager : NetworkBehaviour {
    [SyncVar]
    private int playerCount;
    public Text PCount;

    
    // Use this for initialization
    void Start()
    {
        var numOfPlayers = Network.connections.Length;
        playerCount = PlayerPrefs.GetInt("PlayerCount");
        Debug.Log("Player Count "+ PlayerPrefs.GetInt("PlayerCount"));

        Debug.Log("Players " + GetConnectionCount());
               
    }
    
    public int GetConnectionCount()
    {
        int count = 0;
        GameObject[] players = GameObject.FindGameObjectsWithTag("Player");
        {
            foreach (GameObject item in players)
            {
                count++;
            }
        }
      

        return count;
        
    }



}
