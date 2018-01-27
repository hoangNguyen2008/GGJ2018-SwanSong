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

	void OnMouseOver()
	{
		if (Input.GetMouseButton(0))
		{
			transform.Rotate(Vector3.forward, 5.0f);
		}

		if (Input.GetMouseButton(1))
		{
			transform.Rotate(Vector3.forward, -5.0f);
		}

	}
}
