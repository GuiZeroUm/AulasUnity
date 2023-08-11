using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //GetMouseButton e chamado sempre que o mouse esta sendo clicado
        //GetMouseButtonDown e chamado apenas uma vez ao clicar com o mouse
        //GetMouseButtonUp e chamado apenas uma vez quando soltamos o clique do mouse
        if (Input.GetMouseButton(0))
        {
            Debug.Log("Clicou!");
        }
    }

    //OnMouseDown é chamado quando o botao do mouse clicado
    private void OnMouseDown()
    {
        Debug.Log("Down");
    }

    //OnMouseDrag é chamado enquanto o botao do mouse e clicado
    private void OnMouseDrag()
    {
        Debug.Log("Drag");
    }

    //OnMouseDown é chamado quando o botao do mouse solto
    private void OnMouseUp()
    {
        Debug.Log("Up");
    }

    //OnMouseDown é chamado quando o mouse sai de cima do objeto
    private void OnMouseExit()
    {
        Debug.Log("Exit");
    }
}
