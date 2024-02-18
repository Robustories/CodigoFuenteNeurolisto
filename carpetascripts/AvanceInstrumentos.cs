using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvanceInstrumentos : MonoBehaviour
{
    public bool interruptor_1;
    public bool interruptor_2;
    public bool interruptor_3;
    public bool interruptor_4;
    public bool interruptor_5;
    public GameObject botonContinuar;

    // Start is called before the first frame update
    void Start()
    {
        botonContinuar.gameObject.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(interruptor_1 && interruptor_2 && interruptor_3 && interruptor_4 && interruptor_5 == true)
        {
            Invoke ("FinZonaMusical", 1.0f);
        }
        
    }

    public void ActivarInterruptor_1()
    {
        interruptor_1 = true;
    }

    public void ActivarInterruptor_2()
    {
        interruptor_2 = true;
    }

    public void ActivarInterruptor_3()
    {
        interruptor_3 = true;
    }

    public void ActivarInterruptor_4()
    {
        interruptor_4 = true;
    }

    public void ActivarInterruptor_5()
    {
        interruptor_5 = true;
    }

    void FinZonaMusical()
    {
        botonContinuar.gameObject.SetActive(true);

    }
}
