using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerSceneManager : MonoBehaviour {

    private int selectedShipIndex;
  //  public GameObject[] Ships;
    public Sprite[] shipSprite;
    public GameObject PlayerShip;


    // Use this for initialization
    void Start()
    {
        selectedShipIndex = PlayerPrefs.GetInt("SelectedShip");
        Debug.Log(PlayerPrefs.GetInt("SelectedShip") + shipSprite[selectedShipIndex-1].name);

        PlayerShip.GetComponent<SpriteRenderer>().sprite = shipSprite[selectedShipIndex - 1];

        Instantiate(PlayerShip, transform.position, transform.rotation);
       // Instantiate(Ships[selectedShipIndex -1], this.transform.position, this.transform.rotation);

    }
    // Update is called once per frame
    void Update () {
		
	}
}
