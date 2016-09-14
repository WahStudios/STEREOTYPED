using UnityEngine;
using System.Collections;

public class CreateRoom : MonoBehaviour {

    public EnemyPlacement enemyPlacement;
    public bool isRoomEmpty = false;
    public bool hasSubTypes = false;
    public bool hasBoss = false;
    public bool hasNPC = false;
    public int totalEnemiesInEncounter = 5;
    public int totalEnemiesOnScreen = 20;
    public int spawnFrequency = 4;

    public SpawnArea[] spawnAreas;

    void Start()
    {
        enemyPlacement = GameObject.Find("EnemyPlacement").GetComponent<EnemyPlacement>();
        //spawnFrequency = totalEnemiesOnScreen / totalEnemiesInEncounter;
        SpawnSequence();
    }

    public void SpawnSequence()
    {
        spawnFrequency -= 1;
        if (spawnFrequency > 0)

        {
            SpawnEnemies();
        }
    }



    public void SpawnEnemies()
    {
       
        // Debug.Log("SpawnEnemies?");
        foreach (SpawnArea a in spawnAreas)
        a.SpawnEnemies();
    }

    public void SpawnSubTypes()
    {

        //foreach(SpawnArea a in spawnAreas}
        //a.SpawnSubTypes();
    }

    public void SpawnBoss()
    {

        //foreach(SpawnArea a in spawnAreas}
        //a.SpawnBoss();
    }

    public void SpawnNPC()
    {

        //foreach(SpawnArea a in spawnAreas}
        //a.SpawnNPC();
    }


}
