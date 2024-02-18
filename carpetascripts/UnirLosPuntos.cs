using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnirLosPuntos : MonoBehaviour
{
    public GameObject L1, L2, L3, L4, L5, L6, L7, L8, L9, L10, L11, L12, L13, L14, L15, L16;
    public GameObject B1, B2, B3, B4, B5, B6, B7, B8, B9, B10, B11, B12, B13, B14, B15, B16;
    public GameObject Imagen;
    public GameObject PantallarCompleto;
    public bool D2, D3, D4, D5, D6, D7, D8, D9, D10, D11, D12, D13, D14, D15, Terminado;
    public int numerofinalizar;
    int numero;
    public ComerEnOrden a1;
    public bool repetir;
    Linea lineas;
    
    // Start is called before the first frame update
    void Start()
    {
        Imagen.gameObject.SetActive(false);
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
        PantallarCompleto.gameObject.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        ComerEnOrden variable = GetComponent<ComerEnOrden>();
        numero = ComerEnOrden.Score47;
        repetir = ComerEnOrden.fallo;

        

        if(Terminado == true)
        {
            Invoke ("AparecerImagen", 0.4f);
            Invoke ("Limpiar", 0.8f);
            Invoke ("ActividadCompleta", 2f);
        }
        
    }

    public void CL1()
    {
        L1.gameObject.SetActive(true);
        D2 = true;

    }

    public void CL2()
    {
        if(D2 == true)
        {
            L2.gameObject.SetActive(true);
            D3 = true;
        }
    }

    public void CL3()
    {
        if(D3 == true)
        {
            L3.gameObject.SetActive(true);
            D4 = true;
        }
    }

    public void CL4()
    {
        if(D4 == true)
        {
            L4.gameObject.SetActive(true);
            D5 = true;
        }
    }

    public void CL5()
    {
        if(D5 == true)
        {
            L5.gameObject.SetActive(true);
            D6 = true;
        }
    }

    public void CL6()
    {
        if(D6 == true)
        {
            L6.gameObject.SetActive(true);
            D7 = true;
        }
    }

    public void CL7()
    {
        if(D7 == true)
        {
            L7.gameObject.SetActive(true);
            D8 = true;
        }
    }

    public void CL8()
    {
        if(D8 == true)
        {
            L8.gameObject.SetActive(true);
            D9 = true;
        }
    }

    public void CL9()
    {
        if(D9 == true)
        {
            L9.gameObject.SetActive(true);
            D10 = true;
        }
    }

    public void CL10()
    {
        if(D10 == true)
        {
            L10.gameObject.SetActive(true);
            D11 = true;
        }
    }

    public void CL11()
    {
        if(D11 == true)
        {
            L11.gameObject.SetActive(true);
            D12 = true;
        }
    }

    public void CL12()
    {
        if(D12 == true)
        {
            L12.gameObject.SetActive(true);
            D13 = true;
        }
    }

    public void CL13()
    {
        if(D13 == true)
        {
            L13.gameObject.SetActive(true);
            D14 = true;
        }
    }

    public void CL14()
    {
        if(D14 == true)
        {
            L14.gameObject.SetActive(true);
            D15 = true;
        }
    }

    public void CL15()
    {
        if(D15 == true)
        {
            L15.gameObject.SetActive(true);
            Terminado = true;
            
        }
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
        B16.gameObject.SetActive(false);
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
        PantallarCompleto.gameObject.SetActive(true);

    }

}
