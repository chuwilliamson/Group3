using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyManager : MonoBehaviour {

    public enum GameMode
    {
        None,
        Story,
        Horde,

    }
    public GameMode c_mode = GameMode.None;
    public List<GameObject> _enemy = new List<GameObject>(); 
  
    //time that dudes will spawn
    [HideInInspector]
	public float EnemySpawnCounter;
    [HideInInspector]
	public float LevelCounter;
	 

	void Spawn() 
    {
        Color c = Color.white;
        int randColor = Random.Range(0, 5);
        switch (randColor)
        {
            case 0:
                c = Color.blue;
                break;
            case 1: 
                c = Color.green;
                break;
            case 2: 
                c = Color.red;
                break;
            case 3:
                c = Color.yellow;
                break; 
            default:
                c = Color.white;
                break;
         
        }
		int prefab_num = Random.Range (0,_enemy.Count);
		Vector3 newPosition = new Vector3(Random.insideUnitSphere.x * 50, transform.position.y, Random.insideUnitSphere.z * 50);
		GameObject e =  Instantiate(_enemy[prefab_num], newPosition, transform.rotation) as GameObject;
        e.name = "Enemy[" + EnemySpawnCounter.ToString() +"]";
        e.GetComponent<Renderer>().material.color = c;
		++EnemySpawnCounter;
		++ZombieCount.ZombieCounter;

	}
	// Use this for initialization
	void Start () 
    {
        if (c_mode == GameMode.Story)
        {
            LevelCounter = 1;
            int num = Random.Range(1, 10);
            EnemySpawnCounter = LevelCounter * 5 * num;
            StartCoroutine(countdown(EnemySpawnCounter));
        }
        else if (c_mode == GameMode.Horde)
        {
            StartCoroutine(countdown(9000));
        }
	}
	// Update is called once per frame
	void Update () 
    {
		int enemyCount = GameObject.FindGameObjectsWithTag ("Enemy").Length;
 
	}

    /// <summary>
    /// while the timer is less than the limit set
    /// spawn dudes every 5 seconds until the timer is done
    /// </summary>
    /// <param name="time"></param>
    /// <returns></returns>
	IEnumerator countdown(float time)
	{
		int i = 0;
		while (i < time) 
        {
			Spawn();
			yield return new WaitForSeconds(2.5f);
			--time;
		}
	}
}