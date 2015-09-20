using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {
	public BoxCollider2D boxCollider;
	public bool isInDoorway = false;

	// Use this for initialization
	void Awake(){
		boxCollider = gameObject.AddComponent<BoxCollider2D> ();
	}
	void Start () {

		boxCollider.collider2D.isTrigger = true;
		Vector2 boxSize = boxCollider.size;
		Vector2 boxCenter = boxCollider.center;
		boxSize.x = 2;
		boxSize.y = 4.6f;
		boxCenter.y = 2.2f;
		boxCollider.center = boxCenter;
		boxCollider.size = boxSize;


	}
	
	// Update is called once per frame
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Player") {
			isInDoorway = true;

		}
	}
	void OnTriggerExit2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player") {
			isInDoorway = false;

		}
	}
}
