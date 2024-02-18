using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Niveles6_4 : MonoBehaviour
{
    public static Niveles6_4 niveles6_4;
    public Button nivel6_4_2;
    public Button nivel6_4_3;
    public Button nivel6_4_4;
    public Button nivel6_4_5;
    private int marcador6_4_1;
    private int marcador6_4_2;
    private int marcador6_4_3;
    private int marcador6_4_4;
    private int marcador0;
    public GameObject n1;

    void Awake()
    {
        niveles6_4 = this;
        nivel6_4_2.interactable = false;
        nivel6_4_3.interactable = false;
        nivel6_4_4.interactable = false;
        nivel6_4_5.interactable = false;


    }
    // Start is called before the first frame update
    void Start()
    {
        GetValor6_4();
        Desbloquear6_4();
        EvitarAudio();
        
    }

    void GetValor6_4()
    {
        marcador0 = Neuro.GetA64J();
        marcador6_4_1 = Neuro.Get64S();
        marcador6_4_2 = Neuro.Get642S();
        marcador6_4_3 = Neuro.Get643S();
        marcador6_4_4 = Neuro.Get644S();


    }

    void Desbloquear6_4()
    {
        if (marcador6_4_1 >= 1)
        {
            nivel6_4_2.interactable = true;

        }

        if (marcador6_4_2 >= 1)
        {
            nivel6_4_3.interactable = true;

        }

        if (marcador6_4_3 >= 1)
        {
            nivel6_4_4.interactable = true;

        }

        if (marcador6_4_4 >= 1)
        {
            nivel6_4_5.interactable = true;

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
