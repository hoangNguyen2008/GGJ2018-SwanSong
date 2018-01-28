﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
				Application.LoadLevel("Menu");
			}

			Destroy(gameObject);
		}
	}
}
