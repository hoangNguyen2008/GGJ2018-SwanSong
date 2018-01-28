using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillSwitch : MonoBehaviour 
{
	public float lifetime;
	
	// Update is called once per frame
	void Update () 
	{
		lifetime -= Time.deltaTime;
		if (lifetime < 0)
		{
			if(gameObject.name == "Beam(Clone)")
			{
				SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
			}

			Destroy(gameObject);
		}
	}
}
