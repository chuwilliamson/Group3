using UnityEngine;
using System.Collections;

public class PlayerAnimations : MonoBehaviour {
    private void Awake()
    {
        print("anim on awake");
    }
    private void OnCollisionEnter(Collision o)
    {
        print(o.transform.gameObject.tag);
        if(o.transform.gameObject.tag == "Enemy")
        {
            print("touch an enemy");
        }
    }

}
