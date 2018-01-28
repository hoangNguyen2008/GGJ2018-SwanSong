using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class volumeSetting : MonoBehaviour {

	public AudioMixer autoMixer;

	public void setVolume (float volume)
	{
		autoMixer.SetFloat ("volume", volume);
	}
}
