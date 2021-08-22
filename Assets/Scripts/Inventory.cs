using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public int sizeOfInventory = 4;
    public InventorySlots[] slots;
    public Image[] imagensSenha;
    public int[] senha, entrada = new int[sizeOfInventory];
    // public List<Item> inventory = new List<Item>();
    private ItemDatabase database;
    private int indexAtual;

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

    public void AddSenha(string itemID){

        int ID = int.Parse(itemID);
        /*
        if(indexAtual < sizeOfInventory

        muda imagem de acordo com o ind
        imagemSenha[indexAtual].sprite = database.items[ID].itemIcon
        entrada[index] = id

        index atual ++

        else

        chama função que compara os arrays senha, entrada
        */
    }

}
