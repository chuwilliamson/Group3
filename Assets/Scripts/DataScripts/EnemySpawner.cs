using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {
   
    public int EnemyCount;
	public GameObject Enemy;
	public EnemyData enemyData;
    void spawn() {
        //Vector3 newPosition = new Vector3(Random.insideUnitSphere * 100 * this.gameObject.GetComponent<Transform>().position);
        Vector3 newPosition = new Vector3(Random.insideUnitSphere.x * 50, transform.position.y, Random.insideUnitSphere.z * 50);

        Instantiate(Enemy, newPosition, transform.rotation);
		enemyData.register (gameObject);
        //GetComponent<EnemyData>().register(Enemy);
    }
	// Use this for initialization
	void Start () 
    {
        StartCoroutine(countdown(5));
	}
	
	// Update is called once per frame
	void Update () {
        
        //if (EnemyCount > 5 && timer < 1){
          //  spawn();
          //  timer = 5;
        //}
	}
    
    IEnumerator countdown(int time)
    {
        if (time <= 0){
			//StartCoroutine(countdown(5));
			yield return null;
            if (EnemyCount >= 0)
                spawn();

        }
        else
        {
            yield return new WaitForSeconds(1);
            time--;
            print(time);
            StartCoroutine(countdown(time));
        }
            
         
    }
}
