using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AudioManager : Singleton<AudioManager> 
{
	public List<AudioClip> _sounds = new List<AudioClip> ();
	private Dictionary<string, AudioClip> soundDict = new Dictionary<string, AudioClip> ();
	private AudioSource aSource;
	//Need to make a way to switch between the states of music
	//Need them in audio zone so you can hear it for certain things
	//		ie (Enemy attack, enemy death, portal(when activited))
	//switching between states for background, death, and powerup
	//have a state for when hes idle and walking
	// Use this for initialization
	void Awake()
	{
		foreach (AudioClip a in _sounds) 
		{
			soundDict.Add(a.name, a);
		}
		aSource = GetComponent<AudioSource> ();
	}


	public void PlaySound(string sound)
	{

		if (soundDict.ContainsKey (sound)) {
			Debug.Log ("playing that sound " + sound);
			aSource.clip = soundDict [sound];
			aSource.Play ();

		} else {
			print ("couldn't find the sound");
		}
	}
}
