using UnityEngine;
using System.Collections;

public class ProjectileEvent : MonoBehaviour
{
    [SerializeField]
    private GunData gunData;

    void OnCollisionEnter(Collision col)
    {
        var otherObj = col.gameObject;
        Debug.Log(otherObj.tag);
        //Debug.Log(gunData.currentWeapon.Damage);

        if (otherObj.CompareTag("Enemy"))
        {
            var enemyData = otherObj.GetComponent<Enemy>();
            enemyData.health -= gunData.damage;
            Debug.Log(enemyData.health);
        }

        Destroy(this.gameObject);

    }


    void Awake()
    {

        var player = GameObject.FindGameObjectWithTag("Player");
        gunData = player.transform.GetComponentInChildren<GunData>();
    }
}