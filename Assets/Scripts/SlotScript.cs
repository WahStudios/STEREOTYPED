using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SlotScript : MonoBehaviour, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler, IDragHandler{

    public Item item;
    Image itemImage;
    public int slotNumber;
    Inventory inventory;
//	public EvilBadStats evilBadStats;
	public bool isEquipped = false;
	public bool isUnEquipped = true;
	// Use this for initialization
	void Start () {
		//evilBadStats = GameObject.FindGameObjectWithTag("Player").GetComponent<EvilBadStats>();
        inventory = GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>();
        itemImage = gameObject.transform.GetChild(0).GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {


        if(inventory.Items[slotNumber].itemName != null)
        {
           
			item = inventory.Items[slotNumber];
            itemImage.enabled = true;
            itemImage.sprite = inventory.Items[slotNumber].ItemIcon;

		
				



        }
        else
        {
			//isEquipped = false;
			//isUnEquipped = true;
            itemImage.enabled = false;
        }





    }


	public void OnDrag(PointerEventData data)
	{
		if(inventory.Items[slotNumber].itemName != null)
		{
			inventory.showDraggedItem(inventory.Items[slotNumber], slotNumber);

			inventory.Items[slotNumber] = new Item();
		}
	}

	public void OnPointerDown(PointerEventData data)
    {
        

		if(inventory.Items[slotNumber].itemName == null && inventory.draggingItem)
		{
			if(slotNumber <8){
			inventory.Items[slotNumber] = inventory.draggedItem;
			inventory.closeDraggedItem();
			}
			else if(slotNumber >= 8 && slotNumber <= 12){
			
				if(inventory.draggedItem.itemType == "ArmorMod"){
					inventory.Items[slotNumber] = inventory.draggedItem;
					inventory.closeDraggedItem();
				}
			}else if(slotNumber >= 13 && slotNumber <= 18){
				if(inventory.draggedItem.itemType == "WeaponMod"){
					inventory.Items[slotNumber] = inventory.draggedItem;
					inventory.closeDraggedItem();
				}
			}else if(slotNumber >= 19 && slotNumber <= 22){
				if(inventory.draggedItem.itemType == "GrenadeMod"){
					inventory.Items[slotNumber] = inventory.draggedItem;
					inventory.closeDraggedItem();
				}
			}

		}
		else if(inventory.draggingItem && inventory.Items[slotNumber].itemName != null)
		{
			if(slotNumber < 8){
				inventory.Items[inventory.indexOfDraggedItem] = inventory.Items[slotNumber];
				inventory.Items[slotNumber] = inventory.draggedItem;
				//isEquipped = false;
				inventory.closeDraggedItem();
			}
			else if(slotNumber >= 8 && slotNumber <= 12){ //weapon
				//Debug.Log (item.itemType);
				if(inventory.draggedItem.itemType == "ArmorMod"){
				
					inventory.Items[inventory.indexOfDraggedItem] = inventory.Items[slotNumber];
					inventory.Items[slotNumber] = inventory.draggedItem;
					isEquipped = false;
					inventory.closeDraggedItem();

				}
			}else if(slotNumber >= 13 && slotNumber <= 18){ //chest
				if(inventory.draggedItem.itemType == "WeaponMod"){

					inventory.Items[inventory.indexOfDraggedItem] = inventory.Items[slotNumber];
					inventory.Items[slotNumber] = inventory.draggedItem;
					isEquipped = false;
					inventory.closeDraggedItem();
					
				}
			}
			else if(slotNumber >= 19 && slotNumber <= 22){ //neck
				if(inventory.draggedItem.itemType == "GrenadeMod"){
				
					inventory.Items[inventory.indexOfDraggedItem] = inventory.Items[slotNumber];
					inventory.Items[slotNumber] = inventory.draggedItem;
					isEquipped = false;
					inventory.closeDraggedItem();
				}
			}

		}
	}


			





			
			//isEquipped = true;
		//}
			//Debug.Log ("dragging");
		

	public void OnPointerEnter(PointerEventData data)
    {
        if(inventory.Items[slotNumber].itemName != null && !inventory.draggingItem)
		{
			inventory.showTooltip(inventory.Slots[slotNumber].GetComponent<RectTransform>().localPosition, inventory.Items[slotNumber]);
		

		}


    }

	public void OnPointerStay(PointerEventData data)
	{

	}
	public void OnPointerExit(PointerEventData data)
	{
		if(inventory.Items[slotNumber].itemName != null){
		inventory.closeTooltip();

		}
	}

   
}
