using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Niveles6_16 : MonoBehaviour
{
    public static Niveles6_16 niveles6_16;
    public Button nivel6_16_2;
    public Button nivel6_16_3;
    private int marcador6_16_1;
    private int marcador6_16_2;
    private int marcador0;
    public GameObject n1;
    // Start is called before the first frame update

    void Awake()
    {
        niveles6_16 = this;
        nivel6_16_2.interactable = false;
        nivel6_16_3.interactable = false;



    }
    void Start()
    {
        GetValor6_16();
        Desbloquear6_16();
        EvitarAudio();
        
    }

    void GetValor6_16()
    {
        marcador0 = Neuro.GetA6161J();
        marcador6_16_1 = Neuro.Get6161S();
        marcador6_16_2 = Neuro.Get6162S();


    }

    void Desbloquear6_16()
    {
        if (marcador6_16_1 >= 1)
        {
            nivel6_16_2.interactable = true;

        }

        if (marcador6_16_2 >= 1)
        {
            nivel6_16_3.interactable = true;

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
