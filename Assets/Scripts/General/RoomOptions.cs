using UnityEngine;
using System.Collections;

public class RoomOptions : MonoBehaviour {

	public GameObject upDoor;
	public GameObject downDoor;
	public GameObject leftDoor;
	public GameObject rightDoor;
	public GameObject upDoorExit;
	public GameObject downDoorExit;
	public GameObject leftDoorExit;
	public GameObject rightDoorExit;
	public GameObject upRoom;
	public GameObject downRoom;
	public GameObject leftRoom;
	public GameObject rightRoom;
	public Door leftDoorScript;
	public Door rightDoorScript;
	public Door upDoorScript;
	public Door downDoorScript;
	public GameObject thisGrid;
	public GridPos gridPos;
	public RoomOptions upRoomOptions;
	public RoomOptions downRoomOptions;
	public RoomOptions leftRoomOptions;
	public RoomOptions rightRoomOptions;
	public GameObject playerParent;



	// Use this for initialization
	void Start () {
		thisGrid = GameObject.Find ("Grid/" + gameObject.name);
		gridPos = thisGrid.GetComponent<GridPos> ();
		if(GameObject.Find ("RoomPool/" + gridPos.aboveGrid.name) != null)
		upRoom = GameObject.Find ("RoomPool/" + gridPos.aboveGrid.name);
		if(GameObject.Find ("RoomPool/" + gridPos.belowGrid.name) != null)
		downRoom =  GameObject.Find ("RoomPool/" + gridPos.belowGrid.name);
		if(GameObject.Find ("RoomPool/" + gridPos.leftGrid.name) != null)
		leftRoom = GameObject.Find ("RoomPool/" + gridPos.leftGrid.name);
		if(GameObject.Find ("RoomPool/" + gridPos.rightGrid.name) != null)
		rightRoom =  GameObject.Find ("RoomPool/" + gridPos.rightGrid.name);
		if (upRoom != null) {
			upRoomOptions = upRoom.GetComponent<RoomOptions> ();
			upDoorExit = upRoomOptions.downDoor;
			upDoorScript = upDoor.AddComponent<Door> ();
		} else {
			upDoor.gameObject.SetActive(false);
		}
		if (downRoom != null) {
			downRoomOptions = downRoom.GetComponent<RoomOptions> ();
			downDoorExit = downRoomOptions.upDoor;
			downDoorScript = downDoor.AddComponent<Door>();
		}
	 else {
		downDoor.gameObject.SetActive(false);
	}
		if (leftRoom != null) {
			leftRoomOptions = leftRoom.GetComponent<RoomOptions> ();
			leftDoorExit = leftRoomOptions.rightDoor;
			leftDoorScript = leftDoor.AddComponent<Door>();
			 
		}
		else {
			leftDoor.gameObject.SetActive(false);
		}
		if (rightRoom != null) {
			rightRoomOptions = rightRoom.GetComponent<RoomOptions> ();
			rightDoorExit = rightRoomOptions.leftDoor;
			rightDoorScript = rightDoor.AddComponent<Door>();
		}
		else {
			rightDoor.gameObject.SetActive(false);
		}


	
		playerParent = GameObject.Find ("PlayerParent");



	}
	public bool invokeDelay = false;
	void Delay(){
		delay = false;
		invokeDelay = false;
	}
	static public float decay = 1.5f;
	static public bool delay = false;
	// Update is called once per frame
	void Update () {
		if (delay == false) {
		if (leftDoorScript != null && leftDoorScript.isInDoorway == true) {
				if (Input.GetAxis ("Vertical") > 0.2f) {
					playerParent.transform.position = leftDoorExit.transform.position;
					delay = true;
				}

		}
		if (rightDoorScript != null && rightDoorScript.isInDoorway == true) {
			if(Input.GetAxis("Vertical") > 0.2f)
			{
				playerParent.transform.position = rightDoorExit.transform.position;		
					delay = true;
			}
		}
		if (upDoorScript != null && upDoorScript.isInDoorway == true) {
			if(Input.GetAxis("Vertical") > 0.2f)
			{
				playerParent.transform.position = upDoorExit.transform.position;		
					delay = true;
			}
		}
		if (downDoorScript != null && downDoorScript.isInDoorway == true) {
			if(Input.GetAxis("Vertical") > 0.2f)
			{
				playerParent.transform.position = downDoorExit.transform.position;	
					delay = true;
			}
		}
	}
			else{
				if(invokeDelay == false)
				{
					Invoke("Delay", decay);
					invokeDelay = true;
				}
			}

}
}
