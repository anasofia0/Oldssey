using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public int sizeOfInventory = 4;
    public InventorySlots[] slots;
    // public List<Item> inventory = new List<Item>();
    private ItemDatabase database;

    void Start()
    {
        database = GameObject.FindGameObjectsWithTag("ItemDatabase")[0].GetComponent<ItemDatabase>();
    }

    public void AddItem(string itemID)
    {
        int ID = int.Parse(itemID);
        int index = 0;
        bool canAdd = false;
        for(int i = 0; i < sizeOfInventory; i++){
            if(slots[i].isEmpty){
                index = i;
                canAdd = true;
                break;
            }
        }
        if(canAdd)
        {
            slots[index].item.sprite = database.items[ID].itemIcon;
            slots[index].isEmpty = false;
            slots[index].ID = ID;
        } else
            Debug.Log("inventário cheio");
    }

}
