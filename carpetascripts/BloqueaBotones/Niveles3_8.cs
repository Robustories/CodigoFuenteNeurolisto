using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Niveles3_8 : MonoBehaviour
{
    public static Niveles3_8 niveles3_8;
    public Button nivel3_8_2;
    public Button nivel3_8_3;
    private int marcador3_8_1;
    private int marcador3_8_2;
    private int marcador0;
    public GameObject n1;

    void Awake()
    {
        niveles3_8 = this;
        nivel3_8_2.interactable = false;
        nivel3_8_3.interactable = false;


    }
    // Start is called before the first frame update
    void Start()
    {
        GetValor3_8();
        Desbloquear3_8();
        EvitarAudio();
        
    }


    void GetValor3_8()
    {
        marcador0 = Neuro.GetA381J();
        marcador3_8_1 = Neuro.Get381S();
        marcador3_8_2 = Neuro.Get382S();


    }

    void Desbloquear3_8()
    {
        if (marcador3_8_1 >= 1)
        {
            nivel3_8_2.interactable = true;

        }

        if (marcador3_8_2 >= 1)
        {
            nivel3_8_3.interactable = true;

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
