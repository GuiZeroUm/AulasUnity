using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AulaIfElse : MonoBehaviour
{

    public float vida;

    //if e else só podem ser colocados dentro de metodos, como o void Start
    //if deve ter uma condição dentro de ()
    void Start()
    {
        
        if (vida <= 0)
        {
            // caso 10 > 1 irá executar o if
            // caso 10 < 1 irá executar o else
            Debug.Log("Game Over!");
        } else
        {
            //else executa se a condição for falsa
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
