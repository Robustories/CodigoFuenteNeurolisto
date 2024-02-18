using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nivel6 : MonoBehaviour
{
    public static Nivel6 nivel6;
    public Button nivel6_4;
    public Button nivel6_9;
    public Button nivel6_10;
    private int marcador6_4;
    private int marcador6_9;
    private int marcador6_10;
    // Start is called before the first frame update

    void Awake()
    {
        nivel6 = this;
        nivel6_4.interactable = false;
        nivel6_9.interactable = false;
        nivel6_10.interactable = false;
        
    }


    void Start()
    {
        GetValor6();
        Desbloquear6();
    }

    void GetValor6()
    {
        marcador6_4 = Neuro.Get671S();
        marcador6_9 = Neuro.Get681S();
        marcador6_10 = Neuro.Get6153S();

    }

    void Desbloquear6()
    {
        if (marcador6_4 >= 1)
        {
            nivel6_4.interactable = true;

        }

        if (marcador6_9 >= 1)
        {
            nivel6_9.interactable = true;

        }

        if (marcador6_10 >= 1)
        {
            nivel6_10.interactable = true;

        }

    }
}
