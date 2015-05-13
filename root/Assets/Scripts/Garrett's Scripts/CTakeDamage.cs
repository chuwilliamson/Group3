using UnityEngine;
using System.Collections;

public class CTakeDamage : MonoBehaviour {

    public float health;
    public Animator anim;
    void Awake()
    {
       // print("stuff");
    }

    //character controllers only respond to collisions if they are moving
    void OnCollisionEnter(Collision a_col)
    {
        if(this.CompareTag("Projectile") && a_col.transform.gameObject.tag == "Enemy")
        {
            //if this is a projectile, destroy on impact
            health = -1;
        }

        if (this.CompareTag("Enemy") && a_col.transform.gameObject.CompareTag("Projectile"))
        {
            health -= a_col.transform.gameObject.GetComponent<CProjectile>().damage;
        }

        if (this.transform.gameObject.tag == "Player")
        {
            if(a_col.transform.gameObject.tag == "Enemy")
            {
                health -= a_col.gameObject.GetComponent<CEnemy>().attackDamage;
                anim.SetTrigger("TakeDamage");
                print("hit");
            }
        }
 
        
    }

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

        if (health < 0)
            Destroy(this.gameObject);
	}
}
