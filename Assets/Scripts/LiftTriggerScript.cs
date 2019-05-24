using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftTriggerScript : MonoBehaviour {

    ElevatorScript elevatorScript;

    // Use this for initialization
    void Start () {
        GameObject go = GameObject.FindGameObjectWithTag("elevator");
        elevatorScript = go.GetComponent<ElevatorScript>();

    }
	
	// Update is called once per frame
	void FixedUpdate () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            elevatorScript.setGoUp(true);
        }

    }
}
