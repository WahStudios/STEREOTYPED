using UnityEngine;
using System.Collections;

public class CreateRoom : MonoBehaviour {

    public EnemyPlacement enemyPlacement;
    public bool isRoomEmpty = false;
    public bool isNpcRoom = false;
    public bool isBossRoom = false;
    public bool spawnOtherEnemiesWithBoss = false;
    // public bool hasSubTypes = false;
    //public bool hasBoss = false;
    //public bool hasNPC = false;
    // public int totalEnemiesInEncounter = 5;
    public int spawnWaves = 4;
    int totalEnemiesOnScreen = 20;
    
    int spawnFrequency = 4;

    public SpawnArea[] spawnAreas;
    public SpawnArea bossSpawnArea;
    public SpawnArea npcSpawnArea;
    public SpawnArea[] robotSpawnAreas;
    public SpawnArea[] zombieSpawnAreas;
    public SpawnArea[] insectSpawnAreas;
    public int totalEnemiesLeftBeforeSpawningNextWave = 2;
    public bool isCurrentRoom = false;
    public bool hasSpawned = false;
    void Start()
    {
        totalEnemiesOnScreen = spawnWaves * spawnFrequency;
     //   enemyPlacement = GameObject.Find("EnemyPlacement").GetComponent<EnemyPlacement>();
        //spawnFrequency = totalEnemiesOnScreen / totalEnemiesInEncounter;
       
       
    }
    private void OnTriggerEnter2D(Collider2D other  )
    {
        if(other.gameObject.tag == "Player")
        {
            isCurrentRoom = true;
            hasSpawned = false;
                if (isNpcRoom == true)
                {
                    SpawnNPC();
                }
                if (isBossRoom == true)
                {
                    SpawnBoss();
                    if (spawnOtherEnemiesWithBoss == true)
                    {
                        SpawnSequence();
                    }
                }
                if (isNpcRoom == false && isBossRoom == false)
                {
                    SpawnSequence();
                }
            //}
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(enemiesInRoom != null)
        {
            isCurrentRoom = false;
            if (other.gameObject.tag == "Player")
            {
                StopCoroutine(SequenceCheck());
                enemiesInRoom = GameObject.FindGameObjectsWithTag("Enemy");
                foreach (GameObject g in enemiesInRoom)
                {
                   Destroy(g);
                }
            }
        }
    }
    GameObject[] enemiesInRoom;
    public void SpawnSequence()
    {
        StartCoroutine(SequenceCheck());
    }
    [Tooltip("Amount of time until checking if we should spawn another sequence")]
    public float sequenceChecker = 5f;
    IEnumerator SequenceCheck()
    {
        if (isCurrentRoom == true)
        {
            yield return new WaitForSeconds(sequenceChecker);
            if (isCurrentRoom == true)
            {
                enemiesInRoom = GameObject.FindGameObjectsWithTag("Enemy");
                if (enemiesInRoom.Length < (totalEnemiesLeftBeforeSpawningNextWave))
                {
                    if (totalEnemiesOnScreen > 0)
                    {
                        totalEnemiesOnScreen -= spawnFrequency;

                        SpawnEnemies();
                    }
                }
            }

            StartCoroutine(SequenceCheck());
        }
    }

    public void SpawnEnemies()
    {
       foreach (SpawnArea a in spawnAreas)
        a.SpawnEnemies();
    }
    public void SpawnNPC()
    {
        npcSpawnArea.SpawnNpc();
    }
    public void SpawnBoss()
    {
        bossSpawnArea.SpawnBoss();
    }
    


}
