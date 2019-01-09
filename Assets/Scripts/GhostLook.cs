using UnityEngine;
using System.Collections;

public class GhostLook : MonoBehaviour {

	Rigidbody2D body;
	public Transform start,end;
	public AudioClip turnAround;
	bool collision;
	public float speed;
	float neg = -1f;

	void Start ()
	{
		body = GetComponent<Rigidbody2D> ();
	}
	
	void moveAI(AudioClip sound,float speed,float size,float num)
	{
		AudioSource.PlayClipAtPoint (sound, transform.position);
		transform.localScale = new Vector3 (size * num, 0.7f, 1f);
		body.AddForce (new Vector2 (speed * num, 0) * neg);
	}

	void FixedUpdate () 
	{
		collision = Physics2D.Linecast (start.position, end.position, 1 << LayerMask.NameToLayer ("Solid"));
		Debug.DrawLine (start.position, end.position, Color.yellow);

		if (collision) 
		{
			if (transform.localScale.x == 0.7f) 
			{
				moveAI (turnAround, speed, 0.7f, -1f);
			}else if(transform.localScale.x == -0.7f){
				moveAI (turnAround, speed, 0.7f, 1f);
			}

		}
	
	}
}
