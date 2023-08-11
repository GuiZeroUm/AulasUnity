using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class AulaList : MonoBehaviour
{
    //estrutura basica:
    public List<string> TiposInimigos = new List<string>();


    // Similar a arrays
    void Start()
    {
        //adicionando itens no final lista:
        TiposInimigos.Add("Orc");
        TiposInimigos.Add("Elfo");
        TiposInimigos.Add("Anoes");

        //Contains busca se o item dentro de () existe na lista
        if (TiposInimigos.Contains("Orc"))
        {
            Debug.Log("Existe um Orc!");
        }

        //Insert insere um item na posição desejada
        TiposInimigos.Insert(0, "Lobos");

        //clear limpa TODA a lista:
        //TiposInimigos.Clear();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
