using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Niveles2_1 : MonoBehaviour
{
    public static Niveles2_1 niveles2_1;
    public Button nivel2_1_2;
    public Button nivel2_1_3;
    public Button nivel2_1_4;
    private int marcador2_1_1;
    private int marcador2_1_2;
    private int marcador2_1_3;
    private int marcador2_1;
    public GameObject n2_1;

    void Awake()
    {
        niveles2_1 = this;
        nivel2_1_2.interactable = false;
        nivel2_1_3.interactable = false;
        nivel2_1_4.interactable = false;

    }
    // Start is called before the first frame update
    void Start()
    {
        GetValor2_1();
        Desbloquear2_1();
        EvitarAudio2_1();
    }

    void GetValor2_1()
    {
        marcador2_1 = Neuro.GetA211J();
        marcador2_1_1 = Neuro.Get211S();
        marcador2_1_2 = Neuro.Get212S();
        marcador2_1_3 = Neuro.Get213S();

    }

    void Desbloquear2_1()
    {
        if (marcador2_1_1 >= 1)
        {
            nivel2_1_2.interactable = true;

        }

        if (marcador2_1_2 >= 1)
        {
            nivel2_1_3.interactable = true;

        }

        if (marcador2_1_3 >= 1)
        {
            nivel2_1_4.interactable = true;

        }
    
    }

    void EvitarAudio2_1()
    {
        if (marcador2_1 >= 1)
        {
            n2_1.gameObject.SetActive(false);

        }

    }
}
