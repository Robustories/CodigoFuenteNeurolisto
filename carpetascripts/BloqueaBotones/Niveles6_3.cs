using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Niveles6_3 : MonoBehaviour
{
    public static Niveles6_3 niveles6_3;
    public Button nivel6_3_2;
    public Button nivel6_3_3;
    public Button nivel6_3_4;
    public Button nivel6_3_5;
    private int marcador6_3_1;
    private int marcador6_3_2;
    private int marcador6_3_3;
    private int marcador6_3_4;
    private int marcador0;
    public GameObject n1;
    // Start is called before the first frame update

    void Awake()
    {
        niveles6_3 = this;
        nivel6_3_2.interactable = false;
        nivel6_3_3.interactable = false;
        nivel6_3_4.interactable = false;
        nivel6_3_5.interactable = false;


    }

    void Start()
    {
        GetValor6_3();
        Desbloquear6_3();
        EvitarAudio();
        
    }

    void GetValor6_3()
    {
        marcador0 = Neuro.GetA631J();
        marcador6_3_1 = Neuro.Get631S();
        marcador6_3_2 = Neuro.Get632S();
        marcador6_3_3 = Neuro.Get633S();
        marcador6_3_4 = Neuro.Get634S();


    }

    void Desbloquear6_3()
    {
        if (marcador6_3_1 >= 1)
        {
            nivel6_3_2.interactable = true;

        }

        if (marcador6_3_2 >= 1)
        {
            nivel6_3_3.interactable = true;

        }

        if (marcador6_3_3 >= 1)
        {
            nivel6_3_4.interactable = true;

        }

        if (marcador6_3_4 >= 1)
        {
            nivel6_3_5.interactable = true;

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
