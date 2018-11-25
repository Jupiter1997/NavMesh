using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectShipScript : MonoBehaviour {

    
    public void SetShipIndex(int index)
    {
        PlayerPrefs.SetInt("SelectedShip", index);
    }
    public void GetShipIndex()
    {
       // Debug.Log(PlayerPrefs.GetInt("SelectedShip"));
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    int counter = 0;
    public void PlayerCounter()
    {
        counter = counter + 1;
        PlayerPrefs.SetInt("PlayerCount", counter);
        Debug.Log("Player :" +counter + "joins");
    }

}
