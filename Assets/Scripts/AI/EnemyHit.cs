using UnityEngine;
using System.Collections;

public class EnemyHit : MonoBehaviour {

    public EnemyStats enemyStats;
    public ThugEnemyAI enemyAI;
    public Animator animator;
    public bool isDead = false;
    public bool die = false;
    public float nextFire = 0.5f;
    public float gunShotRate = 0.5f;

    // Use this for initialization
    void Start() { enemyAI = GetComponent<ThugEnemyAI>(); }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (Time.time > nextFire)
        {
            nextFire = Time.time + gunShotRate;
            if (other.gameObject.tag == "Bullet")
            {
                enemyStats.HP -= 30;
                Debug.Log("hit");
            }
        }
            
    }

    void Update()
    {
      if(enemyStats.HP <= 0)
        {
            isDead =true;
        }
      if(isDead == true)
        {
            if(die == false)
            {
                enemyAI.Die();
                die = true;
            }
        }
    }
}