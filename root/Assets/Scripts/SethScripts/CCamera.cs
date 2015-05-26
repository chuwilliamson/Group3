using UnityEngine;
using System.Collections;

[AddComponentMenu("Camera-Control/Smooth Follow CSharp")]

public class CCamera : MonoBehaviour 
{
    public Transform target;
    public float distance = 10.0f;
    public float height = 5.0f;
    public float heightDamping = 2.0f;
   

    void LateUpdate()
    {
        if (!target)
            return;
        float wantedHeight = target.position.y + height;
        float currentHeight = transform.position.y;

        currentHeight = Mathf.Lerp(currentHeight, wantedHeight, heightDamping * Time.deltaTime);


        transform.position = target.position;
        transform.position = new Vector3(transform.position.x, currentHeight, transform.position.z);

        transform.LookAt(target);
    }

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}
}
