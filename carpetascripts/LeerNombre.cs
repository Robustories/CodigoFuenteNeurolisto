using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeerNombre : MonoBehaviour
{
    public static string input;
    //public InputField usernameInput;
    // Start is called before the first frame update
    void Start()
    {
        //if(input != null){usernameInput.text = input;}
        
    }


    public void ReadStringInput(string s)
    {
        input = s;
        Debug.Log(input);
        GuardarNombre(s);

    }

    public void GuardarNombre(string input)
    {
        Neuro.SetNombre (input);
    }
}
