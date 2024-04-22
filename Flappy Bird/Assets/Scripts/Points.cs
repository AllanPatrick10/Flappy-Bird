using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    public GamerController controller;

     void Start()
    {
        controller = FindAnyObjectByType<GamerController>();
    }


    private void OnTriggerEnter2D(Collider2D collision) // colisor para checar se o bird passou entre os cones
    {
        controller.score++; // adiciona pontuação 
        controller.scoreText.text = controller.score.ToString();

    }
}
