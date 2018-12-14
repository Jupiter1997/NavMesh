using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MyNetworkManager : NetworkManager {

    public Dictionary<int, int> ShipSelection = new Dictionary<int, int>();

    public static MyNetworkManager m_Singleton;
    GameObject player;
    public Sprite[] ship;
    int shipIndex = 0;

    void Start()
    {
        shipIndex = PlayerPrefs.GetInt("SelectedShip");
        Debug.Log("Manager Ship: " + shipIndex);

        m_Singleton = this;
    }

    public class NetworkMessage : MessageBase
    {
        public int selectedShipIndex;
    }
    public override void OnServerAddPlayer(NetworkConnection conn, short playerControllerId, NetworkReader extraMessageReader)
    {
        NetworkMessage message = extraMessageReader.ReadMessage<NetworkMessage>();
        int selectedShip = message.selectedShipIndex;

        player = Instantiate(playerPrefab, Random.Range(-10, 10) * Vector3.right, Quaternion.identity) as GameObject;
        player.GetComponent<ShipController>().ShipIndex = selectedShip;


        NetworkServer.AddPlayerForConnection(conn, player, playerControllerId);
    }
    public override void OnClientConnect(NetworkConnection conn)
    {
        NetworkMessage msg = new NetworkMessage();
        msg.selectedShipIndex = shipIndex;
        ClientScene.AddPlayer(conn, 0, msg);
    }

    

}
