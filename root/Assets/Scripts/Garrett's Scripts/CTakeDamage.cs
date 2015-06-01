using UnityEngine;
using System.Collections;

public class CTakeDamage : MonoBehaviour
{

    public float health;

    //character controllers only respond to collisions if they are moving
    //OnCollisionEnter is called when this collider/rigidbody has begun touching another rigidbody/collider.
    void OnCollisionEnter(Collision a_col)
    {
        Vector3 hitForce = (a_col.transform.position - this.transform.position).normalized; //direction of force

        if (this.CompareTag("Projectile") && a_col.gameObject.tag == "Enemy")
        {
            //if this is a projectile, destroy on impact
            health = -1;
        }

        if (this.CompareTag("Enemy") && a_col.gameObject.CompareTag("Projectile"))
        {
            health -= a_col.transform.gameObject.GetComponent<CProjectile>().damage;
        }
	
        if (this.CompareTag("Player"))
        {
            if (this.CompareTag("Enemy"))
            {
                print("player touched enemy");
            }
        }

        if (this.CompareTag("Enemy"))
        {
            if (this.CompareTag("Player"))
            {
                health -= a_col.gameObject.GetComponent<CEnemy>().attackDamage;
                print("enemy touched player");
            }
        }
    }

    void OnCollisionStay(Collision col)
    {
        //if this is the player colliding with an enemy
        if (this.CompareTag("Player"))
        {
            if (col.gameObject.CompareTag("Enemy"))
            {

            }
        }

        //if this is the enemy colliding with a player
        if (this.CompareTag("Enemy"))
        {
            if (col.gameObject.CompareTag("Player"))
            {
                print(gameObject.name + " collided with " + col.gameObject.name);
				//AudioManager.instance.PlaySound("EnemyAttack");
                col.gameObject.GetComponent<CTakeDamage>().health -= this.gameObject.GetComponent<CEnemy>().attackDamage;
				GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>().SetTrigger("TakeDamage");
            }
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {

        if (health < 0)
        {
            if (CompareTag("Player"))
            {                
                GetComponent<Animator>().SetTrigger("ded");
                print("set ded");
            }
             Destroy(this.gameObject);
			 //AudioManager.instance.PlaySound("EnemyDeath");
        }
    }
}
