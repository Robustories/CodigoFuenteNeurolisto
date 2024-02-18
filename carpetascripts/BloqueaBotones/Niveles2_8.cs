using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Niveles2_8 : MonoBehaviour
{
    public static Niveles2_8 niveles2_8;
    public Button nivel2_8_2;
    public Button nivel2_8_3;
    private int marcador2_8_1;
    private int marcador2_8_2;
    private int marcador0;
    public GameObject n1;

    void Awake()
    {
        niveles2_8 = this;
        nivel2_8_2.interactable = false;
        nivel2_8_3.interactable = false;

    }
    // Start is called before the first frame update
    void Start()
    {
        GetValor2_8();
        Desbloquear2_8();
        EvitarAudio();
        
    }

    void GetValor2_8()
    {
        marcador0 = Neuro.GetA281J();
        marcador2_8_1 = Neuro.Get281S();
        marcador2_8_2 = Neuro.Get282S();


    }

    void Desbloquear2_8()
    {
        if (marcador2_8_1 >= 1)
        {
            nivel2_8_2.interactable = true;

        }

        if (marcador2_8_2 >= 1)
        {
            nivel2_8_3.interactable = true;

        }
    
    }

    void EvitarAudio()
    {
        if (marcador0 >= 1)
        {
            n1.gameObject.SetActive(false);

        }

    }
}
