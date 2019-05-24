using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerChestScript : MonoBehaviour {

    SpriteRenderer render;
    public Sprite closedChest;
    public Sprite openChest;



    // Use this for initialization
    void Start () {
        GameObject go = GameObject.FindGameObjectWithTag("chest");
        render = go.GetComponent<SpriteRenderer>();

    }
	
	// Update is called once per frame
	void FixedUpdate () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {

            render.sprite = openChest;
        }

    }
}
