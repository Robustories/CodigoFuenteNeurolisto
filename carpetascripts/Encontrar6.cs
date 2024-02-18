using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Encontrar6 : MonoBehaviour
{
    public int objetosEncontradosTotal;
    private int objetosEncontrados;
    public Text PuntajePrueba;

    public bool encontrable_16;
    public bool encontrable_26;
    public bool encontrable_36;
    public bool encontrable_46;
    public bool encontrable_56;
    public bool encontrable_66;
    public GameObject encontrado6;
    public GameObject chulito16;
    public GameObject chulito26;
    public GameObject chulito36;
    public GameObject chulito46;
    public GameObject chulito56;
    public GameObject chulito66;
    public GameObject Circulo16;
    public GameObject Circulo26;
    public GameObject Circulo36;
    public GameObject Circulo46;
    public GameObject Circulo56;
    public GameObject Circulo66;
    public GameObject oCirculo61;
    public GameObject oCirculo62;
    public GameObject oCirculo63;
    public GameObject oCirculo64;
    public GameObject oCirculo65;
    public GameObject oCirculo66;
    // Start is called before the first frame update
    void Start()
    {
        encontrado6.gameObject.SetActive(false);
        chulito16.gameObject.SetActive(false);
        chulito26.gameObject.SetActive(false);
        chulito36.gameObject.SetActive(false);
        chulito46.gameObject.SetActive(false);
        chulito56.gameObject.SetActive(false);
        chulito66.gameObject.SetActive(false);
        Circulo16.gameObject.SetActive(false);
        Circulo26.gameObject.SetActive(false);
        Circulo36.gameObject.SetActive(false);
        Circulo46.gameObject.SetActive(false);
        Circulo56.gameObject.SetActive(false);
        Circulo66.gameObject.SetActive(false);
        oCirculo61.gameObject.SetActive(false);
        oCirculo62.gameObject.SetActive(false);
        oCirculo63.gameObject.SetActive(false);
        oCirculo64.gameObject.SetActive(false);
        oCirculo65.gameObject.SetActive(false);
        oCirculo66.gameObject.SetActive(false);
    }

       public void Encontrar_1()
    {
        encontrable_16 = true;
        chulito16.gameObject.SetActive(true);  
        Circulo16.gameObject.SetActive(true);  
        oCirculo61.gameObject.SetActive(true);
        //objetosEncontrados++;
        //PuntajePrueba.text = "Puntaje:" + objetosEncontrados;
       
        
    }

    public void Encontrar_2()
    {
        encontrable_26 = true;
        chulito26.gameObject.SetActive(true); 
        Circulo26.gameObject.SetActive(true);   
        oCirculo62.gameObject.SetActive(true);
    }

    public void Encontrar_3()
    {
        encontrable_36 = true;
        chulito36.gameObject.SetActive(true);  
        Circulo36.gameObject.SetActive(true);
        oCirculo63.gameObject.SetActive(true); 
    }

    public void Encontrar_4()
    {
        encontrable_46 = true;
        chulito46.gameObject.SetActive(true);  
        Circulo46.gameObject.SetActive(true); 
        oCirculo64.gameObject.SetActive(true); 
    }

    public void Encontrar_5()
    {
        encontrable_56 = true;
        chulito56.gameObject.SetActive(true);  
        Circulo56.gameObject.SetActive(true); 
        oCirculo65.gameObject.SetActive(true); 
    }
    

    public void Encontrar_6()
    {
        encontrable_66 = true;
        chulito66.gameObject.SetActive(true); 
        Circulo66.gameObject.SetActive(true);  
        oCirculo66.gameObject.SetActive(true); 
    }

    void Update()
    {
        
        if(encontrable_16 && encontrable_26 && encontrable_36 && encontrable_46 && encontrable_56 && encontrable_66 == true)
        {
            {Invoke ("ContinuarE6", 0.8f); }
        }
    }

    void ContinuarE6()
    { 
        encontrado6.SetActive(true);
    }

}
