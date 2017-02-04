using UnityEngine;
using System.Collections;

public class DoorVisual : MonoBehaviour {
    Animator anim;
    bool isOpen = false;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (isOpen == false)
        {

            if (other.gameObject.layer == LayerMask.NameToLayer("Character") && other.gameObject.tag == "Player")// || other.collider.tag == "Enemy")
            {
                isOpen = true;
                anim.SetTrigger("Open");
               
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (isOpen == true)
        {
            if (other.gameObject.layer == LayerMask.NameToLayer("Character") && other.gameObject.tag == "Player")// || other.collider.tag == "Enemy")
            {
                anim.SetTrigger("Close");
                isOpen = false;
            }
        }
    }
}
