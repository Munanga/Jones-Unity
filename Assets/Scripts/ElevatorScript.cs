using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorScript : MonoBehaviour {

    bool goUp = false;
    Rigidbody2D body;
    public int speed;
	// Use this for initialization
	void Start () {

        body = GetComponent<Rigidbody2D>();
        addForce();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        addForce();


    }

    public void setGoUp(bool up) {
        this.goUp = up;
    }

    public void addForce() {
        if (this.goUp) {
            body.AddForce(new Vector2(0,this.speed));
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "EndLift")
        {
            Debug.Log("Ended");
            body.velocity = Vector2.zero;
            body.angularVelocity = Vector2.zero.y;
            this.speed = 0;
        }

    }
}
