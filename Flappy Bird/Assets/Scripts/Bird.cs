using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float speed = 1f;
    private Rigidbody2D rig;

    public GameObject gameOver;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // checando se o botão esquerdo do mouse foi clicado.
        {
            rig.velocity = Vector2.up * speed; 
        }
    }

    // colisão do player no cano e game over
    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameOver.SetActive(true); // ativa o hud de game over
        Time.timeScale = 0; // game é pausado 


    }
}
