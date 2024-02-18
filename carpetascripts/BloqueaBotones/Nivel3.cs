using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nivel3 : MonoBehaviour
{
    public static Nivel3 nivel3;
    public Button nivel3_9;
    public Button nivel3_10;
    private int marcador3_9;
    private int marcador3_10;
    // Start is called before the first frame update
    void Awake()
    {
        nivel3 = this;
        nivel3_9.interactable = false;
        nivel3_10.interactable = false;
        
    }
    void Start()
    {
        GetValor3();
        Desbloquear3();
    }


    void GetValor3()
    {
        marcador3_9 = Neuro.Get383S();
        marcador3_10 = Neuro.Get39S();

    }

    void Desbloquear3()
    {
        if (marcador3_9 >= 1)
        {
            nivel3_9.interactable = true;

        }

        if (marcador3_10 >= 1)
        {
            nivel3_10.interactable = true;

        }

    }
}
