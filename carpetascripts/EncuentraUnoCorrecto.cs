using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EncuentraUnoCorrecto : MonoBehaviour
{
    public bool unicoEncontrable;
    private int puntosFalla;
    public int fallos;
    public GameObject actividadSuperada;
    public GameObject actividadPerdida;
    public Text Prueba;

    // Start is called before the first frame update
    void Start()
    {
        actividadSuperada.gameObject.SetActive(false);
    }

    public void EncontrarUnico()
    {
        unicoEncontrable = true;
       
    }

    public void SumarPuntoNegativo()
    {
        puntosFalla++;
        
       
    }

    // Update is called once per frame
    void Update()
    {
        if(unicoEncontrable == true)
        {
            {actividadSuperada.gameObject.SetActive(true);  }
        }

        if(fallos == puntosFalla)
        {
            {actividadPerdida.gameObject.SetActive(true);}
        }
    }
}
