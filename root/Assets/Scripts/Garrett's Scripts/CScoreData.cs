using UnityEngine;
using System.Collections;

public class CScoreData : MonoBehaviour {

    public float playerHealth;
    public int monstersKilled;
    public float pickupTimer;

    void Awake()
    {
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<CTakeDamage>().health;
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if(pickupTimer > 0)
            pickupTimer -= Time.deltaTime;
	}
}
