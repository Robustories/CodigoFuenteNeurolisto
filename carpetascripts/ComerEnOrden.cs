using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComerEnOrden : MonoBehaviour
{
    public GameObject L1, L2, L3, L4, L5, L6, L7, L8, L9, L10, L11, L12, L13, L14, L15, L16;
    public GameObject B1, B2, B3, B4, B5, B6, B7, B8, B9, B10, B11, B12, B13, B14, B15;
    public static int Score47;
    public static bool fallo;
    bool D2, D3, D4, D5, D6, D7, D8, D9, D10, D11, D12, D13, D14, D15, Terminado;
    Linea lineas;
    public GameObject LineaU;
    public GameObject Imagen;
    // Start is called before the first frame update
    void Start()
    {
        LineaU.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Terminado == true)
        {
            Invoke ("AparecerImagen", 0.4f);
            Invoke ("Limpiar", 0.8f);
            Invoke ("ActividadCompleta", 2f);

        }
        
        
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.tag ==("1")) 
         {
            L1.gameObject.SetActive(false);
            L2.gameObject.SetActive(true);
            D2 = true;
         }

         else if (other.gameObject.tag ==("2") && D2 == true) 
         {
            L2.gameObject.SetActive(false);
            L3.gameObject.SetActive(true);
            D3 = true;

         }

         else if (other.gameObject.tag ==("3") && D3 == true) 
         {
            L3.gameObject.SetActive(false);
            L4.gameObject.SetActive(true);
            D4 = true;

         }

         else if (other.gameObject.tag ==("4") && D4 == true) 
         {
            L4.gameObject.SetActive(false);
            L5.gameObject.SetActive(true);
            D5 = true;

         }

         else if (other.gameObject.tag ==("5") && D5 == true) 
         {
            L5.gameObject.SetActive(false);
            L6.gameObject.SetActive(true);
            D6 = true;

         }

         else if (other.gameObject.tag ==("6") && D6 == true) 
         {
            L6.gameObject.SetActive(false);
            L7.gameObject.SetActive(true);
            D7 = true;

         }

         else if (other.gameObject.tag ==("7") && D7 == true) 
         {
            L7.gameObject.SetActive(false);
            L8.gameObject.SetActive(true);
            D8 = true;

         }

         else if (other.gameObject.tag ==("8") && D8 == true) 
         {
            L8.gameObject.SetActive(false);
            L9.gameObject.SetActive(true);
            D9 = true;

         }

         else if (other.gameObject.tag ==("9") && D9 == true) 
         {
            L9.gameObject.SetActive(false);
            L10.gameObject.SetActive(true);
            D10 = true;

         }

         else if (other.gameObject.tag ==("10") && D10 == true) 
         {
            L10.gameObject.SetActive(false);
            L11.gameObject.SetActive(true);
            D11 = true;

         }

         else if (other.gameObject.tag ==("11") && D11 == true) 
         {
            L11.gameObject.SetActive(false);
            L12.gameObject.SetActive(true);
            D12 = true;

         }

         else if (other.gameObject.tag ==("12") && D12 == true) 
         {
            L12.gameObject.SetActive(false);
            L13.gameObject.SetActive(true);
            D13 = true;

         }

         else if (other.gameObject.tag ==("13") && D13 == true) 
         {
            L13.gameObject.SetActive(false);
            L14.gameObject.SetActive(true);
            D14 = true;

         }

         else if (other.gameObject.tag ==("14") && D14 == true) 
         {
            L14.gameObject.SetActive(false);
            L15.gameObject.SetActive(true);
            D15 = true;

         }

         else if (other.gameObject.tag ==("15") && D15 == true) 
         {
            L15.gameObject.SetActive(false);
            L16.gameObject.SetActive(true);
            Terminado = true;

         }
         

         else{EmpezarOtraVez();
             Invoke ("AjustarBool", 0.001f);}
         
        
         

         
    }

    void EmpezarOtraVez()
    {
        fallo = true;
    }

    void AjustarBool()
    {
        fallo = false;
    }

    void AparecerImagen()
    {
        Imagen.gameObject.SetActive(true);

    }

    public void Limpiar()
    {
        B1.gameObject.SetActive(false);
        B2.gameObject.SetActive(false);
        B3.gameObject.SetActive(false);
        B4.gameObject.SetActive(false);
        B5.gameObject.SetActive(false);
        B6.gameObject.SetActive(false);
        B7.gameObject.SetActive(false);
        B8.gameObject.SetActive(false);
        B9.gameObject.SetActive(false);
        B10.gameObject.SetActive(false);
        B11.gameObject.SetActive(false);
        B12.gameObject.SetActive(false);
        B13.gameObject.SetActive(false);
        B14.gameObject.SetActive(false);
        B15.gameObject.SetActive(false);
        
        L1.gameObject.SetActive(false);
        L2.gameObject.SetActive(false);
        L3.gameObject.SetActive(false);
        L4.gameObject.SetActive(false);
        L5.gameObject.SetActive(false);
        L6.gameObject.SetActive(false);
        L7.gameObject.SetActive(false);
        L8.gameObject.SetActive(false);
        L9.gameObject.SetActive(false);
        L10.gameObject.SetActive(false);
        L11.gameObject.SetActive(false);
        L12.gameObject.SetActive(false);
        L13.gameObject.SetActive(false);
        L14.gameObject.SetActive(false);
        L15.gameObject.SetActive(false);
        L16.gameObject.SetActive(false);
        

    }

    void ActividadCompleta()
    {
        LineaU.gameObject.SetActive(true);

    }
}
