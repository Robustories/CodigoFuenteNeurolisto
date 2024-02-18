using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Niveles3_5 : MonoBehaviour
{
    public static Niveles3_5 niveles3_5;
    public Button nivel3_5_2;
    public Button nivel3_5_3;
    public Button nivel3_5_4;
    private int marcador3_5_1;
    private int marcador3_5_2;
    private int marcador3_5_3;
    private int marcador0;
    public GameObject n1;

    void Awake()
    {
        niveles3_5 = this;
        nivel3_5_2.interactable = false;
        nivel3_5_3.interactable = false;
        nivel3_5_4.interactable = false;

    }
    // Start is called before the first frame update
    void Start()
    {
        GetValor3_5();
        Desbloquear3_5();
        EvitarAudio();
        
    }


    void GetValor3_5()
    {
        marcador0 = Neuro.GetA351J();
        marcador3_5_1 = Neuro.Get351S();
        marcador3_5_2 = Neuro.Get352S();
        marcador3_5_3 = Neuro.Get353S();


    }

    void Desbloquear3_5()
    {
        if (marcador3_5_1 >= 1)
        {
            nivel3_5_2.interactable = true;

        }

        if (marcador3_5_2 >= 1)
        {
            nivel3_5_3.interactable = true;

        }

        if (marcador3_5_3 >= 1)
        {
            nivel3_5_4.interactable = true;

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
