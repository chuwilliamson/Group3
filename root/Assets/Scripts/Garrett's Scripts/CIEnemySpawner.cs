using UnityEngine;
using System.Collections;

public class CIEnemySpawner : MonoBehaviour {

    public GameObject enemyObj;
    public Vector3 position;
    public float spawnRate;
    public float spawnRadius;

    private CSpawnSystem spawnSystem;

	// Use this for initialization
	void Start () {

        spawnSystem = new CSpawnSystem();
        spawnSystem.spawnRate = spawnRate;
        spawnSystem.objToSpawn = enemyObj;
	}
	
	// Update is called once per frame
	void Update () {

        if (spawnSystem.spawnTimer < 0)
        {
            spawnSystem.position = RandomVec(spawnRadius);
        }

        spawnSystem.update();
	}

    Vector3 RandomVec(float seed)
    {
        Vector3 vec = new Vector3(0, 0, 0);
        vec.x = Random.Range(-seed - transform.position.x, seed + transform.position.x);
        vec.y = 1.25f;
        vec.z = Random.Range(-seed - transform.position.z, seed + transform.position.z);

        return vec;
    }
}
