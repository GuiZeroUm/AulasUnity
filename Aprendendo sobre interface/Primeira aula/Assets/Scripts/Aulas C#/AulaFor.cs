using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AulaFor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int contador;
        //tem comando de inicialização
        //Condição
        //Operador de incremento ou decremento
        for (contador = 0; contador < 10; contador++)
        {
            Debug.Log("executou o for pela " + contador);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
