using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AulaIfElse : MonoBehaviour
{

    public float vida;

    //if e else s� podem ser colocados dentro de metodos, como o void Start
    //if deve ter uma condi��o dentro de ()
    void Start()
    {
        
        if (vida <= 0)
        {
            // caso 10 > 1 ir� executar o if
            // caso 10 < 1 ir� executar o else
            Debug.Log("Game Over!");
        } else
        {
            //else executa se a condi��o for falsa
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
