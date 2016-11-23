using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ItemOnClickEventLeft : MonoBehaviour {
    public ItemScrollEvent itemScrollEvent;
	// Use this for initialization
    void OnEnable()
    {
    
       itemScrollEvent.leftEnabled = true;
       GetComponent<ItemOnClickEventLeft>().enabled = false;
    }
    
   
	
}
