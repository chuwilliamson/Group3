using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CurrentFlowers : MonoBehaviour 
{

	private int Flowers;

	Text text;

	// Use this for initialization
	void Awake() 
	{
		text = GetComponent <Text> ();

	}
	
	// Update is called once per frame
	void Update () 
	{
		Flowers = GameObject.FindGameObjectsWithTag ("Enemy").Length;

		//CurrentNumFlowers += Flowers;

		text.text = "Current Enemies: " + Flowers;
	}
}
