using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Niveles5_1 : MonoBehaviour
{
    public static Niveles5_1 niveles5_1;
    public Button nivel5_1_2;
    public Button nivel5_1_3;
    public Button nivel5_1_4;
    public Button nivel5_1_5;
    public Button nivel5_1_6;
    private int marcador5_1_1;
    private int marcador5_1_2;
    private int marcador5_1_3;
    private int marcador5_1_4;
    private int marcador5_1_5;
    private int marcador0;
    public GameObject n1;
    // Start is called before the first frame update
    void Awake()
    {
        niveles5_1 = this;
        nivel5_1_2.interactable = false;
        nivel5_1_3.interactable = false;
        nivel5_1_4.interactable = false;
        nivel5_1_5.interactable = false;
        nivel5_1_6.interactable = false;


    }
    
    void Start()
    {
        GetValor5_1();
        Desbloquear5_1();
        EvitarAudio();
        
    }

    void GetValor5_1()
    {
        marcador0 = Neuro.GetA511J();
        marcador5_1_1 = Neuro.Get511S();
        marcador5_1_2 = Neuro.Get512S();
        marcador5_1_3 = Neuro.Get513S();
        marcador5_1_4 = Neuro.Get514S();
        marcador5_1_5 = Neuro.Get515S();

    }

    void Desbloquear5_1()
    {
        if (marcador5_1_1 >= 1)
        {
            nivel5_1_2.interactable = true;

        }

        if (marcador5_1_2 >= 1)
        {
            nivel5_1_3.interactable = true;

        }

        if (marcador5_1_3 >= 1)
        {
            nivel5_1_4.interactable = true;

        }

        if (marcador5_1_4 >= 1)
        {
            nivel5_1_5.interactable = true;

        }

        if (marcador5_1_5 >= 1)
        {
            nivel5_1_6.interactable = true;

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
