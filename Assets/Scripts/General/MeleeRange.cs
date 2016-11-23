using UnityEngine;
using System.Collections;

public class MeleeRange : MonoBehaviour {

    public ThugEnemyAI enemyAI;
    // Use this for initialization
    void Start() { enemyAI = transform.parent.GetComponent<ThugEnemyAI>(); }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (enemyAI.meleeRange == false)
            {
                enemyAI.meleeRange = true;
            }
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (enemyAI.meleeRange == true)
            {
                enemyAI.meleeRange = false;
            }
        }
    }
}
