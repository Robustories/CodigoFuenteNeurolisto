using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archivoguardado : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Inicio" ,0.1f);
        
    }
    
    void Inicio()
    {
        Debug.Log(Application.persistentDataPath);
    }
}
