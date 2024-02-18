using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerCambiaEscena : MonoBehaviour
{
    private void OnEnable()
    {
        Reloj.AlLlegarACero += TiempoFinalizado;
    }

    private void OnDisable()
    {
        Reloj.AlLlegarACero -= TiempoFinalizado;
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void TiempoFinalizado()
    {
        SceneManager.LoadScene("1_5Introduccion");
        
           
    }
}
