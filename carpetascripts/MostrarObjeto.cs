using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MostrarObjeto : MonoBehaviour
{
    public GameObject objetoExtra;
    // Start is called before the first frame update
    void Start()
    {
        objetoExtra.gameObject.SetActive(false);
        
    }
    
    public void MostrarPantalla()
    {
        objetoExtra.gameObject.SetActive(true);
    }
}
