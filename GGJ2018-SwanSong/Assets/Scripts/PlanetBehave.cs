using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetBehave : MonoBehaviour 
{
	public GameObject pulse;
	public bool isActive;
	private float lifetime;

	// Use this for initialization
	void Start () 
	{
		//isActive = false;
		lifetime = 0.0f;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (isActive) 
		{
			lifetime -= Time.deltaTime;

			if(lifetime < 0)
			{
				Instantiate(pulse, transform.position, transform.rotation);
				lifetime = 4.0f;
			}
		}
	}
}