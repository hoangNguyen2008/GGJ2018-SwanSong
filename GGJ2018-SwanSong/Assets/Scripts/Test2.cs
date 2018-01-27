using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour 
{
	public GameObject wave;
	private bool isActive;

	// Use this for initialization
	void Start () 
	{
		isActive = true;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (isActive) 
		{
			Instantiate (wave, transform.position, transform.rotation);
			isActive = false;
		}
	}
}
