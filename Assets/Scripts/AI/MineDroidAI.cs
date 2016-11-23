using UnityEngine;
using System.Collections;

public class MineDroidAI : MonoBehaviour {

    public float explodeTimer = 2.0f;
    public int health = 3;
    [HideInInspector]
    public Transform target; // if == null then do not run.
    [HideInInspector]
    public bool isGrounded = false;
    [HideInInspector]
    public bool hasFoundPlayer = false;
    [HideInInspector]
    public bool nextToPlayer = false;
    
   // public EnemyStats enemyStats; -  not used for droid
    public Animator anim;
    public Puppet2D_GlobalControl puppetControl;
    
        
    public void Explode()
    {

        Debug.Log("Explode");
        anim.SetTrigger("Explode");
        isDead = true;

        
    }
    void Start () {
    
	}
    [HideInInspector]
    public bool isDead = false;
    [HideInInspector]
    public bool isPlayerOnTheRight = true;
    public float aiSpeed = 10f;
   
   
    public float closestWalkingDistance = 5f;
   
    void Update()
    {
        if (isDead == false)
        {
            if (isGrounded == true)
            {
              
                if (hasFoundPlayer == true)
                {
                    if (target != null)
                    {
                        if (target.position.x > this.transform.position.x)
                        {
                            isPlayerOnTheRight = true;
                            Quaternion rot = transform.rotation;
                            puppetControl.flip = false;
                            //rot.y = 360;
                            transform.rotation = rot;
                        }
                        else
                        {
                            isPlayerOnTheRight = false;
                            Quaternion rot = transform.rotation;
                            puppetControl.flip = true;
                            //rot.y = 180;
                            transform.rotation = rot;
                        }
                        if (isPlayerOnTheRight == true)
                        {
                             if (target.position.x > this.transform.position.x + closestWalkingDistance)
                                {
                                    if (anim.GetCurrentAnimatorStateInfo(0).IsName("Standard_Idle") || anim.GetCurrentAnimatorStateInfo(0).IsName("Standard_Run"))
                                    {
                                        transform.position = Vector2.MoveTowards(transform.position, target.position, aiSpeed);
                                        anim.SetBool("Walk", true);
                                    }
                                }
                                else
                                {
                                Invoke("Explode", explodeTimer);
                                    anim.SetBool("Walk", false);
                                }
                            
                        }
                        else
                        {
                                                           if (target.position.x < this.transform.position.x - closestWalkingDistance)
                                {
                                    if (anim.GetCurrentAnimatorStateInfo(0).IsName("Standard_Idle") || anim.GetCurrentAnimatorStateInfo(0).IsName("Standard_Run"))
                                    {
                                        transform.position = Vector2.MoveTowards(transform.position, target.position, aiSpeed);
                                        anim.SetBool("Walk", true);
                                    }
                                }
                                else
                                {
                                Invoke("Explode", explodeTimer);
                                anim.SetBool("Walk", false);
                                }

                           
                        }


                        

                                
                            }
                        }
                    }
                }
            }
        }
    

