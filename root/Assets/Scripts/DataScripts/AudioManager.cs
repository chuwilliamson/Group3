using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AudioManager : Singleton<AudioManager> 
{
	public List<AudioClip> _sounds = new List<AudioClip> ();
	private Dictionary<string, AudioClip> soundDict = new Dictionary<string, AudioClip> ();
	private AudioSource aSource;

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

		if (soundDict.ContainsKey (sound)) 
		{
			Debug.Log ("playing that sound " + sound);
			aSource.clip = soundDict [sound];
			aSource.Play ();

		} 
		else 
		{
			print ("couldn't find the sound");
		}
	}
}
