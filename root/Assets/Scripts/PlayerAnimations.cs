using UnityEngine;
using System.Collections;

public class PlayerAnimations : MonoBehaviour {
    private void Awake()
    {
        print("anim on awake");
    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody body = hit.collider.attachedRigidbody;
 
        if(hit.gameObject.tag == "Enemy")
        {
            //print("I touch an enemy");
        }
    }

    private void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.tag == "Enemy") { }
            //print("enemy touched me");
    }
 private void Update()
	{
		if(Input.GetKey(KeyCode.Mouse0))
		{
			anim.SetTrigger("SingleShot");
		}	
	}

	public Animator anim;

}
