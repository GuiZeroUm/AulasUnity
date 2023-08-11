using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Classeseconstrutores : MonoBehaviour
{
    //um atributo/metodo nao pode ser acessado de fora da classe caso seja private
    int vida, velocidade;
    Arma espada;

    void Atacar ()
    {

    }

    void Pular ()
    {

    }

    public class Arma
    {
        string nome;
        string tipo;
        
        //construtor da classe
        //
        public Arma(string armaNome, string armaTipo)
        {
            nome = armaNome;
            tipo = armaTipo;
        }

        //unica maneira de ter acesso a uma classe privada, e utilizando um return
        public string getNome()
        {
            return nome;
        }

        //caso queiramos mudar o nome da classe, utilizamos set(Classe)
        //deve ter uma nomeclatura difernete dentro dos paramentros (string Nome)
        public string setNome(string Nome)
        {
            return nome = Nome;
        }
    }

    void Start()
    {
        espada = new Arma("Minha Espada", "Espada");
        Debug.Log(espada);
        Debug.Log(espada.getNome());

        //mudando o nome da espada
        espada.setNome("Agulha");
        Debug.Log("'Minha espada' virou: " + espada.getNome());
    }

}
