using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerMovement : MonoBehaviour {
	
	public float speedForce = 20;           //Player's Forward Speed
	public Vector2 jumpVector;              //Player's jump position (x,y) ex: if x=0, then jump straight up, if x=0.5 slight right etc..
	public bool isGrounded;                 //ground switch, handled by ground check function
	public Transform grounder;              //object that checks for the ground, child of Player
	public float radiuss = 0.2f;            //radius check for ground
	public LayerMask ground;                //what is considered ground? assign layers
	public bool isFalling;                  //falling switch, for animation purposes
	public Animator anim;                   //Player's Animator
	public bool jump;                       //jump switch, for animations
	public Rigidbody2D rigid;               //Player's RigidBody2D = interacts with physics
	public Puppet2D_GlobalControl puppetControl; //control with mouse
//	public Puppet2D_GlobalControl releasePuppetControl; //animations play on without mouse control
	public bool roll = false;
	public bool isFacingMouse = true;
	public GameObject knifeObject;
	public GameObject gunObject;
	public int weaponNumber = 2;
	public bool weaponSwitch = false;

	void Start () {
	jump = anim.GetBool("jump");
	
		
	}
	public bool jumpButton = false;    
	public bool jumpStop = false;
	public bool jumpFall = false;
	public bool walking = false;
	public bool isFacingRight = true;
	public bool isAttacking = false;
	public bool gunControl = false;
	public bool endAttack = false;
	public bool animGunSwitch = false;
	// Update is called once per frame
	void EndAttack(){
		endAttack = true;
		if(weaponNumber == 2){
		puppetControl.SendMessage("EndGunControl");
		gunObject.SetActive(true);
		}
		//if(anim.GetBool("attack") == true)
		//	anim.SetBool("attack", false);
	}


	void Update () {



		if(weaponNumber == 2 && endAttack == false){
			if(animGunSwitch == false){
			//puppetControl.SendMessage("GunControl");
				animGunSwitch = true;
			}
		}

		
			// The player is grounded if a circlecast to the groundcheck position hits anything designated as ground
			isGrounded = Physics2D.OverlapCircle(grounder.transform.position, radiuss, ground);
			anim.SetBool("isGrounded", isGrounded);


				if (Input.GetButtonDown("Jump") && isGrounded == true)
				{
					jumpButton = false;
					if(jumpButton == false){
						
						rigid.AddRelativeForce(jumpVector, ForceMode2D.Force);
						jumpButton = true;
					}
					
				}
		if(Input.GetButtonDown("Fire2")){
			CancelInvoke("EndAttack");
			gunObject.SetActive(false);
			isAttacking = true;
			endAttack = false;
			animGunSwitch = false;
			//if(anim.GetBool("attack") == false){
			int rand = 0;
			rand = Random.Range(0,2);
					
			anim.SetInteger("randomAttack", rand);
			anim.SetTrigger("throw");
			puppetControl.SendMessage("GunControl");
			//}
			
		}
		else
		{
			if(isAttacking == true){
				
				
				isAttacking = false;
				Invoke("EndAttack", 0.5f);
			}
			
			
		}
			if(Input.GetButtonDown("Fire1")){
			CancelInvoke("EndAttack");
			isAttacking = true;
endAttack = false;
			animGunSwitch = false;
			//if(anim.GetBool("attack") == false){
				int rand = 0;
				if(weaponNumber == 1)
				rand = Random.Range(0,2);
				else if(weaponNumber == 0)
				rand = Random.Range (0,3); 
			
				anim.SetInteger("randomAttack", rand);
				anim.SetTrigger("attack");

			//}

		}



				if(Input.GetButtonDown("Fire3")){
			if(anim.GetBool("roll") == false){
				anim.SetBool ("roll", true);
				roll = true;
				if(isFacingRight == true)
				{
					rigid.velocity = new Vector2(speedForce*3, rigid.velocity.y);
				}
				else
				{
					rigid.velocity = new Vector2(-speedForce*3, rigid.velocity.y);
				}
			}
		}
		else
		{	if(roll == false){
			if(anim.GetBool("roll") == true)
				anim.SetBool("roll", false);
			}
		}
				if (Input.GetAxis("Horizontal") < 0)
				{
					if(anim.GetBool("roll") == false){
					//if(anim.GetBool("duck") == false){
				//if(weaponNumber != 2){
				//puppetControl.flip = true;
			//	releasePuppetControl.flip = true;
						//isFacingRight = false;
				//}
				if(anim.GetBool("duck") == false)
						rigid.velocity = new Vector2(-speedForce, rigid.velocity.y);
				else
					rigid.velocity = new Vector2(-speedForce/2, rigid.velocity.y);
						
						//transform.localScale = new Vector3(1, 1, 1);
					//}
			}
					
				}
				else if (Input.GetAxis("Horizontal") > 0)
				{
					if(anim.GetBool("roll") == false){
					//if(anim.GetBool("duck")== false){
						//isFacingRight = true;
						if(anim.GetBool("duck") == false)
						rigid.velocity = new Vector2(speedForce, rigid.velocity.y);
						else
					rigid.velocity = new Vector2(speedForce/2, rigid.velocity.y);
				//puppetControl.flip = false;
			//	releasePuppetControl.flip = false;
						//transform.localScale = new Vector3(-1, 1, 1);
				//}
					}
				}
				else
				{
					if(anim.GetBool("roll") == false)
					rigid.velocity = new Vector2(0, rigid.velocity.y);
				}
				
				
				if (rigid.velocity.y == 0)
				{
					
					
					if(anim.GetBool("jump") == true)
						anim.SetBool("jump", false);
					if(anim.GetBool("jumpForward") == true)
						anim.SetBool("jumpForward", false);
					if(anim.GetBool("isFalling")== true)
						anim.SetBool("isFalling", false);
					
				}
				else
					if (rigid.velocity.y < -1)
				{
					if(anim.GetBool("isFalling") == false)
						anim.SetBool("isFalling", true);
					if(anim.GetBool("jump") == false)
						anim.SetBool("jump", true);
					if(anim.GetBool("jumpForward") == true)
						anim.SetBool("jumpForward", false);
					//jumpFall = true;
					//jumpStop = false;
					//}
					
				}
				else
					if (rigid.velocity.y > 1)
				{
					if(isGrounded ==false){					
					if(anim.GetBool("jump") == false)
						anim.SetBool("jump", true);
					if(anim.GetBool("isFalling")== true)
						anim.SetBool("isFalling", false);
			}
				}
				
				if (rigid.velocity.x > 0 ){
		var playerScreenPoint = Camera.main.WorldToScreenPoint(transform.position);
		Vector3 mousePos = Input.mousePosition;
			
		if(weaponNumber != 2 || mousePos.x > playerScreenPoint.x){	
					if (isGrounded == true)
					{
					isFacingRight = true;
					puppetControl.flip = false;
						if(anim.GetBool("roll") == false){

						
						if(anim.GetBool("walk") == false)
							anim.SetBool("walk", true);
						if(anim.GetBool ("walkBack") == true)
							anim.SetBool ("walkBack", false);
						if(anim.GetBool("jumpForward") == true)
							anim.SetBool("jumpForward", false);
						if(anim.GetBool("walkToIdle") == true)
							anim.SetBool("walkToIdle", false);
				}

			
						//			walking = false;
						//		}
					}
					//}
					else //if (jump == true)
						//{
						if (isGrounded == false)
					{
						//		if(walking == true){
						if(anim.GetBool("jumpForward")== false)
							anim.SetBool("jumpForward", true);
						if(anim.GetBool("jump") == true)
							anim.SetBool("jump", false);
						if(anim.GetBool("walk")== true)
							anim.SetBool("walk", false);
						if(anim.GetBool("walkToIdle") == true)
							anim.SetBool("walkToIdle", false);
						//			walking = false;
						//		}
					}
			}
			else if (mousePos.x < playerScreenPoint.x && weaponNumber == 2){
				isFacingRight = false;
				puppetControl.flip = true;
				if (isGrounded == true)
				{
					if(anim.GetBool("roll") == false){
						
						
						if(anim.GetBool("walkBack") == false)
							anim.SetBool("walkBack", true);
						if(anim.GetBool ("walk") == true)
							anim.SetBool ("walk", false);
						if(anim.GetBool("jumpForward") == true)
							anim.SetBool("jumpForward", false);
						if(anim.GetBool("walkToIdle") == true)
							anim.SetBool("walkToIdle", false);
					}
					
					
					//			walking = false;
					//		}
				}
				//}
				else //if (jump == true)
					//{
					if (isGrounded == false)
				{
					//		if(walking == true){
					if(anim.GetBool("jumpForward")== false)
						anim.SetBool("jumpForward", true);
					if(anim.GetBool("jump") == true)
						anim.SetBool("jump", false);
					if(anim.GetBool("walkBack")== true)
						anim.SetBool("walkBack", false);
					if(anim.GetBool("walkToIdle") == true)
						anim.SetBool("walkToIdle", false);
					//			walking = false;
					//		}
				}
			}

		}else if(rigid.velocity.x < 0){
			var playerScreenPoint = Camera.main.WorldToScreenPoint(transform.position);
			Vector3 mousePos = Input.mousePosition;
			
			if(weaponNumber != 2 || mousePos.x < playerScreenPoint.x){	
				if (isGrounded == true)
				{
					isFacingRight = false;
					puppetControl.flip = true;
					if(anim.GetBool("roll") == false){
						
						
						if(anim.GetBool("walk") == false)
							anim.SetBool("walk", true);
						if(anim.GetBool("walkBack") == true)
							anim.SetBool ("walkBack", false);
						if(anim.GetBool("jumpForward") == true)
							anim.SetBool("jumpForward", false);
						if(anim.GetBool("walkToIdle") == true)
							anim.SetBool("walkToIdle", false);
					}
					
					
					//			walking = false;
					//		}
				}
				//}
				else //if (jump == true)
					//{
					if (isGrounded == false)
				{
					//		if(walking == true){
					if(anim.GetBool("jumpForward")== false)
						anim.SetBool("jumpForward", true);
					if(anim.GetBool("jump") == true)
						anim.SetBool("jump", false);
					if(anim.GetBool("walk")== true)
						anim.SetBool("walk", false);
					if(anim.GetBool("walkToIdle") == true)
						anim.SetBool("walkToIdle", false);
					//			walking = false;
					//		}
				}
			}
			else if (mousePos.x > playerScreenPoint.x && weaponNumber == 2){
				isFacingRight = true;
				puppetControl.flip = false;
				if (isGrounded == true)
				{
					if(anim.GetBool("roll") == false){
						
						
						if(anim.GetBool("walkBack") == false)
							anim.SetBool("walkBack", true);
						if(anim.GetBool("walk") == true)
							anim.SetBool("walk", false);
						if(anim.GetBool("jumpForward") == true)
							anim.SetBool("jumpForward", false);
						if(anim.GetBool("walkToIdle") == true)
							anim.SetBool("walkToIdle", false);
					}
					
					
					//			walking = false;
					//		}
				}
				//}
				else //if (jump == true)
					//{
					if (isGrounded == false)
				{
					//		if(walking == true){
					if(anim.GetBool("jumpForward")== false)
						anim.SetBool("jumpForward", true);
					if(anim.GetBool("jump") == true)
						anim.SetBool("jump", false);
					if(anim.GetBool("walkBack")== true)
						anim.SetBool("walkBack", false);
					if(anim.GetBool("walkToIdle") == true)
						anim.SetBool("walkToIdle", false);
					//			walking = false;
					//		}
				}
			}
		}
				else if (rigid.velocity.x == 0) //not in use
				{
					//if(walking == false){
					if(anim.GetBool("walk")== true)
						anim.SetBool("walk", false);
					if(anim.GetBool ("walkBack")==true)
				anim.SetBool("walkBack", false);
					if(anim.GetBool("jumpForward")== true)
						anim.SetBool("jumpForward", false);
					if(anim.GetBool("walkToIdle")== false)
						anim.SetBool("walkToIdle", true);
					//		walking = true;
					
					
					//	}
				}

		if(Input.GetAxis("Vertical")< 0)
		{
			if(anim.GetBool("duck") == false)
				anim.SetBool("duck", true);
		}
		else
		{
			if(anim.GetBool("duck") == true)
				anim.SetBool("duck", false);
		}

	

		if(Input.GetButtonDown("WeaponSwitch")){
			if(weaponNumber == 0){
				anim.SetInteger("weaponNumber", 1);
				weaponNumber = 1;//knife
				puppetControl.weaponControl = false;
				puppetControl.SendMessage("WeaponSwitch");
				gunObject.SetActive(false);
				knifeObject.SetActive(true);
			}
			else if(weaponNumber == 1){
				anim.SetInteger("weaponNumber", 2);
				weaponNumber = 2;//gun
				puppetControl.weaponControl = true;
				puppetControl.SendMessage("WeaponSwitch");
				knifeObject.SetActive(false);
				gunObject.SetActive(true);

			}
			else if (weaponNumber == 2){
				anim.SetInteger("weaponNumber", 0);
				weaponNumber = 0;//fists
				puppetControl.weaponControl = false;
				puppetControl.SendMessage("WeaponSwitch");
				gunObject.SetActive(false);
				knifeObject.SetActive(false);
			}
		}
		
	}
	
	
	
	void OnDrawGizmos()
	{
		Gizmos.color = Color.white;
		Gizmos.DrawWireSphere(grounder.transform.position, radiuss);
	}
	
}
