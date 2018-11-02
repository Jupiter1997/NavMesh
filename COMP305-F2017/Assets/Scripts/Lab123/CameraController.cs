using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    public GameObject player;
    public Camera Camera;
    Transform currPos;
    public float testZoom;

    // Use this for initialization
    void Start()
    {

        currPos = this.transform;
        Camera = this.GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        float BGpos = player.transform.position.x;
        if (BGpos < 10)
        {
            currPos.position = new Vector3(player.transform.position.x,
                player.transform.position.y, this.transform.position.z);
            Camera.orthographicSize = 3.33f;
            // Debug.Log("BG1!@");
        }
        if (10 <= BGpos && BGpos <= 23)
        {
            Camera.orthographicSize = 3.33f;
            currPos.position = new Vector3(16.4f, 0.66f, -10);
            //Debug.Log("BG2!@");
        }
        if (23 < BGpos)
        {



            currPos.position = new Vector3(player.transform.position.x,
                  player.transform.position.y, this.transform.position.z);
            Camera.orthographicSize = 5f;
            if (BGpos > 24)
            {
                float zoomer = ((BGpos - 23.99999f) + testZoom) - 0.1f;
                Camera.orthographicSize -= zoomer;
            }
            float FOV = Camera.main.fieldOfView;


            // Debug.Log("BG3!@");
        }

    }

}


