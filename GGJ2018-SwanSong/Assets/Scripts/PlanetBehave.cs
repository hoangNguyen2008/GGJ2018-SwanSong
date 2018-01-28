using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetBehave : MonoBehaviour 
{
	public GameObject pulse;
	public bool isActive;
	private float lifetime;
	public AudioClip whenPulse;
	public AudioClip whenWoken;

	// Use this for initialization
	void Start () 
	{
		//isActive = false;
		lifetime = 2.0f;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (isActive) 
		{
			gameObject.GetComponent<SpriteRenderer> ().color = new Color (1.0f, 1.0f, 1.0f, 1.0f);

			lifetime -= Time.deltaTime;

			if(lifetime < 0)
			{
				Instantiate(pulse, transform.position, transform.rotation);
				lifetime = 4.0f;

				AudioSource temp = GetComponent<AudioSource> ();
				temp.clip = whenPulse;
				temp.Play ();
			}
		}
		else
		{
			gameObject.GetComponent<SpriteRenderer> ().color = new Color (0.5f, 0.5f, 0.5f, 1.0f);
		}
	}
}