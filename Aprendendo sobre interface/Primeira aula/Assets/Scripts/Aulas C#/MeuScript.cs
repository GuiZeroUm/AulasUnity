using System.Collections; //pacotes de c�digos (bibliotecas)
using System.Collections.Generic;
using UnityEngine;

public class MeuScript : MonoBehaviour //MonoBehaviour === conjunto de classes/metodos/variaveis
{

    //declarando variavel
    //quando uma variavel � private, ela n�o pode ser acessada de outro script
    //quando a variavel � public pode-se acessa-la de outro script e pode-se autera-la direto na unity    
    public int vida = 45; //inteiro
    public float forca = 5.1f; //numeros com .
    private bool estaVivo = false; //1 (true) ou 0 (false)
    public string nomeDoPersonagem = "Se leu � gay";

    GameObject player;
    Rigidbody rig;


    // � chamado uma vez ao inicializar
    void Start()
    {
        
    }

    // � chamado a cada frame
    void Update()
    {
        
    }
}