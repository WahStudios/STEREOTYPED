using UnityEngine;
using System.Collections;

public class BulletCheck : MonoBehaviour {
    public ThugEnemyAI enemyAI;
    public float bulletHeightAdust = 1f;
    Transform bulletPool;
    public bool isTooCloseToDodge = false;
    // Use this for initialization
    void Start()
    {
        enemyAI = transform.parent.GetComponent<ThugEnemyAI>();
        bulletPool = GameObject.Find("BulletPool").transform;
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            isTooCloseToDodge = true;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Bullet")
        {
            if (isTooCloseToDodge == false)
            {
                if (other.transform.position.y >= transform.position.y + bulletHeightAdust)
                {
                    enemyAI.upperBulletCheck = true;
                    enemyAI.RollDodge();
                    Debug.Log("UpperBullet");

                }
                else
                {
                    enemyAI.RollDodge();
                    Debug.Log("LowerBullet");
                    enemyAI.lowerBulletCheck = true;
                }
            }
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            isTooCloseToDodge = false;
        }
        if (other.gameObject.tag == "Bullet")
            if (isTooCloseToDodge == false)
            {
                {
                    if (other.transform.position.y >= transform.position.y + bulletHeightAdust)
                    {
                        if (other.transform.position.y >= transform.position.y)
                        {
                            enemyAI.upperBulletCheck = false;
                            Debug.Log("Safe from UpperBullet");
                        }
                        else
                        {
                            Debug.Log("Safe from LowerBullet");
                            enemyAI.lowerBulletCheck = false;
                        }
                    }
                }
        }
    }

	
	// Update is called once per frame
	void Update () {
	
	}
}
