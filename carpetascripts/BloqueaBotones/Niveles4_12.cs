using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Niveles4_12 : MonoBehaviour
{
    public static Niveles4_12 niveles4_12;
    public Button nivel4_12_2;
    public Button nivel4_12_3;
    private int marcador4_12_1;
    private int marcador4_12_2;
    private int marcador0;
    public GameObject n1;

    void Awake()
    {
        niveles4_12 = this;
        nivel4_12_2.interactable = false;
        nivel4_12_3.interactable = false;


    }
    // Start is called before the first frame update
    void Start()
    {
        GetValor4_12();
        Desbloquear4_12();
        EvitarAudio();
        
    }

    void GetValor4_12()
    {
        marcador0 = Neuro.GetA4121J();
        marcador4_12_1 = Neuro.Get4121S();
        marcador4_12_2 = Neuro.Get4122S();


    }

    void Desbloquear4_12()
    {
        if (marcador4_12_1 >= 1)
        {
            nivel4_12_2.interactable = true;

        }

        if (marcador4_12_2 >= 1)
        {
            nivel4_12_3.interactable = true;

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
