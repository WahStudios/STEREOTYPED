using UnityEngine;
using System.Collections;

public class EnemyPlacement : MonoBehaviour {
    //using ints allows for expansion later instead of using specific enums
    public int eventType = 0;
    public int gangType = 0;
    int subType = 0;//set by gangType;
    public bool randomSelectGangType = false;
    public int maxGangTypes = 4;
    public GameObject[] blackGangThugs;//spawn is selected in the spawn area script, just stored here
    public GameObject[] blackGangSubTypes;
    public GameObject[] blackGangBosses;
    public GameObject[] whiteGangThugs;//spawn is selected in the spawn area script, just stored here
    public GameObject[] whiteGangBosses;
    public GameObject[] whiteGangSubTypes;
    public GameObject[] asianGangThugs;//spawn is selected in the spawn area script, just stored here
    public GameObject[] asianGangSubTypes;
    public GameObject[] asianGangBosses;
    public GameObject[] latinGangThugs;//spawn is selected in the spawn area script, just stored here
    public GameObject[] latinGangSubTypes;
    public GameObject[] latinGangBosses;
    public GameObject[] itemsType1;//weapons
    public GameObject[] itemsType2;//health
    public GameObject[] itemsType3;//collectible
    public GameObject[] npcs;
   // public int totalEnemiesOnScreen = 6;
    public int maxRooms = 100;
    public CreateRoom[] createRoom;
    GameObject[] createRooms;

    void Start()
    {
        if (randomSelectGangType)
        {
            gangType = Random.Range(0, (maxGangTypes - 1));
        }
        subType = gangType;
        createRoom = new CreateRoom[maxRooms];
        int n = 0;
        createRooms = GameObject.FindGameObjectsWithTag("CreateRoom");
        if(createRooms[n] != null)
        {
            createRoom[n] = createRooms[n].GetComponent<CreateRoom>();
            n++;
            CreateRoomNext(n);
        }
       
    }

    void CreateRoomNext(int n)
    {
        if(createRooms[n] != null)
        {
            createRoom[n] = createRooms[n].GetComponent<CreateRoom>();
            n++;
            CreateRoomNext(n);
        }
    }
    

       void GangWarEvent()
    {

        //randomNumberOfRoom * 2 = opposingGangTypes;
    }

    void BadRobotEvent()
    {

    }

    void ZombieInfestedEvent()
    {

    }

    void InfestedEvent()
    {

    }

    void RacialHarmonyEvent()
    {

    }

    void DarkEvent()
    {

    }

    void LostEvent()
    {

    }

    void WarZoneEvent()
    {

    }


    void AcidRainEvent()
    {

    }

    void RadioActiveHazeEvent()
    {

    }

    void NoEvent()
    {

    }
}
