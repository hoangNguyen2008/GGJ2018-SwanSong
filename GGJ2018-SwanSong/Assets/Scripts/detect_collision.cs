using UnityEngine;
using System.Collections;

public class PlanetGlow : MonoBehaviour
{
	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.name == "laser")
		{
			gameObject.GetComponent<ParticleSystem>().enableEmission = true;
		}
	}
}