using UnityEngine;
using System.Collections;

public class CPlayer : MonoBehaviour {

    public float health;

    void OnCollisionEnter(Collision col)
    {
        if (col.rigidbody.CompareTag("Enemy"))
        {

        }
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
