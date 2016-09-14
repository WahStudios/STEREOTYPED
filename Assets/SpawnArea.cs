using UnityEngine;
using System.Collections;

public class SpawnArea : MonoBehaviour {

    public Transform topLimit;//have these gameobjects attached to spawnarea prefab
    public Transform bottomLimit;
    public Transform leftLimit;
    public Transform rightLimit;
    public bool haslargeEnemies = true;
    public float yMax;
    public float yMin;
    public float xMax;
    public float xMin;
    public CreateRoom createRoom;
    public EnemyPlacement enemyPlacement;
    public int totalEnemiesInEncounter;
    public int currentEnemiesInEncounter;

    void Start()
    {
        totalEnemiesInEncounter = createRoom.totalEnemiesInEncounter;
        currentEnemiesInEncounter = createRoom.totalEnemiesInEncounter;
       
        enemyPlacement = GameObject.Find("EnemyPlacement").GetComponent<EnemyPlacement>() ;
    }

    public void SpawnEnemies()
    {
       
        SpawnEnemy();
    }

    void SpawnEnemy()
    {
      
        yMax = topLimit.position.y;
        yMin = bottomLimit.position.y;
        xMin = leftLimit.position.x;
        xMax = rightLimit.position.x;

        float yPos = Random.Range(yMin, yMax);
        float xPos = Random.Range(xMin, xMax);
        Vector2 randPos = new Vector2(xPos, yPos);
       // Debug.Log("SpawnEnemy:D");
       GameObject enemyPref = (GameObject)Instantiate(enemyPlacement.blackGangPrefab1, randPos, this.transform.rotation);
       // enemyPref.transform.SetParent(this.transform);
        //instantiate gameobject at randPos;
    }

    public void SpawnSubTypes()
    {
        float yPos = Random.Range(yMin, yMax);
        float xPos = Random.Range(xMin, xMax);
        Vector2 randPos = new Vector2(xPos, yPos);

        //instantiate gameobject at randPos;
    }


    public void SpawnBoss()
    {
        float yPos = Random.Range(yMin, yMax);
        float xPos = Random.Range(xMin, xMax);
        Vector2 randPos = new Vector2(xPos, yPos);

        //instantiate gameobject at randPos;
    }

    public void SpawnNpc()
    {
        float yPos = Random.Range(yMin, yMax);
        float xPos = Random.Range(xMin, xMax);
        Vector2 randPos = new Vector2(xPos, yPos);

        //instantiate gameobject at randPos;
    }
}
