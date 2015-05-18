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
        if(this.CompareTag("Projectile") && a_col.gameObject.tag == "Enemy")
        {
            //if this is a projectile, destroy on impact
            health = -1;
        }

        if (this.CompareTag("Enemy") && a_col.gameObject.CompareTag("Projectile"))
        {
            health -= a_col.transform.gameObject.GetComponent<CProjectile>().damage;
        }

        if (this.gameObject.tag == "Player")
        {
            if(a_col.transform.gameObject.tag == "Enemy")
            {
                health -= a_col.gameObject.GetComponent<CEnemy>().attackDamage;
                GameObject.FindGameObjectWithTag("ScoreKeeper").GetComponent<CScoreData>().playerHealth -= a_col.gameObject.GetComponent<CEnemy>().attackDamage;
                anim.SetTrigger("TakeDamage"); 
            }
        }        
    }
 
	
	// Update is called once per frame
	void Update () {

        if (health < 0)
        {
            if (this.gameObject.tag == "Player")
            {
                anim.SetTrigger("ded");
            }

            if(this.gameObject.tag == "Enemy")
            {
                GameObject.FindGameObjectWithTag("ScoreKeeper").GetComponent<CScoreData>().monstersKilled++;
            }
            Destroy(this.gameObject);
        }
	}
}
