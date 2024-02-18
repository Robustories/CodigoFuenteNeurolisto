using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Niveles7_1 : MonoBehaviour
{
    public static Niveles7_1 niveles7_1 ;
    public Button nivel7_1_2;
    public Button nivel7_1_3;
    public Button nivel7_1_4;
    public Button nivel7_1_5;
    private int marcador7_1_1;
    private int marcador7_1_2;
    private int marcador7_1_3;
    private int marcador7_1_4;
    private int marcador0;
    public GameObject n1;
    // Start is called before the first frame update

    void Awake()
    {
        niveles7_1 = this;
        nivel7_1_2.interactable = false;
        nivel7_1_3.interactable = false;
        nivel7_1_4.interactable = false;
        nivel7_1_5.interactable = false;



    }


    void Start()
    {
        GetValor7_1();
        Desbloquear7_1();
        EvitarAudio();
        
    }

    void GetValor7_1()
    {
        marcador0 = Neuro.GetA711J();
        marcador7_1_1 = Neuro.GetA711S();
        marcador7_1_2 = Neuro.GetA712S();
        marcador7_1_3 = Neuro.GetA713S();
        marcador7_1_4 = Neuro.GetA714S();


    }

    void Desbloquear7_1()
    {
        if (marcador7_1_1 >= 1)
        {
            nivel7_1_2.interactable = true;

        }

        if (marcador7_1_2 >= 1)
        {
            nivel7_1_3.interactable = true;

        }

        if (marcador7_1_3 >= 1)
        {
            nivel7_1_4.interactable = true;

        }

        if (marcador7_1_4 >= 1)
        {
            nivel7_1_5.interactable = true;

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
