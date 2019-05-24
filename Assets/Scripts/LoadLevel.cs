using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

public class LoadLevel : MonoBehaviour 
{
	public Text message;      // collect all coins message
	Score scoreScript;
	public string level; 
	int score;

	void Start () 
	{
		GameObject go = GameObject.FindGameObjectWithTag ("Manage");
		scoreScript = go.GetComponent<Score> ();
		message.text = "Collect 30 crystals to proceed";
	}
	

	void Update () 
	{
		score = scoreScript.count;
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.name == "Jones" && score >= 30)   // check if player has collected all coins. If so load next level.
		{
			SceneManager.LoadScene(level);
		}
	}
}
