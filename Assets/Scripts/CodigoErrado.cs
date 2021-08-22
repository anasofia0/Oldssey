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

        tempoInicial = tempoStart;
        bateria = 4;
    }

    private void Update()
    {
        if (!tempoAcabou)
        {
            ContagemRegressiva();
        }

        if (GameObject.FindGameObjectWithTag("Cestinha"))
        {
            Inventorio++;
        }
        else
        {

            bateria -= 1;
        }

        if (GameObject.FindGameObjectWithTag("Pacote_De_Leite"))
        {
            Inventorio++;

        }
        else
        {

            bateria -= 1;
        }

        if (GameObject.FindGameObjectWithTag("Caixa_De_Supermercado"))
        {
            Inventorio++;

        }
        else
        {

            bateria -= 1;
        }

        if (GameObject.FindGameObjectWithTag("Cartao_De_Credito"))
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




        void ContagemRegressiva()
        {
            tempoInicial -= 1 * Time.deltaTime;
            segundos.text = tempoInicial.ToString("0");
            if (tempoInicial >= 30)
            {
                tempoAcabou = false;
            }
            if (tempoInicial < 30)
                tempoAcabou = true;
        }
    }
}

