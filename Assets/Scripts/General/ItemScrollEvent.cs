using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ItemScrollEvent : MonoBehaviour {

	
    public GameObject item1;
    public GameObject item2;
    public GameObject item3;
    public GameObject item4;
    public bool item1enabled = true;
    public bool item2enabled = false;
    public bool item3enabled = false;
    public bool item4enabled = false;
    bool axisInUse = false;
    public bool leftEnabled = false;
    public bool rightEnabled = false;
    public Image thisImage;
    public Image thisImageRight;
    public Sprite nextSprite;
    Sprite thisSprite;
    Sprite thisSpriteRight;
    
    void Start()
    {

        thisSprite = thisImage.sprite;
        thisSpriteRight = thisImageRight.sprite;
    }
        
    void Update()
    {
        if(Input.GetAxis("Horizontal") < 0)
        {
            if (axisInUse == false)
            {
                thisImageRight.sprite = thisSpriteRight;
                thisImage.sprite = nextSprite;
            }
        }
        else if(Input.GetAxis("Horizontal") > 0)
        {
            if (axisInUse == false)
            {
                thisImage.sprite = thisSprite;
                thisImageRight.sprite = nextSprite;
            }
        }
        else if(Input.GetAxis("Horizontal") == 0)
        {
            thisImage.sprite = thisSprite;
            thisImageRight.sprite = thisSpriteRight;
        }



        if (item1enabled == true)
            item1.SetActive(true);
        else
            item1.SetActive(false);
        if (item2enabled == true)
            item2.SetActive(true);
        else
            item2.SetActive(false);
        if (item3enabled == true)
            item3.SetActive(true);
        else
            item3.SetActive(false);
        if (item4enabled == true)
            item4.SetActive(true);
        else
            item4.SetActive(false);
        

        
        if(Input.GetAxisRaw("Horizontal") < 0 || leftEnabled == true)//left
        {
            leftEnabled = false;
            if(axisInUse == false)
            {
                axisInUse = true;
                if (item1enabled == true)
                {
                     item4enabled = true;
                     item1enabled = false;

                }
                else if (item2enabled == true)
                {
                    item1enabled = true;
                    item2enabled = false;

                }
                else if (item3enabled == true)
                {
                    item2enabled = true;
                    item3enabled = false;

                }
                else if (item4enabled == true)
                {
                    item3enabled = true;
                    item4enabled = false;

                }
            }
        }
        else if (Input.GetAxisRaw("Horizontal") > 0 || rightEnabled == true)//right
        {
            rightEnabled = false;
            if (axisInUse == false)
            {
                axisInUse = true;
                if (item1enabled == true)
                {
                    item2enabled = true;
                    item1enabled = false;

                }
                else if (item2enabled == true)
                {
                    item3enabled = true;
                    item2enabled = false;

                }
                else if (item3enabled == true)
                {
                    item4enabled = true;
                    item3enabled = false;

                }
                else if (item4enabled == true)
                {
                    item1enabled = true;
                    item4enabled = false;

                }

            }
        }
        else if(Input.GetAxisRaw("Horizontal") == 0)//null
        {
            //axisInUse = false;
            if (leftEnabled == false && rightEnabled == false)
                axisInUse = false;
        }

    }
}
