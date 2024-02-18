using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Niveles5_5 : MonoBehaviour
{
    public static Niveles5_5 niveles5_5;
    public Button nivel5_5_2;
    public Button nivel5_5_3;
    public Button nivel5_5_4;
    private int marcador5_5_1;
    private int marcador5_5_2;
    private int marcador5_5_3;
    private int marcador0;
    public GameObject n1;

    void Awake()
    {
        niveles5_5 = this;
        nivel5_5_2.interactable = false;
        nivel5_5_3.interactable = false;
        nivel5_5_4.interactable = false;


    }

    // Start is called before the first frame update
    void Start()
    {
        GetValor5_5();
        Desbloquear5_5();
        EvitarAudio();
        
    }

    void GetValor5_5()
    {
        marcador0 = Neuro.GetA551J();
        marcador5_5_1 = Neuro.Get551S();
        marcador5_5_2 = Neuro.Get552S();
        marcador5_5_3 = Neuro.Get553S();


    }

    void Desbloquear5_5()
    {
        if (marcador5_5_1 >= 1)
        {
            nivel5_5_2.interactable = true;

        }

        if (marcador5_5_2 >= 1)
        {
            nivel5_5_3.interactable = true;

        }

        if (marcador5_5_3 >= 1)
        {
            nivel5_5_4.interactable = true;

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

