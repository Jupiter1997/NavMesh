using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class Health : NetworkBehaviour
{

    [Header("Testing")]
    public const int _maxlives = 10;
    [SyncVar(hook = "OnChangeHealth")]
    public int _currentLives = _maxlives;
    public Text LivesText;
    public bool destroyOnDeath;
    public NetworkStartPosition[] spawnPositions;

    void Start()
    {
        if (isLocalPlayer)
        {
            spawnPositions = FindObjectsOfType<NetworkStartPosition>();
        }
        _currentLives = _maxlives;
        LivesText.text = _currentLives.ToString();
    }

    public void TakeDamage(int amount)
    {

        _currentLives -= amount;
        
        if (_currentLives <= 0) // ME DEAD
        {
            if (destroyOnDeath)
            {
                Destroy(gameObject);
            }
            else
            {
                _currentLives = _maxlives;
                 Debug.Log("Dead");
               // RpcRespawn();
            }
        }

    }
    void OnChangeHealth(int health)
    {
        LivesText.text = _currentLives.ToString();
    }
}