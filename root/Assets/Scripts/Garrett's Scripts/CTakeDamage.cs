using UnityEngine;
using System.Collections;

public class CTakeDamage : MonoBehaviour
{
    public float maxHealth = 100;
    public float health;

    public float healthBarLength;

    void Start()
    {
        healthBarLength = Screen.width / 2;
    }

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
                col.gameObject.GetComponent<CTakeDamage>().health -= this.gameObject.GetComponent<CEnemy>().attackDamage;
                GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>().SetTrigger("TakeDamage");
            }
        }
    }

    // Update is called once per frame
       void FixedUpdate()
     {
         adjustCurrentHealth(0);
         if (health < 0)
         {
             if (CompareTag("Player"))
             {                
                 GetComponent<Animator>().SetTrigger("ded");
                 print("set ded");
             }
            
              Destroy(this.gameObject);
         }
     }

       // HealthBar - Seth
       void OnGUI()
       {
           if (this.CompareTag("Player"))
           {
 
               GUI.Box(new Rect(10, 10, healthBarLength, 20), health + "/" + maxHealth);
           }
       }
       public void adjustCurrentHealth(int adjustment)
       {
           if (this.CompareTag("Player"))
           {

               health += adjustment;
               if (health < 0)
               {
                   health = 0;
                   Application.LoadLevel("GameOver");
               }
               if (health > maxHealth)
                   health = maxHealth;
               if (maxHealth < 1)
                   maxHealth = 1;
               healthBarLength = (Screen.width / 2) * (health / (float)maxHealth);
           }
       }
    ////////////////
 }
     