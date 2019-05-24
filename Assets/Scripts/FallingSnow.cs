using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingSnow : MonoBehaviour {

    public GameObject release;
    // Use this for initialization


    void Start () {
        release = GameObject.FindGameObjectWithTag("release");
    }
	
	// Update is called once per frame
	void FixedUpdate () {

		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(release);
        }

    }
}
