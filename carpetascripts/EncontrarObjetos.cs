using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EncontrarObjetos : MonoBehaviour
{
    public int objetosEncontradosTotal;
    private int objetosEncontrados;
    public Text PuntajePrueba;

    public bool encontrable_1;
    public bool encontrable_2;
    public bool encontrable_3;
    public bool encontrable_4;
    public bool encontrable_5;
    public GameObject encontrado;
    public GameObject chulito1;
    public GameObject chulito2;
    public GameObject chulito3;
    public GameObject chulito4;
    public GameObject chulito5;
    public GameObject Circulo1;
    public GameObject Circulo2;
    public GameObject Circulo3;
    public GameObject Circulo4;
    public GameObject Circulo5;
    public GameObject oCirculo1;
    public GameObject oCirculo2;
    public GameObject oCirculo3;
    public GameObject oCirculo4;
    public GameObject oCirculo5;
    
    // Start is called before the first frame update
    void Start()
    {
        encontrado.gameObject.SetActive(false);
        chulito1.gameObject.SetActive(false);
        chulito2.gameObject.SetActive(false);
        chulito3.gameObject.SetActive(false);
        chulito4.gameObject.SetActive(false);
        chulito5.gameObject.SetActive(false);
        Circulo1.gameObject.SetActive(false);
        Circulo2.gameObject.SetActive(false);
        Circulo3.gameObject.SetActive(false);
        Circulo4.gameObject.SetActive(false);
        Circulo5.gameObject.SetActive(false);
        oCirculo1.gameObject.SetActive(false);
        oCirculo2.gameObject.SetActive(false);
        oCirculo3.gameObject.SetActive(false);
        oCirculo4.gameObject.SetActive(false);
        oCirculo5.gameObject.SetActive(false);
        

        
    }
    

    // Update is called once per frame
   

    public void Encontrar_1()
    {
        encontrable_1 = true;
        chulito1.gameObject.SetActive(true); 
        Circulo1.gameObject.SetActive(true);   
        oCirculo1.gameObject.SetActive(true);   
        //objetosEncontrados++;
        //PuntajePrueba.text = "Puntaje:" + objetosEncontrados;
       
        
    }

    public void Encontrar_2()
    {
        encontrable_2 = true;
        chulito2.gameObject.SetActive(true);  
        Circulo2.gameObject.SetActive(true); 
        oCirculo2.gameObject.SetActive(true); 
    }

    public void Encontrar_3()
    {
        encontrable_3 = true;
        chulito3.gameObject.SetActive(true);  
        Circulo3.gameObject.SetActive(true); 
        oCirculo3.gameObject.SetActive(true); 
    }

    public void Encontrar_4()
    {
        encontrable_4 = true;
        chulito4.gameObject.SetActive(true);  
        Circulo4.gameObject.SetActive(true); 
        oCirculo4.gameObject.SetActive(true); 
    }

    public void Encontrar_5()
    {
        encontrable_5 = true;
        chulito5.gameObject.SetActive(true); 
        Circulo5.gameObject.SetActive(true);  
        oCirculo5.gameObject.SetActive(true); 
    }

    void Update()
    {
        
        if(encontrable_1 && encontrable_2 && encontrable_3 && encontrable_4 && encontrable_5 == true)
        {
            {Invoke ("ContinuarE5", 0.4f);   }
        }
    }

    void ContinuarE5()
    { 
        encontrado.SetActive(true);
    }

}
