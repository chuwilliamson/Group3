#pragma strict

public var damage : float;
public var speed : float;
public var lifetime : float;
private var rb : Rigidbody;
private var tr : Transform;

function Awake(){

	tr = GetComponent.<Transform>();
	rb = GetComponent.<Rigidbody>();
}

function Start () {
	
	rb.AddForce(tr.forward * speed);
}

function Update () {
	
	if(lifetime < 0){
	
		Destroy(this.gameObject);
	}
	
	lifetime-= Time.deltaTime;
}