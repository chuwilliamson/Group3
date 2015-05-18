using UnityEngine;
using System.Collections;

public class CPlayerTakeDamage : MonoBehaviour {

    [SerializeField]
    private float health;
    [SerializeField]
    private Animator anim;
    private GameObject enemy;

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Enemy")
        {
            enemy = col.gameObject;
            health -= enemy.GetComponent<CEnemy>().attackDamage;
            anim.SetTrigger("TakeDamage");
            print(health);
        }
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(health <=0)
        {
            PlayerController pc = GetComponent<PlayerController>();
            Destroy(pc);
            anim.SetBool("ded", true);
            print("dead");
        }

	}
}
