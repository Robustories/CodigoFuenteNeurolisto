using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Niveles7_3 : MonoBehaviour
{
    public static Niveles7_3 niveles7_3 ;
    public Button nivel7_3_2;
    public Button nivel7_3_3;
    private int marcador7_3_1;
    private int marcador7_3_2;
    private int marcador0;
    public GameObject n1;
    // Start is called before the first frame update

    void Awake()
    {
        niveles7_3 = this;
        nivel7_3_2.interactable = false;
        nivel7_3_3.interactable = false;

    }


    void Start()
    {
        GetValor7_3();
        Desbloquear7_3();
        EvitarAudio();
        
    }

    void GetValor7_3()
    {
        marcador0 = Neuro.GetA731J();
        marcador7_3_1 = Neuro.GetA731S();
        marcador7_3_2 = Neuro.GetA732S();



    }

    void Desbloquear7_3()
    {
        if (marcador7_3_1 >= 1)
        {
            nivel7_3_2.interactable = true;

        }

        if (marcador7_3_2 >= 1)
        {
            nivel7_3_3.interactable = true;

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
