using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AulaArray : MonoBehaviour
{
    //utilizada para armazenar varios dados do mesmo tipo

    //Metodo normal, criado manualmente:
    public string inimigo1 = "Orc", inimigo2 = "Elfo", inimigo3 = "Anoes";

    //metodo array:
    public string[] inimigos = new string[] {"Orc", "Elfo", "Anoes"};
    //array de gameobjetc:
    public GameObject[] inimigo;



    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(inimigos[2]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
