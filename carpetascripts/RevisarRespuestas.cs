using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RevisarRespuestas : MonoBehaviour
{
    private bool correcto33;
    //private bool incorrecto33;
    public GameObject pantallaContinuar33;
    public Button rojo;
    //public GameObject pantallaRepetir33;
    // Start is called before the first frame update
    void Start()
    {
        pantallaContinuar33.gameObject.SetActive(false); 
        //pantallaRepetir33.gameObject.SetActive(false); 
    }


    public void RespuestaCorrecta()
    {
        correcto33 = true;
        //incorrecto33 = false;
    }

    public void RespuestaIncorrecta()
    {
        correcto33 = false;
        //incorrecto33 = true;

    }

    public void RevisarlasRespuestas()
    {
        if(correcto33 == true)
        {
            pantallaContinuar33.gameObject.SetActive(true); 
        }

        if(correcto33 == false)
        {
            Rojo();
        }

    }

    public void Escoger()
    {
        pantallaContinuar33.gameObject.SetActive(true); 
    }
    
    void Rojo()
    {
        rojo.interactable = false;
        Invoke("Retornar", 0.8f);
    }

    void Retornar()
    {
        rojo.interactable = true;
    }



    
}
