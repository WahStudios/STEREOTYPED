using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Inventory : MonoBehaviour {
	public int indexOfDraggedItem;
    public List<GameObject> Slots = new List<GameObject>();
    public List<Item> Items = new List<Item>();
    public GameObject slots;
   public int x = -110; //backpack 8 slots
   public int y = 110;
	public int xx = -175; //equipment slots
	public int yy = 120;
	public int wx = -225; //weapon slots
	public int wy = 120;
	public int gx = -350; //grenade slots
	public int gy = 120;
    ItemDatabase database;
	public GameObject toolTip;
	public GameObject draggedItemGameObject;
	public bool draggingItem = false;
	public Item draggedItem;
	public Vector2 offScreenPosition;
	public Vector2 startingPosition;
	public bool offScreen = true;

	public void MovePanel(){
		offScreen = !offScreen;
		if(offScreen == false)
			transform.position = startingPosition;
		else
			transform.position = offScreenPosition;
	}




	public void showTooltip(Vector3 toolPosition, Item item)
	{
		toolTip.SetActive (true);
		toolTip.GetComponent<RectTransform>().localPosition = new Vector3(toolPosition.x + 240, toolPosition.y + 10, toolPosition.z);

		toolTip.transform.GetChild (0).GetComponent<Text>().text = item.itemName;
		toolTip.transform.GetChild (1).GetComponent<Text>().text = "Value = " ;//+ item.itemPower.ToString();
		toolTip.transform.GetChild (2).GetComponent<Text>().text = item.itemDesc;



	}

	public void closeDraggedItem()
	{
		draggingItem = false;
		draggedItemGameObject.SetActive(false);

	}
	int origx;
	int origy;
	int origxx;
	int origyy;
	int origwx;
	int origwy;
	int origgx;
	int origgy;


	void Update()
	{
		if(draggingItem)
		{
			Vector3 posi = (Input.mousePosition - GameObject.FindGameObjectWithTag("Canvas").GetComponent<RectTransform>().localPosition);
			draggedItemGameObject.GetComponent<RectTransform>().localPosition = new Vector3(posi.x +15, posi.y - 15, posi.z);
		}
	}
	public void showDraggedItem(Item item, int slotNumber)
	{
		closeTooltip();
		draggedItemGameObject.SetActive(true);
		draggedItemGameObject.GetComponent<Image>().sprite = item.ItemIcon;
		draggingItem = true;
		indexOfDraggedItem = slotNumber;
		draggedItem = item;
	}


	public void closeTooltip()
	{
		toolTip.SetActive (false);
	}





	void Start()
    {
		startingPosition = this.gameObject.transform.position;
		origx = x;
		origy = y;
		origxx = xx;
		origyy = yy;
		origwx = wx;
		origwy = wy;
		origgx = gx;
		origgy = gy;
		MovePanel ();

        int Slotamount = 0;
		int EquipSlotAmount = 0;
        database = GameObject.FindGameObjectWithTag("ItemDatabase").GetComponent<ItemDatabase>();
        for (int i = 0; i < 4; i++)
        {									////BACKPACK////
            for (int k = 0; k < 2; k++)
            {
                GameObject slot = (GameObject)Instantiate(slots);
                slot.GetComponent<SlotScript>().slotNumber = Slotamount;
                Slots.Add(slot);
                Items.Add(new Item());
                slot.transform.SetParent(this.gameObject.transform, false);
                slot.name = "Slot" + i + "." + k;
                slot.GetComponent<RectTransform>().localPosition = new Vector3(x, y, 0);
                x = x + 55;
                if(k == 1)
                {
                    x = origx;
                    y = y - 55;
                }

                Slotamount++;
            }

		}
		for (int n = 0; n < 5; n++)
		{						//ARMOR MODS//////
			for (int m = 0; m < 1; m++)
			{
			GameObject slot = (GameObject)Instantiate(slots);
			slot.GetComponent<SlotScript>().slotNumber = Slotamount;
			Slots.Add(slot);
			Items.Add(new Item());
			slot.transform.SetParent(this.gameObject.transform, false);
			slot.name = "Armor Mods" + n;
				//var slotScale = slot.GetComponent<RectTransform>().localScale;
			//	slotScale.x = 0.5f;
			//	slotScale.y = 0.5f;
				//slot.GetComponent<RectTransform>().localScale = slotScale;
			slot.GetComponent<RectTransform>().localPosition = new Vector3(xx, yy, 0);
				xx = xx + 55;

				if(m == 0)
				{
					xx = origxx;
					yy = yy - 55;
				}
				
				Slotamount++;
			}
		}
		for (int n = 0; n < 6; n++)
		{						//Weapon MODS//////
			for (int m = 0; m < 1; m++)
			{
				GameObject slot = (GameObject)Instantiate(slots);
				slot.GetComponent<SlotScript>().slotNumber = Slotamount;
				Slots.Add(slot);
				Items.Add(new Item());
				slot.transform.SetParent(this.gameObject.transform, false);
				slot.name = "Weapon Mods" + n;
				var slotScale = slot.GetComponent<RectTransform>().localScale;
				//slotScale.x = 0.5f;
				//slotScale.y = 0.5f;
				//slot.GetComponent<RectTransform>().localScale = slotScale;
				slot.GetComponent<RectTransform>().localPosition = new Vector3(wx, wy, 0);
				wx = wx + 55;
				
				if(m == 0)
				{
					wx = origwx;
					wy = wy - 55;
				}
				
				Slotamount++;
			}
		}
		for (int n = 0; n < 4; n++)
		{						//GRENADE MODS//////
			for (int m = 0; m < 1; m++)
			{
				GameObject slot = (GameObject)Instantiate(slots);
				slot.GetComponent<SlotScript>().slotNumber = Slotamount;
				Slots.Add(slot);
				Items.Add(new Item());
				slot.transform.SetParent(this.gameObject.transform, false);
				slot.name = "Grenade Mods" + n;
				var slotScale = slot.GetComponent<RectTransform>().localScale;
				///slotScale.x = 0.5f;
				//slotScale.y = 0.5f;
				//slot.GetComponent<RectTransform>().localScale = slotScale;
				slot.GetComponent<RectTransform>().localPosition = new Vector3(gx, gy, 0);
				gx = gx + 55;
				
				if(m == 0)
				{
					gx = origgx;
					gy = gy - 55;
				}
				
				Slotamount++;
			}
		}
		//addItem(0);
		// addItem(1);
		//	addItem(2);
		
		
		
		
		
    }

   public void addItem(int id)
    {
        for (int i = 0; i < database.items.Count; i++)
        {
			if (database.items[i].itemID == id ) 
             //(database.items[i].itemName == itemName)
            {
                Item item = database.items[i];
				addItemAtEmptySlot(item);

                break;
            }
        }
    }

	public void addItemOnClick(string itemName)
	{
		for (int i = 0; i < database.items.Count; i++)
		{
			if (database.items[i].itemName == itemName) 
				//(database.items[i].itemName == itemName)
			{
				Item item = database.items[i];
				addItemAtEmptySlot(item);
				
				break;
			}
		}
	}
	
    void addItemAtEmptySlot(Item item)
    {
        for (int i = 0; i < Items.Count; i++)
        {
            if (Items[i].itemName == null)
            {
                Items[i] = item;
                break;
            }

        }
    }
}
