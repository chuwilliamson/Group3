using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {
	public int maxHealth 	 = 100;
	public int currentHealth = 100;
	
	// Use this for initialization
	void Start () 
	{
	}
	
	// Update is called once per frame
	void Update () 
	{
		adjustCurrentHealth (0);
	}
		
	public void adjustCurrentHealth(int adjustment)
	{
		currentHealth += adjustment;
        if (currentHealth < 0)
            Destroy(gameObject);
		if (currentHealth > maxHealth)
			currentHealth = maxHealth;
		if (maxHealth < 1)
			maxHealth = 1;
	}
}
