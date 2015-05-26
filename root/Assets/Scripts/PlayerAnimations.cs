using UnityEngine;
using System.Collections;

public class PlayerAnimations : MonoBehaviour {
    private void Awake()
    {
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
 

}
