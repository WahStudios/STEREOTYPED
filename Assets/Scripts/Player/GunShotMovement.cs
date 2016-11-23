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
	bool isParented = true;
	public GameObject explosionFX;
	public Animator explosionAnim;
    public Vector2 startingPosition;
    
	//public GameObject leftFacingRotate;
	//public ObjectPool objectPool;
	// Use this for initialization
	void Start () {
		//transform.parent = null;
		Rigidbody2D rigid  = gameObject.GetComponent<Rigidbody2D>();
		rigid.isKinematic = true;
		parentTransform = transform.parent;
		startingPos = startingPosition;
		startingRot = transform.rotation;
		thisSprite = gameObject.GetComponent<SpriteRenderer>();
		thisSprite.enabled = false;
        //InvokeRepeating("ResetObject", 5f, 5f);	
	}
	
	public void FireRight(){
		ResetGrenade();
		ResetObject ();
		Debug.Log ("FireLeft");
		facingLeft = true;
		isLeftActive = true;
		forceAdded = true;

		//isActive = true;
	}
	
	public void FireLeft(){
		ResetGrenade();
		ResetObject();
		facingLeft = false;
		isLeftActive = true;
		Debug.Log ("FireRight");
		forceAdded = true;

	}
	// Update is called once per frame
	void Update () {
		
		if(isLeftActive == true)
			
		{


			if(ObjectPool.isGrenade == false){
				if(thisSprite.enabled == false){
					
                    
                    thisSprite.enabled = true;
                    if(thisSprite.enabled == true)
                    {
                        Debug.Log("enableSprite");
                    }
				}
					if(transform.parent != null){
					transform.rotation = ObjectPool.facingLeft.transform.rotation;
					transform.parent = null;
					}
					transform.Translate (Vector2.right *  ObjectPool.gunShotSpeed);
			
				if(gameObject.transform.position.x < (startingPos.x - ObjectPool.gunShotDistance) || gameObject.transform.position.x > (startingPos.x + ObjectPool.gunShotDistance))
				{
					//ResetObject ();
				}
			}
			
			else{//grenade logic
				if(forceAdded == true && isLeftActive == true){
                    gameObject.GetComponent<BoxCollider2D>().enabled = true;
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
					Invoke ("ExplodeGrenade", 2f);
				}
				
			}
			
			
		}
	}

	public void ExplodeGrenade(){
		explosionFX.SetActive(true);
		explosionAnim.SetBool("explode", true);
		Invoke ("FinishExplosion", 0.5f);
	}
	public void FinishExplosion(){
		explosionAnim.SetBool("explode", false);
		explosionFX.SetActive(false);
		thisSprite.enabled = false;
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
	}

	public void ResetGrenade(){
		if(ObjectPool.isGrenade == true){
		Rigidbody2D rigid  = gameObject.GetComponent<Rigidbody2D>();
		rigid.isKinematic = true;
		isLeftActive = true;
		transform.parent = parentTransform;
		transform.position = startingPos;
		transform.rotation = startingRot;
			thisSprite.enabled = true;
		}
	}
	public void ResetObject(){
		//	transform.parent = parentTransform ;
		if(ObjectPool.isGrenade == false){
		setLeft = false;
		isActive = false;
		isLeftActive = false;
		transform.SetParent(parentTransform);
		transform.position = startingPos;
		transform.rotation = startingRot;
		transform.Translate (Vector2.right * 0);
		if(thisSprite.enabled == true)
			thisSprite.enabled = false;
		}
        if(thisSprite.enabled == false)
        {
            Debug.Log("Sprite.disabled");
        }
	}
}