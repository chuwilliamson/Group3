using UnityEngine;
using System.Collections;

public class CScoreData : MonoBehaviour {
    
    static public float playerHealth
    {
        get
        {           
            return GameObject.FindGameObjectWithTag("Player").GetComponent<CTakeDamage>().health;
        }

        set
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<CTakeDamage>().health -= value;
        }
    }

    static private int mk;
    static public int monstersKilled
    {
        get
        {
            return mk;
        }

        set
        {
            mk += value;
        }
    }
    public float pickupTimer;

 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if(pickupTimer > 0)
            pickupTimer -= Time.deltaTime;
	}
}
