using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Niveles6_7 : MonoBehaviour
{
    public static Niveles6_7 niveles6_7;
    public Button nivel6_7_2;
    public Button nivel6_7_3;
    public Button nivel6_7_4;
    private int marcador6_7_1;
    private int marcador6_7_2;
    private int marcador6_7_3;
    private int marcador0;
    public GameObject n1;

    // Start is called before the first frame update

    void Awake()
    {
        niveles6_7 = this;
        nivel6_7_2.interactable = false;
        nivel6_7_3.interactable = false;
        nivel6_7_4.interactable = false;



    }

    void Start()
    {
        GetValor6_7();
        Desbloquear6_7();
        EvitarAudio();
    }

    void GetValor6_7()
    {
        marcador0 = Neuro.GetA671J();
        marcador6_7_1 = Neuro.Get671S();
        marcador6_7_2 = Neuro.Get672S();
        marcador6_7_3 = Neuro.Get673S();


    }

    void Desbloquear6_7()
    {
        if (marcador6_7_1 >= 1)
        {
            nivel6_7_2.interactable = true;

        }

        if (marcador6_7_2 >= 1)
        {
            nivel6_7_3.interactable = true;

        }

        if (marcador6_7_3 >= 1)
        {
            nivel6_7_4.interactable = true;

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
