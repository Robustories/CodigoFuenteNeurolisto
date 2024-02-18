using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nivel4 : MonoBehaviour
{
    public static Nivel4 nivel4;
    public Button nivel4_4;
    public Button nivel4_9;
    public Button nivel4_10;
    private int marcador4_4;
    private int marcador4_9;
    private int marcador4_10;
    // Start is called before the first frame update
    void Awake()
    {
        nivel4 = this;
        nivel4_4.interactable = false;
        nivel4_9.interactable = false;
        nivel4_10.interactable = false;
        
    }
    void Start()
    {
        GetValor4();
        Desbloquear4();
    }


    void GetValor4()
    {
        marcador4_4 = Neuro.Get43S();
        marcador4_9 = Neuro.Get483S();
        marcador4_10 = Neuro.Get492S();

    }

    void Desbloquear4()
    {
        if (marcador4_4 >= 1)
        {
            nivel4_4.interactable = true;

        }

        if (marcador4_9 >= 1)
        {
            nivel4_9.interactable = true;

        }

        if (marcador4_10 >= 1)
        {
            nivel4_10.interactable = true;

        }

    }
}
