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

    public bool randomSpawn = false;//only choose 1
    public bool gangSpawn = false;
    public bool subTypeSpawn = false;
    public bool bossSpawn = false;
    public bool npcSpawn = false;
    public bool itemType1Spawn = false;
    public bool itemType2Spawn = false;
    public bool itemType3Spawn = false;
    public int maxRandomSpawn = 7;

    bool hasBlackGang = false;//only select 1 out of list below
    bool hasWhiteGang = false;
    bool hasAsianGang = false;
    bool hasLatinGang = false;
    bool hasBlackGangSubType = false;
    bool hasWhiteGangSubType = false;
    bool hasAsianGangSubType = false;
    bool hasLatinGangSubType = false;
    bool hasItemType1 = false;//only select 1
    bool hasItemType2 = false;
    bool hasItemType3 = false;
    bool hasBlackBoss = false;
    bool hasWhiteBoss = false;
    bool hasAsianBoss = false;
    bool hasLatinBoss = false;
    GameObject objectToSpawn;
    int eventType = 0;
    int gangType = 0;
    int subType = 0;
    bool hasSpawned = false;
    void Start()
    {
      //  totalEnemiesInEncounter = createRoom.totalEnemiesInEncounter;
        //currentEnemiesInEncounter = createRoom.totalEnemiesInEncounter;
       
    //    enemyPlacement = GameObject.Find("EnemyPlacement").GetComponent<EnemyPlacement>() ;
        
    }

    public void SpawnEnemies()
    {
        if (createRoom.hasSpawned == false)
        {
            enemyPlacement.RandomizeGangType();
            createRoom.hasSpawned = true;
        }
        eventType = enemyPlacement.eventType;
       
        subType = enemyPlacement.gangType;
        if (eventType == 0)//no event
        {
                if (gangSpawn)
                {
                    SpawnEnemy(enemyPlacement.gangType);
                }
                else if (subTypeSpawn)
                {
                    SpawnSubTypes();
                }
                else if (bossSpawn)
                {
                    SpawnBoss();
                }
                else if (npcSpawn)
                {
                    SpawnNpc();
                }
                else if (itemType1Spawn)
                {
                    SpawnItems();
                }
                else if (itemType2Spawn)
                {
                    SpawnItems();
                }
                else if (itemType3Spawn)
                {
                    SpawnItems();
                }
                else if (randomSpawn)
            {
                int rand = Random.Range(1, 7);
                if(rand == 1)
                {
                    SpawnEnemy(enemyPlacement.gangType);
                }
                else if(rand == 2)
                {
                    SpawnSubTypes();
                }
                else if (rand== 3)
                {
                    SpawnBoss();
                }
                else if(rand == 4)
                {
                    SpawnItems();
                }
                else if(rand == 5)
                {
                    SpawnNpc();
                }
                else if(rand == 6)
                {
                    SpawnEnemy(gangType);
                }
                else if(rand == 7)
                {
                    SpawnSubTypes();
                }

            }
            
            
        }
       
    }

    void SpawnEnemy(int gangType)
    {
        if(enemyPlacement.gangType == 0)//blackGang
        {
            objectToSpawn = enemyPlacement.blackGangThugs[Random.Range(0, enemyPlacement.blackGangThugs.Length)];
        }
        else if (enemyPlacement.gangType == 1)//whiteGang
        {
            objectToSpawn = enemyPlacement.whiteGangThugs[Random.Range(0, enemyPlacement.whiteGangThugs.Length)];
        }
        else if(enemyPlacement.gangType == 2)//asianGang
        {
            objectToSpawn = enemyPlacement.asianGangThugs[Random.Range(0, enemyPlacement.asianGangThugs.Length)];
        }
        else if(enemyPlacement.gangType == 3)//latinGang
        {
            objectToSpawn = enemyPlacement.latinGangThugs[Random.Range(0, enemyPlacement.latinGangThugs.Length)];
        }
        yMax = topLimit.position.y;
        yMin = bottomLimit.position.y;
        xMin = leftLimit.position.x;
        xMax = rightLimit.position.x;

        float yPos = Random.Range(yMin, yMax);
        float xPos = Random.Range(xMin, xMax);
        Vector2 randPos = new Vector2(xPos, yPos);
       
       GameObject enemyPref = (GameObject)Instantiate(objectToSpawn, randPos, this.transform.rotation);
       
    }

    public void SpawnSubTypes()
    {
        if (enemyPlacement.gangType == 0)//blackGang
        {
            objectToSpawn = enemyPlacement.blackGangSubTypes[Random.Range(0, enemyPlacement.blackGangSubTypes.Length)];
        }                                                                                           
        else if (enemyPlacement.gangType == 1)//whiteGang                                                          
        {                                                                                             
            objectToSpawn = enemyPlacement.whiteGangSubTypes[Random.Range(0, enemyPlacement.whiteGangSubTypes.Length)];
        }                                                                                           
        else if (enemyPlacement.gangType == 2)//asianGang                                                          
        {                                                                                             
            objectToSpawn = enemyPlacement.asianGangSubTypes[Random.Range(0, enemyPlacement.asianGangSubTypes.Length)];
        }                                                                                           
        else if (enemyPlacement.gangType == 3)//latinGang                                                          
        {                                                                                              
            objectToSpawn = enemyPlacement.latinGangSubTypes[Random.Range(0, enemyPlacement.latinGangSubTypes.Length)];
        }
        yMax = topLimit.position.y;
        yMin = bottomLimit.position.y;
        xMin = leftLimit.position.x;
        xMax = rightLimit.position.x;

        float yPos = Random.Range(yMin, yMax);
        float xPos = Random.Range(xMin, xMax);
        Vector2 randPos = new Vector2(xPos, yPos);

        GameObject enemyPref = (GameObject)Instantiate(objectToSpawn, randPos, this.transform.rotation);

    }


    public void SpawnBoss()
    {
        if (enemyPlacement.gangType == 0)//blackGang
        {
            objectToSpawn = enemyPlacement.blackGangBosses[Random.Range(0, enemyPlacement.blackGangBosses.Length)];
        }                                                                                         
        else if (enemyPlacement.gangType == 1)//whiteGang                                                        
        {                                                                                           
            objectToSpawn = enemyPlacement.whiteGangBosses[Random.Range(0, enemyPlacement.whiteGangBosses.Length)];
        }                                                                                         
        else if (enemyPlacement.gangType == 2)//asianGang                                                        
        {                                                                                           
            objectToSpawn = enemyPlacement.asianGangBosses[Random.Range(0, enemyPlacement.asianGangBosses.Length)];
        }                                                                                        
        else if (enemyPlacement.gangType == 3)//latinGang                                                       
        {                                                                                            
            objectToSpawn = enemyPlacement.latinGangBosses[Random.Range(0, enemyPlacement.latinGangBosses.Length)];
        }
        yMax = topLimit.position.y;
        yMin = bottomLimit.position.y;
        xMin = leftLimit.position.x;
        xMax = rightLimit.position.x;

        float yPos = Random.Range(yMin, yMax);
        float xPos = Random.Range(xMin, xMax);
        Vector2 randPos = new Vector2(xPos, yPos);

        GameObject enemyPref = (GameObject)Instantiate(objectToSpawn, randPos, this.transform.rotation);

    }

    public void SpawnNpc()
    {
      
            objectToSpawn = enemyPlacement.npcs[Random.Range(0, enemyPlacement.npcs.Length)];
        
     
        yMax = topLimit.position.y;
        yMin = bottomLimit.position.y;
        xMin = leftLimit.position.x;
        xMax = rightLimit.position.x;

        float yPos = Random.Range(yMin, yMax);
        float xPos = Random.Range(xMin, xMax);
        Vector2 randPos = new Vector2(xPos, yPos);

        GameObject enemyPref = (GameObject)Instantiate(objectToSpawn, randPos, this.transform.rotation);

    }

    public void SpawnItems()
    {
        if (itemType1Spawn)
        {
            objectToSpawn = enemyPlacement.itemsType1[Random.Range(0, enemyPlacement.itemsType1.Length)];
        }
        else if (itemType2Spawn)
        {
            objectToSpawn = enemyPlacement.itemsType2[Random.Range(0, enemyPlacement.itemsType2.Length)];
        }
        else if (itemType3Spawn)
        {
            objectToSpawn = enemyPlacement.itemsType3[Random.Range(0, enemyPlacement.itemsType3.Length)];
        }
        else if (randomSpawn)
        {
            int rand = Random.Range(1, 3);
            if(rand == 1)
            {
                objectToSpawn = enemyPlacement.itemsType1[Random.Range(0, enemyPlacement.itemsType1.Length)];
            }
            else if(rand == 2)
            {
                objectToSpawn = enemyPlacement.itemsType2[Random.Range(0, enemyPlacement.itemsType2.Length)];
            }

            else if(rand == 3)
            {
                objectToSpawn = enemyPlacement.itemsType3[Random.Range(0, enemyPlacement.itemsType3.Length)];
            }
        }


        yMax = topLimit.position.y;
        yMin = bottomLimit.position.y;
        xMin = leftLimit.position.x;
        xMax = rightLimit.position.x;

        float yPos = Random.Range(yMin, yMax);
        float xPos = Random.Range(xMin, xMax);
        Vector2 randPos = new Vector2(xPos, yPos);

        GameObject enemyPref = (GameObject)Instantiate(objectToSpawn, randPos, this.transform.rotation);
    }
}
