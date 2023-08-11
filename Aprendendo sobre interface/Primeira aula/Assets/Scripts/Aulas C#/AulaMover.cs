using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AulaMover : MonoBehaviour
{

    public float velocidade;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //fazer com que nosso objeto mova na direção e no tempo desejado
        transform.Translate(Vector3.left * Time.deltaTime * velocidade);

        //fazer com que nosso objeto rotacione
        //space.self faz com que o objeto rotacione no proprio eixo
        transform.Rotate(10f,0,0, Space.Self);
    }
}
