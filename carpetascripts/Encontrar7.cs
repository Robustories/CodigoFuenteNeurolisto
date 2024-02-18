using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Encontrar7 : MonoBehaviour
{
    public bool encontrable_71;
    public bool encontrable_72;
    public bool encontrable_73;
    public bool encontrable_74;
    public bool encontrable_75;
    public bool encontrable_76;
    public bool encontrable_77;
    public GameObject encontrado7;
    public GameObject chulito1;
    public GameObject chulito2;
    public GameObject chulito3;
    public GameObject chulito4;
    public GameObject chulito5;
    public GameObject chulito6;
    public GameObject chulito7;
    // Start is called before the first frame update
    void Start()
    {
        encontrado7.gameObject.SetActive(false);
    }
    
    public void Encontrar_71()
    {
        encontrable_71 = true;
        chulito1.gameObject.SetActive(true);  
        //objetosEncontrados++;
        //PuntajePrueba.text = "Puntaje:" + objetosEncontrados;
       
        
    }

    public void Encontrar_72()
    {
        encontrable_72 = true;
        chulito2.gameObject.SetActive(true);  
    }

    public void Encontrar_73()
    {
        encontrable_73 = true;
        chulito3.gameObject.SetActive(true);  
    }

    public void Encontrar_74()
    {
        encontrable_74 = true;
        chulito4.gameObject.SetActive(true);  
    }

    public void Encontrar_75()
    {
        encontrable_75 = true;
        chulito5.gameObject.SetActive(true);  
    }

    public void Encontrar_76()
    {
        encontrable_76 = true;
        chulito6.gameObject.SetActive(true);  
    }

    public void Encontrar_77()
    {
        encontrable_77 = true;
        chulito7.gameObject.SetActive(true);  
    }



    void Update()
    {
        
        if(encontrable_71 && encontrable_72 && encontrable_73 && encontrable_74 && encontrable_75 && encontrable_76 && encontrable_77 == true)
        {
            {Invoke ("ContinuarE7", 0.8f); }
        }
    }

    void ContinuarE7()
    { 
        encontrado7.SetActive(true);
    }

}
