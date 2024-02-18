using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nilveles6_13 : MonoBehaviour
{
    public static Nilveles6_13 nilveles6_13;
    public Button nivel6_13_2;
    public Button nivel6_13_3;
    public Button nivel6_13_4;
    private int marcador6_13_1;
    private int marcador6_13_2;
    private int marcador6_13_3;
    private int marcador0;
    public GameObject n1;
    // Start is called before the first frame update

    void Awake()
    {
        nilveles6_13 = this;
        nivel6_13_2.interactable = false;
        nivel6_13_3.interactable = false;
        nivel6_13_4.interactable = false;



    }
    void Start()
    {
        GetValor6_13();
        Desbloquear6_13();
        EvitarAudio();
        
    }


    void GetValor6_13()
    {
        marcador0 = Neuro.GetA6131J();
        marcador6_13_1 = Neuro.Get6131S();
        marcador6_13_2 = Neuro.Get6132S();
        marcador6_13_3 = Neuro.Get6133S();


    }

    void Desbloquear6_13()
    {
        if (marcador6_13_1 >= 1)
        {
            nivel6_13_2.interactable = true;

        }

        if (marcador6_13_2 >= 1)
        {
            nivel6_13_3.interactable = true;

        }

        if (marcador6_13_3 >= 1)
        {
            nivel6_13_4.interactable = true;

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
