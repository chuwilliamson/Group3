using UnityEngine;
using System.Collections;

public class CEnemySpawner : MonoBehaviour {

    [SerializeField]
    private GameObject objToSpawn;
    [SerializeField]
    private float spawnRate;
    [SerializeField]
    private float spawnRadius;
    private float spawnTimer;
    private Vector3 spawnPoint;

	// Use this for initialization
	void Start () {

        spawnTimer = spawnRate;
        spawnPoint.x = Random.Range(transform.position.x * -spawnRadius, transform.position.x * spawnRadius);
        spawnPoint.z = Random.Range(transform.position.z * -spawnRadius, transform.position.z * spawnRadius);
        spawnPoint.y = 1.25f;
	}
	
	// Update is called once per frame
	void Update () {

        if (spawnTimer < 0)
        {
            GameObject obj = Instantiate(objToSpawn, spawnPoint, transform.rotation) as GameObject;
            obj.transform.parent = this.gameObject.transform;
            spawnTimer = spawnRate;
            spawnPoint.x = Random.Range(transform.position.x * -spawnRadius, transform.position.x * spawnRadius);
            spawnPoint.z = Random.Range(transform.position.z * -spawnRadius, transform.position.z * spawnRadius);
            spawnPoint.y = 1.25f;
        }

        spawnTimer -= Time.deltaTime;
	}
}
