using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{

    Transform player;

    //quanto maior for o smooth, mais rapido a camera segue o player
    public float smooth;


    void Start()
    {
        //                 ache o objeto pela tag  ("")
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // LateUpdate deixa a movimentação mais suave
    void LateUpdate()
    {
        if (player.position.x >= 0)
        {
            //fazendo com que a camera siga o personagem somente no eixo X
            Vector3 following = new Vector3(player.position.x, transform.position.y, transform.position.z);

            //Lerp deixa o movimento da camera mais suave
            transform.position = Vector3.Lerp(transform.position, following, smooth * Time.deltaTime);
        }
        
    }
}
