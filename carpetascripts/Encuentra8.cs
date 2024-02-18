using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Encuentra8 : MonoBehaviour
{
    public bool encontrable_81;
    public bool encontrable_82;
    public bool encontrable_83;
    public bool encontrable_84;
    public bool encontrable_85;
    public bool encontrable_86;
    public bool encontrable_87;
    public bool encontrable_88;
    public GameObject encontrado8;
    public GameObject chulito1;
    public GameObject chulito2;
    public GameObject chulito3;
    public GameObject chulito4;
    public GameObject chulito5;
    public GameObject chulito6;
    public GameObject chulito7;
    public GameObject chulito8;
    public GameObject Circulo18;
    public GameObject Circulo28;
    public GameObject Circulo38;
    public GameObject Circulo48;
    public GameObject Circulo58;
    public GameObject Circulo68;
    public GameObject Circulo78;
    public GameObject Circulo88;
    public GameObject oCirculo81;
    public GameObject oCirculo82;
    public GameObject oCirculo83;
    public GameObject oCirculo84;
    public GameObject oCirculo85;
    public GameObject oCirculo86;
    public GameObject oCirculo87;
    public GameObject oCirculo88;
    // Start is called before the first frame update
    void Start()
    {
        encontrado8.gameObject.SetActive(false);
        chulito1.gameObject.SetActive(false);
        chulito2.gameObject.SetActive(false);
        chulito3.gameObject.SetActive(false);
        chulito4.gameObject.SetActive(false);
        chulito5.gameObject.SetActive(false);
        chulito6.gameObject.SetActive(false);
        chulito7.gameObject.SetActive(false);
        chulito8.gameObject.SetActive(false);
        Circulo18.gameObject.SetActive(false);
        Circulo28.gameObject.SetActive(false);
        Circulo38.gameObject.SetActive(false);
        Circulo48.gameObject.SetActive(false);
        Circulo58.gameObject.SetActive(false);
        Circulo68.gameObject.SetActive(false);
        Circulo78.gameObject.SetActive(false);
        Circulo88.gameObject.SetActive(false);
        oCirculo81.gameObject.SetActive(false);
        oCirculo82.gameObject.SetActive(false);
        oCirculo83.gameObject.SetActive(false);
        oCirculo84.gameObject.SetActive(false);
        oCirculo85.gameObject.SetActive(false);
        oCirculo86.gameObject.SetActive(false);
        oCirculo87.gameObject.SetActive(false);
        oCirculo88.gameObject.SetActive(false);
    }

    // Update is called once per frame

    public void Encontrar_81()
    {
        encontrable_81 = true;
        chulito1.gameObject.SetActive(true);  
        Circulo18.gameObject.SetActive(true);  
        oCirculo81.gameObject.SetActive(true);
        //objetosEncontrados++;
        //PuntajePrueba.text = "Puntaje:" + objetosEncontrados;
       
        
    }

    public void Encontrar_82()
    {
        encontrable_82 = true;
        chulito2.gameObject.SetActive(true);  
        Circulo28.gameObject.SetActive(true);  
        oCirculo82.gameObject.SetActive(true);
    }

    public void Encontrar_83()
    {
        encontrable_83 = true;
        chulito3.gameObject.SetActive(true); 
        Circulo38.gameObject.SetActive(true);  
        oCirculo83.gameObject.SetActive(true); 
    }

    public void Encontrar_84()
    {
        encontrable_84 = true;
        chulito4.gameObject.SetActive(true);  
        Circulo48.gameObject.SetActive(true);  
        oCirculo84.gameObject.SetActive(true); 
    }

    public void Encontrar_85()
    {
        encontrable_85 = true;
        chulito5.gameObject.SetActive(true);  
        Circulo58.gameObject.SetActive(true);  
        oCirculo85.gameObject.SetActive(true); 
    }

    public void Encontrar_86()
    {
        encontrable_86 = true;
        chulito6.gameObject.SetActive(true);  
        Circulo68.gameObject.SetActive(true);  
        oCirculo86.gameObject.SetActive(true); 
    }

    public void Encontrar_87()
    {
        encontrable_87 = true;
        chulito7.gameObject.SetActive(true);  
        Circulo78.gameObject.SetActive(true);  
        oCirculo87.gameObject.SetActive(true); 
    }

    public void Encontrar_88()
    {
        encontrable_88 = true;
        chulito8.gameObject.SetActive(true);  
        Circulo88.gameObject.SetActive(true);  
        oCirculo88.gameObject.SetActive(true); 
    }

    void Update()
    {
        if(encontrable_81 && encontrable_82 && encontrable_83 && encontrable_84 && encontrable_85 && encontrable_86 && encontrable_87 && encontrable_88 == true)
        {
            {Invoke ("ContinuarE8", 0.8f); }
        }
    }

    void ContinuarE8()
    { 
        encontrado8.SetActive(true);
    }
}
