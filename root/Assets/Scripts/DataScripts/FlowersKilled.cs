using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FlowersKilled : MonoBehaviour {
	public static int FlowersBurned;
	
	Text text;
	
	void Awake()
	{
		text = GetComponent <Text> ();
		
		FlowersBurned = 0;
	}
	
	void Update()
	{
		text.text = "Flowers Burned: " + FlowersBurned;
	}
}