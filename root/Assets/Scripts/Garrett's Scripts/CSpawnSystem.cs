using UnityEngine;
using System.Collections;

/*
 * For an interface to interact with
 * this you must create a new instance
 * of this CSpawnSystem on the interface
 * and call it's update in the interface's 
 * update. See CIEnemySpawner.cs
 * 
 * */

public class CSpawnSystem {

    public float spawnRate;
    public GameObject objToSpawn;
    public Vector3 position;
    public Quaternion rotation;

    public float spawnTimer;

	// Use this for initialization
	void Start () {

	}
	
	// my update
	public void update () {

        if (spawnTimer < 0)
        {
            MonoBehaviour.Instantiate(objToSpawn, position, rotation);
            spawnTimer = spawnRate;
        }

        spawnTimer -= Time.deltaTime;
	}
}