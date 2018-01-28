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
		//isActive = false;
		lifetime = 0.0f;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (isActive)
		{
			gameObject.GetComponent<SpriteRenderer> ().color = new Color (1.0f, 1.0f, 1.0f, 1.0f);

			lifetime -= Time.deltaTime;

			if (lifetime >= 3.0f)
			{
				laser temp2 = gameObject.GetComponentInChildren<laser> ();
				if (temp2 != null)
				{
					//temp2.mlineRenderer.isVisible = false;
				}
			}

			if (lifetime <= 0)
			{
				laser temp = gameObject.GetComponentInChildren<laser> ();
				if (temp != null)
				{
					temp.mlineRenderer.enabled = true;
				}

				lifetime = 3.0f;
			}
		} 
		else
		{
			gameObject.GetComponent<SpriteRenderer> ().color = new Color (0.5f, 0.5f, 0.5f, 1.0f);
		}
	}

	void OnMouseOver()
	{
		if (isActive)
		{
			if (Input.GetMouseButton(0))
			{
				transform.Rotate(Vector3.forward, 1.5f);
			}

			if (Input.GetMouseButton(1))
			{
				transform.Rotate(Vector3.forward, -1.5f);
			}
		}
	}

	void OnTriggerEnter2D()
	{
		if (!isActive)
		{
			AudioSource woosh = GetComponent<AudioSource> ();
			woosh.Play ();
		}

		isActive = true;
	}
}