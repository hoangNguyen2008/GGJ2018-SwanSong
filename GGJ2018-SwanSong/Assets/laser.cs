using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour 
{
	private LineRenderer mlineRenderer;
	public Transform laserHit;

	// Use this for initialization
	void Start () 
	{
		mlineRenderer = GetComponent<LineRenderer> ();
		mlineRenderer.enabled = false;
		mlineRenderer.useWorldSpace = true;
	}

	// Update is called once per frame
	void Update () {
		RaycastHit2D hit = Physics2D.Raycast (transform.position, transform.up);
		Debug.DrawLine (transform.position, hit.point);
		laserHit.position = hit.point;

		mlineRenderer.SetPosition (0, transform.position);
		mlineRenderer.SetPosition (1, laserHit.position);
		if (Input.GetKey (KeyCode.Space)) {
			mlineRenderer.enabled = true;
		} else {
			mlineRenderer.enabled = false;
		}
	}
}