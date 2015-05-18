#pragma strict

public var speed : float;
public var rotSpeed : float;
private var charCon : CharacterController;
private var charYPos : float;

function Awake(){

	charCon = GetComponent.<CharacterController>();
}

function Start () {

    charYPos = transform.position.y;
}

function FixedUpdate () {
	
    transform.position.y = charYPos;

	if(Input.GetAxis("Vertical")){
		
		charCon.Move(Vector3(0,0,1) * Input.GetAxis("Vertical") * Time.deltaTime * speed);
	}
	
	if(Input.GetAxis("Horizontal")){
	
		charCon.Move(Vector3(1,0,0) * Input.GetAxis("Horizontal") * Time.deltaTime * speed);
	}
	
	var playerPlane = MakePlane(Vector3.up, transform.position);
	var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
	var hitDist = 0.0;
	
	if(playerPlane.Raycast(ray, hitDist)){
		
		var targetPoint = ray.GetPoint(hitDist);
		var targetRotation = Quaternion.LookRotation(targetPoint - transform.position);
		
		transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * rotSpeed);
	}
}

function MakePlane(dir : Vector3, pos : Vector3){

	var plane = new Plane(dir, pos);
	return plane;
}