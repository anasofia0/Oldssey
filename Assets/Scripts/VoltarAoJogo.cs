using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VoltarAoJogo : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene("inicial_menu");
    }
}
