using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Wander : MonoBehaviour {

    public GameObject[] wps;
    NavMeshAgent agent;

	// Use this for initialization
	void Start () {
        agent = this.GetComponent<NavMeshAgent>();
        int d = Random.Range(0, wps.Length);
        agent.SetDestination(wps[d].transform.position);
		
	}
	
	// Update is called once per frame
	void Update () {
        if (agent.remainingDistance < 0.3 )
        {
            int d = Random.Range(0, wps.Length);
            agent.SetDestination(wps[d].transform.position);

        }
		
	}
}
