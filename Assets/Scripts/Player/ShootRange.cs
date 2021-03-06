﻿using UnityEngine;
using System.Collections;

public class ShootRange : MonoBehaviour {
    public ThugEnemyAI enemyAI;
    void Start()
    {
        enemyAI = transform.parent.GetComponent<ThugEnemyAI>();
    }
    // Use this for initialization
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (enemyAI.shootRange == false)
            {
                enemyAI.shootRange = true;
            }
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (enemyAI.shootRange == true)
            {
                enemyAI.shootRange = false;
            }
        }
    }
}
