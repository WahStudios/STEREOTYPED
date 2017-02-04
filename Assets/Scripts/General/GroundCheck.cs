using UnityEngine;
using System.Collections;

public class GroundCheck : MonoBehaviour {

    public ThugEnemyAI enemyAI;
    public string groundLayerName = "Environment";
     
    void Start()
    {
        enemyAI = transform.parent.GetComponent<ThugEnemyAI>();
    }
	// Use this for initialization
	void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer(groundLayerName))
        {
            if(enemyAI.isGrounded == false)
            enemyAI.isGrounded = true;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.layer == LayerMask.NameToLayer("Environment"))
        {
            if(enemyAI.isGrounded == true)
            {
                enemyAI.isGrounded = false;
            }
        }
    }
}
