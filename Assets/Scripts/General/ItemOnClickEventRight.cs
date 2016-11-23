using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ItemOnClickEventRight : MonoBehaviour {
    public ItemScrollEvent itemScrollEvent;
    //public Image thisImage;
    //p///ublic Sprite clickedSprite;
   // Sprite thisSprite;
    // Use this for initialization
    void OnEnable()
    {
      //  thisSprite = thisImage.sprite;
        //thisImage.sprite = clickedSprite;
       itemScrollEvent.rightEnabled = true;
       GetComponent<ItemOnClickEventRight>().enabled = false;
    }
    //void OnDisable()
    //{
      //  thisImage.sprite = thisSprite;
    //}
    
   
	
}
