using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Encontrar2 : MonoBehaviour
{
    public bool encontrable_21;
    public bool encontrable_22;
    public GameObject chulito1;
    public GameObject chulito2;
    public GameObject encontrado2;
    // Start is called before the first frame update
    void Start()
    {
        encontrado2.gameObject.SetActive(false);
        chulito1.gameObject.SetActive(false);
        chulito2.gameObject.SetActive(false);
    }

     public void Encontrar_21()
    {
        encontrable_21 = true;
        chulito1.gameObject.SetActive(true);  
         
        //objetosEncontrados++;
        //PuntajePrueba.text = "Puntaje:" + objetosEncontrados;
       
        
    }

    public void Encontrar_22()
    {
        encontrable_22 = true;
        chulito2.gameObject.SetActive(true);  
        
    }

    // Update is called once per frame
    void Update()
    {
        if(encontrable_21 && encontrable_22  == true)
        {
            {Invoke ("ContinuarE2", 0.5f);  }
        }
    }

    void ContinuarE2()
    { 
        encontrado2.SetActive(true);
    }
        
    
}
