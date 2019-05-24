using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarryScript : MonoBehaviour {

    // for physical movement
    protected Rigidbody2D body;

    // for object speed
    public float speed;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        body.velocity = new Vector2(transform.localScale.x, 0) * speed;
    }


    void FixedUpdate()
    {


    }

    public void OnTriggerEnter2D(Collider2D coll)
    {

        if (coll.gameObject.tag == "edgeRight")
        {
            body.velocity = new Vector2(-transform.localScale.x, 0) * speed;
        }
        else if (coll.gameObject.tag == "edgeLeft")
        {
            body.velocity = new Vector2(transform.localScale.x, 0) * speed;
        }
    }
}
