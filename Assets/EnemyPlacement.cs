using UnityEngine;
using System.Collections;

public class EnemyPlacement : MonoBehaviour {

    public enum EventType { GangWar, BadRobot, Infested }

    public EventType eventType;

    public enum GangType { Black, White, Asian }

    public GangType gangType;

    public enum EnemySubType { Black, White, Asian }

    public EnemySubType enemySubType;

    public enum NpcType { NpcType1, NpcType2, NpcType3 }

    public NpcType npcType;

    public enum BossType { Black, White, Asian }

    public BossType bossType;

    public enum BlackBoss { Boss1, Boss2, Boss3 }
    public enum WhiteBoss { Boss1, Boss2, Boss3 }
    public enum AsianBoss { Boss1, Boss2, Boss3 }

    public BlackBoss blackBoss;
    public WhiteBoss whiteBoss;
    public AsianBoss asianBoss;

   public enum BlackSubType { droid1, mech2, droid3 }
   public enum WhiteSubType { mech3, droid4, droid2 }
   public enum AsianSubType { mech1, mech4, droid5 }

    public BlackSubType blackSubType;
    public WhiteSubType whiteSubType;
    public AsianSubType asianSubType;

    public GameObject blackGangPrefab1;
    public GameObject blackGangPrefab2;
    public GameObject blackGangPrefab3;

    public int totalEnemiesPerRoom;
    public bool isRacialharmony = false;
    public bool isGangWar = false;
    public int maxRooms = 100;
    public CreateRoom[] createRoom;
    GameObject[] createRooms;

    void Start()
    {
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
    void ChooseEnemySubType()
    {
        //if gangType == GangType.Black;
        //enemySubType = EnemySubType.Black;
    }

    void ChooseBoss()
    {
        //based on:
        //eventType
        //gangType
    }

    void CreateRooms()
    {
        //createRoom.stuff happen
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
