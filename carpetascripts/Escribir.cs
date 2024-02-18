using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escribir : MonoBehaviour
{
    public int valorsuperaractividad;
    public int puntos;
    public int valor1;
    public int valor2;
    public int valor3;
    public int valor4;
    public int valor5;
    public int valor6;
    public int valor7;
    public int valor8;
    public GameObject B1, B2, B3, B4, B5, B6, B7, B8;
    public GameObject ActividadSuperada;

    // Start is called before the first frame update
    void Start()
    {
        ActividadSuperada.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(puntos == valor1)
        {
            B1.gameObject.SetActive(false);
            B2.gameObject.SetActive(true);

        }

        if(puntos == valor2)
        {
            B2.gameObject.SetActive(false);
            B3.gameObject.SetActive(true);

        }

        if(puntos == valor3)
        {
            B3.gameObject.SetActive(false);
            B4.gameObject.SetActive(true);

        }

        if(puntos == valor4)
        {
            B4.gameObject.SetActive(false);
            B5.gameObject.SetActive(true);

        }

        if(puntos == valor5)
        {
            B5.gameObject.SetActive(false);
            B6.gameObject.SetActive(true);

        }

        if(puntos == valor6)
        {
            B6.gameObject.SetActive(false);
            B7.gameObject.SetActive(true);

        }

        if(puntos == valor7)
        {
            B7.gameObject.SetActive(false);
            B8.gameObject.SetActive(true);

        }

        

        if(puntos >= valorsuperaractividad)
        {
            ActividadSuperada.gameObject.SetActive(true);

        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
         if (other.gameObject.tag ==("1")) 
         {
            Destroy(other.gameObject);
            puntos = puntos + 1;

         } 

         if (other.gameObject.tag ==("2") && puntos >= valor1) 
         {
            Destroy(other.gameObject);
            puntos = puntos + 1;

         }

         if (other.gameObject.tag ==("3") && puntos >= valor2) 
         {
            Destroy(other.gameObject);
            puntos = puntos + 1;

         }

         if (other.gameObject.tag ==("4") && puntos >= valor3) 
         {
            Destroy(other.gameObject);
            puntos = puntos + 1;

         }

         if (other.gameObject.tag ==("5") && puntos >= valor4) 
         {
            Destroy(other.gameObject);
            puntos = puntos + 1;

         }

         if (other.gameObject.tag ==("6") && puntos >= valor5) 
         {
            Destroy(other.gameObject);
            puntos = puntos + 1;

         }

         if (other.gameObject.tag ==("7") && puntos >= valor6) 
         {
            Destroy(other.gameObject);
            puntos = puntos + 1;

         }

         if (other.gameObject.tag ==("8") && puntos >= valor7) 
         {
            Destroy(other.gameObject);
            puntos = puntos + 1;

         }
    
        //Destroy(other.gameObject);
        //puntos = puntos + 1;
        
        
    }
}
