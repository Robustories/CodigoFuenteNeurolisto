using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Encontrar3 : MonoBehaviour
{
    public bool encontrable_31;
    public bool encontrable_32;
    public bool encontrable_33;

    public GameObject chulito1;
    public GameObject chulito2;
    public GameObject chulito3;

    public GameObject circulo1;
    public GameObject circulo2;
    public GameObject circulo3;

    public GameObject ocirculo1;
    public GameObject ocirculo2;
    public GameObject ocirculo3;

    public GameObject encontrado3;


    // Start is called before the first frame update
    void Start()
    {
        encontrado3.gameObject.SetActive(false);
        chulito1.gameObject.SetActive(false);
        chulito2.gameObject.SetActive(false);
        chulito3.gameObject.SetActive(false);
        circulo1.gameObject.SetActive(false);
        circulo2.gameObject.SetActive(false);
        circulo3.gameObject.SetActive(false);
        ocirculo1.gameObject.SetActive(false);
        ocirculo2.gameObject.SetActive(false);
        ocirculo3.gameObject.SetActive(false);
    }

     public void Encontrar_31()
    {
        encontrable_31 = true;
        chulito1.gameObject.SetActive(true);  
        circulo1.gameObject.SetActive(true);
        ocirculo1.gameObject.SetActive(true);
         
        //objetosEncontrados++;
        //PuntajePrueba.text = "Puntaje:" + objetosEncontrados;
       
        
    }

    public void Encontrar_32()
    {
        encontrable_32 = true;
        chulito2.gameObject.SetActive(true); 
        circulo2.gameObject.SetActive(true); 
        ocirculo2.gameObject.SetActive(true);
        
    }

    public void Encontrar_33()
    {
        encontrable_33 = true;
        chulito3.gameObject.SetActive(true);  
        circulo3.gameObject.SetActive(true); 
        ocirculo3.gameObject.SetActive(true);
         
    }


    // Update is called once per frame
    void Update()
    {
        if(encontrable_31 && encontrable_32 && encontrable_33   == true)
        {
            {Invoke ("ContinuarE3", 0.5f);  }
        }
    }

    void ContinuarE3()
    { 
        encontrado3.SetActive(true);
    }
}
