using UnityEngine;
using System.Collections;

public class Item  {

    public string itemName;
    public int itemID;
    public string itemDesc;
    public Sprite ItemIcon;
    public GameObject itemModel;
	public string itemType;

    public Item(string name, int id, string desc, string type)
    {
        itemName = name;
        itemID = id;
        itemDesc = desc;
		itemType = type;

		ItemIcon = Resources.Load<GameObject>("" + name).GetComponent<SpriteRenderer>().sprite;
    }

    public Item()
    { }
    
}
