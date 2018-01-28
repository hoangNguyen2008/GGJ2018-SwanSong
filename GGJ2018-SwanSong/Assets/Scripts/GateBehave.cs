using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateBehave : MonoBehaviour 
{
	public GameObject beam;
	public bool isActive;

	// Use this for initialization
	void Start () 
	{
		isActive = false;
	}

	// Update is called once per frame
	void Update () 
	{
		if (isActive)
		{
			Vector3 d00t = new Vector3 (0.0f, 3.0f, 0.0f);
			Instantiate(beam, transform.position + d00t, transform.rotation);
			AudioSource blorf = GetComponent<AudioSource> ();
			blorf.Play ();
			isActive = false;
		}
	}

	void OnTriggerEnter2D()
	{
		isActive = true;
	}
}
