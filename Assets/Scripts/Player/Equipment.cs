using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Equipment : MonoBehaviour {
	public int indexOfDraggedItem;
	public List<GameObject> Slots = new List<GameObject>();
	public List<Item> Items = new List<Item>();
	public GameObject slots;
	int x = -110;
	int y = 110;
	ItemDatabase database;
	public GameObject toolTip;
	public GameObject draggedItemGameObject;
	public bool draggingItem = false;
	public Item draggedItem;
	public void showTooltip(Vector3 toolPosition, Item item)
	{
		toolTip.SetActive (true);
		toolTip.GetComponent<RectTransform>().localPosition = new Vector3(toolPosition.x + 240, toolPosition.y + 10, toolPosition.z);
		
		toolTip.transform.GetChild (0).GetComponent<Text>().text = item.itemName;
		toolTip.transform.GetChild (1).GetComponent<Text>().text = "Value = ";// + item.itemPower.ToString();
		toolTip.transform.GetChild (2).GetComponent<Text>().text = item.itemDesc;
		
		
		
	}
	
	public void closeDraggedItem()
	{
		draggingItem = false;
		draggedItemGameObject.SetActive(false);
		
	}
	
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
		int Slotamount = 0;
		database = GameObject.FindGameObjectWithTag("ItemDatabase").GetComponent<ItemDatabase>();
		for (int i = 0; i < 5; i++)
		{
			for (int k = 0; k < 5; k++)
			{
				GameObject slot = (GameObject)Instantiate(slots);
				slot.GetComponent<SlotScript>().slotNumber = Slotamount;
				Slots.Add(slot);
				Items.Add(new Item());
				slot.transform.SetParent(this.gameObject.transform, false);
				slot.name = "Slot" + i + "." + k;
				slot.GetComponent<RectTransform>().localPosition = new Vector3(x, y, 0);
				x = x + 55;
				if(k == 4)
				{
					x = -110;
					y = y - 55;
				}
				
				Slotamount++;
			}
		}
		
		addItem(0);
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
