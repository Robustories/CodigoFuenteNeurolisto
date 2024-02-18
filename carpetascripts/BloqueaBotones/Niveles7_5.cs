using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Niveles7_5 : MonoBehaviour
{
    public static Niveles7_5 niveles7_5 ;
    public Button nivel7_5_2;
    public Button nivel7_5_3;
    private int marcador7_5_1;
    private int marcador7_5_2;
    private int marcador0;
    public GameObject n1;

    void Awake()
    {
        niveles7_5 = this;
        nivel7_5_2.interactable = false;
        nivel7_5_3.interactable = false;

    }
    // Start is called before the first frame update
    void Start()
    {
        GetValor7_5();
        Desbloquear7_5();
        EvitarAudio();
        
    }

    void GetValor7_5()
    {
        marcador0 = Neuro.GetA751J();
        marcador7_5_1 = Neuro.GetA751S();
        marcador7_5_2 = Neuro.GetA752S();



    }

    void Desbloquear7_5()
    {
        if (marcador7_5_1 >= 1)
        {
            nivel7_5_2.interactable = true;

        }

        if (marcador7_5_2 >= 1)
        {
            nivel7_5_3.interactable = true;

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
