using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockRotation : MonoBehaviour {

    public RectTransform rectTransform;
    public Transform[] LifeHUD;

    PlayerSceneManager PM;
    private void Start()
    {
        PM = GameObject.Find("SceneManager").GetComponent<PlayerSceneManager>();

        rectTransform = this.gameObject.GetComponent<RectTransform>();
        if (PM.GetConnectionCount() == 1)
        {
            rectTransform.position = LifeHUD[0].position;
        }
        if (PM.GetConnectionCount() == 2)
        {
            rectTransform.position = LifeHUD[1].position;
        }
        if (PM.GetConnectionCount() == 3)
        {
            rectTransform.position = LifeHUD[2].position;
        }
        if (PM.GetConnectionCount() == 4)
        {
            rectTransform.position = LifeHUD[3].position;
        }

    }


}