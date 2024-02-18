using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nivel5 : MonoBehaviour
{
    public static Nivel5 nivel5;
    public Button nivel5_4;
    public Button nivel5_9;
    public Button nivel5_10;
    private int marcador5_4;
    private int marcador5_9;
    private int marcador5_10;
    // Start is called before the first frame update
    void Awake()
    {
        nivel5 = this;
        nivel5_4.interactable = false;
        nivel5_9.interactable = false;
        nivel5_10.interactable = false;
        
    }

    void Start()
    {
        GetValor5();
        Desbloquear5();
    }

    void GetValor5()
    {
        marcador5_4 = Neuro.Get52S();
        marcador5_9 = Neuro.Get584S();
        marcador5_10 = Neuro.Get59S();

    }

    void Desbloquear5()
    {
        if (marcador5_4 >= 1)
        {
            nivel5_4.interactable = true;

        }

        if (marcador5_9 >= 1)
        {
            nivel5_9.interactable = true;

        }

        if (marcador5_10 >= 1)
        {
            nivel5_10.interactable = true;

        }

    }
}
