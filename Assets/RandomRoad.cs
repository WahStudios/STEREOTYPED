using UnityEngine;
using System.Collections;

public class RandomRoad : MonoBehaviour {
	public Transform endPoint;
	public GameObject exitDoor;
	public Transform[] enemySpawnPoints;
	public Transform[] itemSpawnPoints;
	public Transform playerSpawnPoint;
	public int maxItemSpawn;
	public int maxEnemySpawn;
	public GameObject[] items;
	public GameObject[] enemies;
	public int maxRandomItems;
	public int maxRandomEnemies;
	int i = 0;
	int k = 0;

	// Use this for initialization
	void Start () {
		maxItemSpawn--;
		maxEnemySpawn--;

	}
	
	// Update is called once per frame
	void Update () {
		int r = Random.Range(0, maxRandomItems);
		int e = Random.Range(0, maxRandomEnemies);
		if(i <= maxItemSpawn)
		{
			Instantiate(items[r], itemSpawnPoints[i].position, itemSpawnPoints[i].rotation);
			i++;
		}
		if(k <= maxEnemySpawn)
		{
			Instantiate(enemies[e], enemySpawnPoints[k].position, enemySpawnPoints[k].rotation);
			k++;
		}
	}
}
