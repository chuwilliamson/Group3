using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ZombieCount : MonoBehaviour {
	public static int ZombieCounter;

	Text text;

	void Awake()
	{
		text = GetComponent <Text> ();

		ZombieCounter = 1;
	}

	void Update()
	{
		text.text = "Zombie Count: " + ZombieCounter;
	}
}