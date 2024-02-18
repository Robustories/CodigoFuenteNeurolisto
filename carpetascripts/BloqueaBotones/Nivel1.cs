using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nivel1 : MonoBehaviour
{
    public static Nivel1 nivel1;
    public Button nivel1_9;
    public Button nivel1_10;
    private int marcador1_9;
    private int marcador1_10;
    // Start is called before the first frame update
    void Awake()
    {
        nivel1 = this;
        nivel1_9.interactable = false;
        nivel1_10.interactable = false;
        
    }

    void Start()
    {
        GetValor1();
        Desbloquear1();
    }


    void GetValor1()
    {
        marcador1_9 = Neuro.GetA18S();
        marcador1_10 = Neuro.GetA19S();

    }

    void Desbloquear1()
    {
        if (marcador1_9 >= 1)
        {
            nivel1_9.interactable = true;

        }

        if (marcador1_10 >= 1)
        {
            nivel1_10.interactable = true;

        }

    }
}
