using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //criando variavel para velocidade
    public float speed;
    //criando variavel para for�a do pulo
    public float JumpForce;
    //criando variavel para detectar se o player esta executando um pulo duplo
    bool doubleJumple;
    //criando variavel para detectar se o player esta pulando
    bool isJumping;

    bool isfire;

    public GameObject bow;
    public Transform firePoint;

    //colocando o Rigidbody2D dentro de uma variavel (rig)
    Rigidbody2D rig;
    //colocando o Animator dentro de uma variavel (ani)
    Animator anim;

    float movement;

    void Start()
    {

        rig = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        Jump();
        BowFire();
    }

    private void FixedUpdate()
    {
        Move();
    }

    //criando uma fun��o para o movimento do player
    void Move ()
    {
        //se nao precionar nada o valor � 0
        //precionar direita o valor maximo � 1
        //precionar esquerda valor maximo � -1
        movement = Input.GetAxis("Horizontal");
        
        //mexendo na velocidade | movimento*velocidade | deixando o personagem na posi��o Y dele mesmo
        rig.velocity = new Vector2(movement * speed, rig.velocity.y);

        if (movement > 0)
        {
            if (isJumping == false)
            {
                //adicionando anima��o de correr ao personagem caso o pulo n�o esteja sendo executado
                anim.SetInteger("Transition", 1);
            }

            //deixando o sprite virado para a direita
            //                                  X   Y   Z
            transform.eulerAngles = new Vector3 (0, 0, 0);
        }

        if (movement < 0)
        {
            if (isJumping == false)
            {
                //adicionando anima��o de correr ao personagem caso o pulo n�o esteja sendo executado
                anim.SetInteger("Transition", 1);
            }
            //deixando o sprite virado para a esquerda
            //                                  X   Y   Z
            transform.eulerAngles = new Vector3(0, 180, 0);
        }

        if(movement == 0 && isJumping == false && !isfire)
        {
            //se o personagem estiver parado e n�o estiver pulando, ele ira executar a anima��o 'idle'
            anim.SetInteger("Transition", 0);
        }

    }

    //criando uma fun��o para o pulo do player
    void Jump ()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (isJumping == false)
            {
                anim.SetInteger("Transition", 2);
                //vai pegar o personagem e "ARREMESSAR" ele
                rig.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
                doubleJumple = true;
                isJumping = true;
            }
            else
            {
                if (doubleJumple == true)
                {
                    anim.SetInteger("Transition", 2);
                    //vai pegar o personagem e "ARREMESSAR" ele
                    rig.AddForce(new Vector2(0, JumpForce * 1), ForceMode2D.Impulse);
                    doubleJumple = false;
                }
            }
        }
    }

    void BowFire()
    {
        //chamando a courrotina
        StartCoroutine("Fire");
    }

    //criando uma courrotina para determinar o tempo entre uma anima��o e outra
    IEnumerator Fire ()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            isfire = true;
            anim.SetInteger("Transition", 3);
            GameObject Bow = Instantiate(bow, firePoint.position, firePoint.rotation);

            if (transform.position.y >= 0)
            {
                Bow.GetComponent<Bow>().isRight = true;
            }

            if (transform.position.y == 180)
            {
                Bow.GetComponent<Bow>().isRight = false;
            }

            yield return new WaitForSeconds(0.2f);
            isfire = false;
            anim.SetInteger("Transition", 0);
        }
    }

    //OnCollisionEnter � chamado toda vez que nosso objeto toca em outro objeto
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //player so pode pular novamente caso ele encoste no ch�o(8)
        if (collision.gameObject.layer == 8)
        {
            isJumping = false;
        }
    }

}
