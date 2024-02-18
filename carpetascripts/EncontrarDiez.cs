using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncontrarDiez : MonoBehaviour
{
    public bool encontrable_101;
    public bool encontrable_102;
    public bool encontrable_103;
    public bool encontrable_104;
    public bool encontrable_105;
    public bool encontrable_106;
    public bool encontrable_107;
    public bool encontrable_108;
    public bool encontrable_109;
    public bool encontrable_1010;
    public GameObject encontrado10;
    public GameObject chulito101;
    public GameObject chulito102;
    public GameObject chulito103;
    public GameObject chulito104;
    public GameObject chulito105;
    public GameObject chulito106;
    public GameObject chulito107;
    public GameObject chulito108;
    public GameObject chulito109;
    public GameObject chulito1010;
    public GameObject Circulo1;
    public GameObject Circulo2;
    public GameObject Circulo3;
    public GameObject Circulo4;
    public GameObject Circulo5;
    public GameObject Circulo6;
    public GameObject Circulo7;
    public GameObject Circulo8;
    public GameObject Circulo9;
    public GameObject Circulo10;
    // Start is called before the first frame update
    void Start()
    {
        encontrado10.gameObject.SetActive(false);
        chulito101.gameObject.SetActive(false);
        chulito102.gameObject.SetActive(false);
        chulito103.gameObject.SetActive(false);
        chulito104.gameObject.SetActive(false);
        chulito105.gameObject.SetActive(false);
        chulito106.gameObject.SetActive(false);
        chulito107.gameObject.SetActive(false);
        chulito108.gameObject.SetActive(false);
        chulito109.gameObject.SetActive(false);
        chulito1010.gameObject.SetActive(false);
        Circulo1.gameObject.SetActive(false);
        Circulo2.gameObject.SetActive(false);
        Circulo3.gameObject.SetActive(false);
        Circulo4.gameObject.SetActive(false);
        Circulo5.gameObject.SetActive(false);
        Circulo6.gameObject.SetActive(false);
        Circulo7.gameObject.SetActive(false);
        Circulo8.gameObject.SetActive(false);
        Circulo9.gameObject.SetActive(false);
        Circulo10.gameObject.SetActive(false);
    }

    
    

    public void Encontrar_101()
    {
        encontrable_101 = true;
        chulito101.gameObject.SetActive(true);  
        Circulo1.gameObject.SetActive(true);  
        //objetosEncontrados++;
        //PuntajePrueba.text = "Puntaje:" + objetosEncontrados;
       
        
    }

    public void Encontrar_102()
    {
        encontrable_102 = true;
        chulito102.gameObject.SetActive(true);  
        Circulo2.gameObject.SetActive(true); 
    }

    public void Encontrar_103()
    {
        encontrable_103 = true;
        chulito103.gameObject.SetActive(true);  
        Circulo3.gameObject.SetActive(true);  
    }

    public void Encontrar_104()
    {
        encontrable_104 = true;
        chulito104.gameObject.SetActive(true);  
        Circulo4.gameObject.SetActive(true);  
    }

    public void Encontrar_105()
    {
        encontrable_105 = true;
        chulito105.gameObject.SetActive(true);  
        Circulo5.gameObject.SetActive(true);  
    }

    public void Encontrar_106()
    {
        encontrable_106 = true;
        chulito106.gameObject.SetActive(true);  
        Circulo6.gameObject.SetActive(true);  
    }

    public void Encontrar_107()
    {
        encontrable_107 = true;
        chulito107.gameObject.SetActive(true);  
        Circulo7.gameObject.SetActive(true);  
    }

    public void Encontrar_108()
    {
        encontrable_108 = true;
        chulito108.gameObject.SetActive(true);  
        Circulo8.gameObject.SetActive(true);  
    }

    public void Encontrar_109()
    {
        encontrable_109 = true;
        chulito109.gameObject.SetActive(true);  
        Circulo9.gameObject.SetActive(true);  
    }

    public void Encontrar_1010()
    {
        encontrable_1010 = true;
        chulito1010.gameObject.SetActive(true);  
        Circulo10.gameObject.SetActive(true);  
    }

    void Update()
    {
        if(encontrable_101 && encontrable_102 && encontrable_103 && encontrable_104 && encontrable_105 && encontrable_106 && encontrable_107 && encontrable_108 && encontrable_109 && encontrable_1010 == true)
        {
            {Invoke ("ContinuarE10", 0.8f);  }
        }
    }

    void ContinuarE10()
    { 
        encontrado10.SetActive(true);
    }
}
