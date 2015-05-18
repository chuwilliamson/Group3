using UnityEngine;
using System.Collections;

public class CCameraFollow : MonoBehaviour {
    GameObject target;
    public float speed;
    Vector3 followDir;
    public bool targetPlayer;
	// Update is called once per frame
	void FixedUpdate () 
    {
        if (targetPlayer)
        {
            target = GameObject.FindGameObjectWithTag("Player");
        }
        followDir = (target.transform.position - transform.position).normalized;
        if((transform.position - target.transform.position).sqrMagnitude > 4)        
        {
		    GetComponent<Rigidbody>().AddForce(new Vector3(followDir.x, 0, followDir.z) * speed);
        }
	
	}
}
