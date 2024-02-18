using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiempoPagina : MonoBehaviour
{
    public AudioSource source {get {return GetComponent<AudioSource> ();}}
    public GameObject btnAvanzar;
    public GameObject objetoMostrar;
    public AudioClip palabra;
    public float tiempoduracion, tiempoduracion2;
    // Start is called before the first frame update
    void Start()
    {
        btnAvanzar.SetActive(false);
        objetoMostrar.SetActive(false);
        Invoke("TiempoTerminado", tiempoduracion);
        Invoke("TiempoTerminado2", tiempoduracion2);
        
    }

    public void TiempoTerminado()
    
    {
        btnAvanzar.SetActive(true);
        source.PlayOneShot (palabra);

    }

    public void TiempoTerminado2()
    
    {
        objetoMostrar.SetActive(true);
        

    }
}
