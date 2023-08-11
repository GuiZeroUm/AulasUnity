using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AulaVector : MonoBehaviour
{

    //vector armazenam posições em x y e z
    //Vector2 cria uma variavel com valores X e Y
    //usado em jogos 2D
    public Vector2 pos;

    //vector 3 cria uma variavel com valores X Y e Z
    //usado em jogos 3D
    public Vector3 pos2;

    // Start is called before the first frame update
    void Start()
    {
        //                  X   Y   Z
        pos2 = new Vector3(1f, 1f, 1f);

        //podemos acessar de forma individual um valor de nosso valor
        pos2.y = 10f;

        //transform.position move um objeto para a posição desejada
        transform.position = pos2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
