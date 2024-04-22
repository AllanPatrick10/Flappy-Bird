using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        // vector3.Left sem vai ser -1 no X ou seja, sempre vai para a esquerda * espeed para almentar essa velocidade e o Time.deltaTime para deixar suave essa ação
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
