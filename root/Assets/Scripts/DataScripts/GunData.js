#pragma strict

class Gun{

	public var ROF : float;
	public var Damage : float;
	public var lifetime : float;
};

public var startingWeapon : Gun;
public var currentWeapon : Gun;
public var weaponLifetime : float;
private var instObjScript : InstantiateObj;

function Awake(){

	currentWeapon = startingWeapon;
	weaponLifetime = currentWeapon.lifetime;
	instObjScript = GetComponent.<InstantiateObj>();
}

function Start () {
	
	
}

function Update () {
	
	instObjScript.spawnRate = currentWeapon.ROF;
	
	// only decrement lifetime if it is
	// not the starting weapon
	if(currentWeapon != startingWeapon){
	
		weaponLifetime -= Time.deltaTime;
	}
	
	Debug.Log(weaponLifetime);
	
	// if the weapon lifetime is less than 0
	// revert back to starting weapon
	if(weaponLifetime < 0){
	
		currentWeapon = startingWeapon;
	}
	
}