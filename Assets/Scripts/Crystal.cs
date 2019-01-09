using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Crystal : MonoBehaviour 
{
	Score script;
	public int value;
	public AudioClip coinSound;


	void Start () 
	{
		GameObject go = GameObject.FindGameObjectWithTag ("Manage");
		script = go.GetComponent<Score> ();
	}

	// Collect method
	void collect(AudioClip sound,int value)
	{
		AudioSource.PlayClipAtPoint (sound, transform.position);
		script.addScore (value);
		Destroy (gameObject);
	}
		
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player") 
		{
			collect (coinSound, value);
		}

	}

}
