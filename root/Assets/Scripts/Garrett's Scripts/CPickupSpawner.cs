using UnityEngine;
using System.Collections;

public class CPickupSpawner : MonoBehaviour {

    public GameObject pickup;
    public float spawnRate;
    public float spawnRadius;
    private GameObject pickupChild;
    private float spawnTimer;
    private Vector3 spawnPoint;

	// Use this for initialization
	void Start () {

        pickupChild = pickup.transform.FindChild("Weapon").gameObject;
        spawnTimer = spawnRate;
	}
	
	// Update is called once per frame
	void Update () {

        if (spawnTimer < 0)
        {
            pickupChild.GetComponent<CWeapon>().Randomize(50);
            spawnPoint.x = Random.insideUnitCircle.x * spawnRadius;
            spawnPoint.z = Random.insideUnitCircle.y * spawnRadius;
            spawnPoint.y = 0.75f;

            GameObject obj = Instantiate(pickup, spawnPoint, Quaternion.identity) as GameObject;
            obj.transform.parent = this.gameObject.transform;
            spawnTimer = spawnRate;
        }

        spawnTimer -= Time.deltaTime;
	}
}
