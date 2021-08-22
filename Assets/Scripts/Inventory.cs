using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public int sizeOfInventory = 4;
    public InventorySlots[] slots;
    public Image[] imagensSenha;
    public int[] senha, entrada = new int[4];
    // public List<Item> inventory = new List<Item>();
    private ItemDatabase database;
    private int index;

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
        
        if(index < sizeOfInventory)
        {
            // muda imagem de acordo com o ind
            imagensSenha[index].sprite = database.items[ID].itemIcon;
            entrada[index] = ID;

            index++;
        }


        static bool CompararArray(string[] senha, string[] entrada)
        {
            if (senha.Length != entrada.Length)
            {
                return false;
            }
            for (int i = 0; i < senha.Length; i++)
            {
                if (senha[i] != entrada[i])
                {
                    return false;
                }
            }
            return true;


        
        


        }

        //a função vai comparar se os valores de senha e entrada são iguais. se os valores forem iguais vai retornar como true, caso contrário, retorna como falso





    }

}
