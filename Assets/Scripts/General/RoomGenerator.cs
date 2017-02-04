using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RoomGenerator : MonoBehaviour {

	public GameObject playerToSpawn;
	public GameObject startRoom;
	public GameObject shopRoom;
	public GameObject itemRoom;
	public GameObject specialRoom1;
	public GameObject specialRoom2;
	public GameObject bossRoom;
	public GameObject[] randomRooms;
	public GameObject[] specialRooms;
	public int gridWidth = 12;
	public int gridHeight = 12;
	public GameObject[] gridColumn1;
	public GameObject[] gridColumn2;
	public GameObject[] gridColumn3;
	public GameObject[] gridColumn4;
	public GameObject[] gridColumn5;
	public GameObject[] gridColumn6;
	public GameObject[] gridColumn7;
	public GameObject[] gridColumn8;
	public GameObject[] gridColumn9;
	public GameObject[] gridColumn10;
	public GameObject[] gridColumn11;
	public GameObject[] gridColumn12;
	public GameObject[] gridColumn13;
	public GameObject[] gridColumn14;	
	public GameObject[] gridColumn15;
	public GameObject[] gridColumn16;
	public GameObject startingPoint;

	public int currentRandomRooms = 0;
	public GameObject currentGrid;
	public GameObject currentGrid2;
	public GameObject currentGrid3;
	public GameObject currentGrid4;
	public GameObject currentRandomRoom;
	public GameObject currentRandomRoom2;
	public GameObject currentRandomRoom3;
	public GameObject currentRandomRoom4;
	public GameObject currentRandomRoom5;
	public GameObject currentRandomRoom6;
	public GameObject currentRandomRoom7;
	public GameObject currentRandomRoom8;
	public Dictionary<GameObject, int> usedRooms;
	public Dictionary<GameObject, int> usedGrids;
	public int maxSpecialRooms = 5;
	//public GameObject[] gridColumn17;
	//public GameObject[] gridColumn18;
	//public GameObject[] gridColumn19;
	//public GameObject[] gridColumn20;

	public int maxRandomRooms;
	public int specialRoomFrequency = 0;
	public int currentRoomFrequency = 0;
	public int currentSpecialRoom = 0;
	public RoomOptions startingRoomOptions;
    public bool isStartingRoom = true;
    public bool isStart1 = true;
    public bool isStart2 = true;
    public bool isStart3 = true;
    public bool isStart4 = true;
	// Use this for initialization
	void Start () {
        isStartingRoom = true;
		usedGrids = new Dictionary<GameObject, int> ();
		usedRooms = new Dictionary<GameObject, int> ();
		maxRandomRooms = randomRooms.Length -1;
        specialRoomFrequency = randomRooms.Length / 5;
        int randGridNumber = Random.Range (4, gridWidth - 4);
        int randGridSelection = Random.Range(4, gridHeight - 4);
        GameObject[] gridColumnSelection = gridColumn1;
        GameObject[] gridColumnLeft = gridColumn1;
        GameObject[] gridColumnRight = gridColumn2;
		if (randGridNumber == 1) {
            gridColumnSelection = gridColumn1;
           gridColumnLeft = gridColumn1;
           gridColumnRight = gridColumn2;
            startingPoint = gridColumnSelection[randGridSelection];
		}
		if (randGridNumber == 2) {
           gridColumnLeft = gridColumn1;
            gridColumnRight = gridColumn3;
            gridColumnSelection = gridColumn2;
            startingPoint = gridColumnSelection[randGridSelection];
        }
		if (randGridNumber == 3) {
            gridColumnSelection = gridColumn3;
            gridColumnLeft = gridColumn2;
           gridColumnRight = gridColumn4;
            startingPoint = gridColumnSelection[randGridSelection];
        }
		if (randGridNumber == 4) {
            gridColumnSelection = gridColumn4;
            gridColumnLeft = gridColumn3;
            gridColumnRight = gridColumn5;
            startingPoint = gridColumnSelection[randGridSelection];
        }
		if (randGridNumber == 5) {
            gridColumnSelection = gridColumn5;
            gridColumnLeft = gridColumn4;
           gridColumnRight = gridColumn6;
            startingPoint = gridColumnSelection[randGridSelection];
        }
		if (randGridNumber == 6) {
            gridColumnSelection = gridColumn6;
           gridColumnLeft = gridColumn5;
            gridColumnRight = gridColumn7;
            startingPoint = gridColumnSelection[randGridSelection];
        }
		if (randGridNumber == 7) {
            gridColumnSelection = gridColumn7;
           gridColumnLeft = gridColumn6;
gridColumnRight = gridColumn8;
            startingPoint = gridColumnSelection[randGridSelection];

        }
		if (randGridNumber == 8) {
            gridColumnSelection = gridColumn8;
            gridColumnLeft = gridColumn7;
            gridColumnRight = gridColumn9;
            startingPoint = gridColumnSelection[randGridSelection];
        }
		if (randGridNumber == 9) {
            gridColumnSelection = gridColumn9;
            gridColumnLeft = gridColumn8;
            gridColumnRight = gridColumn10;
            startingPoint = gridColumnSelection[randGridSelection];
        }
		if (randGridNumber == 10) {
            gridColumnSelection = gridColumn10;
            gridColumnLeft = gridColumn9;
            gridColumnRight = gridColumn11;
            startingPoint = gridColumnSelection[randGridSelection];
        }
		if (randGridNumber == 11) {
            gridColumnSelection = gridColumn11;
           gridColumnLeft = gridColumn10;
            gridColumnRight= gridColumn12;
            startingPoint = gridColumnSelection[randGridSelection];
        }
		if (randGridNumber == 12) {
            gridColumnSelection = gridColumn12;
            gridColumnLeft = gridColumn11;
            gridColumnRight = gridColumn13;
            startingPoint = gridColumnSelection[randGridSelection];
        }
		if (randGridNumber == 13) {
            gridColumnSelection = gridColumn13;
            gridColumnLeft = gridColumn12;
            gridColumnRight = gridColumn14;
            startingPoint = gridColumnSelection[randGridSelection];
        }
		if (randGridNumber == 14) {
            gridColumnSelection = gridColumn14;
            gridColumnLeft = gridColumn13;
            gridColumnRight = gridColumn15;
            startingPoint = gridColumnSelection[randGridSelection];
        }
		if (randGridNumber == 15) {
            gridColumnSelection = gridColumn15;
            gridColumnLeft = gridColumn14;
            gridColumnRight = gridColumn16;
            startingPoint = gridColumnSelection[randGridSelection];
        }
		if (randGridNumber == 16) {
            gridColumnSelection = gridColumn16;
           gridColumnLeft = gridColumn15;
            gridColumnRight = gridColumn16;
            startingPoint = gridColumnSelection[randGridSelection];
        }
		startRoom.transform.position = startingPoint.transform.position;
        startingRoomOptions = startRoom.GetComponent<RoomOptions>();
       
        currentGrid = startingPoint;
        currentGrid2 = startingPoint;
        currentGrid3 = startingPoint;
        currentGrid4 = startingPoint;
        startRoom.name = currentGrid.name;
        currentRandomRoom = startRoom;
        int randomSplitAmount = Random.Range(3, 4);
        int randomDirection = Random.Range(1, 4);
        usedRooms.Add(startRoom, usedGridNumber);
        usedGridNumber++;
        StartRoom(gridColumnSelection, gridColumnLeft, gridColumnRight, randGridSelection);
        playerToSpawn.transform.position = startingRoomOptions.upDoor.transform.position;
    }
    public int BossRoomVerticalLocation = 0;
    public GameObject[] bossPossibleLocations;
    public int bossLayerNumber = 0;
    public GameObject[] grids;
    void BossRoom()
    {
        
        SpawnBoss();
    }

    void SpawnBoss()//GridPos bossGridPos
    {
        Debug.Log("SpawnBoss");
        int randomDirection;

        int max = maxRandomRooms + 1;
            randomDirection = Random.Range(1, 4);//1=left, 2=right, 3=up, 4=down
            int randRoom = Random.Range(0, maxRandomRooms);
            //  if (isStartingRoom == false)
            // {
            currentRandomRoom = bossRoom;
            // }
            // else
            // {
            //    currentRandomRoom = startRoom;
            //   isStartingRoom = false;
            // }

            GridPos gridPos;
      

            //   GridPos gridPos = currentGrid.GetComponent<GridPos>();
            int randomUsedGrid = Random.Range(0, usedGrids.Count);
            gridPos = currentGrid.GetComponent<GridPos>();
            if (isStart1 == false)
            {
                foreach (KeyValuePair<GameObject, int> i in usedGrids)
                {
                    if (i.Value == randomUsedGrid)
                    {
                        gridPos = i.Key.GetComponent<GridPos>();
                    }



                }
            }
            else
            {
                gridPos = currentGrid.GetComponent<GridPos>();
                isStart1 = false;

            }

        if (randomDirection == 1)//up
        {
            if (!usedGrids.ContainsKey(gridPos.aboveGrid) && gridPos.aboveGrid != null && roomPool.transform.Find(gridPos.aboveGrid.name) == null)
            {
                if (gridPos.aboveGrid != null)
                {
                    currentRandomRoom.transform.position = gridPos.aboveGrid.transform.position;
                    currentGrid = gridPos.aboveGrid;
                    //usedGrids.Add(gridPos.aboveGrid, usedGridNumber);
                    // usedGridNumber++;
                }
            }
            else if (!usedGrids.ContainsKey(gridPos.belowGrid) && gridPos.belowGrid != null && roomPool.transform.Find(gridPos.belowGrid.name) == null)
            {
                if (gridPos.belowGrid != null)
                {
                    currentRandomRoom.transform.position = gridPos.belowGrid.transform.position;
                    currentGrid = gridPos.belowGrid;
                    //usedGrids.Add(gridPos.belowGrid, usedGridNumber);
                    // usedGridNumber++;
                }
            }
            else if (!usedGrids.ContainsKey(gridPos.leftGrid) && gridPos.leftGrid != null && roomPool.transform.Find(gridPos.leftGrid.name) == null)
            {
                if (gridPos.leftGrid != null)
                {
                    currentRandomRoom.transform.position = gridPos.leftGrid.transform.position;
                    currentGrid = gridPos.leftGrid;
                    //usedGrids.Add(gridPos.leftGrid, usedGridNumber);
                    //usedGridNumber++;
                }
            }
            else if (!usedGrids.ContainsKey(gridPos.rightGrid) && gridPos.rightGrid != null && roomPool.transform.Find(gridPos.rightGrid.name) == null)
            {
                if (gridPos.rightGrid != null)
                {
                    currentRandomRoom.transform.position = gridPos.rightGrid.transform.position;
                    currentGrid = gridPos.rightGrid;
                    // usedGrids.Add(gridPos.rightGrid, usedGridNumber);
                    //usedGridNumber++;
                }
            }


        }
        else if (randomDirection == 2)//down
        {
            if (!usedGrids.ContainsKey(gridPos.belowGrid) && gridPos.belowGrid != null && roomPool.transform.Find(gridPos.belowGrid.name) == null)
            {
                if (gridPos.belowGrid != null)
                {
                    currentRandomRoom.transform.position = gridPos.belowGrid.transform.position;
                    currentGrid = gridPos.belowGrid;
                    // usedGrids.Add(gridPos.belowGrid, usedGridNumber);
                    // usedGridNumber++;
                }
            }
            else if (!usedGrids.ContainsKey(gridPos.aboveGrid) && gridPos.aboveGrid != null && roomPool.transform.Find(gridPos.aboveGrid.name) == null)
            {
                if (gridPos.aboveGrid != null)
                {
                    currentRandomRoom.transform.position = gridPos.aboveGrid.transform.position;
                    currentGrid = gridPos.aboveGrid;
                    //usedGrids.Add(gridPos.aboveGrid, usedGridNumber);
                    //usedGridNumber++;
                }
            }
            else if (!usedGrids.ContainsKey(gridPos.leftGrid) && gridPos.leftGrid != null && roomPool.transform.Find(gridPos.leftGrid.name) == null)
            {
                if (gridPos.leftGrid != null)
                {
                    currentRandomRoom.transform.position = gridPos.leftGrid.transform.position;
                    currentGrid = gridPos.leftGrid;
                    // usedGrids.Add(gridPos.leftGrid, usedGridNumber);
                    // usedGridNumber++;
                }
            }
            else if (!usedGrids.ContainsKey(gridPos.rightGrid) && gridPos.rightGrid != null && roomPool.transform.Find(gridPos.rightGrid.name) == null)
            {
                if (gridPos.rightGrid != null)
                {
                    currentRandomRoom.transform.position = gridPos.rightGrid.transform.position;
                    currentGrid = gridPos.rightGrid;
                    // usedGrids.Add(gridPos.rightGrid, usedGridNumber);
                    // usedGridNumber++;
                }
            }


        }
        else if (randomDirection == 3)//left
        {
            if (!usedGrids.ContainsKey(gridPos.leftGrid) && gridPos.leftGrid != null && roomPool.transform.Find(gridPos.leftGrid.name) == null)
            {
                if (gridPos.leftGrid != null)
                {
                    currentRandomRoom.transform.position = gridPos.leftGrid.transform.position;
                    currentGrid = gridPos.leftGrid;
                    //  usedGrids.Add(gridPos.leftGrid, usedGridNumber);
                    //  usedGridNumber++;
                }

            }
            else if (!usedGrids.ContainsKey(gridPos.aboveGrid) && gridPos.aboveGrid != null && roomPool.transform.Find(gridPos.aboveGrid.name) == null)
            {
                if (gridPos.aboveGrid != null)
                {
                    currentRandomRoom.transform.position = gridPos.aboveGrid.transform.position;
                    currentGrid = gridPos.aboveGrid;
                    // usedGrids.Add(gridPos.aboveGrid, usedGridNumber);
                    //  usedGridNumber++;
                }
            }
            else if (!usedGrids.ContainsKey(gridPos.belowGrid) && gridPos.belowGrid != null && roomPool.transform.Find(gridPos.belowGrid.name) == null)
            {
                if (gridPos.belowGrid != null)
                {
                    currentRandomRoom.transform.position = gridPos.belowGrid.transform.position;
                    currentGrid = gridPos.belowGrid;
                    // usedGrids.Add(gridPos.belowGrid, usedGridNumber);
                    // usedGridNumber++;
                }
            }
            else if (!usedGrids.ContainsKey(gridPos.rightGrid) && gridPos.rightGrid != null && roomPool.transform.Find(gridPos.rightGrid.name) == null)
            {
                if (gridPos.rightGrid != null)
                {
                    currentRandomRoom.transform.position = gridPos.rightGrid.transform.position;
                    currentGrid = gridPos.rightGrid;
                    //usedGrids.Add(gridPos.rightGrid, usedGridNumber);
                    // usedGridNumber++;
                }
            }


        }
        else if (randomDirection == 4)//right
        {
            if (!usedGrids.ContainsKey(gridPos.rightGrid) && gridPos.rightGrid != null && roomPool.transform.Find(gridPos.rightGrid.name) == null)
            {
                if (gridPos.rightGrid != null)
                {
                    currentRandomRoom.transform.position = gridPos.rightGrid.transform.position;
                    currentGrid = gridPos.rightGrid;
                    // usedGrids.Add(gridPos.rightGrid, usedGridNumber);
                    // usedGridNumber++;
                }
            }

            else if (!usedGrids.ContainsKey(gridPos.aboveGrid) && gridPos.aboveGrid != null && roomPool.transform.Find(gridPos.aboveGrid.name) == null)
            {
                if (gridPos.aboveGrid != null)
                {
                    currentRandomRoom.transform.position = gridPos.aboveGrid.transform.position;
                    currentGrid = gridPos.aboveGrid;
                    // usedGrids.Add(gridPos.aboveGrid, usedGridNumber);
                    //usedGridNumber++;
                }
            }
            else if (!usedGrids.ContainsKey(gridPos.belowGrid) && gridPos.belowGrid != null && roomPool.transform.Find(gridPos.belowGrid.name) == null)
            {
                if (gridPos.belowGrid != null)
                {
                    currentRandomRoom.transform.position = gridPos.belowGrid.transform.position;
                    currentGrid = gridPos.belowGrid;
                    //  usedGrids.Add(gridPos.belowGrid, usedGridNumber);
                    // usedGridNumber++;
                }
            }
            else if (!usedGrids.ContainsKey(gridPos.leftGrid) && gridPos.leftGrid != null && roomPool.transform.Find(gridPos.leftGrid.name) == null)
            {
                if (gridPos.leftGrid != null)
                {
                    currentRandomRoom.transform.position = gridPos.leftGrid.transform.position;
                    currentGrid = gridPos.leftGrid;
                    //usedGrids.Add(gridPos.leftGrid, usedGridNumber); usedGridNumber++;
                }

            }


        }
            currentRandomRoom.name = currentGrid.name;
            usedRooms.Add(currentRandomRoom, 1);
            currentRandomRooms++;


        }
        
       
    


            void StartRoom(GameObject[] gridColumnSelection, GameObject[] gridColumnLeft, GameObject[] gridColumnRight, int randGridSelection)
    {
       
        NextRoom();
       
    }
    public GameObject currentSpecialRoom1;
    public GameObject currentSpecialRoom2;
    public GameObject currentSpecialRoom3;
    public GameObject currentSpecialRoom4;
    void SpecialRoom2(int randomDirection){

		if (currentSpecialRoom > maxSpecialRooms) {
			NextRoom2 ();
		} else {
            Debug.Log("Special2");
			currentSpecialRoom2 = specialRooms [currentSpecialRoom];
			currentSpecialRoom++;

			GridPos gridPos = currentGrid2.GetComponent<GridPos> ();
			if (randomDirection == 1) {//up
				if (!usedGrids.ContainsKey (gridPos.aboveGrid) && gridPos.aboveGrid != null && roomPool.transform.Find(gridPos.aboveGrid.name) == null) {

					currentSpecialRoom2.transform.position = gridPos.aboveGrid.transform.position;

					currentGrid2 = gridPos.aboveGrid;

					usedGrids.Add (gridPos.aboveGrid, usedGridNumber);
                    usedGridNumber++;

                } else if (!usedGrids.ContainsKey (gridPos.belowGrid) && gridPos.belowGrid != null && roomPool.transform.Find(gridPos.belowGrid.name) == null) {
				
					currentSpecialRoom2.transform.position = gridPos.belowGrid.transform.position;
					currentGrid2 = gridPos.belowGrid;
					usedGrids.Add (gridPos.belowGrid, usedGridNumber);
                    usedGridNumber++;

                } else if (!usedGrids.ContainsKey (gridPos.leftGrid) && gridPos.leftGrid != null && roomPool.transform.Find(gridPos.leftGrid.name) == null) {

					currentSpecialRoom2.transform.position = gridPos.leftGrid.transform.position;
					currentGrid2 = gridPos.leftGrid;
					usedGrids.Add (gridPos.leftGrid, usedGridNumber);
                    usedGridNumber++;

                } else if (!usedGrids.ContainsKey (gridPos.rightGrid) && gridPos.rightGrid != null && roomPool.transform.Find(gridPos.rightGrid.name) == null) {

					currentSpecialRoom2.transform.position = gridPos.rightGrid.transform.position;
					currentGrid2 = gridPos.rightGrid;
					usedGrids.Add (gridPos.rightGrid, usedGridNumber);
                    usedGridNumber++;

                }
			
			
			} else if (randomDirection == 2) {//down
				if (!usedGrids.ContainsKey (gridPos.belowGrid) && gridPos.belowGrid != null && roomPool.transform.Find(gridPos.belowGrid.name) == null) {

					currentSpecialRoom2.transform.position = gridPos.belowGrid.transform.position;
					currentGrid2 = gridPos.belowGrid;
					usedGrids.Add (gridPos.belowGrid, usedGridNumber);
                    usedGridNumber++;

                } else if (!usedGrids.ContainsKey (gridPos.aboveGrid) && gridPos.aboveGrid != null && roomPool.transform.Find(gridPos.aboveGrid.name) == null) {

					currentSpecialRoom2.transform.position = gridPos.aboveGrid.transform.position;
					currentGrid2 = gridPos.aboveGrid;
					usedGrids.Add (gridPos.aboveGrid, usedGridNumber);
                    usedGridNumber++;

                } else if (!usedGrids.ContainsKey (gridPos.leftGrid) && gridPos.leftGrid != null && roomPool.transform.Find(gridPos.leftGrid.name) == null) {

					currentSpecialRoom2.transform.position = gridPos.leftGrid.transform.position;
					currentGrid2 = gridPos.leftGrid;
					usedGrids.Add (gridPos.leftGrid, usedGridNumber);
                    usedGridNumber++;

                } else if (!usedGrids.ContainsKey (gridPos.rightGrid) && gridPos.rightGrid != null && roomPool.transform.Find(gridPos.rightGrid.name) == null) {

					currentSpecialRoom2.transform.position = gridPos.rightGrid.transform.position;
					currentGrid2 = gridPos.rightGrid;
					usedGrids.Add (gridPos.rightGrid, usedGridNumber);
                    usedGridNumber++;

                }
			
			
			} else if (randomDirection == 3) {//left
				if (!usedGrids.ContainsKey (gridPos.leftGrid) && gridPos.leftGrid != null && roomPool.transform.Find(gridPos.leftGrid.name) == null) {

					currentSpecialRoom2.transform.position = gridPos.leftGrid.transform.position;
					currentGrid2 = gridPos.leftGrid;
					usedGrids.Add (gridPos.leftGrid, usedGridNumber);
                    usedGridNumber++;


                } else if (!usedGrids.ContainsKey (gridPos.aboveGrid) && gridPos.aboveGrid != null && roomPool.transform.Find(gridPos.aboveGrid.name) == null) {
					if(gridPos.aboveGrid != null){
					currentSpecialRoom2.transform.position = gridPos.aboveGrid.transform.position;
					currentGrid2 = gridPos.aboveGrid;
					usedGrids.Add (gridPos.aboveGrid, usedGridNumber);
                        usedGridNumber++;
                    }
				} else if (!usedGrids.ContainsKey (gridPos.belowGrid) && gridPos.belowGrid != null && roomPool.transform.Find(gridPos.belowGrid.name) == null) {
					if(gridPos.belowGrid != null){
					currentSpecialRoom2.transform.position = gridPos.belowGrid.transform.position;
					currentGrid2 = gridPos.belowGrid;
					usedGrids.Add (gridPos.belowGrid, usedGridNumber);
                        usedGridNumber++;
                    }
				} else if (!usedGrids.ContainsKey (gridPos.rightGrid) && gridPos.rightGrid != null && roomPool.transform.Find(gridPos.rightGrid.name) == null) {
					if(gridPos.rightGrid != null){
					currentSpecialRoom2.transform.position = gridPos.rightGrid.transform.position;
					currentGrid2 = gridPos.rightGrid;
					usedGrids.Add (gridPos.rightGrid, usedGridNumber);
                        usedGridNumber++;
                    }
				}
			
			
			} else if (randomDirection == 4) {//right
				if (!usedGrids.ContainsKey (gridPos.rightGrid) && gridPos.rightGrid != null && roomPool.transform.Find(gridPos.rightGrid.name) == null) {
					if(gridPos.rightGrid != null){
					currentSpecialRoom2.transform.position = gridPos.rightGrid.transform.position;
					currentGrid2 = gridPos.rightGrid;
					usedGrids.Add (gridPos.rightGrid, usedGridNumber);
                        usedGridNumber++;
                    }
				} else  if (!usedGrids.ContainsKey (gridPos.aboveGrid) && gridPos.aboveGrid != null && roomPool.transform.Find(gridPos.aboveGrid.name) == null) {
					if(gridPos.aboveGrid != null){
					currentSpecialRoom2.transform.position = gridPos.aboveGrid.transform.position;
					currentGrid2 = gridPos.aboveGrid;
					usedGrids.Add (gridPos.aboveGrid, usedGridNumber);
                        usedGridNumber++;
                    }
				} else if (!usedGrids.ContainsKey (gridPos.belowGrid) && gridPos.belowGrid != null && roomPool.transform.Find(gridPos.belowGrid.name) == null) {
					if(gridPos.belowGrid != null){
					currentSpecialRoom2.transform.position = gridPos.belowGrid.transform.position;
					currentGrid2 = gridPos.belowGrid;
					usedGrids.Add (gridPos.belowGrid, usedGridNumber);
                        usedGridNumber++;
                    }
				} else if (!usedGrids.ContainsKey (gridPos.leftGrid) && gridPos.leftGrid != null && roomPool.transform.Find(gridPos.leftGrid.name) == null) {
					if(gridPos.leftGrid != null){
					currentSpecialRoom2.transform.position = gridPos.leftGrid.transform.position;
					currentGrid2 = gridPos.leftGrid;
					usedGrids.Add (gridPos.leftGrid, usedGridNumber);
                        usedGridNumber++;
                    }
				
				}
			
			
			}
			currentSpecialRoom2.name = currentGrid2.name;
			usedRooms.Add (currentSpecialRoom2, 1);
			NextRoom ();
		}
	}

	void SpecialRoom3(int randomDirection){
		currentSpecialRoom3 = specialRooms [currentSpecialRoom];
		if (currentSpecialRoom > maxSpecialRooms) {
			NextRoom3 ();
		} else {
           
			currentSpecialRoom++;
	
			GridPos gridPos = currentGrid3.GetComponent<GridPos> ();
			if (randomDirection == 1) {//up
				if (!usedGrids.ContainsKey (gridPos.aboveGrid) && gridPos.aboveGrid != null && roomPool.transform.Find(gridPos.aboveGrid.name) == null) {
					if(gridPos.aboveGrid != null){
					currentSpecialRoom3.transform.position = gridPos.aboveGrid.transform.position;
					currentGrid3 = gridPos.aboveGrid;
					usedGrids.Add (gridPos.aboveGrid, usedGridNumber);
                        usedGridNumber++;
                    }
				} else  if (!usedGrids.ContainsKey (gridPos.belowGrid) && gridPos.belowGrid != null && roomPool.transform.Find(gridPos.belowGrid.name) == null) {
					if(gridPos.belowGrid != null){
					currentSpecialRoom3.transform.position = gridPos.belowGrid.transform.position;
					currentGrid3 = gridPos.belowGrid;
					usedGrids.Add (gridPos.belowGrid, usedGridNumber);
                        usedGridNumber++;
                    }
				} else if (!usedGrids.ContainsKey (gridPos.leftGrid) && gridPos.leftGrid != null && roomPool.transform.Find(gridPos.leftGrid.name) == null) {
					if(gridPos.leftGrid != null){
					currentSpecialRoom3.transform.position = gridPos.leftGrid.transform.position;
					currentGrid3 = gridPos.leftGrid;
					usedGrids.Add (gridPos.leftGrid, usedGridNumber);
                        usedGridNumber++;
                    }
				} else if (!usedGrids.ContainsKey (gridPos.rightGrid) && gridPos.rightGrid != null && roomPool.transform.Find(gridPos.rightGrid.name) == null) {
					if(gridPos.rightGrid != null){
					currentSpecialRoom3.transform.position = gridPos.rightGrid.transform.position;
					currentGrid3 = gridPos.rightGrid;
					usedGrids.Add (gridPos.rightGrid, usedGridNumber);
                        usedGridNumber++;
                    }
				}
				
				
			} else if (randomDirection == 2) {//down
				if (!usedGrids.ContainsKey (gridPos.belowGrid) && gridPos.belowGrid != null && roomPool.transform.Find(gridPos.belowGrid.name) == null) {
					if(gridPos.belowGrid != null){
					currentSpecialRoom3.transform.position = gridPos.belowGrid.transform.position;
					currentGrid3 = gridPos.belowGrid;
					usedGrids.Add (gridPos.belowGrid, usedGridNumber);
                        usedGridNumber++;
                    }
				} else if (!usedGrids.ContainsKey (gridPos.aboveGrid) && gridPos.aboveGrid != null && roomPool.transform.Find(gridPos.aboveGrid.name) == null) {
					if(gridPos.aboveGrid != null){
					currentSpecialRoom3.transform.position = gridPos.aboveGrid.transform.position;
					currentGrid3 = gridPos.aboveGrid;
					usedGrids.Add (gridPos.aboveGrid, usedGridNumber);
                        usedGridNumber++;
                    }
				} else if (!usedGrids.ContainsKey (gridPos.leftGrid) && gridPos.leftGrid != null && roomPool.transform.Find(gridPos.leftGrid.name) == null) {
					if(gridPos.leftGrid != null){
					currentSpecialRoom3.transform.position = gridPos.leftGrid.transform.position;
					currentGrid3 = gridPos.leftGrid;
					usedGrids.Add (gridPos.leftGrid, usedGridNumber);
                        usedGridNumber++;
                    }
				} else if (!usedGrids.ContainsKey (gridPos.rightGrid) && gridPos.rightGrid != null && roomPool.transform.Find(gridPos.rightGrid.name) == null) {
					if(gridPos.rightGrid != null){
					currentSpecialRoom3.transform.position = gridPos.rightGrid.transform.position;
					currentGrid3 = gridPos.rightGrid;
					usedGrids.Add (gridPos.rightGrid, usedGridNumber);
                        usedGridNumber++;
                    }
				}
				
				
			} else if (randomDirection == 3) {//left
				if (!usedGrids.ContainsKey (gridPos.leftGrid) && gridPos.leftGrid != null && roomPool.transform.Find(gridPos.leftGrid.name) == null) {
					if(gridPos.leftGrid != null){
					currentSpecialRoom3.transform.position = gridPos.leftGrid.transform.position;
					currentGrid3 = gridPos.leftGrid;
					usedGrids.Add (gridPos.leftGrid, usedGridNumber);
                        usedGridNumber++;
                    }
				
					
				} else if (!usedGrids.ContainsKey (gridPos.aboveGrid) && gridPos.aboveGrid != null && roomPool.transform.Find(gridPos.aboveGrid.name) == null) {

					currentSpecialRoom3.transform.position = gridPos.aboveGrid.transform.position;
					currentGrid3 = gridPos.aboveGrid;
					usedGrids.Add (gridPos.aboveGrid, usedGridNumber);
                    usedGridNumber++;


                } else if (!usedGrids.ContainsKey (gridPos.belowGrid) && gridPos.belowGrid != null && roomPool.transform.Find(gridPos.belowGrid.name) == null) {
				if(gridPos.belowGrid != null){
					currentSpecialRoom3.transform.position = gridPos.belowGrid.transform.position;
					currentGrid3 = gridPos.belowGrid;
					usedGrids.Add (gridPos.belowGrid, usedGridNumber);
                        usedGridNumber++;
                    }
				} else  if (!usedGrids.ContainsKey (gridPos.rightGrid) && gridPos.rightGrid != null && roomPool.transform.Find(gridPos.rightGrid.name) == null) {
				if(gridPos.rightGrid != null){
					currentSpecialRoom3.transform.position = gridPos.rightGrid.transform.position;
					currentGrid3 = gridPos.rightGrid;
					usedGrids.Add (gridPos.rightGrid, usedGridNumber);
                        usedGridNumber++;
                    }
				}
				
				
			} else if (randomDirection == 4) {//right
				if (!usedGrids.ContainsKey (gridPos.rightGrid) && gridPos.rightGrid != null && roomPool.transform.Find(gridPos.rightGrid.name) == null) {
					if(gridPos.rightGrid != null){
					currentSpecialRoom3.transform.position = gridPos.rightGrid.transform.position;
					currentGrid3 = gridPos.rightGrid;
					usedGrids.Add (gridPos.rightGrid, usedGridNumber);
                        usedGridNumber++;
                    }
				} else  if (!usedGrids.ContainsKey (gridPos.aboveGrid) && gridPos.aboveGrid != null && roomPool.transform.Find(gridPos.aboveGrid.name) == null) {
					if(gridPos.aboveGrid != null){
					currentSpecialRoom3.transform.position = gridPos.aboveGrid.transform.position;
					currentGrid3 = gridPos.aboveGrid;
					usedGrids.Add (gridPos.aboveGrid, usedGridNumber);
                        usedGridNumber++;
                    }
				
				} else  if (!usedGrids.ContainsKey (gridPos.belowGrid) && gridPos.belowGrid != null && roomPool.transform.Find(gridPos.belowGrid.name) == null) {
					if(gridPos.belowGrid != null){
					currentSpecialRoom3.transform.position = gridPos.belowGrid.transform.position;
					currentGrid3 = gridPos.belowGrid;
					usedGrids.Add (gridPos.belowGrid, usedGridNumber);
                        usedGridNumber++;
                    }
				} else if (!usedGrids.ContainsKey (gridPos.leftGrid) && gridPos.leftGrid != null && roomPool.transform.Find(gridPos.leftGrid.name) == null) { 
					if(gridPos.leftGrid != null){
					currentSpecialRoom3.transform.position = gridPos.leftGrid.transform.position;
					currentGrid3 = gridPos.leftGrid;
					usedGrids.Add (gridPos.leftGrid, usedGridNumber);
                        usedGridNumber++;
                    }
					
				}
				
				
			}
			currentSpecialRoom3.name = currentGrid3.name;
            usedRooms.Add(currentSpecialRoom3, 1);
			NextRoom ();
		}
	}

	void SpecialRoom(int randomDirection){
		currentSpecialRoom1 = specialRooms [currentSpecialRoom];
		if (currentSpecialRoom > maxSpecialRooms) {
			NextRoom3 ();
		} else {
  
			currentSpecialRoom++;
		
			GridPos gridPos = currentGrid.GetComponent<GridPos> ();
			if (randomDirection == 1) {//up
				if (!usedGrids.ContainsKey (gridPos.aboveGrid) && gridPos.aboveGrid != null && roomPool.transform.Find(gridPos.aboveGrid.name) == null) {
					if(gridPos.aboveGrid != null){
					currentSpecialRoom1.transform.position = gridPos.aboveGrid.transform.position;
					currentGrid = gridPos.aboveGrid;
					usedGrids.Add (gridPos.aboveGrid, usedGridNumber);
                        usedGridNumber++;
                    }
				} else  if (!usedGrids.ContainsKey (gridPos.belowGrid) && gridPos.belowGrid != null && roomPool.transform.Find(gridPos.belowGrid.name) == null) {
					if(gridPos.belowGrid != null){
					currentSpecialRoom1.transform.position = gridPos.belowGrid.transform.position;
					currentGrid = gridPos.belowGrid;
					usedGrids.Add (gridPos.belowGrid, usedGridNumber);
                        usedGridNumber++;
                    }
				} else if (!usedGrids.ContainsKey (gridPos.leftGrid) && gridPos.leftGrid != null && roomPool.transform.Find(gridPos.leftGrid.name) == null) { 
					if(gridPos.leftGrid != null){
					currentSpecialRoom1.transform.position = gridPos.leftGrid.transform.position;
					currentGrid = gridPos.leftGrid;
					usedGrids.Add (gridPos.leftGrid, usedGridNumber);
                        usedGridNumber++;
                    }
				} else	if (!usedGrids.ContainsKey (gridPos.rightGrid) && gridPos.rightGrid != null && roomPool.transform.Find(gridPos.rightGrid.name) == null) {
					if(gridPos.rightGrid != null){
					currentSpecialRoom1.transform.position = gridPos.rightGrid.transform.position;
					currentGrid = gridPos.rightGrid;
					usedGrids.Add (gridPos.rightGrid, usedGridNumber);
                        usedGridNumber++;
                    }
				}
			
			
			} else if (randomDirection == 2) {//down
				if (!usedGrids.ContainsKey (gridPos.belowGrid) && gridPos.belowGrid != null && roomPool.transform.Find(gridPos.belowGrid.name) == null) {
					if(gridPos.belowGrid != null){
					currentSpecialRoom1.transform.position = gridPos.belowGrid.transform.position;
					currentGrid = gridPos.belowGrid;
					usedGrids.Add (gridPos.belowGrid, usedGridNumber);
                        usedGridNumber++;
                    }
				} else if (!usedGrids.ContainsKey (gridPos.aboveGrid) && gridPos.aboveGrid != null && roomPool.transform.Find(gridPos.aboveGrid.name) == null) {
					if(gridPos.aboveGrid != null){
					currentSpecialRoom1.transform.position = gridPos.aboveGrid.transform.position;
					currentGrid = gridPos.aboveGrid;
					usedGrids.Add (gridPos.aboveGrid, usedGridNumber);
                        usedGridNumber++;
                    }
				} else if (!usedGrids.ContainsKey (gridPos.leftGrid) && gridPos.leftGrid != null && roomPool.transform.Find(gridPos.leftGrid.name) == null) { 
					if(gridPos.leftGrid != null){
					currentSpecialRoom1.transform.position = gridPos.leftGrid.transform.position;
					currentGrid = gridPos.leftGrid;
					usedGrids.Add (gridPos.leftGrid, usedGridNumber);
                        usedGridNumber++;
                    }
				} else	if (!usedGrids.ContainsKey (gridPos.rightGrid) && gridPos.rightGrid != null && roomPool.transform.Find(gridPos.rightGrid.name) == null) {
					if(gridPos.rightGrid != null){
					currentSpecialRoom1.transform.position = gridPos.rightGrid.transform.position;
					currentGrid = gridPos.rightGrid;
					usedGrids.Add (gridPos.rightGrid, usedGridNumber);
                        usedGridNumber++;
                    }
				}
			
			
			} else if (randomDirection == 3) {//left
				if (!usedGrids.ContainsKey (gridPos.leftGrid) && gridPos.leftGrid != null && roomPool.transform.Find(gridPos.leftGrid.name) == null) { 
					if(gridPos.leftGrid != null){
					currentSpecialRoom1.transform.position = gridPos.leftGrid.transform.position;
					currentGrid = gridPos.leftGrid;
					usedGrids.Add (gridPos.leftGrid, usedGridNumber);
                        usedGridNumber++;
                    }
				
				} else if (!usedGrids.ContainsKey (gridPos.aboveGrid) && gridPos.aboveGrid != null && roomPool.transform.Find(gridPos.aboveGrid.name) == null) {
					if(gridPos.aboveGrid != null){
					currentSpecialRoom1.transform.position = gridPos.aboveGrid.transform.position;
					currentGrid = gridPos.aboveGrid;
					usedGrids.Add (gridPos.aboveGrid, usedGridNumber);
                        usedGridNumber++;
                    }
				} else if (!usedGrids.ContainsKey (gridPos.belowGrid) && gridPos.belowGrid != null && roomPool.transform.Find(gridPos.belowGrid.name) == null) {
					if(gridPos.belowGrid != null){
					currentSpecialRoom1.transform.position = gridPos.belowGrid.transform.position;
					currentGrid = gridPos.belowGrid;
					usedGrids.Add (gridPos.belowGrid, usedGridNumber);
                        usedGridNumber++;
                    }
				} else if (!usedGrids.ContainsKey (gridPos.rightGrid) && gridPos.rightGrid != null && roomPool.transform.Find(gridPos.rightGrid.name) == null) {
					if(gridPos.rightGrid != null){
					currentSpecialRoom1.transform.position = gridPos.rightGrid.transform.position;
					currentGrid = gridPos.rightGrid;
					usedGrids.Add (gridPos.rightGrid, usedGridNumber);
                        usedGridNumber++;
                    }
				}
			
			
			} else if (randomDirection == 4) {//right
				if (!usedGrids.ContainsKey (gridPos.rightGrid) && gridPos.rightGrid != null && roomPool.transform.Find(gridPos.rightGrid.name) == null) {
					if(gridPos.rightGrid != null){
					currentSpecialRoom1.transform.position = gridPos.rightGrid.transform.position;
					currentGrid = gridPos.rightGrid;
					usedGrids.Add (gridPos.rightGrid, usedGridNumber);
                        usedGridNumber++;
                    }
				} else if (!usedGrids.ContainsKey (gridPos.aboveGrid) && gridPos.aboveGrid != null && roomPool.transform.Find(gridPos.aboveGrid.name) == null) {
					if(gridPos.aboveGrid != null){
					currentSpecialRoom1.transform.position = gridPos.aboveGrid.transform.position;
					currentGrid = gridPos.aboveGrid;
					usedGrids.Add (gridPos.aboveGrid, usedGridNumber);
                        usedGridNumber++;
                    }
				} else  if (!usedGrids.ContainsKey (gridPos.belowGrid) && gridPos.belowGrid != null && roomPool.transform.Find(gridPos.belowGrid.name) == null) {
					if(gridPos.belowGrid != null){
					currentSpecialRoom1.transform.position = gridPos.belowGrid.transform.position;
					currentGrid = gridPos.belowGrid;
					usedGrids.Add (gridPos.belowGrid, usedGridNumber);
                        usedGridNumber++;
                    }
				} else if (!usedGrids.ContainsKey (gridPos.leftGrid) && gridPos.leftGrid != null && roomPool.transform.Find(gridPos.leftGrid.name) == null) { 
					if(gridPos.leftGrid != null){
					currentSpecialRoom1.transform.position = gridPos.leftGrid.transform.position;
					currentGrid = gridPos.leftGrid;
					usedGrids.Add (gridPos.leftGrid, usedGridNumber);
                        usedGridNumber++;
                    }
				
				}
			
			
			}
			currentSpecialRoom1.name = currentGrid.name;
            usedRooms.Add(currentSpecialRoom1, 1);
			NextRoom ();
		}
	}
	void NextRoom(){
		int randomDirection = Random.Range (1, 4);//1=left, 2=right, 3=up, 4=down
		int randomSplitAmount = 4;
		int max = maxRandomRooms + randomRooms.Length/4;
     
		if (currentRandomRooms == specialRoomFrequency && specialRoomFrequency < max ) {//&& isStartingRoom == false
            specialRoomFrequency = specialRoomFrequency + randomRooms.Length / 5;
			SpecialRoom (randomDirection);
		} else {
           // isStartingRoom = false;
			if (randomSplitAmount == 1) {
				RandomRoomChooser (randomDirection, randomSplitAmount);
			} else if (randomSplitAmount == 2) {
				RandomRoomChooser (randomDirection, randomSplitAmount);
				RandomRoomChooser2 (randomDirection, randomSplitAmount);
			} else if (randomSplitAmount == 3) {
              //  Debug.Log("Split");
                RandomRoomChooser (randomDirection, randomSplitAmount);
				RandomRoomChooser2 (randomDirection, randomSplitAmount);

				RandomRoomChooser3 (randomDirection, randomSplitAmount);
			} else if (randomSplitAmount == 4) {
               // Debug.Log("Split");
                RandomRoomChooser (randomDirection, randomSplitAmount);
				//RandomRoomChooser2 (randomDirection, randomSplitAmount);
				//RandomRoomChooser3 (randomDirection, randomSplitAmount);
				//RandomRoomChooser4 (randomDirection, randomSplitAmount);
			}


		}
       

    }
	void NextRoom2(){
		int randomDirection = Random.Range (1, 4);//1=left, 2=right, 3=up, 4=down
		int randomSplitAmount = 4;
		int max = maxRandomRooms + randomRooms.Length/4;
		if (currentRandomRooms == specialRoomFrequency && specialRoomFrequency < max) {
			specialRoomFrequency = specialRoomFrequency + randomRooms.Length / 5;
			SpecialRoom2 (randomDirection);
		} else {
			if (randomSplitAmount == 1) {
				RandomRoomChooser2 (randomDirection, randomSplitAmount);
			} else if (randomSplitAmount == 2) {
				RandomRoomChooser (randomDirection, randomSplitAmount);
				RandomRoomChooser2 (randomDirection, randomSplitAmount);
			} else if (randomSplitAmount == 3) {
              //  Debug.Log("Split");
                RandomRoomChooser (randomDirection, randomSplitAmount);
				RandomRoomChooser2 (randomDirection, randomSplitAmount);
			
				RandomRoomChooser3 (randomDirection, randomSplitAmount);
			} else if (randomSplitAmount == 4) {
             //   Debug.Log("Split");
                RandomRoomChooser2 (randomDirection, randomSplitAmount);
				//RandomRoomChooser (randomDirection, randomSplitAmount);
				//RandomRoomChooser4 (randomDirection, randomSplitAmount);
				//RandomRoomChooser3 (randomDirection, randomSplitAmount);
			}
		}
	}

	void NextRoom3(){
		int randomDirection = Random.Range (1, 4);//1=left, 2=right, 3=up, 4=down
		int randomSplitAmount = 4;
		int max = maxRandomRooms + randomRooms.Length/4;
		if (currentRandomRooms == specialRoomFrequency && specialRoomFrequency < max) {
			specialRoomFrequency = specialRoomFrequency + randomRooms.Length / 5;
			SpecialRoom3 (randomDirection);
		} else {
			if (randomSplitAmount == 1) {
				RandomRoomChooser3 (randomDirection, randomSplitAmount);
			} else if (randomSplitAmount == 2) {Debug.Log("Split");
				RandomRoomChooser3 (randomDirection, randomSplitAmount);
				RandomRoomChooser2 (randomDirection, randomSplitAmount);
			} else if (randomSplitAmount == 3) {
            //    Debug.Log("Split");
                RandomRoomChooser (randomDirection, randomSplitAmount);
				RandomRoomChooser2 (randomDirection, randomSplitAmount);
				RandomRoomChooser3 (randomDirection, randomSplitAmount);
			} else if (randomSplitAmount == 4) {
            //    Debug.Log("Split");
                RandomRoomChooser3 (randomDirection, randomSplitAmount);
				//RandomRoomChooser4 (randomDirection, randomSplitAmount);
				//RandomRoomChooser2 (randomDirection, randomSplitAmount);
				//RandomRoomChooser (randomDirection, randomSplitAmount);
			}
		}
	}

	void NextRoom4(){

        int randomDirection = Random.Range(1, 4);//1=left, 2=right, 3=up, 4=down
        int randomSplitAmount = 4;
        int max = maxRandomRooms + randomRooms.Length / 4;
        if (currentRandomRooms == specialRoomFrequency && specialRoomFrequency < max)
        {
            specialRoomFrequency = specialRoomFrequency + randomRooms.Length / 5;
            SpecialRoom(randomDirection);
        }
        else
        {
            if (randomSplitAmount == 1)
            {
                RandomRoomChooser4(randomDirection, randomSplitAmount);
            }
            else if (randomSplitAmount == 2)
            {
                RandomRoomChooser3(randomDirection, randomSplitAmount);
                RandomRoomChooser4(randomDirection, randomSplitAmount);
            }
            else if (randomSplitAmount == 3)
            {
                RandomRoomChooser4(randomDirection, randomSplitAmount);
                RandomRoomChooser2(randomDirection, randomSplitAmount);
                //  Debug.Log("Split");
                RandomRoomChooser3(randomDirection, randomSplitAmount);
            }
            else if (randomSplitAmount == 4)
            {
                //   Debug.Log("Split");
                RandomRoomChooser4(randomDirection, randomSplitAmount);
                //RandomRoomChooser3 (randomDirection, randomSplitAmount);
                //RandomRoomChooser (randomDirection, randomSplitAmount);
                //RandomRoomChooser2 (randomDirection, randomSplitAmount);
            }
        }
	}
    public GameObject roomPool;
    int usedGridNumber = 1;
	void RandomRoomChooser(int randomDirection, int randomSplitAmount){
        int max = maxRandomRooms + 1;
        if (max >= currentRandomRooms)
        {
            randomDirection = Random.Range(1, 4);//1=left, 2=right, 3=up, 4=down
            int randRoom = Random.Range(0, maxRandomRooms);
          //  if (isStartingRoom == false)
           // {
                currentRandomRoom = randomRooms[Random.Range(0, maxRandomRooms)];
            // }
            // else
            // {
            //    currentRandomRoom = startRoom;
            //   isStartingRoom = false;
            // }

            GridPos gridPos;
            if (usedRooms.ContainsKey(currentRandomRoom))
                {
                    RandomRoomChooser2(randomDirection, randomSplitAmount);
                }
                else
                {

                //   GridPos gridPos = currentGrid.GetComponent<GridPos>();
                int randomUsedGrid = Random.Range(0, usedGrids.Count);
                gridPos = currentGrid.GetComponent<GridPos>();
                if (isStart1 == false)
                {
                    foreach (KeyValuePair<GameObject, int> i in usedGrids)
                    {
                        if (i.Value == randomUsedGrid)
                        {
                            gridPos = i.Key.GetComponent<GridPos>();
                        }



                    }
                }
                else
                {
                    gridPos = currentGrid.GetComponent<GridPos>();
                    isStart1 = false;

                }
               
                    if (randomDirection == 1)//up
                    {
                        if (!usedGrids.ContainsKey(gridPos.aboveGrid) && gridPos.aboveGrid != null && roomPool.transform.Find(gridPos.aboveGrid.name) == null)
                        {
                            if (gridPos.aboveGrid != null )                                                                                                                                                               
                            {
                                currentRandomRoom.transform.position = gridPos.aboveGrid.transform.position;
                                currentGrid = gridPos.aboveGrid;
                                usedGrids.Add(gridPos.aboveGrid, usedGridNumber);
                                 usedGridNumber++;
                            }
                        }
                        else if (!usedGrids.ContainsKey(gridPos.belowGrid) && gridPos.belowGrid != null && roomPool.transform.Find(gridPos.belowGrid.name) == null)
                        {
                            if (gridPos.belowGrid != null)
                            {
                                currentRandomRoom.transform.position = gridPos.belowGrid.transform.position;
                                currentGrid = gridPos.belowGrid;
                                usedGrids.Add(gridPos.belowGrid, usedGridNumber);
                            usedGridNumber++;
                            }
                        }
                        else if (!usedGrids.ContainsKey(gridPos.leftGrid) && gridPos.leftGrid != null && roomPool.transform.Find(gridPos.leftGrid.name) == null)
                        {
                            if (gridPos.leftGrid != null)
                            {
                                currentRandomRoom.transform.position = gridPos.leftGrid.transform.position;
                                currentGrid = gridPos.leftGrid;
                                usedGrids.Add(gridPos.leftGrid, usedGridNumber);
                            usedGridNumber++;
                            }
                        }
                        else if (!usedGrids.ContainsKey(gridPos.rightGrid) && gridPos.rightGrid != null && roomPool.transform.Find(gridPos.rightGrid.name) == null)
                        {
                            if (gridPos.rightGrid != null)
                            {
                                currentRandomRoom.transform.position = gridPos.rightGrid.transform.position;
                                currentGrid = gridPos.rightGrid;
                                usedGrids.Add(gridPos.rightGrid, usedGridNumber);
                            usedGridNumber++;
                            }
                        }


                    }
                    else if (randomDirection == 2)//down
                    {
                        if (!usedGrids.ContainsKey(gridPos.belowGrid) && gridPos.belowGrid != null && roomPool.transform.Find(gridPos.belowGrid.name) == null)
                        {
                            if (gridPos.belowGrid != null)
                            {
                                currentRandomRoom.transform.position = gridPos.belowGrid.transform.position;
                                currentGrid = gridPos.belowGrid;
                                usedGrids.Add(gridPos.belowGrid, usedGridNumber);
                            usedGridNumber++;
                        }
                        }
                        else if (!usedGrids.ContainsKey(gridPos.aboveGrid) && gridPos.aboveGrid != null && roomPool.transform.Find(gridPos.aboveGrid.name) == null)
                        {
                            if (gridPos.aboveGrid != null)
                            {
                                currentRandomRoom.transform.position = gridPos.aboveGrid.transform.position;
                                currentGrid = gridPos.aboveGrid;
                                usedGrids.Add(gridPos.aboveGrid, usedGridNumber);
                            usedGridNumber++;
                        }
                        }
                        else if (!usedGrids.ContainsKey(gridPos.leftGrid) && gridPos.leftGrid != null && roomPool.transform.Find(gridPos.leftGrid.name) == null)
                        {
                            if (gridPos.leftGrid != null)
                            {
                                currentRandomRoom.transform.position = gridPos.leftGrid.transform.position;
                                currentGrid = gridPos.leftGrid;
                                usedGrids.Add(gridPos.leftGrid, usedGridNumber);
                            usedGridNumber++;
                            }
                        }
                        else if (!usedGrids.ContainsKey(gridPos.rightGrid) && gridPos.rightGrid != null && roomPool.transform.Find(gridPos.rightGrid.name) == null)
                        {
                            if (gridPos.rightGrid != null)
                            {
                                currentRandomRoom.transform.position = gridPos.rightGrid.transform.position;
                                currentGrid = gridPos.rightGrid;
                                usedGrids.Add(gridPos.rightGrid, usedGridNumber);
                            usedGridNumber++;
                        }
                        }


                    }
                    else if (randomDirection == 3)//left
                    {
                        if (!usedGrids.ContainsKey(gridPos.leftGrid) && gridPos.leftGrid != null && roomPool.transform.Find(gridPos.leftGrid.name) == null)
                        {
                            if (gridPos.leftGrid != null)
                            {
                                currentRandomRoom.transform.position = gridPos.leftGrid.transform.position;
                                currentGrid = gridPos.leftGrid;
                                usedGrids.Add(gridPos.leftGrid, usedGridNumber);
                            usedGridNumber++;
                        }

                        }
                        else if (!usedGrids.ContainsKey(gridPos.aboveGrid) && gridPos.aboveGrid != null && roomPool.transform.Find(gridPos.aboveGrid.name) == null)
                        {
                            if (gridPos.aboveGrid != null)
                            {
                                currentRandomRoom.transform.position = gridPos.aboveGrid.transform.position;
                                currentGrid = gridPos.aboveGrid;
                                usedGrids.Add(gridPos.aboveGrid, usedGridNumber);
                            usedGridNumber++;
                        }
                        }
                        else if (!usedGrids.ContainsKey(gridPos.belowGrid) && gridPos.belowGrid != null && roomPool.transform.Find(gridPos.belowGrid.name) == null)
                        {
                            if (gridPos.belowGrid != null)
                            {
                                currentRandomRoom.transform.position = gridPos.belowGrid.transform.position;
                                currentGrid = gridPos.belowGrid;
                                usedGrids.Add(gridPos.belowGrid, usedGridNumber);
                            usedGridNumber++;
                        }
                        }
                        else if (!usedGrids.ContainsKey(gridPos.rightGrid) && gridPos.rightGrid != null && roomPool.transform.Find(gridPos.rightGrid.name) == null)
                        {
                            if (gridPos.rightGrid != null)
                            {
                                currentRandomRoom.transform.position = gridPos.rightGrid.transform.position;
                                currentGrid = gridPos.rightGrid;
                                usedGrids.Add(gridPos.rightGrid, usedGridNumber);
                            usedGridNumber++;
                        }
                        }


                    }
                    else if (randomDirection == 4)//right
                    {
                        if (!usedGrids.ContainsKey(gridPos.rightGrid) && gridPos.rightGrid != null && roomPool.transform.Find(gridPos.rightGrid.name) == null)
                        {
                            if (gridPos.rightGrid != null)
                            {
                                currentRandomRoom.transform.position = gridPos.rightGrid.transform.position;
                                currentGrid = gridPos.rightGrid;
                                usedGrids.Add(gridPos.rightGrid, usedGridNumber);
                            usedGridNumber++;
                        }
                        }

                        else if (!usedGrids.ContainsKey(gridPos.aboveGrid) && gridPos.aboveGrid != null && roomPool.transform.Find(gridPos.aboveGrid.name) == null)
                        {
                            if (gridPos.aboveGrid != null)
                            {
                                currentRandomRoom.transform.position = gridPos.aboveGrid.transform.position;
                                currentGrid = gridPos.aboveGrid;
                                usedGrids.Add(gridPos.aboveGrid, usedGridNumber);
                            usedGridNumber++;
                        }
                        }
                        else if (!usedGrids.ContainsKey(gridPos.belowGrid) && gridPos.belowGrid != null && roomPool.transform.Find(gridPos.belowGrid.name) == null)
                        {
                            if (gridPos.belowGrid != null)
                            {
                                currentRandomRoom.transform.position = gridPos.belowGrid.transform.position;
                                currentGrid = gridPos.belowGrid;
                                usedGrids.Add(gridPos.belowGrid, usedGridNumber);
                            usedGridNumber++;
                        }
                        }
                        else if (!usedGrids.ContainsKey(gridPos.leftGrid) && gridPos.leftGrid != null && roomPool.transform.Find(gridPos.leftGrid.name) == null)
                        {
                            if (gridPos.leftGrid != null)
                            {
                                currentRandomRoom.transform.position = gridPos.leftGrid.transform.position;
                                currentGrid = gridPos.leftGrid;
                                usedGrids.Add(gridPos.leftGrid, usedGridNumber); usedGridNumber++;
                        }

                        }


                    }
                    currentRandomRoom.name = currentGrid.name;
                    usedRooms.Add(currentRandomRoom, 1);
                    currentRandomRooms++;

                    if (maxRandomRooms > currentRandomRooms)
                       NextRoom2();
                }
            }
        else
        {
            BossRoom();
        }
        
	}

	void RandomRoomChooser2(int randomDirection, int randomSplitAmount){
       
        int max = maxRandomRooms + 1;
        if (max >= currentRandomRooms) {

            randomDirection = Random.Range(1, 4);//1=left, 2=right, 3=up, 4=down
            int randRoom = Random.Range (0, maxRandomRooms);
           
                currentRandomRoom2 = randomRooms[Random.Range(0, maxRandomRooms)];
            
			if (usedRooms.ContainsKey (currentRandomRoom2)) {
				RandomRoomChooser3(randomDirection, randomSplitAmount);
      
			}
			else
			{
				GridPos gridPos = currentGrid2.GetComponent<GridPos>();
                int randomUsedGrid = Random.Range(0, usedGrids.Count);
                if (isStart2 == false) {
                    foreach (KeyValuePair<GameObject, int> i in usedGrids)
                    {
                        if (i.Value == randomUsedGrid)
                        {
                            gridPos = i.Key.GetComponent<GridPos>();
                        }



                    }}
                else
                {
                  
                    gridPos = currentGrid2.GetComponent<GridPos>();
                    isStart2 = false;
                }
                if (randomDirection == 1)//up
				{
					if (!usedGrids.ContainsKey (gridPos.aboveGrid) && gridPos.aboveGrid != null && roomPool.transform.Find(gridPos.aboveGrid.name) == null) {
						if(gridPos.aboveGrid != null){
						currentRandomRoom2.transform.position = gridPos.aboveGrid.transform.position;
						currentGrid2 = gridPos.aboveGrid;
						usedGrids.Add(gridPos.aboveGrid, usedGridNumber); usedGridNumber++;
                        }
					}
					else  if (!usedGrids.ContainsKey (gridPos.belowGrid) && gridPos.belowGrid != null && roomPool.transform.Find(gridPos.belowGrid.name) == null) {
						if(gridPos.belowGrid != null){
						currentRandomRoom2.transform.position = gridPos.belowGrid.transform.position;
						currentGrid2 = gridPos.belowGrid;
						usedGrids.Add(gridPos.belowGrid, usedGridNumber); usedGridNumber++;
                        }
					}
					else if (!usedGrids.ContainsKey (gridPos.leftGrid) && gridPos.leftGrid != null && roomPool.transform.Find(gridPos.leftGrid.name) == null) { 
						if(gridPos.leftGrid != null){
						currentRandomRoom2.transform.position = gridPos.leftGrid.transform.position;
						currentGrid2 = gridPos.leftGrid;
						usedGrids.Add(gridPos.leftGrid, usedGridNumber); usedGridNumber++;
                        }
					}
					else if (!usedGrids.ContainsKey (gridPos.rightGrid) && gridPos.rightGrid != null && roomPool.transform.Find(gridPos.rightGrid.name) == null) {
						if(gridPos.rightGrid != null){
						currentRandomRoom2.transform.position = gridPos.rightGrid.transform.position;
						currentGrid2 = gridPos.rightGrid;
						usedGrids.Add(gridPos.rightGrid, usedGridNumber); usedGridNumber++;
                        }
					}
					
					
				}
				else if(randomDirection == 2)//down
				{
                    if (!usedGrids.ContainsKey(gridPos.belowGrid) && gridPos.belowGrid != null && roomPool.transform.Find(gridPos.belowGrid.name) == null)
                    {
                        if (gridPos.belowGrid != null)
                        {
                            currentRandomRoom2.transform.position = gridPos.belowGrid.transform.position;
                            currentGrid2 = gridPos.belowGrid;
                            usedGrids.Add(gridPos.belowGrid, usedGridNumber); usedGridNumber++;
                        }
                    }
                    else if (!usedGrids.ContainsKey(gridPos.aboveGrid) && gridPos.aboveGrid != null && roomPool.transform.Find(gridPos.aboveGrid.name) == null)
                    {
                        if (gridPos.aboveGrid != null)
                        {
                            currentRandomRoom2.transform.position = gridPos.aboveGrid.transform.position;
                            currentGrid2 = gridPos.aboveGrid;
                            usedGrids.Add(gridPos.aboveGrid, usedGridNumber); usedGridNumber++;
                        }
                    }
                    else if (!usedGrids.ContainsKey(gridPos.leftGrid) && gridPos.leftGrid != null && roomPool.transform.Find(gridPos.leftGrid.name) == null)
                    {
                        if (gridPos.leftGrid != null)
                        {
                            currentRandomRoom2.transform.position = gridPos.leftGrid.transform.position;
                            currentGrid2 = gridPos.leftGrid;
                            usedGrids.Add(gridPos.leftGrid, usedGridNumber); usedGridNumber++;
                        }
                    }
                    else if (!usedGrids.ContainsKey(gridPos.rightGrid) && gridPos.rightGrid != null && roomPool.transform.Find(gridPos.rightGrid.name) == null)
                    {
                        if (gridPos.rightGrid != null)
                        {
                            currentRandomRoom2.transform.position = gridPos.rightGrid.transform.position;
                            currentGrid2 = gridPos.rightGrid;
                            usedGrids.Add(gridPos.rightGrid, usedGridNumber); usedGridNumber++;
                        }
                    }
					
					
				}
				else if(randomDirection == 3)//left
				{
					if (!usedGrids.ContainsKey (gridPos.leftGrid) && gridPos.leftGrid != null && roomPool.transform.Find(gridPos.leftGrid.name) == null) { 
						if(gridPos.leftGrid != null){
						currentRandomRoom2.transform.position = gridPos.leftGrid.transform.position;
						currentGrid2 = gridPos.leftGrid;
						usedGrids.Add(gridPos.leftGrid, usedGridNumber); usedGridNumber++;
                            }
						
					}
					else if (!usedGrids.ContainsKey (gridPos.aboveGrid) && gridPos.aboveGrid != null && roomPool.transform.Find(gridPos.aboveGrid.name) == null) {
						if(gridPos.aboveGrid != null){
						currentRandomRoom2.transform.position = gridPos.aboveGrid.transform.position;
						currentGrid2 = gridPos.aboveGrid;
						usedGrids.Add(gridPos.aboveGrid, usedGridNumber); usedGridNumber++;
                            }
					}
					else  if (!usedGrids.ContainsKey (gridPos.belowGrid) && gridPos.belowGrid != null && roomPool.transform.Find(gridPos.belowGrid.name) == null) {
						if(gridPos.belowGrid != null){
						currentRandomRoom2.transform.position = gridPos.belowGrid.transform.position;
						currentGrid2 = gridPos.belowGrid;
						usedGrids.Add(gridPos.belowGrid, usedGridNumber); usedGridNumber++;
                            }
					}
					else if (!usedGrids.ContainsKey (gridPos.rightGrid) && gridPos.rightGrid != null && roomPool.transform.Find(gridPos.rightGrid.name) == null) {
						if(gridPos.rightGrid != null){
						currentRandomRoom2.transform.position = gridPos.rightGrid.transform.position;
						currentGrid2 = gridPos.rightGrid;
						usedGrids.Add(gridPos.rightGrid, usedGridNumber); usedGridNumber++;
                            }
					}
					
					
				}
				else if(randomDirection == 4)//right
				{
					if (!usedGrids.ContainsKey (gridPos.rightGrid) && gridPos.rightGrid != null && roomPool.transform.Find(gridPos.rightGrid.name) == null) {
						if(gridPos.rightGrid != null){
						currentRandomRoom2.transform.position = gridPos.rightGrid.transform.position;
						currentGrid2 = gridPos.rightGrid;
						usedGrids.Add(gridPos.rightGrid, usedGridNumber); usedGridNumber++;
                            }
					}
					
					else if (!usedGrids.ContainsKey (gridPos.aboveGrid) && gridPos.aboveGrid != null && roomPool.transform.Find(gridPos.aboveGrid.name) == null) {
						if(gridPos.aboveGrid != null){
						currentRandomRoom2.transform.position = gridPos.aboveGrid.transform.position;
						currentGrid2 = gridPos.aboveGrid;
						usedGrids.Add(gridPos.aboveGrid, usedGridNumber); usedGridNumber++;
                            }
					}
					else  if (!usedGrids.ContainsKey (gridPos.belowGrid) && gridPos.belowGrid != null && roomPool.transform.Find(gridPos.belowGrid.name) == null) {
						if(gridPos.belowGrid != null){
						currentRandomRoom2.transform.position = gridPos.belowGrid.transform.position;
						currentGrid2 = gridPos.belowGrid;
						usedGrids.Add(gridPos.belowGrid, usedGridNumber); usedGridNumber++;
                            }
					}
					else 	if (!usedGrids.ContainsKey (gridPos.leftGrid) && gridPos.leftGrid != null && roomPool.transform.Find(gridPos.leftGrid.name) == null) { 
						if(gridPos.leftGrid != null){
						currentRandomRoom2.transform.position = gridPos.leftGrid.transform.position;
						currentGrid2 = gridPos.leftGrid;
						usedGrids.Add(gridPos.leftGrid, usedGridNumber); usedGridNumber++;
                            }
						
					}
					
					
				}
				currentRandomRoom2.name = currentGrid2.name;
				usedRooms.Add(currentRandomRoom2, 1);
				currentRandomRooms++;
				if(maxRandomRooms > currentRandomRooms)
                  NextRoom3();
            }
		}
        else
        {
            BossRoom();
        }
    }
	void RandomRoomChooser3(int randomDirection, int randomSplitAmount){
      
        int max = maxRandomRooms + 1;
        if (max >= currentRandomRooms) {
            randomDirection = Random.Range(1, 4);//1=left, 2=right, 3=up, 4=down
            int randRoom = Random.Range (0, maxRandomRooms);
          
                currentRandomRoom3 = randomRooms[Random.Range(0, maxRandomRooms)];
           
			if (usedRooms.ContainsKey (currentRandomRoom3)) {
				RandomRoomChooser4(randomDirection, randomSplitAmount);
			}
			else
			{
				GridPos gridPos = currentGrid3.GetComponent<GridPos>();
                int randomUsedGrid = Random.Range(0, usedGrids.Count);
                if (isStart3 == false)
                {
                    foreach (KeyValuePair<GameObject, int> i in usedGrids)
                    {
                        if (i.Value == randomUsedGrid)
                        {
                            gridPos = i.Key.GetComponent<GridPos>();
                        }



                    }
                }
                else
                {
                    gridPos = currentGrid3.GetComponent<GridPos>();
                    isStart3 = false;
                }
                if (randomDirection == 1)//up
				{
					if (!usedGrids.ContainsKey (gridPos.aboveGrid) && gridPos.aboveGrid != null && roomPool.transform.Find(gridPos.aboveGrid.name) == null) {
						if(gridPos.aboveGrid != null){
						currentRandomRoom3.transform.position = gridPos.aboveGrid.transform.position;
						currentGrid3 = gridPos.aboveGrid;
						usedGrids.Add(gridPos.aboveGrid, usedGridNumber); usedGridNumber++;
                        }
					}
					else  if (!usedGrids.ContainsKey (gridPos.belowGrid) && gridPos.belowGrid != null && roomPool.transform.Find(gridPos.belowGrid.name) == null) {
						if(gridPos.belowGrid != null){
						currentRandomRoom3.transform.position = gridPos.belowGrid.transform.position;
						currentGrid3 = gridPos.belowGrid;
						usedGrids.Add(gridPos.belowGrid, usedGridNumber); usedGridNumber++;
                        }
					}
					else if (!usedGrids.ContainsKey (gridPos.leftGrid) && gridPos.leftGrid != null && roomPool.transform.Find(gridPos.leftGrid.name) == null) { 
						if(gridPos.leftGrid != null){
						currentRandomRoom3.transform.position = gridPos.leftGrid.transform.position;
						currentGrid3 = gridPos.leftGrid;
						usedGrids.Add(gridPos.leftGrid, usedGridNumber); usedGridNumber++;
                        }
					}
					else if (!usedGrids.ContainsKey (gridPos.rightGrid) && gridPos.rightGrid != null && roomPool.transform.Find(gridPos.rightGrid.name) == null) {
						if(gridPos.rightGrid != null){
						currentRandomRoom3.transform.position = gridPos.rightGrid.transform.position;
						currentGrid3 = gridPos.rightGrid;
						usedGrids.Add(gridPos.rightGrid, usedGridNumber); usedGridNumber++;
                        }
					}
					
					
				}
				else if(randomDirection == 2)//down
				{
					if (!usedGrids.ContainsKey (gridPos.belowGrid) && gridPos.belowGrid != null && roomPool.transform.Find(gridPos.belowGrid.name) == null) {
						currentRandomRoom3.transform.position = gridPos.belowGrid.transform.position;
						currentGrid3 = gridPos.belowGrid;
						usedGrids.Add(gridPos.belowGrid, usedGridNumber); usedGridNumber++;
                    }
					else if (!usedGrids.ContainsKey (gridPos.aboveGrid) && gridPos.aboveGrid != null && roomPool.transform.Find(gridPos.aboveGrid.name) == null) {
						currentRandomRoom3.transform.position = gridPos.aboveGrid.transform.position;
						currentGrid3 = gridPos.aboveGrid;
						usedGrids.Add(gridPos.aboveGrid, usedGridNumber); usedGridNumber++;
                    }
					else if (!usedGrids.ContainsKey (gridPos.leftGrid) && gridPos.leftGrid != null && roomPool.transform.Find(gridPos.leftGrid.name) == null) { 
						currentRandomRoom3.transform.position = gridPos.leftGrid.transform.position;
						currentGrid3 = gridPos.leftGrid;
						usedGrids.Add(gridPos.leftGrid, usedGridNumber); usedGridNumber++;
                    }
					else if (!usedGrids.ContainsKey (gridPos.rightGrid) && gridPos.rightGrid != null && roomPool.transform.Find(gridPos.rightGrid.name) == null) {
						currentRandomRoom3.transform.position = gridPos.rightGrid.transform.position;
						currentGrid3 = gridPos.rightGrid;
						usedGrids.Add(gridPos.rightGrid, usedGridNumber); usedGridNumber++;
                    }
					
					
				}
				else if(randomDirection == 3)//left
				{
					if (!usedGrids.ContainsKey (gridPos.leftGrid) && gridPos.leftGrid != null && roomPool.transform.Find(gridPos.leftGrid.name) == null) { 
						currentRandomRoom3.transform.position = gridPos.leftGrid.transform.position;
						currentGrid3 = gridPos.leftGrid;
						usedGrids.Add(gridPos.leftGrid, usedGridNumber); usedGridNumber++;

                    }
					else if (!usedGrids.ContainsKey (gridPos.aboveGrid) && gridPos.aboveGrid != null && roomPool.transform.Find(gridPos.aboveGrid.name) == null) {
						currentRandomRoom3.transform.position = gridPos.aboveGrid.transform.position;
						currentGrid3 = gridPos.aboveGrid;
						usedGrids.Add(gridPos.aboveGrid, usedGridNumber); usedGridNumber++;
                    }
					else	if (!usedGrids.ContainsKey (gridPos.belowGrid) && gridPos.belowGrid != null && roomPool.transform.Find(gridPos.belowGrid.name) == null) {
						currentRandomRoom3.transform.position = gridPos.belowGrid.transform.position;
						currentGrid3 = gridPos.belowGrid;
						usedGrids.Add(gridPos.belowGrid, usedGridNumber); usedGridNumber++;
                    }
					else if (!usedGrids.ContainsKey (gridPos.rightGrid) && gridPos.rightGrid != null && roomPool.transform.Find(gridPos.rightGrid.name) == null) {
						currentRandomRoom3.transform.position = gridPos.rightGrid.transform.position;
						currentGrid3 = gridPos.rightGrid;
						usedGrids.Add(gridPos.rightGrid, usedGridNumber); usedGridNumber++;
                    }
					
					
				}
				else if(randomDirection == 4)//right
				{
					if (!usedGrids.ContainsKey (gridPos.rightGrid) && gridPos.rightGrid != null && roomPool.transform.Find(gridPos.rightGrid.name) == null) {
						currentRandomRoom3.transform.position = gridPos.rightGrid.transform.position;
						currentGrid3 = gridPos.rightGrid;
						usedGrids.Add(gridPos.rightGrid, usedGridNumber); usedGridNumber++;
                    }
					
					else if (!usedGrids.ContainsKey (gridPos.aboveGrid) && gridPos.aboveGrid != null && roomPool.transform.Find(gridPos.aboveGrid.name) == null) {
						currentRandomRoom3.transform.position = gridPos.aboveGrid.transform.position;
						currentGrid3 = gridPos.aboveGrid;
						usedGrids.Add(gridPos.aboveGrid, usedGridNumber); usedGridNumber++;
                    }
					else	if (!usedGrids.ContainsKey (gridPos.belowGrid) && gridPos.belowGrid != null && roomPool.transform.Find(gridPos.belowGrid.name) == null) {
						currentRandomRoom3.transform.position = gridPos.belowGrid.transform.position;
						currentGrid3 = gridPos.belowGrid;
						usedGrids.Add(gridPos.belowGrid, 1);
					}
					else if (!usedGrids.ContainsKey (gridPos.leftGrid) && gridPos.leftGrid != null && roomPool.transform.Find(gridPos.leftGrid.name) == null) { 
						currentRandomRoom3.transform.position = gridPos.leftGrid.transform.position;
						currentGrid3 = gridPos.leftGrid;
						usedGrids.Add(gridPos.leftGrid, usedGridNumber); usedGridNumber++;

                    }
					
					
				}
				currentRandomRoom3.name = currentGrid3.name;
				usedRooms.Add(currentRandomRoom3, 1);
				currentRandomRooms++;
				if(maxRandomRooms > currentRandomRooms)
                    NextRoom4();
            }
		}
        else
        {
            BossRoom();
        }
    }

	/// CALL SEPERARATE FROM START
	void RandomRoomChooser4(int randomDirection, int randomSplitAmount){
        
        int max = maxRandomRooms + 1;
        if (max >= currentRandomRooms) {
            randomDirection = Random.Range(1, 4);//1=left, 2=right, 3=up, 4=down
            int randRoom = Random.Range (0, maxRandomRooms);
           
                currentRandomRoom4 = randomRooms [Random.Range (0, maxRandomRooms)];
           
			if (usedRooms.ContainsKey (currentRandomRoom4)) {
				RandomRoomChooser(randomDirection, randomSplitAmount);
			}
			else
			{
				GridPos gridPos = currentGrid4.GetComponent<GridPos>();
                int randomUsedGrid = Random.Range(0, usedGrids.Count);
                if (isStart4 == false)
                {

                    

                    /*
                    foreach (KeyValuePair<GameObject, int> i in usedGrids)
                    {
                        if (i.Value == randomUsedGrid)
                        {
                            gridPos = i.Key.GetComponent<GridPos>();
                        }



                    }

                     */
                }
                else
                {
                    gridPos = currentGrid4.GetComponent<GridPos>();
                    isStart4 = false;
                }
                if (randomDirection == 1)//up
				{
					if (!usedGrids.ContainsKey (gridPos.aboveGrid) && gridPos.aboveGrid != null && roomPool.transform.Find(gridPos.aboveGrid.name) == null) {
						currentRandomRoom4.transform.position = gridPos.aboveGrid.transform.position;
						currentGrid4 = gridPos.aboveGrid;
						usedGrids.Add(gridPos.aboveGrid, usedGridNumber); usedGridNumber++;
                    }
					else if (!usedGrids.ContainsKey (gridPos.belowGrid) && gridPos.belowGrid != null && roomPool.transform.Find(gridPos.belowGrid.name) == null) {
						currentRandomRoom4.transform.position = gridPos.belowGrid.transform.position;
						currentGrid4 = gridPos.belowGrid;
						usedGrids.Add(gridPos.belowGrid, usedGridNumber); usedGridNumber++;
                    }
					else if (!usedGrids.ContainsKey (gridPos.leftGrid) && gridPos.leftGrid != null && roomPool.transform.Find(gridPos.leftGrid.name) == null) { 
						currentRandomRoom4.transform.position = gridPos.leftGrid.transform.position;
						currentGrid4 = gridPos.leftGrid;
						usedGrids.Add(gridPos.leftGrid, usedGridNumber); usedGridNumber++;
                    }
					else if (!usedGrids.ContainsKey (gridPos.rightGrid) && gridPos.rightGrid != null && roomPool.transform.Find(gridPos.rightGrid.name) == null) {
						currentRandomRoom4.transform.position = gridPos.rightGrid.transform.position;
						currentGrid4 = gridPos.rightGrid;
						usedGrids.Add(gridPos.rightGrid, usedGridNumber); usedGridNumber++;
                    }
					
					
				}
				else if(randomDirection == 2)//down
				{
					if (!usedGrids.ContainsKey (gridPos.belowGrid) && gridPos.belowGrid != null && roomPool.transform.Find(gridPos.belowGrid.name) == null) {
						currentRandomRoom4.transform.position = gridPos.belowGrid.transform.position;
						currentGrid4 = gridPos.belowGrid;
						usedGrids.Add(gridPos.belowGrid, usedGridNumber); usedGridNumber++;
                    }
					else if (!usedGrids.ContainsKey (gridPos.aboveGrid) && gridPos.aboveGrid != null && roomPool.transform.Find(gridPos.aboveGrid.name) == null) {
						currentRandomRoom4.transform.position = gridPos.aboveGrid.transform.position;
						currentGrid4 = gridPos.aboveGrid;
						usedGrids.Add(gridPos.aboveGrid, usedGridNumber); usedGridNumber++;
                    }
					else if (!usedGrids.ContainsKey (gridPos.leftGrid) && gridPos.leftGrid != null && roomPool.transform.Find(gridPos.leftGrid.name) == null) { 
						currentRandomRoom4.transform.position = gridPos.leftGrid.transform.position;
						currentGrid4 = gridPos.leftGrid;
						usedGrids.Add(gridPos.leftGrid, usedGridNumber); usedGridNumber++;
                    }
					else if (!usedGrids.ContainsKey (gridPos.rightGrid) && gridPos.rightGrid != null && roomPool.transform.Find(gridPos.rightGrid.name) == null) {
						currentRandomRoom4.transform.position = gridPos.rightGrid.transform.position;
						currentGrid4 = gridPos.rightGrid;
						usedGrids.Add(gridPos.rightGrid, usedGridNumber); usedGridNumber++;
                    }
					
					
				}
				else if(randomDirection == 3)//left
				{
					if (!usedGrids.ContainsKey (gridPos.leftGrid) && gridPos.leftGrid != null && roomPool.transform.Find(gridPos.leftGrid.name) == null) { 
						currentRandomRoom4.transform.position = gridPos.leftGrid.transform.position;
						currentGrid4 = gridPos.leftGrid;
						usedGrids.Add(gridPos.leftGrid, usedGridNumber); usedGridNumber++;

                    }
					else if (!usedGrids.ContainsKey (gridPos.aboveGrid) && gridPos.aboveGrid != null && roomPool.transform.Find(gridPos.aboveGrid.name) == null) {
						currentRandomRoom4.transform.position = gridPos.aboveGrid.transform.position;
						currentGrid4 = gridPos.aboveGrid;
						usedGrids.Add(gridPos.aboveGrid, usedGridNumber); usedGridNumber++;
                    }
					else if (!usedGrids.ContainsKey (gridPos.belowGrid) && gridPos.belowGrid != null && roomPool.transform.Find(gridPos.belowGrid.name) == null) {
						currentRandomRoom4.transform.position = gridPos.belowGrid.transform.position;
						currentGrid4 = gridPos.belowGrid;
						usedGrids.Add(gridPos.belowGrid, usedGridNumber); usedGridNumber++;
                    }
					else if (!usedGrids.ContainsKey (gridPos.rightGrid) && gridPos.rightGrid != null && roomPool.transform.Find(gridPos.rightGrid.name) == null) {
						currentRandomRoom4.transform.position = gridPos.rightGrid.transform.position;
						currentGrid4 = gridPos.rightGrid;
						usedGrids.Add(gridPos.rightGrid, usedGridNumber); usedGridNumber++;
                    }
					
					
				}
				else if(randomDirection == 4)//right
				{
					if (!usedGrids.ContainsKey (gridPos.rightGrid) && gridPos.rightGrid != null && roomPool.transform.Find(gridPos.rightGrid.name) == null) {
						currentRandomRoom4.transform.position = gridPos.rightGrid.transform.position;
						currentGrid4 = gridPos.rightGrid;
						usedGrids.Add(gridPos.rightGrid, usedGridNumber); usedGridNumber++;
                    }
					
					else if (!usedGrids.ContainsKey (gridPos.aboveGrid) && gridPos.aboveGrid != null && roomPool.transform.Find(gridPos.aboveGrid.name) == null) {
						currentRandomRoom4.transform.position = gridPos.aboveGrid.transform.position;
						currentGrid4 = gridPos.aboveGrid;
						usedGrids.Add(gridPos.aboveGrid, usedGridNumber); usedGridNumber++;
                    }
					else if (!usedGrids.ContainsKey (gridPos.belowGrid) && gridPos.belowGrid != null && roomPool.transform.Find(gridPos.belowGrid.name) == null) {
						currentRandomRoom4.transform.position = gridPos.belowGrid.transform.position;
						currentGrid4 = gridPos.belowGrid;
						usedGrids.Add(gridPos.belowGrid, usedGridNumber); usedGridNumber++;
                    }
					else if (!usedGrids.ContainsKey (gridPos.leftGrid) && gridPos.leftGrid != null && roomPool.transform.Find(gridPos.leftGrid.name) == null) { 
						currentRandomRoom4.transform.position = gridPos.leftGrid.transform.position;
						currentGrid4 = gridPos.leftGrid;
						usedGrids.Add(gridPos.leftGrid, usedGridNumber); usedGridNumber++;

                    }
					
					
				}
				currentRandomRoom4.name = currentGrid4.name;
				usedRooms.Add(currentRandomRoom4, 1);
				currentRandomRooms++;
				if(maxRandomRooms > currentRandomRooms)
                    NextRoom();

            }
		}
        else
        {
            BossRoom();
        }
    }
    public EnemyPlacement enemyPlacement;
    public bool hasReachedMax = false;
	// Update is called once per frame
	void Update () {
        if(hasReachedMax == false)
        {
            if(maxRandomRooms == currentRandomRooms)
            {
                BossRoom();
                foreach(CreateRoom c in enemyPlacement.createRoom)
                {
                    //c.spawnAreas[0].SpawnEnemies();
                }
                hasReachedMax = true;

            }
        }

	
	}
}
