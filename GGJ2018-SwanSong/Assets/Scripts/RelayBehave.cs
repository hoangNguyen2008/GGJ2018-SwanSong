using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RelayBehave : MonoBehaviour 
{
	public bool isActive;
	private float lifetime;

	// Use this for initialization
	void Start () 
	{
		isActive = false;
		lifetime = 3.0f;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (isActive) 
		{
			lifetime -= Time.deltaTime;

			if (lifetime < 0)
			{
				laser temp = gameObject.GetComponentInChildren<laser>();
				if (temp != null)
				{
					temp.mlineRenderer.enabled = true;
				}

				lifetime = 3.0f;
			}
		}
	}

	void OnMouseOver()
	{
		if (Input.GetMouseButton(0))
		{
			transform.Rotate(Vector3.forward, 2.5f);
		}

		if (Input.GetMouseButton(1))
		{
			transform.Rotate(Vector3.forward, -2.5f);
		}
	}

	void OnTriggerEnter2D()
	{
		isActive = true;
	}
}