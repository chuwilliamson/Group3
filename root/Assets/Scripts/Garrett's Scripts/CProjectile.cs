using UnityEngine;
using System.Collections;

public class CProjectile : MonoBehaviour {

    public float speed;
    public float lifetime;
    public float damage;
    public float spreadRange;

    private Transform tr;
    private Rigidbody rb;
    private Vector3 rand;

	// Use this for initialization
	void Start () {

        rand.x = Random.Range(-spreadRange, spreadRange);
        tr = GetComponent<Transform>();
        rb = GetComponent<Rigidbody>();
        float impact = gameObject.transform.localScale.magnitude;
        rb.AddForce(((tr.forward * impact) + rand) * speed);
	}
	
	// Update is called once per frame
	void Update () {

        lifetime -= Time.deltaTime;

        if (lifetime < 0)
            Destroy(this.gameObject);
	}
}
