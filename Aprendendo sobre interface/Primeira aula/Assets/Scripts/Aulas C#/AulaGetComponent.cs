using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AulaGetComponent : MonoBehaviour
{

    public Rigidbody rig;
    BoxCollider box;

    // Start is called before the first frame update
    void Start()
    {
        //getcomponent é utilizado para acessar um componente que exista dentro do nosso GameObject
        rig = GetComponent<Rigidbody>();
        box = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
