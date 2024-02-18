using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Reloj : MonoBehaviour
{
    [Tooltip ("tiempo inicial en segundos al arrancar el juego")]
    public int tiempoInicial;
    [Tooltip ("Escala de tiempo del reloj")]
    [Range(-10.0f, 10.0f)]
    public float escalaDeTiempo = 1;
    
    private Text myText;
    private float tiempoDelFrameConTimeScale = 0f;
    public float tiempoAMostrarEnSegundos = 0f;
    private float escalaDeTiempoAlPausar, escalaDeTiempoInicial;
    //private bool estaPausado = false;
    private bool eventoTiempoCeroInvocado = false;

    public bool eventoSecuencias = false;

    

    public delegate void AccionTiempoCero();
    public static event AccionTiempoCero AlLlegarACero;


    // Start is called before the first frame update
    void Start()
    {
        escalaDeTiempoInicial = escalaDeTiempo;

        myText = GetComponent<Text>();
        tiempoAMostrarEnSegundos = tiempoInicial;

        ActualizarReloj(tiempoInicial);
        
    }

    // Update is called once per frame
    void Update()
    {
        
        tiempoDelFrameConTimeScale = Time.deltaTime * escalaDeTiempo;
        tiempoAMostrarEnSegundos += tiempoDelFrameConTimeScale;
        ActualizarReloj(tiempoAMostrarEnSegundos);
        
        
        
    }

    public void ActualizarReloj(float tiempoEnSegundos)
    {
        int minutos = 0;
        int segundos = 0;
        string textoDelReloj;

        if (tiempoEnSegundos <= 0 && !eventoTiempoCeroInvocado)
        {
            if(AlLlegarACero != null)
            {
            AlLlegarACero();
            }
            eventoTiempoCeroInvocado = true;
        }

        if (tiempoEnSegundos < 0) tiempoEnSegundos = 0;

        minutos  = (int) tiempoEnSegundos / 60;
        segundos  = (int) tiempoEnSegundos % 60;

        textoDelReloj = minutos.ToString("00") + ":" + segundos.ToString("00");

        myText.text = textoDelReloj;
    }

    public void Reiniciar()
    {
        //estaPausado = false;
        eventoTiempoCeroInvocado = false;
        escalaDeTiempo = escalaDeTiempoInicial;
        tiempoAMostrarEnSegundos = tiempoInicial;
        ActualizarReloj(tiempoAMostrarEnSegundos);
    }
}
