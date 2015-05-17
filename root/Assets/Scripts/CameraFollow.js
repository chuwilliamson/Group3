#pragma strict

public var target : GameObject;
public var speed : float;
private var followDir : Vector3;

function Start () {

}

function Update () {
	
	followDir = (target.transform.position - transform.position).normalized;
	
	if((transform.position - target.transform.position).sqrMagnitude > 4){
		GetComponent.<Rigidbody>().AddForce(Vector3(followDir.x, 0, followDir.z) * speed);
	}
	
}