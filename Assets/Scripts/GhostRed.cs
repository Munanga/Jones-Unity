using UnityEngine;
using System.Collections;

public class GhostRed : MonoBehaviour 
{

	Rigidbody2D body;
	public float speed;

	void Start () 
	{
		body = GetComponent<Rigidbody2D> ();
	}
	

	void FixedUpdate () 
	{
		body.velocity = new Vector2 (transform.localScale.x, 0) * speed;
	}
}
