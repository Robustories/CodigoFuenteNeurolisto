using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lyrics : MonoBehaviour
{
    public Text textoQueSeVa, textoActual, textoQueViene;

    public string[] frasesCancion;
    public float[] tiemposInicia, tiemposFinal, tiemposIniciaClick, tiemposFinalClick;
    public float tiempoTranscurrido;
    public bool cancionEmpezada, subtituloActivo, esperandoSiguienteFrase, oprimirClick;
    public int indiceRequerido, puntos, indiceClick;
    private int indiceActual;
    public GameObject cancionTerminadaSuperado;
    public GameObject cancionTerminadaRepetir;
    public Text Textscore;
    public GameObject efecto;
    int puntosn;
    public int limitefallas;

 void Start()
    {
        EmpezarCancion();
        cancionTerminadaRepetir.SetActive(false);
        cancionTerminadaSuperado.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Textscore.text = "Puntaje:" + puntos.ToString() + "/" + tiemposFinalClick.Length;
        if (cancionEmpezada)
        {
            tiempoTranscurrido += Time.deltaTime;

        }

        AlgoritmoSubtitulos();
        AlgoritmoActividad();

        if(puntosn == limitefallas)
        {
            cancionTerminadaRepetir.SetActive(true);

        }
    }

    public void EmpezarCancion()
    {
        //Depende de cuando y donde le des play al audiosource, se puede llamar desde otros scripts
        tiempoTranscurrido = 0f;
        indiceActual = 0;
        indiceClick = 0;
        cancionEmpezada = true;
        subtituloActivo = false;
        oprimirClick = false;
    }

    void AlgoritmoSubtitulos()
    {
        if (!subtituloActivo)
        {
            if (tiempoTranscurrido >= tiemposInicia[indiceActual])
            {
                subtituloActivo = true;
                textoActual.text = frasesCancion[indiceActual];
            }

        }
        else
        {
            if (tiempoTranscurrido >= tiemposFinal[indiceActual])
            {
                subtituloActivo = false;
                textoActual.text = "";
                indiceActual++;
                if (indiceActual < frasesCancion.Length && indiceActual<tiemposInicia.Length && indiceActual < tiemposFinal.Length )
                {
                    subtituloActivo = false;
                }
                else
                {
                    cancionEmpezada = false;
                    //cancion finalizada?
                }

            }


        }

        if(!cancionEmpezada)
        {
            if(puntos >= indiceRequerido)
            {
                cancionTerminadaSuperado.SetActive(true);
                
            }
            else
            {
                cancionTerminadaRepetir.SetActive(true);

            }

        }
    }

    void AlgoritmoActividad()
    {
        if (!oprimirClick)
        {

            if (tiempoTranscurrido >= tiemposIniciaClick[indiceClick])
            {
                Debug.Log("a");
                oprimirClick = true;
                
            }
        }
        else
        {
            if (tiempoTranscurrido >= tiemposFinalClick[indiceClick])
            {
                oprimirClick = false;
                indiceClick++;

            }


        }

    }

    public void HacerPuntos()
    {
        if(oprimirClick == true)
        {
            puntos++;
            Instantiate(efecto);
            
        }
        else
        {
            puntosn++;
        }
    }

}
