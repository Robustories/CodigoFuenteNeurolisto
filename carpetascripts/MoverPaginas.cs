using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoverPaginas : MonoBehaviour
{
    public GameObject[] pagina;
    public int indicepagina = 0;
    public GameObject pagina_1;
    public GameObject pagina_2;
    public GameObject pagina_3;
    public GameObject pagina_4;
    public GameObject pagina_5;
    public GameObject pagina_6;
    public GameObject pagina_7;
    public GameObject pagina_8;
    public GameObject pagina_9;
    public GameObject pagina_10;
    public GameObject pagina_11;
    public GameObject pagina_12;
    public GameObject pagina_13;
    public GameObject pagina_14;
    public GameObject pagina_15;
    public GameObject pagina_16;
    public GameObject pagina_17;
    public GameObject pagina_18;
    public GameObject botonContinuar;
    public GameObject textoOculto;
    
    
	public bool pagina_1Mostrado;
	public bool pagina_2Mostrado;
	public bool pagina_3Mostrado;
	public bool pagina_4Mostrado;
	public bool pagina_5Mostrado;
    public bool pagina_6Mostrado;
	public bool pagina_7Mostrado;
	public bool pagina_8Mostrado;
	public bool pagina_9Mostrado;
	public bool pagina_10Mostrado;
    public bool pagina_11Mostrado;
    public bool pagina_12Mostrado;
    public bool pagina_13Mostrado;
	public bool pagina_14Mostrado;
	public bool pagina_15Mostrado;
	public bool pagina_16Mostrado;
	public bool pagina_17Mostrado;
    public bool pagina_18Mostrado;
	
    // Start is called before the first frame update
    void Start()
    {
        botonContinuar.gameObject.SetActive(false);
        textoOculto.gameObject.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(pagina_3Mostrado && pagina_4Mostrado && pagina_5Mostrado && pagina_6Mostrado && pagina_7Mostrado)
        {
            botonContinuar.gameObject.SetActive(true);
            textoOculto.gameObject.SetActive(true);

        }

        if(pagina_3Mostrado && pagina_4Mostrado && pagina_5Mostrado && pagina_7Mostrado && pagina_8Mostrado && pagina_9Mostrado)
        {
            botonContinuar.gameObject.SetActive(true);
            textoOculto.gameObject.SetActive(true);

        }
        
    }


    public void MostrarPagina_1()
    {
        pagina_1.SetActive(true);
        pagina_1Mostrado = true;
    }

    public void EsconderPagina_1()
    {
        pagina_1.SetActive(false);
        pagina_1Mostrado = false;
    }
	public void MostrarPagina_2()
    {
        pagina_2.SetActive(true);
        pagina_2Mostrado = true;
    }

    public void EsconderPagina_2()
    {
        pagina_2.SetActive(false);
        
    }
	public void MostrarPagina_3()
    {
        pagina_3.SetActive(true);
        pagina_3Mostrado = true;
    }

    public void EsconderPagina_3()
    {
        pagina_3.SetActive(false);
        
    }

	public void MostrarPagina_4()
    {
        pagina_4.SetActive(true);
        pagina_4Mostrado = true;
    }

    public void EsconderPagina_4()
    {
        pagina_4.SetActive(false);
        
    }

	public void MostrarPagina_5()
    {
        pagina_5.SetActive(true);
        pagina_5Mostrado = true;
    }

    public void EsconderPagina_5()
    {
        pagina_5.SetActive(false);
        
    }

    public void MostrarPagina_6()
    {
        pagina_6.SetActive(true);
        pagina_6Mostrado = true;
    }

    public void EsconderPagina_6()
    {
        pagina_6.SetActive(false);
        
    }
	public void MostrarPagina_7()
    {
        pagina_7.SetActive(true);
        pagina_7Mostrado = true;
    }

    public void EsconderPagina_7()
    {
        pagina_7.SetActive(false);
        
    }
	public void MostrarPagina_8()
    {
        pagina_8.SetActive(true);
        pagina_8Mostrado = true;
    }

    public void EsconderPagina_8()
    {
        pagina_8.SetActive(false);
        
    }

	public void MostrarPagina_9()
    {
        pagina_9.SetActive(true);
        pagina_9Mostrado = true;
    }

    public void EsconderPagina_9()
    {
        pagina_9.SetActive(false);
        
    }

	public void MostrarPagina_10()
    {
        pagina_10.SetActive(true);
        pagina_10Mostrado = true;
    }

    public void EsconderPagina_10()
    {
        pagina_10.SetActive(false);
        pagina_10Mostrado = false;
    }

    public void MostrarPagina_11()
    {
        pagina_11.SetActive(true);
        pagina_11Mostrado = true;
    }

    public void EsconderPagina_11()
    {
        pagina_11.SetActive(false);
        pagina_11Mostrado = false;
    }

    public void MostrarPagina_12()
    {
        pagina_12.SetActive(true);
        pagina_12Mostrado = true;
    }

    public void EsconderPagina_12()
    {
        pagina_12.SetActive(false);
        pagina_12Mostrado = false;
    }

    public void MostrarPagina_13()
    {
        pagina_13.SetActive(true);
        pagina_13Mostrado = true;
    }

    public void EsconderPagina_13()
    {
        pagina_13.SetActive(false);
        pagina_13Mostrado = false;
    }
	public void MostrarPagina_14()
    {
        pagina_14.SetActive(true);
        pagina_14Mostrado = true;
    }

    public void EsconderPagina_14()
    {
        pagina_14.SetActive(false);
        pagina_14Mostrado = false;
    }
	public void MostrarPagina_15()
    {
        pagina_15.SetActive(true);
        pagina_15Mostrado = true;
    }

    public void EsconderPagina_15()
    {
        pagina_15.SetActive(false);
        pagina_15Mostrado = false;
    }

	public void MostrarPagina_16()
    {
        pagina_16.SetActive(true);
        pagina_16Mostrado = true;
    }

    public void EsconderPagina_16()
    {
        pagina_16.SetActive(false);
        pagina_16Mostrado = false;
    }

	public void MostrarPagina_17()
    {
        pagina_17.SetActive(true);
        pagina_17Mostrado = true;
    }

    public void EsconderPagina_17()
    {
        pagina_17.SetActive(false);
        pagina_17Mostrado = false;
    }

    public void MostrarPagina_18()
    {
        pagina_18.SetActive(true);
        pagina_18Mostrado = true;
    }

    public void EsconderPagina_18()
    {
        pagina_18.SetActive(false);
        pagina_18Mostrado = false;
    }





}
