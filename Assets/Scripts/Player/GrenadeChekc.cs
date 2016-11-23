using UnityEngine;
using System.Collections;

public class GrenadeChekc : MonoBehaviour {
    public ThugEnemyAI enemyAI;
    public GameObject currentGrenade;
	// Use this for initialization
	void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.tag == "Grenade")
        {
            currentGrenade = other.gameObject;
                enemyAI.grenadeCheck = true;
                Debug.Log("Grenade!");
         
           
        }
    }
    void Start() { enemyAI = transform.parent.GetComponent<ThugEnemyAI>(); }
    void Update()
    {
        if (currentGrenade != null)
        {
            if (currentGrenade.GetComponent<BoxCollider2D>().enabled == false)
            {
                if(enemyAI.grenadeCheck == true)
                enemyAI.grenadeCheck = false;
            }
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Grenade")
        {
            enemyAI.grenadeCheck = false;
            Debug.Log("SafeFromGrenade");
        }
    }
}
