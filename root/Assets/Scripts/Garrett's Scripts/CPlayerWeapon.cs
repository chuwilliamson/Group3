using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CPlayerWeapon : CWeapon {

    public Animator anim;
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
	protected override void Start () {

        base.Start();
	}
	
	// Update is called once per frame
	protected override void Update () {

        base.Update();

        if(Input.GetKey(KeyCode.Mouse0))
        {
            anim.SetTrigger("DoubleFireBall");
			AudioManager.instance.PlaySound("EnemyAttack");
        }

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

