using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Niveles1_1 : MonoBehaviour
{
    public static Niveles1_1 niveles1_1;
    public Button nivel2;
    public Button nivel3;
    public Button nivel4;
    private int marcador01_1;
    private int marcador1;
    private int marcador2;
    private int marcador3;
    public GameObject n1_1;
    // Start is called before the first frame update
    void Awake()
    {
        niveles1_1 = this;
        nivel2.interactable = false;
        nivel3.interactable = false;
        nivel4.interactable = false;
        


    }

    void Start()
    {
        
        GetValor1_1();
        Desbloquear1_1();
        EvitarAudio1_1();
        
    }

    // Update is called once per frame

    void GetValor1_1()
    {
        marcador01_1 = Neuro.GetA111J();
        marcador1 = Neuro.GetA111S();
        marcador2 = Neuro.GetA112S();
        marcador3 = Neuro.GetA113S();

    }

    void Desbloquear1_1()
    {
        if (marcador1 >= 1)
        {
            nivel2.interactable = true;

        }

        if (marcador2 >= 1)
        {
            nivel3.interactable = true;

        }

        if (marcador3 >= 1)
        {
            nivel4.interactable = true;

        }
        
    }

    void EvitarAudio1_1()
    {
        if (marcador01_1 >= 1)
        {
            n1_1.gameObject.SetActive(false);

        }

    }
}
