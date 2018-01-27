using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour 
{
	public GameObject pulse;
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
			Instantiate(pulse, transform.position, transform.rotation); 
			isActive = false;
		}
	}
}