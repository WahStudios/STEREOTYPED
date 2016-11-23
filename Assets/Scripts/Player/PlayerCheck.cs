using UnityEngine;
using System.Collections;

public class PlayerCheck : MonoBehaviour {
    public ThugEnemyAI enemyAI;

    void Start() { enemyAI = transform.parent.GetComponent<ThugEnemyAI>(); }
	// Use this for initialization
	void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            if(enemyAI.hasFoundPlayer == false)
            {
                enemyAI.target = other.transform;
                enemyAI.hasFoundPlayer = true;
            }
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (enemyAI.hasFoundPlayer == true)
            {
                enemyAI.target = null;
                enemyAI.hasFoundPlayer = false;
            }
        }
    }
}
