using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metodos : MonoBehaviour
{
    public string nome;
    int vida;
    int velocidade;
    int forcaPulo;

    private void Start()
    {
        Atacar();
        DefinirNome();
    }

    //void nao necessariamente precissa retornar algo
    //normalmente e utilizado o Void para criar metodos
    void Atacar ()
    {
        Debug.Log("Ola mundo!");
    }
    
    //existe diversos tipos de metodos com propositos diferentes, por exemplo:
    //Int para retornar valor inteiro
    //Float para retornar valor "Quebrado"
    //bool para retornar true ou false
    //string para retornar texto
    //void que nao necessariamente precissa retornar algo
    string DefinirNome()
    {
        nome = "Player 1";
        return nome;
    }

}
