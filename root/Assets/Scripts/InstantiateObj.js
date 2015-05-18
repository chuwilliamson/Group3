#pragma strict

public var parent : GameObject;
public var obj : GameObject;
public var button : String;
public var spawnRate : float;
private var spawnTimer : float;

function Start () {
	
	spawnTimer = spawnRate;
}

function Update () {

	if(Input.GetAxis(button) && spawnTimer < 0){
	
		Instantiate(obj, parent.transform.position, parent.transform.rotation);	
		spawnTimer = spawnRate;
	}
	
	spawnTimer -= Time.deltaTime;
}