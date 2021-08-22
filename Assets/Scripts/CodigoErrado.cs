using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

#pragma strict

public class CodigoErrado : MonoBehaviour

{
    private Touch toqueTela;
    public GameObject player;
    public float tempoInicial, tempoStart;
    public bool tempoAcabou;
    public Text segundos;
    private int vida_personagem;
    private int bateria = 4;
    private int Inventorio;


    private void Start()
    {
        toqueTela = new Touch { fingerId = -1 };
        tempoInicial = tempoStart;
        bateria = 4;
    }

    private void Update()
    {
        if (!tempoAcabou)
        {
            ContagemRegressiva();
        }

        if (player.CompareTag("Cestinha"))
        {
            Inventorio++;
        }
        else
        {
            
            bateria -= 1;
        }

        if (player.CompareTag("Pacote_De_Leite"))
        {
            Inventorio++;
            
        }
        else
        {
            
            bateria -= 1;
        }

        if (player.CompareTag("Caixa_De_Supermercado"))
        {
            Inventorio++;

        }
        else
        {
           
            bateria -= 1;
        }

        if (player.CompareTag("Cartao_De_Credito"))
        {
            Inventorio++;

        }
        else
        {

            bateria -= 1;
        }

        if (bateria == 0)
        {
            Debug.Log("Gameover");
        }



    

        if(Input.touchCount > 0)
        {
            for(int a = 0; a < Input.touchCount; a++)
            {
                if(toqueTela.fingerId == -1)
                {
                    if (Input.GetTouch(a).position.x < Screen.width / 2 && Input.GetTouch(a).position.y < Screen.height / 2)
                    {
                        toqueTela = Input.GetTouch(a);
                    }
                }
                
                    
            }
        }
    }

         
           

    void ContagemRegressiva()
    {
        tempoInicial -= 1 * Time.deltaTime;
        segundos.text = tempoInicial.ToString("0");
        if(tempoInicial >= 30)
        {
            tempoAcabou = false;
        }
        if (tempoInicial < 30)
            tempoAcabou = true;
    }
}
