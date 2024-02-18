using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nivel7_8 : MonoBehaviour
{
    public static Nivel7_8 nivel7_8 ;
    public Button nivel7_8_2;
    public Button nivel7_8_3;
    public Button nivel7_8_4;
    public Button nivel7_8_5;
    private int marcador7_8_1;
    private int marcador7_8_2;
    private int marcador7_8_3;
    private int marcador7_8_4;
    private int marcador0;
    public GameObject n1;
    // Start is called before the first frame update
    void Awake()
    {
        nivel7_8 = this;
        nivel7_8_2.interactable = false;
        nivel7_8_3.interactable = false;
        nivel7_8_4.interactable = false;
        nivel7_8_5.interactable = false;

    }
    void Start()
    {
        GetValor7_8();
        Desbloquear7_8();
        EvitarAudio();
        
    }

    void GetValor7_8()
    {
        marcador0 = Neuro.GetA781();
        marcador7_8_1 = Neuro.GetA781S();
        marcador7_8_2 = Neuro.GetA782S();
        marcador7_8_3 = Neuro.GetA783S();
        marcador7_8_4 = Neuro.GetA784S();



    }

    void Desbloquear7_8()
    {
        if (marcador7_8_1 >= 1)
        {
            nivel7_8_2.interactable = true;

        }

        if (marcador7_8_2 >= 1)
        {
            nivel7_8_3.interactable = true;

        }

        if (marcador7_8_3 >= 1)
        {
            nivel7_8_4.interactable = true;

        }

        if (marcador7_8_4 >= 1)
        {
            nivel7_8_5.interactable = true;

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
