using UnityEngine;
using System.Collections;

public class GroundCheck : MonoBehaviour {

    public EnemyAI enemyAI;
	// Use this for initialization
	void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Ground")
        {
            if(enemyAI.isGrounded == false)
            enemyAI.isGrounded = true;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.tag == "Ground")
        {
            if(enemyAI.isGrounded == true)
            {
                enemyAI.isGrounded = false;
            }
        }
    }
}
