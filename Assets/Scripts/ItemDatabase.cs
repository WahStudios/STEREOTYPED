using UnityEngine;
using System.Collections;
using System.Collections.Generic;
//using UnityEngine.UI;
public class ItemDatabase : MonoBehaviour {

    public List<Item> items = new List<Item>();

    public GameObject item1;
	ItemStats itemStats1;
	public GameObject item2;
	 ItemStats itemStats2;
    public GameObject item3;
	 ItemStats itemStats3;
    public GameObject item4;
	 ItemStats itemStats4;
	public GameObject item5;
	 ItemStats itemStats5;
    public GameObject item6;
 ItemStats itemStats6;
    public GameObject item7;
	 ItemStats itemStats7;
    public GameObject item8;
	 ItemStats itemStats8;
    public GameObject item9;
	 ItemStats itemStats9;
    public GameObject item10;
	 ItemStats itemStats10;
    public GameObject item11;
	ItemStats itemStats11;
    public GameObject item12;
	 ItemStats itemStats12;
    public GameObject item13;
	 ItemStats itemStats13;
	public GameObject item14;
	 ItemStats itemStats14;
	public GameObject item15;
	 ItemStats itemStats15;
	public GameObject item16;
	 ItemStats itemStats16;
	public GameObject item17;
	 ItemStats itemStats17;
	public GameObject item18;
	 ItemStats itemStats18;
	public GameObject item19;
	 ItemStats itemStats19;
	public GameObject item20;
	 ItemStats itemStats20;
	public GameObject item21;
	 ItemStats itemStats21;
	public GameObject item22;
	ItemStats itemStats22;
	public GameObject item23;
	 ItemStats itemStats23;
	public GameObject item24;
	ItemStats itemStats24;
	public GameObject item25;
	ItemStats itemStats25;
	public GameObject item26;
	ItemStats itemStats26;
	public GameObject item27;
	ItemStats itemStats27;
	public GameObject item28;
	ItemStats itemStats28;
	public GameObject item29;
	ItemStats itemStats29;
	public GameObject item30;
	ItemStats itemStats30;
	public GameObject item31;
	ItemStats itemStats31;
	public GameObject item32;
	ItemStats itemStats32;
	public GameObject item33;
	ItemStats itemStats33;
	public GameObject item34;
	ItemStats itemStats34;
	public GameObject item35;
	ItemStats itemStats35;
	public GameObject item36;
	ItemStats itemStats36;
	public GameObject item37;
	ItemStats itemStats37;
	public GameObject item38;
	ItemStats itemStats38;
	public GameObject item39;
	ItemStats itemStats39;
	public GameObject item40;
	ItemStats itemStats40;
	public GameObject item41;
	ItemStats itemStats41;
	public GameObject item42;
	ItemStats itemStats42;
	public GameObject item43;
	ItemStats itemStats43;
	public GameObject item44;
	ItemStats itemStats44;
	public GameObject item45;
	ItemStats itemStats45;
	public GameObject item46;
	ItemStats itemStats46;
	public GameObject item47;
	ItemStats itemStats47;
	public GameObject item48;
	ItemStats itemStats48;
	public GameObject item49;
	ItemStats itemStats49;
	public GameObject item50;
	ItemStats itemStats50;
	public GameObject item51;
	ItemStats itemStats51;
	public GameObject item52;
	ItemStats itemStats52;
	public GameObject item53;
	ItemStats itemStats53;
	public GameObject item54;
	ItemStats itemStats54;
	/*
	public GameObject item25;
	ItemStats itemStats25;
	public GameObject item26;
	ItemStats itemStats26;
	public GameObject item27;
	ItemStats itemStats27;
	public GameObject item28;
	ItemStats itemStats28;
	public GameObject item29;
	ItemStats itemStats29;
	public GameObject item30;

ItemStats itemStats30;
*/
	//public GameObject item25;
	//ItemStats itemStats25;
	// Use this for initializati

	void Start () {
		itemStats1 = item1.GetComponent<ItemStats>();
		itemStats2 = item2.GetComponent<ItemStats>();
		itemStats3 = item3.GetComponent<ItemStats>();
		itemStats4 = item4.GetComponent<ItemStats>();
		itemStats5 = item5.GetComponent<ItemStats>();
		itemStats6 = item6.GetComponent<ItemStats>();
		itemStats7 = item7.GetComponent<ItemStats>();
		itemStats8 = item8.GetComponent<ItemStats>();
		itemStats9 = item9.GetComponent<ItemStats>();
		itemStats10 = item10.GetComponent<ItemStats>();
		itemStats11 = item11.GetComponent<ItemStats>();
		itemStats12 = item12.GetComponent<ItemStats>();
		itemStats13 = item13.GetComponent<ItemStats>();
		itemStats14 = item14.GetComponent<ItemStats>();
		itemStats15 = item15.GetComponent<ItemStats>();
		itemStats16 = item16.GetComponent<ItemStats>();
		itemStats17 = item17.GetComponent<ItemStats>();
		itemStats18 = item18.GetComponent<ItemStats>();
		itemStats19 = item19.GetComponent<ItemStats>();
		itemStats20 = item20.GetComponent<ItemStats>();
		itemStats21 = item21.GetComponent<ItemStats>();
		itemStats22 = item22.GetComponent<ItemStats>();
		itemStats23 = item23.GetComponent<ItemStats>();
		itemStats24 = item24.GetComponent<ItemStats>();
		itemStats25 = item25.GetComponent<ItemStats>();
		itemStats26 = item26.GetComponent<ItemStats>();
		itemStats27 = item27.GetComponent<ItemStats>();
		itemStats28 = item28.GetComponent<ItemStats>();
		itemStats29 = item29.GetComponent<ItemStats>();
		itemStats30 = item30.GetComponent<ItemStats>();
		itemStats31 = item31.GetComponent<ItemStats>();
		itemStats32 = item32.GetComponent<ItemStats>();
		itemStats33 = item33.GetComponent<ItemStats>();
		itemStats34 = item34.GetComponent<ItemStats>();
		itemStats35 = item35.GetComponent<ItemStats>();
		itemStats36 = item36.GetComponent<ItemStats>();
		itemStats37 = item37.GetComponent<ItemStats>();
		itemStats38 = item38.GetComponent<ItemStats>();
		itemStats39 = item39.GetComponent<ItemStats>();
		itemStats40 = item40.GetComponent<ItemStats>();
		itemStats41 = item41.GetComponent<ItemStats>();
		itemStats42 = item42.GetComponent<ItemStats>();
		itemStats43 = item43.GetComponent<ItemStats>();
		itemStats44 = item44.GetComponent<ItemStats>();
		itemStats45 = item45.GetComponent<ItemStats>();
		itemStats46 = item46.GetComponent<ItemStats>();
		itemStats47 = item47.GetComponent<ItemStats>();
		itemStats48 = item48.GetComponent<ItemStats>();
		itemStats49 = item49.GetComponent<ItemStats>();
		itemStats50 = item50.GetComponent<ItemStats>();
		itemStats51 = item51.GetComponent<ItemStats>();
		/*
		itemStats52 = item52.GetComponent<ItemStats>();
		itemStats53 = item53.GetComponent<ItemStats>();
		itemStats54 = item54.GetComponent<ItemStats>();
*/

/*
		itemStats25 = item25.GetComponent<ItemStats>();
		itemStats26 = item26.GetComponent<ItemStats>();
		itemStats27 = item27.GetComponent<ItemStats>();
		itemStats28 = item28.GetComponent<ItemStats>();
		itemStats29 = item29.GetComponent<ItemStats>();
		itemStats30 = item30.GetComponent<ItemStats>();
*/

	
        
		
		items.Add(new Item(item1.name, itemStats1.itemID, itemStats1.itemDesc, itemStats1.itemTypeString));
	
		items.Add(new Item(item2.name, itemStats2.itemID, itemStats2.itemDesc, itemStats2.itemTypeString));

		items.Add(new Item(item3.name, itemStats3.itemID, itemStats3.itemDesc,  itemStats3.itemTypeString));

		items.Add(new Item(item4.name, itemStats4.itemID, itemStats4.itemDesc,  itemStats4.itemTypeString));

		items.Add(new Item(item5.name, itemStats5.itemID, itemStats5.itemDesc,  itemStats5.itemTypeString));

		items.Add(new Item(item6.name, itemStats6.itemID, itemStats6.itemDesc,  itemStats6.itemTypeString));


		items.Add(new Item(item7.name, itemStats7.itemID, itemStats7.itemDesc, itemStats7.itemTypeString));

		items.Add(new Item(item8.name, itemStats8.itemID, itemStats8.itemDesc,itemStats8.itemTypeString));

		items.Add(new Item(item9.name, itemStats9.itemID, itemStats9.itemDesc,  itemStats9.itemTypeString));

		items.Add(new Item(item10.name, itemStats10.itemID, itemStats10.itemDesc, itemStats10.itemTypeString));

		items.Add(new Item(item11.name, itemStats11.itemID, itemStats11.itemDesc, itemStats11.itemTypeString));

		items.Add(new Item(item12.name, itemStats12.itemID, itemStats12.itemDesc,  itemStats12.itemTypeString));

		items.Add(new Item(item13.name, itemStats13.itemID, itemStats13.itemDesc,  itemStats13.itemTypeString));

		items.Add(new Item(item14.name, itemStats14.itemID, itemStats14.itemDesc, itemStats14.itemTypeString));

		items.Add(new Item(item15.name, itemStats15.itemID, itemStats15.itemDesc,itemStats15.itemTypeString));

		items.Add(new Item(item16.name, itemStats16.itemID, itemStats16.itemDesc, itemStats16.itemTypeString));

		items.Add(new Item(item17.name, itemStats17.itemID, itemStats17.itemDesc, itemStats17.itemTypeString));

		items.Add(new Item(item18.name, itemStats18.itemID, itemStats18.itemDesc, itemStats18.itemTypeString));

		items.Add(new Item(item19.name, itemStats19.itemID, itemStats19.itemDesc, itemStats19.itemTypeString));

		items.Add(new Item(item20.name, itemStats20.itemID, itemStats20.itemDesc, itemStats20.itemTypeString));

		items.Add(new Item(item21.name, itemStats21.itemID, itemStats21.itemDesc,itemStats21.itemTypeString));

		items.Add(new Item(item22.name, itemStats22.itemID, itemStats22.itemDesc,  itemStats22.itemTypeString));

		items.Add(new Item(item23.name, itemStats23.itemID, itemStats23.itemDesc,  itemStats23.itemTypeString));

		items.Add(new Item(item24.name, itemStats24.itemID, itemStats24.itemDesc, itemStats24.itemTypeString));

		items.Add(new Item(item25.name, itemStats25.itemID, itemStats25.itemDesc,  itemStats25.itemTypeString));

		items.Add(new Item(item26.name, itemStats26.itemID, itemStats26.itemDesc, itemStats26.itemTypeString));

		items.Add(new Item(item27.name, itemStats27.itemID, itemStats27.itemDesc,  itemStats27.itemTypeString));

		items.Add(new Item(item28.name, itemStats28.itemID, itemStats28.itemDesc, itemStats28.itemTypeString));

		items.Add(new Item(item29.name, itemStats29.itemID, itemStats29.itemDesc, itemStats29.itemTypeString));

		items.Add(new Item(item30.name, itemStats30.itemID, itemStats30.itemDesc, itemStats30.itemTypeString));

		items.Add(new Item(item31.name, itemStats31.itemID, itemStats31.itemDesc, itemStats31.itemTypeString));

		items.Add(new Item(item32.name, itemStats32.itemID, itemStats32.itemDesc,  itemStats32.itemTypeString));

		items.Add(new Item(item33.name, itemStats33.itemID, itemStats33.itemDesc, itemStats33.itemTypeString));

		items.Add(new Item(item34.name, itemStats34.itemID, itemStats34.itemDesc, itemStats34.itemTypeString));

		items.Add(new Item(item35.name, itemStats35.itemID, itemStats35.itemDesc, itemStats35.itemTypeString));

		items.Add(new Item(item36.name, itemStats36.itemID, itemStats36.itemDesc,itemStats36.itemTypeString));

		items.Add(new Item(item37.name, itemStats37.itemID, itemStats37.itemDesc, itemStats37.itemTypeString));

		items.Add(new Item(item38.name, itemStats38.itemID, itemStats38.itemDesc, itemStats38.itemTypeString));

		items.Add(new Item(item39.name, itemStats39.itemID, itemStats39.itemDesc, itemStats39.itemTypeString));

		items.Add(new Item(item40.name, itemStats40.itemID, itemStats40.itemDesc,  itemStats40.itemTypeString));

		items.Add(new Item(item41.name, itemStats41.itemID, itemStats41.itemDesc, itemStats41.itemTypeString));

		items.Add(new Item(item42.name, itemStats42.itemID, itemStats42.itemDesc,itemStats42.itemTypeString));

		items.Add(new Item(item43.name, itemStats43.itemID, itemStats43.itemDesc,  itemStats43.itemTypeString));

		items.Add(new Item(item44.name, itemStats44.itemID, itemStats44.itemDesc, itemStats44.itemTypeString));

		items.Add(new Item(item45.name, itemStats45.itemID, itemStats45.itemDesc,  itemStats45.itemTypeString));

		items.Add(new Item(item46.name, itemStats46.itemID, itemStats46.itemDesc, itemStats46.itemTypeString));

		items.Add(new Item(item47.name, itemStats47.itemID, itemStats47.itemDesc,  itemStats47.itemTypeString));

		items.Add(new Item(item48.name, itemStats48.itemID, itemStats48.itemDesc, itemStats48.itemTypeString));

		items.Add(new Item(item49.name, itemStats49.itemID, itemStats49.itemDesc,  itemStats49.itemTypeString));

		items.Add(new Item(item50.name, itemStats50.itemID, itemStats50.itemDesc, itemStats50.itemTypeString));

		items.Add(new Item(item51.name, itemStats51.itemID, itemStats51.itemDesc, itemStats51.itemTypeString));
	

	}
	
}
