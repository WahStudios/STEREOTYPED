using UnityEngine;
using System.Collections;

public class PreciousAI : MonoBehaviour
{
    public GameObject equippedMeleeWeapon;
    public bool isAbovePlayer = false;


    [HideInInspector]
    public Transform target; // if == null then do not run.
    [HideInInspector]
    public bool isGrounded = false;
    [HideInInspector]
    public bool hasFoundPlayer = false;
    [HideInInspector]
    public bool shootRange = false;
    [HideInInspector]
    public bool meleeRange = false;

    public float shootCooldown = 3f;//reload
    public float meleeCooldown = 2f;
    [HideInInspector]
    public bool grenadeCheck = false;
    [HideInInspector]
    public bool upperBulletCheck = false;
    [HideInInspector]
    public bool lowerBulletCheck = false;
    public EnemyStats enemyStats;
    public Animator anim;
    public Puppet2D_GlobalControl puppetControl;


    // Use this for initialization
    public void Reload()
    {
        Debug.Log("DoneReloading");
        shootSwitch = false;
    }
    public void RegainStamina()
    {
        Debug.Log("RegainStamina");
        kickSwitch = false;
    }
    public void Shoot()
    {
        Debug.Log("Shoot");
        anim.SetTrigger("Shoot");
        Invoke("Reload", shootCooldown);

    }

    public void Kick()
    {

        Debug.Log("Kick");
        anim.SetTrigger("Kick");
        Invoke("RegainStamina", meleeCooldown);
    }
    void Start()
    {
        enemyStats = GetComponent<EnemyStats>();
        anim = GetComponent<Animator>();
        puppetControl = GetComponent<Puppet2D_GlobalControl>();
    }

    public void Die()
    {
        isDead = true;
        anim.SetTrigger("Die");
        Debug.Log("Die");
        Destroy(this.gameObject);
    }
    [HideInInspector]
    public bool isDead = false;
    [HideInInspector]
    public bool isPlayerOnTheRight = true;

    public float aiSpeed = 10f;
    [HideInInspector]
    public bool shootSwitch = false; //pull the trigger to make true
    [HideInInspector]
    public bool kickSwitch = false;
    public float closestWalkingDistance = 5f;
    public Vector2 jumpVector;
    bool isDodgeReady = true;
    public float rollDodgeCoolDown = 10f;
    // Update is called once per frame

    public void RollDodge()
    {
        if (isDodgeReady == true)
        {
            isDodgeReady = false;
            Invoke("ResetDodge", rollDodgeCoolDown);
            if (upperBulletCheck == true)
            {

                // anim.SetTrigger("Duck"); 
                Debug.Log("Roll");
                anim.SetTrigger("Roll");
                upperBulletCheck = false;
            }
            if (lowerBulletCheck == true)
            {
                //anim.SetTrigger("Jump");
                Debug.Log("Roll");
                anim.SetTrigger("Roll");
                lowerBulletCheck = false;
                rigidbody2D.AddRelativeForce(jumpVector, ForceMode2D.Force);
            }
        }
        else
        {
            if (upperBulletCheck == true)
            {

                anim.SetTrigger("Duck");
                // Debug.Log("Roll");
                //  anim.SetTrigger("Roll");
                upperBulletCheck = false;
            }
            if (lowerBulletCheck == true)
            {
                anim.SetTrigger("Jump");
                //Debug.Log("Roll");
                // anim.SetTrigger("Roll");
                lowerBulletCheck = false;
                rigidbody2D.AddRelativeForce(jumpVector, ForceMode2D.Force);
            }
        }
    }


    void ResetDodge()
    {
        isDodgeReady = true;
    }
    void Update()
    {
        if (isDead == false)
        {
            if (isGrounded == true)
            {


                if (grenadeCheck == false)
                {
                    if (anim.GetBool("GrenadeCheck") == true)
                        anim.SetBool("GrenadeCheck", false);
                }
                else
                {
                    if (anim.GetBool("GrenadeCheck") == false)
                        anim.SetBool("GrenadeCheck", true);
                }
                if (hasFoundPlayer == true)
                {
                    if (target != null)
                    {
                        if (lowerBulletCheck == false && upperBulletCheck == false)
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
                        }
                        if (isPlayerOnTheRight == true)
                        {
                            if (grenadeCheck == false)
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

                                    anim.SetBool("Walk", false);
                                }
                            }
                            else
                            {
                                transform.position = Vector2.MoveTowards(transform.position, target.position, -aiSpeed);
                                anim.SetBool("Walk", true);
                                puppetControl.flip = true;
                            }
                        }
                        else
                        {
                            if (grenadeCheck == false)
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
                                    anim.SetBool("Walk", false);
                                }

                            }
                            else
                            {
                                transform.position = Vector2.MoveTowards(transform.position, target.position, -aiSpeed);
                                anim.SetBool("Walk", true);
                                puppetControl.flip = false;
                            }
                        }


                        if (shootRange == true)
                        {
                            if (meleeRange == false)
                            {
                                if (shootSwitch == false)
                                {
                                    if (anim.GetCurrentAnimatorStateInfo(0).IsName("Standard_Idle") || anim.GetCurrentAnimatorStateInfo(0).IsName("Standard_Run"))
                                    {
                                        if (grenadeCheck == false)
                                        {
                                            Shoot();
                                            shootSwitch = true;
                                        }
                                    }
                                }
                            }
                            else
                            {

                                if (kickSwitch == false)
                                    if (grenadeCheck == false)
                                    {
                                        Kick();
                                        kickSwitch = true;
                                    }
                            }
                        }
                    }
                }
            }
        }
    }
}

