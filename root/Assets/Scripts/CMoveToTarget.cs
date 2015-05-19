using UnityEngine;
using System.Collections;

[RequireComponent(typeof(NavMeshAgent))]
public class CMoveToTarget : MonoBehaviour 
{
    public Animator anim;
    public GameObject player;
 
    void FixedUpdate()
    {

        print("agentbehavior");
        NavMeshAgent nma = GetComponent<NavMeshAgent>();

        player = GameObject.FindGameObjectWithTag("Player");
        nma.SetDestination(player.transform.position);

        if (nma.velocity.magnitude > 1)
            print(gameObject.name + " is moving ");
        else if (nma.velocity.magnitude < 1)
            print(gameObject.name + "has stopped");

        anim.SetFloat("move", nma.velocity.magnitude);
        float dist = Vector3.Distance(gameObject.transform.position, player.transform.position);
        anim.SetFloat("distance", dist);
        if (dist < 1.2)
        {
            //anim.SetTrigger("attack");           
        }
    }

    
}
