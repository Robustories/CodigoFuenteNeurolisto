using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Niveles7_10 : MonoBehaviour
{
    public static Niveles7_10 niveles7_10 ;
    public Button nivel7_10_2;
    public Button nivel7_10_3;
    private int marcador7_10_1;
    private int marcador7_10_2;
    private int marcador0;
    public GameObject n1;

    // Start is called before the first frame update
    void Awake()
    {
        niveles7_10 = this;
        nivel7_10_2.interactable = false;
        nivel7_10_3.interactable = false;

    }

    void Start()
    {
        GetValor7_10();
        Desbloquear7_10();
        EvitarAudio();
        
    }

    void GetValor7_10()
    {
        marcador0 = Neuro.GetA7101J();
        marcador7_10_1 = Neuro.GetA7101S();
        marcador7_10_2 = Neuro.GetA7102S();



    }

    void Desbloquear7_10()
    {
        if (marcador7_10_1 >= 1)
        {
            nivel7_10_2.interactable = true;

        }

        if (marcador7_10_2 >= 1)
        {
            nivel7_10_3.interactable = true;

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
