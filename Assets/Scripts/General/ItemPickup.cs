using UnityEngine;
using System.Collections;

public class ItemPickup : MonoBehaviour {
	public Inventory inventory;
	private bool axisInUse = false;
	//public Collider triggerCollider;
	// Use this for initialization
	void Start () {
	
	}
	
	void OnTriggerStay2D(Collider2D other)
	{

		if(other.gameObject.tag == "Item")
		{
			if(Input.GetAxis ("Vertical") > 0){
				if(axisInUse == false){
				Destroy (other.gameObject);
			inventory.addItemOnClick (other.gameObject.name);
					axisInUse = true;
				}
			}
			if(Input.GetAxis ("Vertical") == 0){
				axisInUse = false;
			}
		}
	}
}
			 