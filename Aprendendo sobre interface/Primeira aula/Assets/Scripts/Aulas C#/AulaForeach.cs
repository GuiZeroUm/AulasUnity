using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AulaForeach : MonoBehaviour
{

    public string[] nomesNPC = new string[3];
    public List<string> nomesInimigos = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        nomesNPC[0] = "Mark";
        nomesNPC[1] = "Robb";
        nomesNPC[2] = "Julia";

        nomesInimigos.Add("Duratan");
        nomesInimigos.Add("Sauron");
        nomesInimigos.Add("Peter");

        //Foreach percorre colecoes
        //foreach deve ter um item da coleção in colecao
        foreach (string elemento in nomesNPC)
        {
            //vai retornar Mark, Robb e Julia
            Debug.Log(elemento);
        }
        foreach (string elemento in nomesInimigos)
        {
            //vai retornar Duratan, Sauron e Peter
            Debug.Log(elemento);
        }

        //utilizando for
        //Listas utilizam o .Count
        //Arrays utilizam o .Length
        //for (int i = 0; i < nomesNPC.Length; i++)
        //{
        //    Debug.Log(nomesNPC[i]);
        //}

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
