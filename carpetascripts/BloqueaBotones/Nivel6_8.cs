using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nivel6_8 : MonoBehaviour
{
    public static Nivel6_8 niveles6_8;
    public Button nivel6_8_2;
    public Button nivel6_8_3;
    private int marcador6_8_1;
    private int marcador6_8_2;
    private int marcador0;
    public GameObject n1;
    // Start is called before the first frame update

    void Awake()
    {
        niveles6_8 = this;
        nivel6_8_2.interactable = false;
        nivel6_8_3.interactable = false;



    }
    void Start()
    {
        GetValor6_8();
        Desbloquear6_8();
        EvitarAudio();
        
    }

    void GetValor6_8()
    {
        marcador0 = Neuro.GetA681J();
        marcador6_8_1 = Neuro.Get681S();
        marcador6_8_2 = Neuro.Get682S();


    }

    void Desbloquear6_8()
    {
        if (marcador6_8_1 >= 1)
        {
            nivel6_8_2.interactable = true;

        }

        if (marcador6_8_2 >= 1)
        {
            nivel6_8_3.interactable = true;

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
