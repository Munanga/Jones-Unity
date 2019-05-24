using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Player : MonoBehaviour 
{
	//public Transform start, end;
	public Collider2D one;
	public float speed;
	public float jumpHeight;
	private bool collision;
	Rigidbody2D body;
	Animator animator;
	Score script;
	public AudioClip deathScream;


	void Start () 
	{
		GameObject go = GameObject.FindGameObjectWithTag ("Manage");
		script = go.GetComponent<Score> ();

		animator = GetComponent<Animator> ();
		body = GetComponent<Rigidbody2D> ();

	}

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }


    void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Deadly") 
		{
			death ();
		}
			
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "Deadly") 
		{
            AudioSource.PlayClipAtPoint (deathScream, transform.position);
			death ();
		}

	}

	void death()
	{
		
		script.isDead = true;
		Destroy (gameObject);
	}

	// Player speed, animState and x-axis direction
	void move(float playerSpeed,float playerXdireection)
	{
		animator.SetInteger ("AnimState", 1);
		body.AddForce (new Vector2 (playerSpeed, 0));
		transform.localScale = new Vector3 (playerXdireection, 1, 1);
	}

	void FixedUpdate ()
	{
     

        if (Input.GetKey ("right")) {
			move (speed, 1);
		} else if (Input.GetKey ("left")) {
			move (-speed, -1);
		} else {
			animator.SetInteger ("AnimState", 0);
		}


		bool touch = Physics2D.IsTouchingLayers (one, LayerMask.GetMask ("Solid"));
		if (touch && Input.GetKey ("space")) {
			animator.SetInteger ("AnimState", 2);
			body.velocity = new Vector2(body.velocity.x, jumpHeight);//AddForce (new Vector2 (body.velocity.x, jumpHeight));

		}
		
	}



}
