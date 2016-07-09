using UnityEngine;
using System.Collections;

public class NonSolidPlatforms : MonoBehaviour {
    public BoxCollider2D col;
    public float reEnableColliderAfter = 2f;
	// Use this for initialization
	void Start () {
	
	}
	void OnCollisionStay(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                col.enabled = false;
                if (!IsInvoking("ReEnableCollider"))
                {
                    Invoke("ReEnableCollider", reEnableColliderAfter);
                }
            }
        }
    }

    void ReEnableCollider()
    {
        col.enabled = true;
    }
	// Update is called once per frame
	void Update () {
	
	}
}
