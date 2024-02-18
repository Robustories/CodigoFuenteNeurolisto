using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegistroUI : MonoBehaviour
{
    public GameObject tema1, tema2, tema3, tema4, tema5, tema6, tema7, tema8;
    // Start is called before the first frame update
    void Start()
    {
        tema1.gameObject.SetActive(false);
        tema2.gameObject.SetActive(false);
        tema3.gameObject.SetActive(false);
        tema4.gameObject.SetActive(false);
        tema5.gameObject.SetActive(false);
        tema6.gameObject.SetActive(false);
        tema7.gameObject.SetActive(false);
        tema8.gameObject.SetActive(false);
        
    }

    public void MostrarTema1()
    {
        tema1.gameObject.SetActive(true);

    }

    public void OcultarTema1()
    {
        tema1.gameObject.SetActive(false);

    }

    public void MostrarTema2()
    {
        tema2.gameObject.SetActive(true);

    }

    public void OcultarTema2()
    {
        tema2.gameObject.SetActive(false);

    }

    public void MostrarTema3()
    {
        tema3.gameObject.SetActive(true);

    }

    public void OcultarTema3()
    {
        tema3.gameObject.SetActive(false);

    }

    public void MostrarTema4()
    {
        tema4.gameObject.SetActive(true);

    }

    public void OcultarTema4()
    {
        tema4.gameObject.SetActive(false);

    }

    public void MostrarTema5()
    {
        tema5.gameObject.SetActive(true);

    }

    public void OcultarTema5()
    {
        tema5.gameObject.SetActive(false);

    }

    public void MostrarTema6()
    {
        tema6.gameObject.SetActive(true);

    }

    public void OcultarTema6()
    {
        tema6.gameObject.SetActive(false);

    }

    public void MostrarTema7()
    {
        tema7.gameObject.SetActive(true);

    }

    public void OcultarTema7()
    {
        tema7.gameObject.SetActive(false);

    }

    public void MostrarTema8()
    {
        tema8.gameObject.SetActive(true);

    }

    public void OcultarTema8()
    {
        tema8.gameObject.SetActive(false);

    }
}
