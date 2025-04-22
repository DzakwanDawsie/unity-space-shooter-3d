using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {

	public GameObject enemy;
	public int limitSpawn = 0;
	int spawnCount;

	// Use this for initialization
	void Start () {
		StartCoroutine(StartSpawning());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator StartSpawning () {

		if (spawnCount < limitSpawn){
			spawnCount++;
			yield return new WaitForSeconds (Random.Range(5f, 7f));
        	Instantiate (enemy, transform.position, Quaternion.identity);  
        	StartCoroutine (StartSpawning ());
		}else{
			StopCoroutine(StartSpawning());
		}
        
    }
}
