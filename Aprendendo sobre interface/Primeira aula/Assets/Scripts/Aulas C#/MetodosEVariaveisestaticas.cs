using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetodosEVariaveisestaticas : MonoBehaviour
{
    //uma variavel estatica e compartilhada com todos os scrips da classe
    public static int contadorInimigos = 0;

    public int vida;

    public static MetodosEVariaveisestaticas meuInimigo;



    //um metodo estatico é chamado mesmo que nao exista um elemento na classe
    //nao e possivel acessar variaveis nao estaticas
    public static int Adicionar(int num1, int num2)
    {
        return num1 + num2;
    }

    private void Start()
    {
        //this vai atribuir o valor de meuInimigo a ele mesmo
        meuInimigo = this;
    }
}
