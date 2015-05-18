using UnityEngine;
using System.Collections;

public class CPredictionFollowing : MonoBehaviour {

    public float predictedScalar;
    private NavMeshAgent agent;
    private Vector3 predictedPos;
    private GameObject target;

    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        target = GameObject.FindGameObjectWithTag("Player");

        
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        predictedPos.z = (target.transform.position.z + predictedScalar);
        predictedPos.y = transform.position.y;
        predictedPos.x = transform.position.x;

        agent.SetDestination(target.transform.position);
	}
}
