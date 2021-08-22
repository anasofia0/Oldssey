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
    public int[] senha = new int[4], entrada = new int[4];
    public bool podeBotar = false;
    public CodigoErrado codigoErrado;
    // public List<Item> inventory = new List<Item>();
    private ItemDatabase database;
    private int indexSenha;

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

    public void AddSenha(string indexBotaoPress){


        int indexBotao = int.Parse(indexBotaoPress);
        if(podeBotar){
            int ID = slots[indexBotao].ID;

            if(indexSenha < sizeOfInventory)
            {
                // muda imagem de acordo com o ind
                imagensSenha[indexSenha].sprite = database.items[ID].itemIcon;
                entrada[indexSenha] = ID;

                indexSenha++;
            }
            if(indexSenha >= 4){
                if(CompararArray()){
                    Debug.Log("GANHOU MINHE QUERIDE");
                    // ganhou
                    // chamar tela/cena de vitória aqui
                } else {
                    codigoErrado.TiraBateria();
                }
            }
        }
    }

    private bool CompararArray()
    {
        for (int i = 0; i < 4; i++)
        {
            if (senha[i] != entrada[i])
            {
                return false;
            }
        }
        return true;
    }

    public void Clear(){
        for(int i = 0; i < 4; i++){
            imagensSenha[i].sprite = null;
            entrada[i] = -1;
        }
        indexSenha = 0;
    }

    public void AtivaSenhaInventario(){
        podeBotar = true;
    }


    public void DesativaSenhaInventario(){
        podeBotar = false;
    }
}
