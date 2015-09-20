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
	// Use this for initialization
	void Start () {

		usedGrids = new Dictionary<GameObject, int> ();
		usedRooms = new Dictionary<GameObject, int> ();
		maxRandomRooms = randomRooms.Length;
		specialRoomFrequency = randomRooms.Length / 5;
		int randGridNumber = Random.Range (1, gridWidth);
		if (randGridNumber == 1) {
			startingPoint = gridColumn1[Random.Range (2,gridHeight-2)];
		}
		if (randGridNumber == 2) {
			startingPoint = gridColumn2[Random.Range (2,gridHeight-2)];
		}
		if (randGridNumber == 3) {
			startingPoint = gridColumn3[Random.Range (2,gridHeight-2)];
		}
		if (randGridNumber == 4) {
			startingPoint = gridColumn4[Random.Range (2,gridHeight-2)];
		}
		if (randGridNumber == 5) {
			startingPoint = gridColumn5[Random.Range (2,gridHeight-2)];
		}
		if (randGridNumber == 6) {
			startingPoint = gridColumn6[Random.Range (2,gridHeight-2)];
		}
		if (randGridNumber == 7) {
			startingPoint = gridColumn7[Random.Range (2,gridHeight-2)];

		}
		if (randGridNumber == 8) {
			startingPoint = gridColumn8[Random.Range (2,gridHeight-2)];
		}
		if (randGridNumber == 9) {
			startingPoint = gridColumn9[Random.Range (2,gridHeight-2)];
		}
		if (randGridNumber == 10) {
			startingPoint = gridColumn10[Random.Range (2,gridHeight-2)];
		}
		if (randGridNumber == 11) {
			startingPoint = gridColumn11[Random.Range (2,gridHeight-2)];
		}
		if (randGridNumber == 12) {
			startingPoint = gridColumn12[Random.Range (2,gridHeight-2)];
		}
		if (randGridNumber == 13) {
			startingPoint = gridColumn13[Random.Range (2,gridHeight-2)];
		}
		if (randGridNumber == 14) {
			startingPoint = gridColumn14[Random.Range (2,gridHeight-2)];
		}
		if (randGridNumber == 15) {
			startingPoint = gridColumn15[Random.Range (2,gridHeight-2)];
		}
		if (randGridNumber == 16) {
			startingPoint = gridColumn16[Random.Range (2,gridHeight-2)];
		}
		startRoom.transform.position = startingPoint.transform.position;
		currentGrid = startingPoint;
		currentGrid2 = startingPoint;
		currentGrid3 = startingPoint;
		currentGrid4 = startingPoint;
		startRoom.name = currentGrid.name;
		NextRoom ();
		startingRoomOptions = startRoom.GetComponent<RoomOptions> ();
		playerToSpawn.transform.position = startingRoomOptions.upDoor.transform.position;
	}

	void SpecialRoom2(int randomDirection){

		if (currentSpecialRoom > maxSpecialRooms) {
			NextRoom2 ();
		} else {

			currentRandomRoom2 = specialRooms [currentSpecialRoom];
			currentSpecialRoom++;

			GridPos gridPos = currentGrid2.GetComponent<GridPos> ();
			if (randomDirection == 1) {//up
				if (!usedGrids.ContainsKey (gridPos.aboveGrid) && gridPos.aboveGrid != null) {

					currentRandomRoom2.transform.position = gridPos.aboveGrid.transform.position;

					currentGrid2 = gridPos.aboveGrid;

					usedGrids.Add (gridPos.aboveGrid, 1);

				} else if (!usedGrids.ContainsKey (gridPos.belowGrid) && gridPos.belowGrid != null) {
				
					currentRandomRoom2.transform.position = gridPos.belowGrid.transform.position;
					currentGrid2 = gridPos.belowGrid;
					usedGrids.Add (gridPos.belowGrid, 1);

				} else if (!usedGrids.ContainsKey (gridPos.leftGrid) && gridPos.leftGrid != null) {

					currentRandomRoom2.transform.position = gridPos.leftGrid.transform.position;
					currentGrid2 = gridPos.leftGrid;
					usedGrids.Add (gridPos.leftGrid, 1);
				
				} else if (!usedGrids.ContainsKey (gridPos.rightGrid) && gridPos.rightGrid != null) {

					currentRandomRoom2.transform.position = gridPos.rightGrid.transform.position;
					currentGrid2 = gridPos.rightGrid;
					usedGrids.Add (gridPos.rightGrid, 1);

				}
			
			
			} else if (randomDirection == 2) {//down
				if (!usedGrids.ContainsKey (gridPos.belowGrid) && gridPos.belowGrid != null) {

					currentRandomRoom2.transform.position = gridPos.belowGrid.transform.position;
					currentGrid2 = gridPos.belowGrid;
					usedGrids.Add (gridPos.belowGrid, 1);

				} else if (!usedGrids.ContainsKey (gridPos.aboveGrid) && gridPos.aboveGrid != null) {

					currentRandomRoom2.transform.position = gridPos.aboveGrid.transform.position;
					currentGrid2 = gridPos.aboveGrid;
					usedGrids.Add (gridPos.aboveGrid, 1);

				} else if (!usedGrids.ContainsKey (gridPos.leftGrid) && gridPos.leftGrid != null) {

					currentRandomRoom2.transform.position = gridPos.leftGrid.transform.position;
					currentGrid2 = gridPos.leftGrid;
					usedGrids.Add (gridPos.leftGrid, 1);

				} else if (!usedGrids.ContainsKey (gridPos.rightGrid) && gridPos.rightGrid != null) {

					currentRandomRoom2.transform.position = gridPos.rightGrid.transform.position;
					currentGrid2 = gridPos.rightGrid;
					usedGrids.Add (gridPos.rightGrid, 1);

				}
			
			
			} else if (randomDirection == 3) {//left
				if (!usedGrids.ContainsKey (gridPos.leftGrid) && gridPos.leftGrid != null) {

					currentRandomRoom2.transform.position = gridPos.leftGrid.transform.position;
					currentGrid2 = gridPos.leftGrid;
					usedGrids.Add (gridPos.leftGrid, 1);

				
				} else if (!usedGrids.ContainsKey (gridPos.aboveGrid) && gridPos.aboveGrid != null) {
					if(gridPos.aboveGrid != null){
					currentRandomRoom2.transform.position = gridPos.aboveGrid.transform.position;
					currentGrid2 = gridPos.aboveGrid;
					usedGrids.Add (gridPos.aboveGrid, 1);
					}
				} else if (!usedGrids.ContainsKey (gridPos.belowGrid) && gridPos.belowGrid != null) {
					if(gridPos.belowGrid != null){
					currentRandomRoom2.transform.position = gridPos.belowGrid.transform.position;
					currentGrid2 = gridPos.belowGrid;
					usedGrids.Add (gridPos.belowGrid, 1);
					}
				} else if (!usedGrids.ContainsKey (gridPos.rightGrid) && gridPos.rightGrid != null) {
					if(gridPos.rightGrid != null){
					currentRandomRoom2.transform.position = gridPos.rightGrid.transform.position;
					currentGrid2 = gridPos.rightGrid;
					usedGrids.Add (gridPos.rightGrid, 1);
					}
				}
			
			
			} else if (randomDirection == 4) {//right
				if (!usedGrids.ContainsKey (gridPos.rightGrid) && gridPos.rightGrid != null) {
					if(gridPos.rightGrid != null){
					currentRandomRoom2.transform.position = gridPos.rightGrid.transform.position;
					currentGrid2 = gridPos.rightGrid;
					usedGrids.Add (gridPos.rightGrid, 1);
					}
				} else  if (!usedGrids.ContainsKey (gridPos.aboveGrid) && gridPos.aboveGrid != null) {
					if(gridPos.aboveGrid != null){
					currentRandomRoom2.transform.position = gridPos.aboveGrid.transform.position;
					currentGrid2 = gridPos.aboveGrid;
					usedGrids.Add (gridPos.aboveGrid, 1);
					}
				} else if (!usedGrids.ContainsKey (gridPos.belowGrid) && gridPos.belowGrid != null) {
					if(gridPos.belowGrid != null){
					currentRandomRoom2.transform.position = gridPos.belowGrid.transform.position;
					currentGrid2 = gridPos.belowGrid;
					usedGrids.Add (gridPos.belowGrid, 1);
					}
				} else if (!usedGrids.ContainsKey (gridPos.leftGrid) && gridPos.leftGrid != null) {
					if(gridPos.leftGrid != null){
					currentRandomRoom2.transform.position = gridPos.leftGrid.transform.position;
					currentGrid2 = gridPos.leftGrid;
					usedGrids.Add (gridPos.leftGrid, 1);
					}
				
				}
			
			
			}
			currentRandomRoom2.name = currentGrid2.name;
			usedRooms.Add (currentRandomRoom2, 1);
			NextRoom ();
		}
	}

	void SpecialRoom3(int randomDirection){
		currentRandomRoom3 = specialRooms [currentSpecialRoom];
		if (currentSpecialRoom > maxSpecialRooms) {
			NextRoom3 ();
		} else {
			currentSpecialRoom++;
	
			GridPos gridPos = currentGrid3.GetComponent<GridPos> ();
			if (randomDirection == 1) {//up
				if (!usedGrids.ContainsKey (gridPos.aboveGrid) && gridPos.aboveGrid != null) {
					if(gridPos.aboveGrid != null){
					currentRandomRoom3.transform.position = gridPos.aboveGrid.transform.position;
					currentGrid3 = gridPos.aboveGrid;
					usedGrids.Add (gridPos.aboveGrid, 1);
					}
				} else  if (!usedGrids.ContainsKey (gridPos.belowGrid) && gridPos.belowGrid != null) {
					if(gridPos.belowGrid != null){
					currentRandomRoom3.transform.position = gridPos.belowGrid.transform.position;
					currentGrid3 = gridPos.belowGrid;
					usedGrids.Add (gridPos.belowGrid, 1);
					}
				} else if (!usedGrids.ContainsKey (gridPos.leftGrid) && gridPos.leftGrid != null) {
					if(gridPos.leftGrid != null){
					currentRandomRoom3.transform.position = gridPos.leftGrid.transform.position;
					currentGrid3 = gridPos.leftGrid;
					usedGrids.Add (gridPos.leftGrid, 1);
					}
				} else if (!usedGrids.ContainsKey (gridPos.rightGrid) && gridPos.rightGrid != null) {
					if(gridPos.rightGrid != null){
					currentRandomRoom3.transform.position = gridPos.rightGrid.transform.position;
					currentGrid3 = gridPos.rightGrid;
					usedGrids.Add (gridPos.rightGrid, 1);
					}
				}
				
				
			} else if (randomDirection == 2) {//down
				if (!usedGrids.ContainsKey (gridPos.belowGrid) && gridPos.belowGrid != null) {
					if(gridPos.belowGrid != null){
					currentRandomRoom3.transform.position = gridPos.belowGrid.transform.position;
					currentGrid3 = gridPos.belowGrid;
					usedGrids.Add (gridPos.belowGrid, 1);
					}
				} else if (!usedGrids.ContainsKey (gridPos.aboveGrid) && gridPos.aboveGrid != null) {
					if(gridPos.aboveGrid != null){
					currentRandomRoom3.transform.position = gridPos.aboveGrid.transform.position;
					currentGrid3 = gridPos.aboveGrid;
					usedGrids.Add (gridPos.aboveGrid, 1);
					}
				} else if (!usedGrids.ContainsKey (gridPos.leftGrid) && gridPos.leftGrid != null) {
					if(gridPos.leftGrid != null){
					currentRandomRoom3.transform.position = gridPos.leftGrid.transform.position;
					currentGrid3 = gridPos.leftGrid;
					usedGrids.Add (gridPos.leftGrid, 1);
					}
				} else if (!usedGrids.ContainsKey (gridPos.rightGrid) && gridPos.rightGrid != null) {
					if(gridPos.rightGrid != null){
					currentRandomRoom3.transform.position = gridPos.rightGrid.transform.position;
					currentGrid3 = gridPos.rightGrid;
					usedGrids.Add (gridPos.rightGrid, 1);
					}
				}
				
				
			} else if (randomDirection == 3) {//left
				if (!usedGrids.ContainsKey (gridPos.leftGrid) && gridPos.leftGrid != null) {
					if(gridPos.leftGrid != null){
					currentRandomRoom3.transform.position = gridPos.leftGrid.transform.position;
					currentGrid3 = gridPos.leftGrid;
					usedGrids.Add (gridPos.leftGrid, 1);
					}
				
					
				} else if (!usedGrids.ContainsKey (gridPos.aboveGrid) && gridPos.aboveGrid != null) {

					currentRandomRoom3.transform.position = gridPos.aboveGrid.transform.position;
					currentGrid3 = gridPos.aboveGrid;
					usedGrids.Add (gridPos.aboveGrid, 1);


				} else if (!usedGrids.ContainsKey (gridPos.belowGrid) && gridPos.belowGrid != null) {
				if(gridPos.belowGrid != null){
					currentRandomRoom3.transform.position = gridPos.belowGrid.transform.position;
					currentGrid3 = gridPos.belowGrid;
					usedGrids.Add (gridPos.belowGrid, 1);
				}
				} else  if (!usedGrids.ContainsKey (gridPos.rightGrid) && gridPos.rightGrid != null) {
				if(gridPos.rightGrid != null){
					currentRandomRoom3.transform.position = gridPos.rightGrid.transform.position;
					currentGrid3 = gridPos.rightGrid;
					usedGrids.Add (gridPos.rightGrid, 1);
				}
				}
				
				
			} else if (randomDirection == 4) {//right
				if (!usedGrids.ContainsKey (gridPos.rightGrid) && gridPos.rightGrid != null) {
					if(gridPos.rightGrid != null){
					currentRandomRoom3.transform.position = gridPos.rightGrid.transform.position;
					currentGrid3 = gridPos.rightGrid;
					usedGrids.Add (gridPos.rightGrid, 1);
					}
				} else  if (!usedGrids.ContainsKey (gridPos.aboveGrid) && gridPos.aboveGrid != null) {
					if(gridPos.aboveGrid != null){
					currentRandomRoom3.transform.position = gridPos.aboveGrid.transform.position;
					currentGrid3 = gridPos.aboveGrid;
					usedGrids.Add (gridPos.aboveGrid, 1);
					}
				
				} else  if (!usedGrids.ContainsKey (gridPos.belowGrid) && gridPos.belowGrid != null) {
					if(gridPos.belowGrid != null){
					currentRandomRoom3.transform.position = gridPos.belowGrid.transform.position;
					currentGrid3 = gridPos.belowGrid;
					usedGrids.Add (gridPos.belowGrid, 1);
					}
				} else if (!usedGrids.ContainsKey (gridPos.leftGrid) && gridPos.leftGrid != null) { 
					if(gridPos.leftGrid != null){
					currentRandomRoom3.transform.position = gridPos.leftGrid.transform.position;
					currentGrid3 = gridPos.leftGrid;
					usedGrids.Add (gridPos.leftGrid, 1);
					}
					
				}
				
				
			}
			currentRandomRoom3.name = currentGrid3.name;
			NextRoom ();
		}
	}

	void SpecialRoom(int randomDirection){
		currentRandomRoom = specialRooms [currentSpecialRoom];
		if (currentSpecialRoom > maxSpecialRooms) {
			NextRoom3 ();
		} else {

			currentSpecialRoom++;
		
			GridPos gridPos = currentGrid.GetComponent<GridPos> ();
			if (randomDirection == 1) {//up
				if (!usedGrids.ContainsKey (gridPos.aboveGrid) && gridPos.aboveGrid != null) {
					if(gridPos.aboveGrid != null){
					currentRandomRoom.transform.position = gridPos.aboveGrid.transform.position;
					currentGrid = gridPos.aboveGrid;
					usedGrids.Add (gridPos.aboveGrid, 1);
					}
				} else  if (!usedGrids.ContainsKey (gridPos.belowGrid) && gridPos.belowGrid != null) {
					if(gridPos.belowGrid != null){
					currentRandomRoom.transform.position = gridPos.belowGrid.transform.position;
					currentGrid = gridPos.belowGrid;
					usedGrids.Add (gridPos.belowGrid, 1);
					}
				} else if (!usedGrids.ContainsKey (gridPos.leftGrid) && gridPos.leftGrid != null) { 
					if(gridPos.leftGrid != null){
					currentRandomRoom.transform.position = gridPos.leftGrid.transform.position;
					currentGrid = gridPos.leftGrid;
					usedGrids.Add (gridPos.leftGrid, 1);
					}
				} else	if (!usedGrids.ContainsKey (gridPos.rightGrid) && gridPos.rightGrid != null) {
					if(gridPos.rightGrid != null){
					currentRandomRoom.transform.position = gridPos.rightGrid.transform.position;
					currentGrid = gridPos.rightGrid;
					usedGrids.Add (gridPos.rightGrid, 1);
					}
				}
			
			
			} else if (randomDirection == 2) {//down
				if (!usedGrids.ContainsKey (gridPos.belowGrid) && gridPos.belowGrid != null) {
					if(gridPos.belowGrid != null){
					currentRandomRoom.transform.position = gridPos.belowGrid.transform.position;
					currentGrid = gridPos.belowGrid;
					usedGrids.Add (gridPos.belowGrid, 1);
					}
				} else if (!usedGrids.ContainsKey (gridPos.aboveGrid) && gridPos.aboveGrid != null) {
					if(gridPos.aboveGrid != null){
					currentRandomRoom.transform.position = gridPos.aboveGrid.transform.position;
					currentGrid = gridPos.aboveGrid;
					usedGrids.Add (gridPos.aboveGrid, 1);
					}
				} else if (!usedGrids.ContainsKey (gridPos.leftGrid) && gridPos.leftGrid != null) { 
					if(gridPos.leftGrid != null){
					currentRandomRoom.transform.position = gridPos.leftGrid.transform.position;
					currentGrid = gridPos.leftGrid;
					usedGrids.Add (gridPos.leftGrid, 1);
					}
				} else	if (!usedGrids.ContainsKey (gridPos.rightGrid) && gridPos.rightGrid != null) {
					if(gridPos.rightGrid != null){
					currentRandomRoom.transform.position = gridPos.rightGrid.transform.position;
					currentGrid = gridPos.rightGrid;
					usedGrids.Add (gridPos.rightGrid, 1);
					}
				}
			
			
			} else if (randomDirection == 3) {//left
				if (!usedGrids.ContainsKey (gridPos.leftGrid) && gridPos.leftGrid != null) { 
					if(gridPos.leftGrid != null){
					currentRandomRoom.transform.position = gridPos.leftGrid.transform.position;
					currentGrid = gridPos.leftGrid;
					usedGrids.Add (gridPos.leftGrid, 1);
					}
				
				} else if (!usedGrids.ContainsKey (gridPos.aboveGrid) && gridPos.aboveGrid != null) {
					if(gridPos.aboveGrid != null){
					currentRandomRoom.transform.position = gridPos.aboveGrid.transform.position;
					currentGrid = gridPos.aboveGrid;
					usedGrids.Add (gridPos.aboveGrid, 1);
					}
				} else if (!usedGrids.ContainsKey (gridPos.belowGrid) && gridPos.belowGrid != null) {
					if(gridPos.belowGrid != null){
					currentRandomRoom.transform.position = gridPos.belowGrid.transform.position;
					currentGrid = gridPos.belowGrid;
					usedGrids.Add (gridPos.belowGrid, 1);
					}
				} else if (!usedGrids.ContainsKey (gridPos.rightGrid) && gridPos.rightGrid != null) {
					if(gridPos.rightGrid != null){
					currentRandomRoom.transform.position = gridPos.rightGrid.transform.position;
					currentGrid = gridPos.rightGrid;
					usedGrids.Add (gridPos.rightGrid, 1);
					}
				}
			
			
			} else if (randomDirection == 4) {//right
				if (!usedGrids.ContainsKey (gridPos.rightGrid) && gridPos.rightGrid != null) {
					if(gridPos.rightGrid != null){
					currentRandomRoom.transform.position = gridPos.rightGrid.transform.position;
					currentGrid = gridPos.rightGrid;
					usedGrids.Add (gridPos.rightGrid, 1);
					}
				} else if (!usedGrids.ContainsKey (gridPos.aboveGrid) && gridPos.aboveGrid != null) {
					if(gridPos.aboveGrid != null){
					currentRandomRoom.transform.position = gridPos.aboveGrid.transform.position;
					currentGrid = gridPos.aboveGrid;
					usedGrids.Add (gridPos.aboveGrid, 1);
					}
				} else  if (!usedGrids.ContainsKey (gridPos.belowGrid) && gridPos.belowGrid != null) {
					if(gridPos.belowGrid != null){
					currentRandomRoom.transform.position = gridPos.belowGrid.transform.position;
					currentGrid = gridPos.belowGrid;
					usedGrids.Add (gridPos.belowGrid, 1);
					}
				} else if (!usedGrids.ContainsKey (gridPos.leftGrid) && gridPos.leftGrid != null) { 
					if(gridPos.leftGrid != null){
					currentRandomRoom.transform.position = gridPos.leftGrid.transform.position;
					currentGrid = gridPos.leftGrid;
					usedGrids.Add (gridPos.leftGrid, 1);
					}
				
				}
			
			
			}
			currentRandomRoom.name = currentGrid.name;
			NextRoom ();
		}
	}
	void NextRoom(){
		int randomDirection = Random.Range (1, 4);//1=left, 2=right, 3=up, 4=down
		int randomSplitAmount = Random.Range (1, 3);
		int max = maxRandomRooms + randomRooms.Length/4;
		if (currentRandomRooms == specialRoomFrequency && specialRoomFrequency < max) {
			specialRoomFrequency = specialRoomFrequency + randomRooms.Length / 4;
			SpecialRoom (randomDirection);
		} else {
			if (randomSplitAmount == 1) {
				RandomRoomChooser (randomDirection, randomSplitAmount);
			} else if (randomSplitAmount == 2) {
				RandomRoomChooser (randomDirection, randomSplitAmount);
				RandomRoomChooser2 (randomDirection, randomSplitAmount);
			} else if (randomSplitAmount == 3) {
				RandomRoomChooser (randomDirection, randomSplitAmount);
				RandomRoomChooser2 (randomDirection, randomSplitAmount);

				RandomRoomChooser3 (randomDirection, randomSplitAmount);
			} else if (randomSplitAmount == 4) {
				RandomRoomChooser (randomDirection, randomSplitAmount);
				RandomRoomChooser2 (randomDirection, randomSplitAmount);
				RandomRoomChooser3 (randomDirection, randomSplitAmount);
				RandomRoomChooser4 (randomDirection, randomSplitAmount);
			}


		}	
	
	}
	void NextRoom2(){
		int randomDirection = Random.Range (1, 4);//1=left, 2=right, 3=up, 4=down
		int randomSplitAmount = Random.Range (1, 3);
		int max = maxRandomRooms + randomRooms.Length/4;
		if (currentRandomRooms == specialRoomFrequency && specialRoomFrequency < max) {
			specialRoomFrequency = specialRoomFrequency + randomRooms.Length / 4;
			SpecialRoom2 (randomDirection);
		} else {
			if (randomSplitAmount == 1) {
				RandomRoomChooser2 (randomDirection, randomSplitAmount);
			} else if (randomSplitAmount == 2) {
				RandomRoomChooser (randomDirection, randomSplitAmount);
				RandomRoomChooser2 (randomDirection, randomSplitAmount);
			} else if (randomSplitAmount == 3) {
				RandomRoomChooser (randomDirection, randomSplitAmount);
				RandomRoomChooser2 (randomDirection, randomSplitAmount);
			
				RandomRoomChooser3 (randomDirection, randomSplitAmount);
			} else if (randomSplitAmount == 4) {
				RandomRoomChooser (randomDirection, randomSplitAmount);
				RandomRoomChooser2 (randomDirection, randomSplitAmount);
				RandomRoomChooser3 (randomDirection, randomSplitAmount);
				RandomRoomChooser4 (randomDirection, randomSplitAmount);
			}
		}
	}

	void NextRoom3(){
		int randomDirection = Random.Range (1, 4);//1=left, 2=right, 3=up, 4=down
		int randomSplitAmount = Random.Range (1, 3);
		int max = maxRandomRooms + randomRooms.Length/4;
		if (currentRandomRooms == specialRoomFrequency && specialRoomFrequency < max) {
			specialRoomFrequency = specialRoomFrequency + randomRooms.Length / 4;
			SpecialRoom3 (randomDirection);
		} else {
			if (randomSplitAmount == 1) {
				RandomRoomChooser3 (randomDirection, randomSplitAmount);
			} else if (randomSplitAmount == 2) {
				RandomRoomChooser3 (randomDirection, randomSplitAmount);
				RandomRoomChooser2 (randomDirection, randomSplitAmount);
			} else if (randomSplitAmount == 3) {
				RandomRoomChooser (randomDirection, randomSplitAmount);
				RandomRoomChooser2 (randomDirection, randomSplitAmount);
			
				RandomRoomChooser3 (randomDirection, randomSplitAmount);
			} else if (randomSplitAmount == 4) {
				RandomRoomChooser (randomDirection, randomSplitAmount);
				RandomRoomChooser2 (randomDirection, randomSplitAmount);
				RandomRoomChooser3 (randomDirection, randomSplitAmount);
				RandomRoomChooser4 (randomDirection, randomSplitAmount);
			}
		}
	}

	void NextRoom4(){
		int randomDirection = Random.Range (1, 4);//1=left, 2=right, 3=up, 4=down
		int randomSplitAmount = Random.Range (1, 3);

			if (randomSplitAmount == 1) {
				RandomRoomChooser4 (randomDirection, randomSplitAmount);
			} else if (randomSplitAmount == 2) {
				RandomRoomChooser3 (randomDirection, randomSplitAmount);
				RandomRoomChooser4 (randomDirection, randomSplitAmount);
			} else if (randomSplitAmount == 3) {
				RandomRoomChooser4 (randomDirection, randomSplitAmount);
				RandomRoomChooser2 (randomDirection, randomSplitAmount);
			
				RandomRoomChooser3 (randomDirection, randomSplitAmount);
			} else if (randomSplitAmount == 4) {
				RandomRoomChooser (randomDirection, randomSplitAmount);
				RandomRoomChooser2 (randomDirection, randomSplitAmount);
				RandomRoomChooser3 (randomDirection, randomSplitAmount);
				RandomRoomChooser4 (randomDirection, randomSplitAmount);
			}

	}
	void RandomRoomChooser(int randomDirection, int randomSplitAmount){
		if (maxRandomRooms > currentRandomRooms) {
		
			int randRoom = Random.Range (0, maxRandomRooms);
			currentRandomRoom = randomRooms [Random.Range (0, maxRandomRooms)];
			if (usedRooms.ContainsKey (currentRandomRoom)) {
				RandomRoomChooser(randomDirection, randomSplitAmount);
				}
			else
			{
				GridPos gridPos = currentGrid.GetComponent<GridPos>();
				if(randomDirection == 1)//up
				{
					if (!usedGrids.ContainsKey (gridPos.aboveGrid) && gridPos.aboveGrid != null) {
						if(gridPos.aboveGrid != null){
						currentRandomRoom.transform.position = gridPos.aboveGrid.transform.position;
						currentGrid = gridPos.aboveGrid;
						usedGrids.Add(gridPos.aboveGrid, 1);
						}
					}
					else if (!usedGrids.ContainsKey (gridPos.belowGrid) && gridPos.belowGrid != null) {
						if(gridPos.belowGrid != null){
						currentRandomRoom.transform.position = gridPos.belowGrid.transform.position;
						currentGrid = gridPos.belowGrid;
						usedGrids.Add(gridPos.belowGrid, 1);
						}
					}
					else if (!usedGrids.ContainsKey (gridPos.leftGrid) && gridPos.leftGrid != null) { 
						if(gridPos.leftGrid != null){
						currentRandomRoom.transform.position = gridPos.leftGrid.transform.position;
						currentGrid = gridPos.leftGrid;
						usedGrids.Add(gridPos.leftGrid, 1);
						}
					}
					else if (!usedGrids.ContainsKey (gridPos.rightGrid) && gridPos.rightGrid != null) {
						if(gridPos.rightGrid != null){
						currentRandomRoom.transform.position = gridPos.rightGrid.transform.position;
						currentGrid = gridPos.rightGrid;
						usedGrids.Add(gridPos.rightGrid, 1);
					}
					}


				}
				else if(randomDirection == 2)//down
				{
					if (!usedGrids.ContainsKey (gridPos.belowGrid) && gridPos.belowGrid != null) {
						if(gridPos.belowGrid != null){
						currentRandomRoom.transform.position = gridPos.belowGrid.transform.position;
						currentGrid = gridPos.belowGrid;
						usedGrids.Add(gridPos.belowGrid, 1);
						}
					}
					else if (!usedGrids.ContainsKey (gridPos.aboveGrid) && gridPos.aboveGrid != null) {
						if(gridPos.aboveGrid != null){
						currentRandomRoom.transform.position = gridPos.aboveGrid.transform.position;
						currentGrid = gridPos.aboveGrid;
						usedGrids.Add(gridPos.aboveGrid, 1);
						}
					}
					else  if (!usedGrids.ContainsKey (gridPos.leftGrid) && gridPos.leftGrid != null) { 
						if(gridPos.leftGrid != null){
						currentRandomRoom.transform.position = gridPos.leftGrid.transform.position;
						currentGrid = gridPos.leftGrid;
						usedGrids.Add(gridPos.leftGrid, 1);
						}
					}
					else if (!usedGrids.ContainsKey (gridPos.rightGrid) && gridPos.rightGrid != null) {
						if(gridPos.rightGrid != null){
						currentRandomRoom.transform.position = gridPos.rightGrid.transform.position;
						currentGrid = gridPos.rightGrid;
						usedGrids.Add(gridPos.rightGrid, 1);
						}
					}
					
					
				}
				else if(randomDirection == 3)//left
				{
				if (!usedGrids.ContainsKey (gridPos.leftGrid) && gridPos.leftGrid != null) { 
						if(gridPos.leftGrid != null){
						currentRandomRoom.transform.position = gridPos.leftGrid.transform.position;
						currentGrid = gridPos.leftGrid;
						usedGrids.Add(gridPos.leftGrid, 1);
						}
				
					}
					else if (!usedGrids.ContainsKey (gridPos.aboveGrid) && gridPos.aboveGrid != null) {
						if(gridPos.aboveGrid != null){
						currentRandomRoom.transform.position = gridPos.aboveGrid.transform.position;
						currentGrid = gridPos.aboveGrid;
						usedGrids.Add(gridPos.aboveGrid, 1);
						}
					}
					else  if (!usedGrids.ContainsKey (gridPos.belowGrid) && gridPos.belowGrid != null) {
						if(gridPos.belowGrid != null){
						currentRandomRoom.transform.position = gridPos.belowGrid.transform.position;
						currentGrid = gridPos.belowGrid;
						usedGrids.Add(gridPos.belowGrid, 1);
						}
					}
					else if (!usedGrids.ContainsKey (gridPos.rightGrid) && gridPos.rightGrid != null) {
						if(gridPos.rightGrid != null){
						currentRandomRoom.transform.position = gridPos.rightGrid.transform.position;
						currentGrid = gridPos.rightGrid;
						usedGrids.Add(gridPos.rightGrid, 1);
						}
					}
					
					
				}
				else if(randomDirection == 4)//right
				{
					if (!usedGrids.ContainsKey (gridPos.rightGrid) && gridPos.rightGrid != null) {
						if(gridPos.rightGrid != null){
						currentRandomRoom.transform.position = gridPos.rightGrid.transform.position;
						currentGrid = gridPos.rightGrid;
						usedGrids.Add(gridPos.rightGrid, 1);
						}
					}

					else  if (!usedGrids.ContainsKey (gridPos.aboveGrid) && gridPos.aboveGrid != null) {
						if(gridPos.aboveGrid != null){
						currentRandomRoom.transform.position = gridPos.aboveGrid.transform.position;
						currentGrid = gridPos.aboveGrid;
						usedGrids.Add(gridPos.aboveGrid, 1);
						}
					}
					else  if (!usedGrids.ContainsKey (gridPos.belowGrid) && gridPos.belowGrid != null) {
						if(gridPos.belowGrid != null){
						currentRandomRoom.transform.position = gridPos.belowGrid.transform.position;
						currentGrid = gridPos.belowGrid;
						usedGrids.Add(gridPos.belowGrid, 1);
						}
					}
					else if (!usedGrids.ContainsKey (gridPos.leftGrid) && gridPos.leftGrid != null) { 
						if(gridPos.leftGrid != null){
						currentRandomRoom.transform.position = gridPos.leftGrid.transform.position;
						currentGrid = gridPos.leftGrid;
						usedGrids.Add(gridPos.leftGrid, 1);
						}
						
					}
					
					
				}
				currentRandomRoom.name = currentGrid.name;
				usedRooms.Add(currentRandomRoom, 1);
				currentRandomRooms++;
			
				if(maxRandomRooms > currentRandomRooms)
					NextRoom();
			}
		}
	}

	void RandomRoomChooser2(int randomDirection, int randomSplitAmount){
		if (maxRandomRooms > currentRandomRooms) {

		
			int randRoom = Random.Range (0, maxRandomRooms);
			currentRandomRoom2 = randomRooms [Random.Range (0, maxRandomRooms)];
			if (usedRooms.ContainsKey (currentRandomRoom2)) {
				RandomRoomChooser2(randomDirection, randomSplitAmount);
			}
			else
			{
				GridPos gridPos = currentGrid2.GetComponent<GridPos>();
				if(randomDirection == 1)//up
				{
					if (!usedGrids.ContainsKey (gridPos.aboveGrid) && gridPos.aboveGrid != null) {
						if(gridPos.aboveGrid != null){
						currentRandomRoom2.transform.position = gridPos.aboveGrid.transform.position;
						currentGrid2 = gridPos.aboveGrid;
						usedGrids.Add(gridPos.aboveGrid, 1);
						}
					}
					else  if (!usedGrids.ContainsKey (gridPos.belowGrid) && gridPos.belowGrid != null) {
						if(gridPos.belowGrid != null){
						currentRandomRoom2.transform.position = gridPos.belowGrid.transform.position;
						currentGrid2 = gridPos.belowGrid;
						usedGrids.Add(gridPos.belowGrid, 1);
						}
					}
					else if (!usedGrids.ContainsKey (gridPos.leftGrid) && gridPos.leftGrid != null) { 
						if(gridPos.leftGrid != null){
						currentRandomRoom2.transform.position = gridPos.leftGrid.transform.position;
						currentGrid2 = gridPos.leftGrid;
						usedGrids.Add(gridPos.leftGrid, 1);
						}
					}
					else if (!usedGrids.ContainsKey (gridPos.rightGrid) && gridPos.rightGrid != null) {
						if(gridPos.rightGrid != null){
						currentRandomRoom2.transform.position = gridPos.rightGrid.transform.position;
						currentGrid2 = gridPos.rightGrid;
						usedGrids.Add(gridPos.rightGrid, 1);
						}
					}
					
					
				}
				else if(randomDirection == 2)//down
				{
					if (!usedGrids.ContainsKey (gridPos.belowGrid) && gridPos.belowGrid != null) {
						if(gridPos.belowGrid != null){
						currentRandomRoom2.transform.position = gridPos.belowGrid.transform.position;
						currentGrid2 = gridPos.belowGrid;
						usedGrids.Add(gridPos.belowGrid, 1);
						}
					}
					else if (!usedGrids.ContainsKey (gridPos.aboveGrid) && gridPos.aboveGrid != null) {
						if(gridPos.aboveGrid != null){
						currentRandomRoom2.transform.position = gridPos.aboveGrid.transform.position;
						currentGrid2 = gridPos.aboveGrid;
						usedGrids.Add(gridPos.aboveGrid, 1);
						}
					}
					else if (!usedGrids.ContainsKey (gridPos.leftGrid) && gridPos.leftGrid != null) { 
						if(gridPos.leftGrid != null){
						currentRandomRoom2.transform.position = gridPos.leftGrid.transform.position;
						currentGrid2 = gridPos.leftGrid;
						usedGrids.Add(gridPos.leftGrid, 1);
						}
					}
					else if (!usedGrids.ContainsKey (gridPos.rightGrid) && gridPos.rightGrid != null) {
						if(gridPos.rightGrid != null){
						currentRandomRoom2.transform.position = gridPos.rightGrid.transform.position;
						currentGrid2 = gridPos.rightGrid;
						usedGrids.Add(gridPos.rightGrid, 1);
						}
					}
					
					
				}
				else if(randomDirection == 3)//left
				{
					if (!usedGrids.ContainsKey (gridPos.leftGrid) && gridPos.leftGrid != null) { 
						if(gridPos.leftGrid != null){
						currentRandomRoom2.transform.position = gridPos.leftGrid.transform.position;
						currentGrid2 = gridPos.leftGrid;
						usedGrids.Add(gridPos.leftGrid, 1);
						}
						
					}
					else if (!usedGrids.ContainsKey (gridPos.aboveGrid) && gridPos.aboveGrid != null) {
						if(gridPos.aboveGrid != null){
						currentRandomRoom2.transform.position = gridPos.aboveGrid.transform.position;
						currentGrid2 = gridPos.aboveGrid;
						usedGrids.Add(gridPos.aboveGrid, 1);
						}
					}
					else  if (!usedGrids.ContainsKey (gridPos.belowGrid) && gridPos.belowGrid != null) {
						if(gridPos.belowGrid != null){
						currentRandomRoom2.transform.position = gridPos.belowGrid.transform.position;
						currentGrid2 = gridPos.belowGrid;
						usedGrids.Add(gridPos.belowGrid, 1);
						}
					}
					else if (!usedGrids.ContainsKey (gridPos.rightGrid) && gridPos.rightGrid != null) {
						if(gridPos.rightGrid != null){
						currentRandomRoom2.transform.position = gridPos.rightGrid.transform.position;
						currentGrid2 = gridPos.rightGrid;
						usedGrids.Add(gridPos.rightGrid, 1);
						}
					}
					
					
				}
				else if(randomDirection == 4)//right
				{
					if (!usedGrids.ContainsKey (gridPos.rightGrid) && gridPos.rightGrid != null) {
						if(gridPos.rightGrid != null){
						currentRandomRoom2.transform.position = gridPos.rightGrid.transform.position;
						currentGrid2 = gridPos.rightGrid;
						usedGrids.Add(gridPos.rightGrid, 1);
						}
					}
					
					else if (!usedGrids.ContainsKey (gridPos.aboveGrid) && gridPos.aboveGrid != null) {
						if(gridPos.aboveGrid != null){
						currentRandomRoom2.transform.position = gridPos.aboveGrid.transform.position;
						currentGrid2 = gridPos.aboveGrid;
						usedGrids.Add(gridPos.aboveGrid, 1);
						}
					}
					else  if (!usedGrids.ContainsKey (gridPos.belowGrid) && gridPos.belowGrid != null) {
						if(gridPos.belowGrid != null){
						currentRandomRoom2.transform.position = gridPos.belowGrid.transform.position;
						currentGrid2 = gridPos.belowGrid;
						usedGrids.Add(gridPos.belowGrid, 1);
						}
					}
					else 	if (!usedGrids.ContainsKey (gridPos.leftGrid) && gridPos.leftGrid != null) { 
						if(gridPos.leftGrid != null){
						currentRandomRoom2.transform.position = gridPos.leftGrid.transform.position;
						currentGrid2 = gridPos.leftGrid;
						usedGrids.Add(gridPos.leftGrid, 1);
						}
						
					}
					
					
				}
				currentRandomRoom2.name = currentGrid2.name;
				usedRooms.Add(currentRandomRoom2, 1);
				currentRandomRooms++;
				if(maxRandomRooms > currentRandomRooms)
					NextRoom2();
			}
		}
	}
	void RandomRoomChooser3(int randomDirection, int randomSplitAmount){
		if (maxRandomRooms > currentRandomRooms) {

			int randRoom = Random.Range (0, maxRandomRooms);
			currentRandomRoom3 = randomRooms [Random.Range (0, maxRandomRooms)];
			if (usedRooms.ContainsKey (currentRandomRoom3)) {
				RandomRoomChooser3(randomDirection, randomSplitAmount);
			}
			else
			{
				GridPos gridPos = currentGrid3.GetComponent<GridPos>();
				if(randomDirection == 1)//up
				{
					if (!usedGrids.ContainsKey (gridPos.aboveGrid) && gridPos.aboveGrid != null) {
						if(gridPos.aboveGrid != null){
						currentRandomRoom3.transform.position = gridPos.aboveGrid.transform.position;
						currentGrid3 = gridPos.aboveGrid;
						usedGrids.Add(gridPos.aboveGrid, 1);
						}
					}
					else  if (!usedGrids.ContainsKey (gridPos.belowGrid) && gridPos.belowGrid != null) {
						if(gridPos.belowGrid != null){
						currentRandomRoom3.transform.position = gridPos.belowGrid.transform.position;
						currentGrid3 = gridPos.belowGrid;
						usedGrids.Add(gridPos.belowGrid, 1);
						}
					}
					else if (!usedGrids.ContainsKey (gridPos.leftGrid) && gridPos.leftGrid != null) { 
						if(gridPos.leftGrid != null){
						currentRandomRoom3.transform.position = gridPos.leftGrid.transform.position;
						currentGrid3 = gridPos.leftGrid;
						usedGrids.Add(gridPos.leftGrid, 1);
						}
					}
					else if (!usedGrids.ContainsKey (gridPos.rightGrid) && gridPos.rightGrid != null) {
						if(gridPos.rightGrid != null){
						currentRandomRoom3.transform.position = gridPos.rightGrid.transform.position;
						currentGrid3 = gridPos.rightGrid;
						usedGrids.Add(gridPos.rightGrid, 1);
						}
					}
					
					
				}
				else if(randomDirection == 2)//down
				{
					if (!usedGrids.ContainsKey (gridPos.belowGrid) && gridPos.belowGrid != null) {
						currentRandomRoom3.transform.position = gridPos.belowGrid.transform.position;
						currentGrid3 = gridPos.belowGrid;
						usedGrids.Add(gridPos.belowGrid, 1);
					}
					else if (!usedGrids.ContainsKey (gridPos.aboveGrid) && gridPos.aboveGrid != null) {
						currentRandomRoom3.transform.position = gridPos.aboveGrid.transform.position;
						currentGrid3 = gridPos.aboveGrid;
						usedGrids.Add(gridPos.aboveGrid, 1);
					}
					else if (!usedGrids.ContainsKey (gridPos.leftGrid) && gridPos.leftGrid != null) { 
						currentRandomRoom3.transform.position = gridPos.leftGrid.transform.position;
						currentGrid3 = gridPos.leftGrid;
						usedGrids.Add(gridPos.leftGrid, 1);
					}
					else if (!usedGrids.ContainsKey (gridPos.rightGrid) && gridPos.rightGrid != null) {
						currentRandomRoom3.transform.position = gridPos.rightGrid.transform.position;
						currentGrid3 = gridPos.rightGrid;
						usedGrids.Add(gridPos.rightGrid, 1);
					}
					
					
				}
				else if(randomDirection == 3)//left
				{
					if (!usedGrids.ContainsKey (gridPos.leftGrid) && gridPos.leftGrid != null) { 
						currentRandomRoom3.transform.position = gridPos.leftGrid.transform.position;
						currentGrid3 = gridPos.leftGrid;
						usedGrids.Add(gridPos.leftGrid, 1);
						
					}
					else if (!usedGrids.ContainsKey (gridPos.aboveGrid) && gridPos.aboveGrid != null) {
						currentRandomRoom3.transform.position = gridPos.aboveGrid.transform.position;
						currentGrid3 = gridPos.aboveGrid;
						usedGrids.Add(gridPos.aboveGrid, 1);
					}
					else	if (!usedGrids.ContainsKey (gridPos.belowGrid) && gridPos.belowGrid != null) {
						currentRandomRoom3.transform.position = gridPos.belowGrid.transform.position;
						currentGrid3 = gridPos.belowGrid;
						usedGrids.Add(gridPos.belowGrid, 1);
					}
					else if (!usedGrids.ContainsKey (gridPos.rightGrid) && gridPos.rightGrid != null) {
						currentRandomRoom3.transform.position = gridPos.rightGrid.transform.position;
						currentGrid3 = gridPos.rightGrid;
						usedGrids.Add(gridPos.rightGrid, 1);
					}
					
					
				}
				else if(randomDirection == 4)//right
				{
					if (!usedGrids.ContainsKey (gridPos.rightGrid) && gridPos.rightGrid != null) {
						currentRandomRoom3.transform.position = gridPos.rightGrid.transform.position;
						currentGrid3 = gridPos.rightGrid;
						usedGrids.Add(gridPos.rightGrid, 1);
					}
					
					else if (!usedGrids.ContainsKey (gridPos.aboveGrid) && gridPos.aboveGrid != null) {
						currentRandomRoom3.transform.position = gridPos.aboveGrid.transform.position;
						currentGrid3 = gridPos.aboveGrid;
						usedGrids.Add(gridPos.aboveGrid, 1);
					}
					else	if (!usedGrids.ContainsKey (gridPos.belowGrid) && gridPos.belowGrid != null) {
						currentRandomRoom3.transform.position = gridPos.belowGrid.transform.position;
						currentGrid3 = gridPos.belowGrid;
						usedGrids.Add(gridPos.belowGrid, 1);
					}
					else if (!usedGrids.ContainsKey (gridPos.leftGrid) && gridPos.leftGrid != null) { 
						currentRandomRoom3.transform.position = gridPos.leftGrid.transform.position;
						currentGrid3 = gridPos.leftGrid;
						usedGrids.Add(gridPos.leftGrid, 1);
						
					}
					
					
				}
				currentRandomRoom3.name = currentGrid3.name;
				usedRooms.Add(currentRandomRoom3, 1);
				currentRandomRooms++;
				if(maxRandomRooms > currentRandomRooms)
					NextRoom3();
			}
		}
	}

	/// CALL SEPERARATE FROM START
	void RandomRoomChooser4(int randomDirection, int randomSplitAmount){
		if (maxRandomRooms > currentRandomRooms) {

			int randRoom = Random.Range (0, maxRandomRooms);
			currentRandomRoom4 = randomRooms [Random.Range (0, maxRandomRooms)];
			if (usedRooms.ContainsKey (currentRandomRoom4)) {
				RandomRoomChooser4(randomDirection, randomSplitAmount);
			}
			else
			{
				GridPos gridPos = currentGrid4.GetComponent<GridPos>();
				if(randomDirection == 1)//up
				{
					if (!usedGrids.ContainsKey (gridPos.aboveGrid) && gridPos.aboveGrid != null) {
						currentRandomRoom4.transform.position = gridPos.aboveGrid.transform.position;
						currentGrid4 = gridPos.aboveGrid;
						usedGrids.Add(gridPos.aboveGrid, 1);
					}
					else if (!usedGrids.ContainsKey (gridPos.belowGrid) && gridPos.belowGrid != null) {
						currentRandomRoom4.transform.position = gridPos.belowGrid.transform.position;
						currentGrid4 = gridPos.belowGrid;
						usedGrids.Add(gridPos.belowGrid, 1);
					}
					else if (!usedGrids.ContainsKey (gridPos.leftGrid) && gridPos.leftGrid != null) { 
						currentRandomRoom4.transform.position = gridPos.leftGrid.transform.position;
						currentGrid4 = gridPos.leftGrid;
						usedGrids.Add(gridPos.leftGrid, 1);
					}
					else if (!usedGrids.ContainsKey (gridPos.rightGrid) && gridPos.rightGrid != null) {
						currentRandomRoom4.transform.position = gridPos.rightGrid.transform.position;
						currentGrid4 = gridPos.rightGrid;
						usedGrids.Add(gridPos.rightGrid, 1);
					}
					
					
				}
				else if(randomDirection == 2)//down
				{
					if (!usedGrids.ContainsKey (gridPos.belowGrid) && gridPos.belowGrid != null) {
						currentRandomRoom4.transform.position = gridPos.belowGrid.transform.position;
						currentGrid4 = gridPos.belowGrid;
						usedGrids.Add(gridPos.belowGrid, 1);
					}
					else if (!usedGrids.ContainsKey (gridPos.aboveGrid) && gridPos.aboveGrid != null) {
						currentRandomRoom4.transform.position = gridPos.aboveGrid.transform.position;
						currentGrid4 = gridPos.aboveGrid;
						usedGrids.Add(gridPos.aboveGrid, 1);
					}
					else if (!usedGrids.ContainsKey (gridPos.leftGrid) && gridPos.leftGrid != null) { 
						currentRandomRoom4.transform.position = gridPos.leftGrid.transform.position;
						currentGrid4 = gridPos.leftGrid;
						usedGrids.Add(gridPos.leftGrid, 1);
					}
					else if (!usedGrids.ContainsKey (gridPos.rightGrid) && gridPos.rightGrid != null) {
						currentRandomRoom4.transform.position = gridPos.rightGrid.transform.position;
						currentGrid4 = gridPos.rightGrid;
						usedGrids.Add(gridPos.rightGrid, 1);
					}
					
					
				}
				else if(randomDirection == 3)//left
				{
					if (!usedGrids.ContainsKey (gridPos.leftGrid) && gridPos.leftGrid != null) { 
						currentRandomRoom4.transform.position = gridPos.leftGrid.transform.position;
						currentGrid4 = gridPos.leftGrid;
						usedGrids.Add(gridPos.leftGrid, 1);
						
					}
					else if (!usedGrids.ContainsKey (gridPos.aboveGrid) && gridPos.aboveGrid != null) {
						currentRandomRoom4.transform.position = gridPos.aboveGrid.transform.position;
						currentGrid4 = gridPos.aboveGrid;
						usedGrids.Add(gridPos.aboveGrid, 1);
					}
					else if (!usedGrids.ContainsKey (gridPos.belowGrid) && gridPos.belowGrid != null) {
						currentRandomRoom4.transform.position = gridPos.belowGrid.transform.position;
						currentGrid4 = gridPos.belowGrid;
						usedGrids.Add(gridPos.belowGrid, 1);
					}
					else if (!usedGrids.ContainsKey (gridPos.rightGrid) && gridPos.rightGrid != null) {
						currentRandomRoom4.transform.position = gridPos.rightGrid.transform.position;
						currentGrid4 = gridPos.rightGrid;
						usedGrids.Add(gridPos.rightGrid, 1);
					}
					
					
				}
				else if(randomDirection == 4)//right
				{
					if (!usedGrids.ContainsKey (gridPos.rightGrid) && gridPos.rightGrid != null) {
						currentRandomRoom4.transform.position = gridPos.rightGrid.transform.position;
						currentGrid4 = gridPos.rightGrid;
						usedGrids.Add(gridPos.rightGrid, 1);
					}
					
					else if (!usedGrids.ContainsKey (gridPos.aboveGrid) && gridPos.aboveGrid != null) {
						currentRandomRoom4.transform.position = gridPos.aboveGrid.transform.position;
						currentGrid4 = gridPos.aboveGrid;
						usedGrids.Add(gridPos.aboveGrid, 1);
					}
					else if (!usedGrids.ContainsKey (gridPos.belowGrid) && gridPos.belowGrid != null) {
						currentRandomRoom4.transform.position = gridPos.belowGrid.transform.position;
						currentGrid4 = gridPos.belowGrid;
						usedGrids.Add(gridPos.belowGrid, 1);
					}
					else if (!usedGrids.ContainsKey (gridPos.leftGrid) && gridPos.leftGrid != null) { 
						currentRandomRoom4.transform.position = gridPos.leftGrid.transform.position;
						currentGrid4 = gridPos.leftGrid;
						usedGrids.Add(gridPos.leftGrid, 1);
						
					}
					
					
				}
				currentRandomRoom4.name = currentGrid4.name;
				usedRooms.Add(currentRandomRoom4, 1);
				currentRandomRooms++;
				if(maxRandomRooms > currentRandomRooms)
					NextRoom4();
				
			}
		}
	}
	// Update is called once per frame
	void Update () {


	
	}
}
