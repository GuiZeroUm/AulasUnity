using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Colisions : MonoBehaviour
{

    Rigidbody rig;


    private void Start()
    {
        rig = GetComponent<Rigidbody>();
    }


    private void Update()
    {
        //movendo objeto que tem rigidbody
        //rig.velocity = new Vector3(1f, 0f, 0f);
    }


    //diferente do Update, o FixedUpdate nao necessariamente e chamado a cada frame
    //utilizado normalmente ao trabalhar com a fisica (ex: rigidbody)
    //evita bugs no projeto (como a queda de frames in game)
    private void FixedUpdate()
    {
        //movendo objeto ao precionar botao do teclado
        //GetKey chamado a cada frame enquanto precionar o botao escolhido
        //GetKeyDown e chamdo uma vez quando precionamos o botao
        //GetKeyUp e chamado uma vez apos soltarmos o botao

        //movendo para frente
        if (Input.GetKey(KeyCode.W))
        {
            rig.velocity = new Vector3(1f, 0f, 0f);
        }
        //movendo para tras
        if (Input.GetKey(KeyCode.S))
        {
            rig.velocity = new Vector3(-1f, 0f, 0f);
        }
        //movendo para a esquerda
        if (Input.GetKey(KeyCode.A))
        {
            rig.velocity = new Vector3(0f, 0f, 1f);
        }
        //movendo para a direita
        if (Input.GetKey(KeyCode.D))
        {
            rig.velocity = new Vector3(0f, 0f, -1f);
        }
    }



    ////para utilizar os OnCollision o objeto deve ter o rigidBody e um colisor

    ////detecta colisao no primeiro toque do objeto
    //private void OnCollisionEnter(Collision collision)
    //{
    //    Debug.Log("Enter");
    //}

    ////detecta quando o objeto para de colidir com um outro objeto
    //private void OnCollisionExit(Collision collision)
    //{
    //    Debug.Log("Exit");
    //}

    ////é utilizado enquanto um objeto colide com outro objeto
    //private void OnCollisionStay(Collision collision)
    //{
    //    Debug.Log("Stay!");
    //}
}
