using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//importando biblioteca do canvas
using UnityEngine.UI;

public class CanvasControler : MonoBehaviour
{
    //referenciando o TEXT do meu canvas
    public Text myText;


    public string newText;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            
        }
    }

    public void ChangeText()
    {
        myText.text = newText;
    }
}
