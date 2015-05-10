using UnityEngine;
using System.Collections;

public class GunShotMovement : MonoBehaviour {
	public bool isActive = false;
	public bool isLeftActive = false;
	public Vector3 startingPos;
	public Quaternion startingRot;
	public GunShoot ObjectPool;
	public SpriteRenderer thisSprite;
	Transform parentTransform;
	public bool setLeft = false;
	public Vector2 forceVector;
	public Vector2 forceVectorHighThrow;
	public Vector2 forceVectorLeft;
	public Vector2 forceVectorHighThrowLeft;
	bool forceAdded = false;
	bool facingLeft = false;
	//public GameObject leftFacingRotate;
	//public ObjectPool objectPool;
	// Use this for initialization
	void Start () {
		//transform.parent = null;
		Rigidbody2D rigid  = gameObject.GetComponent<Rigidbody2D>();
		rigid.isKinematic = true;
		parentTransform = transform.parent;
		startingPos = transform.position;
		startingRot = transform.rotation;
		thisSprite = gameObject.GetComponent<SpriteRenderer>();
		thisSprite.enabled = false;

	}
	
	public void FireRight(){
		Debug.Log ("FireRight");
		facingLeft = true;
		isLeftActive = false;
		forceAdded = true;
		ResetGrenade();
		//isActive = true;
	}
	
	public void FireLeft(){
		facingLeft = false;
		isLeftActive = false;
		Debug.Log ("FireLeft");
		forceAdded = true;
		ResetGrenade();
	}
	// Update is called once per frame
	void Update () {
		/*
		if(isActive == true)
		{
			if(thisSprite.enabled == false)
				thisSprite.enabled = true;
			if(setLeft == false){
				//transform.parent = parentTransform ;
				transform.rotation = startingRot;
				setLeft = true;
			}

			transform.Translate (Vector2.right * ObjectPool.gunShotRate);
			//transform.parent = null;
			
		}
		*/
		if(isLeftActive == true)

		{

			if(thisSprite.enabled == false)
			thisSprite.enabled = true;
			if(ObjectPool.isGrenade == false){
			if(setLeft == false){
				//transform.parent = parentTransform ;
				transform.rotation = ObjectPool.facingLeft.transform.rotation;
				setLeft = true;
			}

			transform.Translate (Vector2.right *  ObjectPool.gunShotSpeed);
			//transform.parent = null;
		
		


		
		if(gameObject.transform.position.x < (startingPos.x - ObjectPool.gunShotDistance) || gameObject.transform.position.x > (startingPos.x + ObjectPool.gunShotDistance))
		{
			ResetObject ();
		}
			}

			else{//grenade logic
				if(forceAdded == true && isLeftActive == true){
				transform.parent = null;
				Rigidbody2D rigid  = gameObject.GetComponent<Rigidbody2D>();
				rigid.isKinematic = false;

				if(facingLeft == false){
				if(ObjectPool.playerMovement.randomMoveNumber == 1)
				rigid.AddForce(forceVector);
				else
						rigid.AddForce(forceVectorHighThrow);
					forceAdded = false;
			}
			else
					{
						if(ObjectPool.playerMovement.randomMoveNumber == 1)
							rigid.AddForce(forceVectorLeft);
						else
							rigid.AddForce(forceVectorHighThrowLeft);
						forceAdded = false;
					}
				}

			}

		
	}
	}
	public void ResetGrenade(){
		Rigidbody2D rigid  = gameObject.GetComponent<Rigidbody2D>();
		rigid.isKinematic = true;
		isLeftActive = true;
		transform.parent = parentTransform;
		transform.position = startingPos;
		transform.rotation = startingRot;
	}
	public void ResetObject(){
	//	transform.parent = parentTransform ;
		setLeft = false;
		isActive = false;
		isLeftActive = false;
		transform.position = startingPos;
		transform.rotation = startingRot;
		transform.Translate (Vector2.right * 0);
		if(thisSprite.enabled == true)
			thisSprite.enabled = false;
	}
}