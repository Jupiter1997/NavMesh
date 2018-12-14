using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;


public class PlayerSceneManager : NetworkBehaviour {

    
    // Use this for initialization
    void Start()
    {
      //  var numOfPlayers = Network.connections.Length;

        Debug.Log("Players Connected" + GetConnectionCount());
               
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
