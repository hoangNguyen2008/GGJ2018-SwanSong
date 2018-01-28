using UnityEngine;
using System.Collections;

public class circular_movement : MonoBehaviour  
{

	float timeCounter = 20;

	private Vector3 v;

	void Start() {
	}

	void Update () 
	{
		timeCounter += Time.deltaTime;

		float x = Mathf.Cos(timeCounter) * 8;
		float y = Mathf.Sin(timeCounter) * 3;
		float z = 0;

		transform.position = new Vector3 (x, y, z);
	}
}