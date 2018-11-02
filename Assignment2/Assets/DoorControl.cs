using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorControl : MonoBehaviour {

    public Transform openDoor;
    public Transform closeDoor;
    public float speed;

    // Use this for initialization
    void Start () {
    //    closeDoor = GetComponent<Transform>();
        transform.position =  new Vector3(closeDoor.position.x,closeDoor.position.y,closeDoor.position.z);

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Capsule")
        {
            Debug.Log("Enter!");
            transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, this.transform.position.z);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Capsule")
        {
            Debug.Log("Exit!");
            transform.position = new Vector3(this.transform.position.x, this.transform.position.y - 1.5f, this.transform.position.z);
        }


    }
     void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Capsule")
        {
            Debug.Log("Stay!");
            transform.position = new Vector3(openDoor.position.x, openDoor.position.y, openDoor.position.z);
        }

    }


}
