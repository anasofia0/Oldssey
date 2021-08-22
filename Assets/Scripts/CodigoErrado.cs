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
    //private Touch toqueTela;
    public Sprite [] baterias = new Sprite[4];
    public Image bateriaImagem;
    public float tempoInicial, tempoStart;
    public bool tempoAcabou;
    public Text segundos;
    private int vida_personagem;
    private int bateria = 4;


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

        if (bateria == 0)
        {
            //chamar game over aqui
            Debug.Log("Gameover");
        }

    }

    public void ContagemRegressiva()
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

    public void TiraBateria(){
        Debug.Log(bateria);
        bateria--;
        bateriaImagem.sprite = baterias[bateria-1];
    }


}
