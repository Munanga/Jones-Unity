using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Return : MonoBehaviour 
{
	public void Exit()
	{
		Application.Quit ();
	}

	public void Restart()
	{
		SceneManager.LoadScene ("Menu");
	}
	public void Begin()
	{
		SceneManager.LoadScene ("Level1");
	}
}
