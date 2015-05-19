using UnityEngine;
using System.Collections;

[RequireComponent(typeof(NavMeshAgent))]
public class CMoveToTarget : MonoBehaviour 
{
    public GameObject p;
    void Awake()
    {
        p = GameObject.FindGameObjectWithTag("Player");
    }
    void Update()
    {
        //Vector3 playerPos = GameObject.FindGameObjectWithTag("Player").transform.position;
        GetComponent<NavMeshAgent>().destination = p.transform.position;
    }
}
