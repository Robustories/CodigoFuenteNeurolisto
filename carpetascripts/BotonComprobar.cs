using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotonComprobar : MonoBehaviour
{
    public TestBox2 testbox2;
    public Comprobante1 comprobante1;
    public Comprobante2 comprobante2;
    public Comprobante3 comprobante3;
    public Comprobante4 comprobante4;
    public Comprobante5 comprobante5;
    public Comprobante6 comprobante6;
    public GameObject cVictoria;
    public GameObject cGameOver;
    public int puntajeAcumulado;
    public Text texts;
    private int puntaje1;
    private int puntaje2;
    private int puntaje3;
    private int puntaje4;
    private int puntaje5;
    private int puntaje6;
    private int puntaje7;
    private int puntajetotal;
    public int objetivoVictoria;
    // Start is called before the first frame update
    void Start()
    {
        cVictoria.gameObject.SetActive(false);
        cGameOver.gameObject.SetActive(false);
        TestBox2 variable = GetComponent<TestBox2>();
        Comprobante1 variable2 = GetComponent<Comprobante1>();
        Comprobante2 variable3 = GetComponent<Comprobante2>();
        Comprobante3 variable4 = GetComponent<Comprobante3>();
        Comprobante4 variable5 = GetComponent<Comprobante4>();
        Comprobante5 variable6 = GetComponent<Comprobante5>();
        Comprobante6 variable7 = GetComponent<Comprobante6>();
    }

    // Update is called once per frame
    void Update()
    {
        puntaje1 = testbox2.puntos;
        puntaje2 = comprobante1.puntos;
        puntaje3 = comprobante2.puntos;
        puntaje4 = comprobante3.puntos;
        puntaje5 = comprobante4.puntos;
        puntaje6 = comprobante5.puntos;
        puntaje7 = comprobante6.puntos;

        puntajetotal = puntaje1 + puntaje2 + puntaje3 + puntaje4 + puntaje5 + puntaje6 + puntaje7;


    }

    public void BotonVerificar()
    {
        texts.text =  puntajetotal.ToString();

         if(puntajetotal == objetivoVictoria)
        {
            {Invoke ("ContinuarC", 0.8f); }
        }

        
        if(puntajetotal <= 1)
        {
            {Invoke ("GameOverC", 0.8f); }   
        }
        
    }

    void ContinuarC()
    { 
        cVictoria.gameObject.SetActive(true); 
    }

    void GameOverC()
    { 
        cGameOver.gameObject.SetActive(true); 
    }
}
