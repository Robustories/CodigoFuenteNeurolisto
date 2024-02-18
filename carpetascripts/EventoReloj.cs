using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EventoReloj : MonoBehaviour
{
    public GameObject cuadro;
    public GameObject objetoExtra;
    public bool tiempoSuperado;
    
    //public GameObject cuadro;
    // Start is called before the first frame update
    private void OnEnable()
    {
        Reloj.AlLlegarACero += TiempoFinalizado;
    }

    private void OnDisable()
    {
        Reloj.AlLlegarACero -= TiempoFinalizado;
        
    }
    
    void Start()
    {
    cuadro.gameObject.SetActive(false);
    objetoExtra.gameObject.SetActive(false);
    }
    
    void TiempoFinalizado()
    {
        cuadro.gameObject.SetActive(true); 
        objetoExtra.gameObject.SetActive(true); 
        tiempoSuperado = true;
        
           
    }

}

