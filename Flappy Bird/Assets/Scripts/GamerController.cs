using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // acessar os elementos de interface de usario da unity

public class GamerController : MonoBehaviour
{
    public int score; // pontu��o 
    public Text scoreText;

     void Start()
    {
        Time.timeScale = 1f;
    }


    public void RestartGame()
    {
        SceneManager.LoadScene(0); // reinicio de cena
    }


}
