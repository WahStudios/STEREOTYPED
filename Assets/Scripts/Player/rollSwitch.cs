using UnityEngine;
using System.Collections;

public class rollSwitch : MonoBehaviour {
	public PlayerMovement player;
	public bool roll = true;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if(roll == false){
			if(player.roll == true){
				player.roll = false;
				roll = true;
			}
		}
		//else{
		//	if(player.roll == false)
		//		player.roll = true;
		//}
	}
}
