using UnityEngine;
using System.Collections;

public class WeaponText : MonoBehaviour 
{

	string currentWeapon;
    bool hasCollided;

	void Start () 
	{
	
	}

	void Update () 
	{
    //  OnGUI();
	}

    /*void onTriggerEnter(Collider Launcher)
    {
        if (Launcher.gameObject.tag == "Launcher")
        {
            hasCollided = true;
        }

    }
   */

	void OnGUI()
	{

        
            if (gameObject.tag == "SMG")
            {
                currentWeapon = "SMG";
            }

            if (gameObject.tag == "Launcher")
            {
                currentWeapon = "Launcher";
            }

            else
            {
                currentWeapon = "Pistol";
            }
        
        
		GUI.TextField(new Rect (10,30,200, 20), "Current weapon: " + currentWeapon);

    
}
}



