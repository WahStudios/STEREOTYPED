using UnityEngine;
using System.Collections;

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
	public Puppet2D_GlobalControl puppetControl;
	public bool roll = false;
	
	void Start () {
	jump = anim.GetBool("jump");
	
		
	}
	public bool jumpButton = false;    
	public bool jumpStop = false;
	public bool jumpFall = false;
	public bool walking = false;
	public bool isFacingRight;
	// Update is called once per frame
	void Update () {
		
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
					if(anim.GetBool("duck") == false){
				puppetControl.flip = true;
						isFacingRight = false;
						rigid.velocity = new Vector2(-speedForce, rigid.velocity.y);
						
						//transform.localScale = new Vector3(1, 1, 1);
					}
			}
					
				}
				else if (Input.GetAxis("Horizontal") > 0)
				{
					if(anim.GetBool("roll") == false){
					if(anim.GetBool("duck")== false){
						isFacingRight = true;
						rigid.velocity = new Vector2(speedForce, rigid.velocity.y);
				puppetControl.flip = false;
						//transform.localScale = new Vector3(-1, 1, 1);
				}
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
				
				if (rigid.velocity.x > 0 || rigid.velocity.x < 0)
				{
					
					if (isGrounded == true)
					{
						if(anim.GetBool("roll") == false){

						
						if(anim.GetBool("walk") == false)
							anim.SetBool("walk", true);
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
					
					//}
				}
				else if (rigid.velocity.x == 0) //not in use
				{
					//if(walking == false){
					if(anim.GetBool("walk")== true)
						anim.SetBool("walk", false);
					if(anim.GetBool("jumpForward")== true)
						anim.SetBool("jumpForward", false);
					if(anim.GetBool("walkToIdle")== false)
						anim.SetBool("walkToIdle", true);
					//		walking = true;
					
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
					//	}
				}
				
				
		
	}
	
	
	
	void OnDrawGizmos()
	{
		Gizmos.color = Color.white;
		Gizmos.DrawWireSphere(grounder.transform.position, radiuss);
	}
	
}
