using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VictoriaClasificar : MonoBehaviour
{
    public GameObject AA1, AA2, AA3, AA4, AA5, AA6, AA7, AA8, AA9, AA10, AA11, AA12, AA13, AA14, AA15, AA16, AA17, AA18, AA19, AA20, AA21, AA22, AA23, AA24, AA25;
    Vector2 AA1InitialPos, AA2InitialPos, AA3InitialPos, AA4InitialPos, AA5InitialPos, AA6InitialPos, AA7InitialPos, AA8InitialPos, AA9InitialPos, 
    AA10InitialPos, AA11InitialPos, AA12InitialPos, AA13InitialPos, AA14InitialPos, AA15InitialPos, AA16InitialPos, AA17InitialPos, AA18InitialPos;
    public Contenedores contenedores;
    public Contenedoresdos contenedoresdos;
    public Contenedorestres contenedorestres;
    public Contenedor4 contenedoresq;
    public Contenedor5 contenedoresv;
    public Contenedor6 contenedoress;
    public int objetivoVictoria;
    public GameObject cuadroVictoria;
    private int puntaje1;
    private int puntaje2;
    private int puntaje3;
    private int puntaje4;
    private int puntaje5;
    private int puntaje6;
    private int puntajetotal;
   
    
    // Start is called before the first frame update
    void Start()
    {
        cuadroVictoria.gameObject.SetActive(false);
        AA1InitialPos = AA1.transform.position;
        AA2InitialPos = AA2.transform.position;
        AA3InitialPos = AA3.transform.position;
        AA4InitialPos = AA4.transform.position;
        AA5InitialPos = AA5.transform.position;
        AA6InitialPos = AA6.transform.position;
        AA7InitialPos = AA7.transform.position;
        AA8InitialPos = AA8.transform.position;
        AA9InitialPos = AA9.transform.position;
        AA10InitialPos = AA10.transform.position;
        AA11InitialPos = AA11.transform.position;
        AA12InitialPos = AA12.transform.position;
        AA13InitialPos = AA13.transform.position;
        AA14InitialPos = AA14.transform.position;
        AA15InitialPos = AA15.transform.position;
        AA16InitialPos = AA16.transform.position;
        AA17InitialPos = AA17.transform.position;
        AA18InitialPos = AA18.transform.position;
        

    }

    // Update is called once per frame
    void Update()
    {
        Contenedores variable = GetComponent<Contenedores>();
        Contenedoresdos variable2 = GetComponent<Contenedoresdos>();
        Contenedorestres variable3 = GetComponent<Contenedorestres>();
        Contenedor4 variable4 = GetComponent<Contenedor4>();
        Contenedor5 variable5 = GetComponent<Contenedor5>();
        Contenedor6 variable6 = GetComponent<Contenedor6>();
        puntaje1 = Contenedores.ScoreCS;
        puntaje2 = Contenedoresdos.ScoreCSdos;
        puntaje3 = Contenedorestres.ScoreCStres;
        puntaje4 = Contenedor4.ScoreCSq;
        puntaje5 = Contenedor5.ScoreCSv;
        puntaje6 = Contenedor6.ScoreCSs;

        puntajetotal = puntaje1 + puntaje2 + puntaje3 + puntaje4 + puntaje5 + puntaje6;

        

        if(puntajetotal == objetivoVictoria)
        {
            cuadroVictoria.SetActive(true);
            AA1.gameObject.SetActive(false);
            AA2.gameObject.SetActive(false);
            AA3.gameObject.SetActive(false);
            AA4.gameObject.SetActive(false);
            AA5.gameObject.SetActive(false);
            AA6.gameObject.SetActive(false);
            AA7.gameObject.SetActive(false);
            AA8.gameObject.SetActive(false);
            AA9.gameObject.SetActive(false);
            AA10.gameObject.SetActive(false);
            AA11.gameObject.SetActive(false);
            AA12.gameObject.SetActive(false);
            AA13.gameObject.SetActive(false);
            AA14.gameObject.SetActive(false);
            AA15.gameObject.SetActive(false);
            AA16.gameObject.SetActive(false);
            AA17.gameObject.SetActive(false);
            AA18.gameObject.SetActive(false);
            AA19.gameObject.SetActive(false);
            AA20.gameObject.SetActive(false);
            AA21.gameObject.SetActive(false);
            AA22.gameObject.SetActive(false);
            AA23.gameObject.SetActive(false);
            AA24.gameObject.SetActive(false);
            AA25.gameObject.SetActive(false);
            
            
        }
        
    }

    void Vic()
    { 
        cuadroVictoria.SetActive(true);
    }



    
}
