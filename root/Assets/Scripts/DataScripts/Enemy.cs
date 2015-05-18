using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private int _hp;

    public EnemyData enemyData;

    private void Awake()
    {
        enemyData.register(gameObject);
    }

    public int health
    {
        get { return _hp; }
        set { _hp = value; }

    }
    private int weaponDamage = 1;
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "bullet")
        {
            _hp -= weaponDamage;
            StartCoroutine(blinkyFlashy());
        }

    }

    private void Update()
    {
        if (_hp < 0)
        {
            enemyData.unregister(gameObject);
            
        }
    }

    IEnumerator blinkyFlashy()
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
        yield return new WaitForEndOfFrame();
        GetComponent<MeshRenderer>().material.color = Color.white;
    }
}
