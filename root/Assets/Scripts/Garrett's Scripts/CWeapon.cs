using UnityEngine;
using System.Collections;

public class CWeapon : MonoBehaviour
{
    public float rof;
    public float lifetime;
    public string type;
    public GameObject projectile;
    public GameObject bucket;
    public float timer;

    void Awake()
    {
    }

    // Use this for initialization
    protected virtual void Start()
    { 
        timer = rof;
    }

    //if you inherit from this class you must provide virtual functions then call the base from 
    //what you are inheriting from. otherwise it will just be hidden.
    protected virtual void Update()
    {

        if (Input.GetKey(KeyCode.Mouse0) && timer < 0)
        {
            GameObject instPrefab = Instantiate(projectile, GetComponent<Transform>().position, GetComponent<Transform>().rotation) as GameObject;
           // instPrefab.transform.parent = GameObject.Find("Bucket").transform;
            instPrefab.transform.parent = GameObject.FindGameObjectWithTag("Bucket").transform;
            timer = rof;
        }

        timer -= Time.deltaTime;
    }

    public void Randomize(float value)
    {
        rof = Random.Range(0.01f, value * 0.02f);
        lifetime = Random.Range(1, value);
        CProjectile proj = projectile.GetComponent<CProjectile>();
        proj.speed = Random.Range(50, value * 4);
        proj.damage = Random.Range(1, value);
        proj.spreadRange = Random.Range(0.1f, value * 0.01f);
    }
}