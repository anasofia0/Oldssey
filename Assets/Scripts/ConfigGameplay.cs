using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConfigGameplay : MonoBehaviour
{
    public AudioSource Audio;
    public GameObject PanelCredits;
    public GameObject PanelConfig;

    public void CloseCredits()
    {
        if (PanelCredits != null)
        {
            PanelCredits.SetActive(false);
        }
        Debug.Log("Créditos fechado");
    }

    public void CloseConfig()
    {
        if (PanelConfig != null)
        {
            PanelConfig.SetActive(false);
        }
        Debug.Log("Configurações fechadas");
    }

    public void ChangeSound()
    {
        if (GameObject.Find("ButtonSound").GetComponentInChildren<Text>().text == "Sound ON")
        {
            GameObject.Find("ButtonSound").GetComponentInChildren<Text>().text = "Sound OFF";
            Debug.Log("Sound off");
        }
        else
        {
            GameObject.Find("ButtonSound").GetComponentInChildren<Text>().text = "Sound ON";
            Debug.Log("Sound on");
        }
    }
    public void ChangeMusic()
    {
        if (Audio.isPlaying)
        {
            Audio.Pause();
            GameObject.Find("ButtonMusic").GetComponentInChildren<Text>().text = "Music OFF";
        }
        else
        {
            Audio.Play();
            GameObject.Find("ButtonMusic").GetComponentInChildren<Text>().text = "Music ON";
        }
    }
}
