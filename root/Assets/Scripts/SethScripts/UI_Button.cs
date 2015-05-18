using UnityEngine;
using System.Collections;

public class UI_Button : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	private void OnGUI()
	{
		if (GUI.Button (new Rect (20, 20, 75, 75), "Scene"))
		{
			Application.LoadLevel ("MainGame");
		}


	}

}
