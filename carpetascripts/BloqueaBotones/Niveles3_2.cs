using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Niveles3_2 : MonoBehaviour
{
    public static Niveles3_2 niveles3_2;
    public Button nivel3_2_2;
    public Button nivel3_2_3;
    public Button nivel3_2_4;
    public Button nivel3_2_5;
    public Button nivel3_2_6;
    public Button nivel3_2_7;
    public Button nivel3_2_8;
    public Button nivel3_2_9;
    public Button nivel3_2_10;
    public Button nivel3_2_11;
    public Button nivel3_2_12;
    public Button nivel3_2_13;
    public Button nivel3_2_14;
    public Button nivel3_2_15;
    private int marcador3_2_1;
    private int marcador3_2_2;
    private int marcador3_2_3;
    private int marcador3_2_4;
    private int marcador3_2_5;
    private int marcador3_2_6;
    private int marcador3_2_7;
    private int marcador3_2_8;
    private int marcador3_2_9;
    private int marcador3_2_10;
    private int marcador3_2_11;
    private int marcador3_2_12;
    private int marcador3_2_13;
    private int marcador3_2_14;
    private int marcador0;
    public GameObject n1;
    // Start is called before the first frame update
    void Awake()
    {
        niveles3_2 = this;
        nivel3_2_2.interactable = false;
        nivel3_2_3.interactable = false;
        nivel3_2_4.interactable = false;
        nivel3_2_5.interactable = false;
        nivel3_2_6.interactable = false;
        nivel3_2_7.interactable = false;
        nivel3_2_8.interactable = false;
        nivel3_2_9.interactable = false;
        nivel3_2_10.interactable = false;
        nivel3_2_11.interactable = false;
        nivel3_2_12.interactable = false;
        nivel3_2_13.interactable = false;
        nivel3_2_14.interactable = false;
        nivel3_2_15.interactable = false;

    }
    void Start()
    {
        GetValor3_2();
        Desbloquear3_2();
        EvitarAudio();
        
    }

    void GetValor3_2()
    {
        marcador0 = Neuro.GetA321();
        marcador3_2_1 = Neuro.GetA321S();
        marcador3_2_2 = Neuro.GetA322S();
        marcador3_2_3 = Neuro.GetA323S();
        marcador3_2_4 = Neuro.GetA324S();
        marcador3_2_5 = Neuro.GetA325S();
        marcador3_2_6 = Neuro.GetA326S();
        marcador3_2_7 = Neuro.GetA327S();
        marcador3_2_8 = Neuro.GetA328S();
        marcador3_2_9 = Neuro.GetA329S();
        marcador3_2_10 = Neuro.GetA3210S();
        marcador3_2_11 = Neuro.GetA3211S();
        marcador3_2_12 = Neuro.GetA3212S();
        marcador3_2_13 = Neuro.GetA3213S();
        marcador3_2_14 = Neuro.GetA3214S();


    }

    void Desbloquear3_2()
    {
        if (marcador3_2_1 >= 1)
        {
            nivel3_2_2.interactable = true;

        }

        if (marcador3_2_2 >= 1)
        {
            nivel3_2_3.interactable = true;

        }

        if (marcador3_2_3 >= 1)
        {
            nivel3_2_4.interactable = true;

        }

        if (marcador3_2_4 >= 1)
        {
            nivel3_2_5.interactable = true;

        }

        if (marcador3_2_5 >= 1)
        {
            nivel3_2_6.interactable = true;

        }

        if (marcador3_2_6 >= 1)
        {
            nivel3_2_7.interactable = true;

        }

        if (marcador3_2_7 >= 1)
        {
            nivel3_2_8.interactable = true;

        }

        if (marcador3_2_8 >= 1)
        {
            nivel3_2_9.interactable = true;

        }

        if (marcador3_2_9 >= 1)
        {
            nivel3_2_10.interactable = true;

        }

        if (marcador3_2_10 >= 1)
        {
            nivel3_2_11.interactable = true;

        }

        if (marcador3_2_11 >= 1)
        {
            nivel3_2_12.interactable = true;

        }

        if (marcador3_2_12 >= 1)
        {
            nivel3_2_13.interactable = true;

        }

        if (marcador3_2_13 >= 1)
        {
            nivel3_2_14.interactable = true;

        }

        if (marcador3_2_14 >= 1)
        {
            nivel3_2_15.interactable = true;

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
