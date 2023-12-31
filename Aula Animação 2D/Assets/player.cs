using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    public float speed;
    private Rigidbody2D rig;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            anim.SetBool("IsATK", true);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            anim.SetBool("IsATK", false);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rig.velocity = Vector2.right * speed;
            anim.SetBool("IsRUN", true);
            transform.eulerAngles = new Vector2(0f, 180f);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rig.velocity = Vector2.left * speed;
            anim.SetBool("IsRUN", true);
            transform.eulerAngles = new Vector2(0f, 0f);
        }
        else
        {
            anim.SetBool("IsRUN", false);
        }
    }
}
