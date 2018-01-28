using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTrans : MonoBehaviour 
{
	private float lifetime;

	// Use this for initialization
	void Start () 
	{
		AudioSource temp = GetComponent<AudioSource> ();
		lifetime = temp.clip.length;
	}
	
	// Update is called once per frame
	void Update () 
	{
		lifetime -= Time.deltaTime;
		if (lifetime < 0)
		{
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
		}
	}
}
