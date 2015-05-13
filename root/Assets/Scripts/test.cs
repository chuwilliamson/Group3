using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {

    public Animator _anim;
    void Awake()
    {
        
    }
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            _anim.SetTrigger("TakeDamage");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _anim.SetTrigger("DoubleFireBall");
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            _anim.SetTrigger("ded");
        }
	
	}
}
