using UnityEngine;
using System.Collections;

public class BulletCheck : MonoBehaviour {
    public EnemyAI enemyAI;
    public float bulletHeightAdust = 1f;
    // Use this for initialization

        void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Bullet")
        {
            if(other.transform.position.y >= transform.position.y + bulletHeightAdust)
            {
                enemyAI.upperBulletCheck = true;
                Debug.Log("UpperBullet");
                
            }
            else
            {
                Debug.Log("LowerBullet");
                enemyAI.lowerBulletCheck = true;
            }
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bullet")
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

    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
