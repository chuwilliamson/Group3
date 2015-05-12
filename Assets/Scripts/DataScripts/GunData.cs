using UnityEngine;
using System.Collections;

public class GunData : MonoBehaviour 
{

    [SerializeField]
    private int _damage = 5;


    public int damage
    {
        get { return _damage; }
        set { _damage = value; }

    }
//public Gun currentWeapon;
//private InstantiateObj instObjScript;

    void Awake(){

	    //instObjScript = GetComponent(InstantiateObj);
    }

    void Start () {
	
    }

    void Update () {
	
	    //instObjScript.spawnRate = currentWeapon.ROF;
    }
}
