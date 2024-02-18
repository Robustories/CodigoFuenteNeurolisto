using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Niveles7_7 : MonoBehaviour
{
    public static Niveles7_7 niveles7_7 ;
    public Button nivel7_7_2;
    public Button nivel7_7_3;
    private int marcador7_7_1;
    private int marcador7_7_2;
    private int marcador0;
    public GameObject n1;

    void Awake()
    {
        niveles7_7 = this;
        nivel7_7_2.interactable = false;
        nivel7_7_3.interactable = false;

    }
    // Start is called before the first frame update
    void Start()
    {
        GetValor7_7();
        Desbloquear7_7();
        EvitarAudio();
        
    }

    void GetValor7_7()
    {
        marcador0 = Neuro.GetA771J();
        marcador7_7_1 = Neuro.GetA771S();
        marcador7_7_2 = Neuro.GetA772S();



    }

    void Desbloquear7_7()
    {
        if (marcador7_7_1 >= 1)
        {
            nivel7_7_2.interactable = true;

        }

        if (marcador7_7_2 >= 1)
        {
            nivel7_7_3.interactable = true;

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
