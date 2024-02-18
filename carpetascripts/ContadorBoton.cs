using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ContadorBoton : MonoBehaviour
{
    [SerializeField]
    private Text message;

    private int buttonPressedCounter = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void MyButtonFunction()
    {
        buttonPressedCounter++;
        if(buttonPressedCounter == 1 )
        {
            message.text = "The button has been pressed" + buttonPressedCounter + "time.";
        }
        else
        {
            message.text = "The button has been pressed" + buttonPressedCounter + "times.";
        }

    }
    
}
