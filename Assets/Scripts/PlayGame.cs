using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayGame : MonoBehaviour {

        public GameObject PanelCredits;
        public GameObject PanelConfig;

        public void StartGame() {
                    Debug.Log("Começa a cutscene!");
        }
        public void ShowConfig() {
               if(PanelConfig != null) {
                        PanelConfig.SetActive(true);
                }   
                Debug.Log("Abriu config");  
        }

        public void ShowCredits() {
                if(PanelCredits != null) {
                        PanelCredits.SetActive(true);
                }
                Debug.Log("Abriu créditos");
                    
        }

        public void CloseCredits() {
              if(PanelCredits != null) {
                        PanelCredits.SetActive(false);
                }
              Debug.Log("Créditos fechado");  
        }

        public void CloseConfig() {
              if(PanelConfig != null) {
                        PanelConfig.SetActive(false);
                }
              Debug.Log("Configurações fechadas");  
        }

        public void ChangeSound() {
              if (GameObject.Find("ButtonSound").GetComponentInChildren<Text>().text == "Sound ON") {
                        GameObject.Find("ButtonSound").GetComponentInChildren<Text>().text = "Sound OFF";
                        Debug.Log("Sound off");  
              } else {
                        GameObject.Find("ButtonSound").GetComponentInChildren<Text>().text = "Sound ON";
                        Debug.Log("Sound on");  
              }
        }
        public void ChangeMusic() {
              if (GameObject.Find("ButtonMusic").GetComponentInChildren<Text>().text == "Music ON") {
                        GameObject.Find("ButtonMusic").GetComponentInChildren<Text>().text = "Music OFF";
                        Debug.Log("Music off");  
              } else {
                        GameObject.Find("ButtonMusic").GetComponentInChildren<Text>().text = "Music ON";
                        Debug.Log("Music on");  
              }
        }
}
