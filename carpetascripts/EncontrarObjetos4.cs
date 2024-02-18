using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EncontrarObjetos4 : MonoBehaviour
{
    public bool encontrable_41;
    public bool encontrable_42;
    public bool encontrable_43;
    public bool encontrable_44;
    
    public Text PuntajePrueba;
    public GameObject chulito1;
    public GameObject chulito2;
    public GameObject chulito3;
    public GameObject chulito4;

    public GameObject encontrado4;
    // Start is called before the first frame update
    void Start()
    {
        encontrado4.gameObject.SetActive(false);
        chulito1.gameObject.SetActive(false);
        chulito2.gameObject.SetActive(false);
        chulito3.gameObject.SetActive(false);
        chulito4.gameObject.SetActive(false);
    }

     public void Encontrar_41()
    {
        encontrable_41 = true;
        chulito1.gameObject.SetActive(true);  
         
        //objetosEncontrados++;
        //PuntajePrueba.text = "Puntaje:" + objetosEncontrados;
       
        
    }

    public void Encontrar_42()
    {
        encontrable_42 = true;
        chulito2.gameObject.SetActive(true);  
        
    }

    public void Encontrar_43()
    {
        encontrable_43 = true;
        chulito3.gameObject.SetActive(true);  
         
    }

    public void Encontrar_44()
    {
        encontrable_44 = true;
        chulito4.gameObject.SetActive(true);  
        
    }

    // Update is called once per frame
    void Update()
    {
        if(encontrable_41 && encontrable_42 && encontrable_43 && encontrable_44  == true)
        {
            {Invoke ("ContinuarE4", 0.8f);  }
        }

        
    }

    void ContinuarE4()
    { 
        encontrado4.SetActive(true);
    }

    
}
