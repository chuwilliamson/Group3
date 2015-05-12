using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CPlayerWeapon : CWeapon {

    private float startingROF;
    private float startingDamage;
    private float startingLifetime;
    private string startingType;
    private GameObject startingProjectile;
    private GameObject startingBucket;

    public void WeaponPickup(CWeapon weapon)
    {
        rof = weapon.rof;
        lifetime = weapon.lifetime;
        type = weapon.type;
        projectile = weapon.projectile;
        bucket = weapon.bucket;
    }

    void Awake()
    {
        startingROF = rof;
        startingType = type;
        startingProjectile = projectile;
        startingBucket = bucket;
    }

	// Use this for initialization
	public void Start () {

        base.Start();
	}
	
	// Update is called once per frame
	void Update () {

        base.Update();

        if(type != "Starting Weapon")
        {
            lifetime -= Time.deltaTime;
        }
	
        if(lifetime < 0)
        {
            rof = startingROF;
            lifetime = startingLifetime;
            type = startingType;
            projectile = startingProjectile;
            bucket = startingBucket;
        }
	}
}

