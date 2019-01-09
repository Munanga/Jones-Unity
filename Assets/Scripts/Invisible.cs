using UnityEngine;
using System.Collections;

public class Invisible : MonoBehaviour
{
	Renderer see;

	void Start () 
	{
		see = GetComponent<Renderer> ();
	}
	

	void Update () 
	{
		see.enabled = false;
		
	}
}
