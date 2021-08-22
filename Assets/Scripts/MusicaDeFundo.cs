using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicaDeFundo : MonoBehaviour
{
    public static AudioClip background, gameover;
    static AudioSource audioScr;

    void Start()
    {
        background = Resources.Load<AudioClip>("MusicaDeFundo");
        

        audioScr = GetComponent<AudioSource>();


    }



}
