using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Niveles2_2 : MonoBehaviour
{
    public static Niveles2_2 niveles2_2;
    public Button nivel2_2_2;
    public Button nivel2_2_3;
    public Button nivel2_2_4;
    private int marcador2_2_1;
    private int marcador2_2_2;
    private int marcador2_2_3;
    private int marcador0;
    public GameObject n1;
    public GameObject n2;

    void Awake()
    {
        niveles2_2 = this;
        nivel2_2_2.interactable = false;
        nivel2_2_3.interactable = false;
        nivel2_2_4.interactable = false;

    }
    // Start is called before the first frame update
    void Start()
    {
        GetValor2_2();
        Desbloquear2_2();
        EvitarAudio();
        
    }

    void GetValor2_2()
    {
        marcador0 = Neuro.GetA221J();
        marcador2_2_1 = Neuro.Get221S();
        marcador2_2_2 = Neuro.Get222S();
        marcador2_2_3 = Neuro.Get223S();

    }

    void Desbloquear2_2()
    {
        if (marcador2_2_1 >= 1)
        {
            nivel2_2_2.interactable = true;

        }

        if (marcador2_2_2 >= 1)
        {
            nivel2_2_3.interactable = true;

        }

        if (marcador2_2_3 >= 1)
        {
            nivel2_2_4.interactable = true;

        }
    
    }

    void EvitarAudio()
    {
        if (marcador0 >= 1)
        {
            n1.gameObject.SetActive(false);

        }

        if (marcador0 >= 1)
        {
            n2.gameObject.SetActive(false);

        }

    }
}
