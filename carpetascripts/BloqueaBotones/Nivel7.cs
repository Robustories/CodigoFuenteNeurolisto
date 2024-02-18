using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nivel7 : MonoBehaviour
{
    public static Nivel7 nivel7;
    public Button nivel7_4;
    public Button nivel7_9;
    public Button nivel7_10;
    private int marcador7_4;
    private int marcador7_9;
    private int marcador7_10;

    void Awake()
    {
        nivel7 = this;
        nivel7_4.interactable = false;
        nivel7_9.interactable = false;
        nivel7_10.interactable = false;
        
    }
    // Start is called before the first frame update
    void Start()
    {
        GetValor7();
        Desbloquear7();
    }

    void GetValor7()
    {
        marcador7_4 = Neuro.GetA74S();
        marcador7_9 = Neuro.GetA76S();
        marcador7_10 = Neuro.GetA79S();

    }

    void Desbloquear7()
    {
        if (marcador7_4 >= 1)
        {
            nivel7_4.interactable = true;

        }

        if (marcador7_9 >= 1)
        {
            nivel7_9.interactable = true;

        }

        if (marcador7_10 >= 1)
        {
            nivel7_10.interactable = true;

        }

    }
}
