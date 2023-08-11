using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AulaInstantiateDestroy : MonoBehaviour
{

    public GameObject cubo;

    // Start is called before the first frame update
    void Start()
    {
        //fazendo com que seja criado um objeto na cena, detgerminando sua posi��o e rota��o

        GameObject copiaCubo =  Instantiate(cubo, transform.position, transform.rotation);

        //destruindo objeto ap�s o tempo escolhido (nesse caso 2 segundos)
        Destroy(copiaCubo.gameObject, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
