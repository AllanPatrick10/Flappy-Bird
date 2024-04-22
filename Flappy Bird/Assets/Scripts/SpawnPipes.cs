using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPipes : MonoBehaviour
{
    public GameObject pipe; // cano
    public float heigth; //Altura
    public float maxTime = 1f; // tempo maximo

    private float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        GameObject newpipe = Instantiate(pipe); // instanciar é criar a cópia do objt vulgo pipe
          // esse newpipe recebe uma nova posição = a posição 0 no eixo X e no eixo Z e a posição Y sera aleatorio entre duas variaveis: -heigth e heigth
        newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-heigth, heigth), 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > maxTime)
        {
            // canos a ser instanciados a cada segundo 
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-heigth, heigth), 0);
            Destroy(newpipe, 20f); // destroi o cone a cada 20s
            timer = 0f;
        }

        timer += Time.deltaTime;
    }

}
