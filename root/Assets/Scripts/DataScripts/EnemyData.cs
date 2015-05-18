using UnityEngine;
using System.Collections.Generic;

public class EnemyData : MonoBehaviour
{


    [SerializeField]
   // private int _numEnemies = 5;
    private int _enemyCount;


    public int enemyCount
    {
        get { return _enemyCount; }

    }

    public GameObject text;
    public GameObject PORTAL;


    public void unregister(GameObject go)
    {
        enemyDict.Remove(go.name);
        Destroy(go);
        _enemyCount--;

    }

    public void register(GameObject go)
    {
        enemyDict.Add(go.name, go);
        _enemyCount++;

    }

    private void Update()
    {
        if (enemyCount <= 0)
        {
            text.SetActive(true);
            PORTAL.SetActive(true);
        }
    }
    private Dictionary<string, GameObject> enemyDict = new Dictionary<string, GameObject>(); 
}
