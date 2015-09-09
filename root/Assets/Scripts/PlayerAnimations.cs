using UnityEngine;
using System.Collections;

public class PlayerAnimations : MonoBehaviour {
	public float NewTimer;
	public float RoF;
    private void Awake()
    {
		//RoF = GetComponent<CWeapon> ().rof;
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
  	void FixedUpdate()
	{
		//NewTimer = GetComponent<CWeapon> ().timer;
		if(Input.GetKeyDown(KeyCode.Mouse0))
		{
			anim.SetTrigger("SingleShot");
		}	
		//NewTimer = RoF;
	}

	public Animator anim;

}
