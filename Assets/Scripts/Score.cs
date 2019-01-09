using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;
using UnityEngine;

public class Score : MonoBehaviour
{
	public GameObject player;
	public Text score;
	public int count {
		get;
		set;
	}
	public bool isDead;

	public int get()
	{
		return count;
	}

	void Update () 
	{

		if (count >= 30) 
		{
			Debug.Log ("Done with level");	
		}

		if (isDead == true) 
		{
			Scene level = SceneManager.GetActiveScene (); // Restart Level for Now!!!!
			SceneManager.LoadScene (level.name);
		}
	}

	public void addScore(int value)
	{
		count = count + value;
		score.text = "SCORE: " + count;	
	}



}
