/*#pragma strict

var gunData : GunData;

function OnCollisionEnter(coll : Collision)
{

	var otherObj = coll.gameObject;
	Debug.Log(otherObj.tag);
	Debug.Log(gunData.currentWeapon.Damage);
	
	if(otherObj.CompareTag("Enemy")){
		var enemyData = otherObj.GetComponent(EnemyData);
		enemyData.health -= gunData.currentWeapon.Damage;
		Debug.Log(enemyData.health);
	}
	
	Destroy(this.gameObject);
}

function Awake(){

	var player = GameObject.FindGameObjectWithTag("Player");
	gunData = player.transform.GetComponentInChildren(GunData);
}

*/