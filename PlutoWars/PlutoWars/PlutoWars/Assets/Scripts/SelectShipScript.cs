using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectShipScript : MonoBehaviour {

    

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void SetShipIndex(int index)
    {
        PlayerPrefs.SetInt("SelectedShip", index);
    }
    public void GetShipIndex()
    {
       // Debug.Log(PlayerPrefs.GetInt("SelectedShip"));
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
