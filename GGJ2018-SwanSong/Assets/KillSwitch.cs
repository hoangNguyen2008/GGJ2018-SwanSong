using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillSwitch : MonoBehaviour 
{
	private float lifetime;


	// Use this for initialization
	void Start () 
	{
		lifetime = 0.6f;
	}
	
	// Update is called once per frame
	void Update () 
	{
		lifetime -= Time.deltaTime;
		if (lifetime < 0)
		{
			Destroy(gameObject);
		}
	}
}
