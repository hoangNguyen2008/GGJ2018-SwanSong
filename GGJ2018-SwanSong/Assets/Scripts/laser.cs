﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour 
{
	public LineRenderer mlineRenderer;
	public Transform laserHit;

	// Use this for initialization
	void Start () 
	{
		mlineRenderer = GetComponent<LineRenderer> ();
		mlineRenderer.enabled = false;
		mlineRenderer.useWorldSpace = true;
	}

	// Update is called once per frame
	void Update () 
	{
		if(mlineRenderer.enabled)
		{
				DrawLaser ();
		}
	}

	public void DrawLaser()
	{
		int laserReflected = 1;
		int vertexCounter = 1;								
		bool loopActive = true;
		Vector2 laserDirection = transform.up;
		Vector2 lastLaserPosition = transform.position;

		mlineRenderer.positionCount = 1;
		mlineRenderer.SetPosition(0, transform.position);

		while (loopActive) 
		{
			RaycastHit2D hit = Physics2D.Raycast (lastLaserPosition, laserDirection, 3);

			if (hit) 
			{
				laserReflected++;
				vertexCounter += 1;
				mlineRenderer.positionCount = vertexCounter;
				mlineRenderer.SetPosition(vertexCounter - 1, Vector2.MoveTowards(hit.point, lastLaserPosition, 0.01f));
				//mlineRenderer.SetPosition(vertexCounter - 2, hit.point);
				//mlineRenderer.SetPosition(vertexCounter - 1, hit.point);
				lastLaserPosition = hit.point;
				laserDirection = Vector2.Reflect(laserDirection, hit.normal);

				GameObject temp = hit.collider.gameObject;
				PlanetBehave toggleActive = temp.GetComponent<PlanetBehave>();
				if (toggleActive != null)
				{
					toggleActive.isActive = true;
				}
			}
			else 
			{
				laserReflected++;
				vertexCounter++;
				mlineRenderer.positionCount = vertexCounter;
				mlineRenderer.SetPosition(vertexCounter - 1, lastLaserPosition + laserDirection.normalized * 3);

				loopActive = false;
			}

			if (laserReflected > 2) 
			{
				loopActive = false;
			}
		}

		/*
		RaycastHit2D hit = Physics2D.Raycast (transform.position, transform.up);
		Debug.DrawLine (transform.position, hit.point);
		laserHit.position = hit.point;

		mlineRenderer.SetPosition (0, transform.position);
		mlineRenderer.SetPosition (1, laserHit.position);
		*/
	}
}