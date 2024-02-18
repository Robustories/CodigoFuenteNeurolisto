using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Niveles6_12 : MonoBehaviour
{
    public static Niveles6_12 niveles6_12;
    public Button nivel6_12_2;
    public Button nivel6_12_3;
    public Button nivel6_12_4;
    private int marcador6_12_1;
    private int marcador6_12_2;
    private int marcador6_12_3;
    private int marcador0;
    public GameObject n1;
    // Start is called before the first frame update

    void Awake()
    {
        niveles6_12 = this;
        nivel6_12_2.interactable = false;
        nivel6_12_3.interactable = false;
        nivel6_12_4.interactable = false;



    }

    void Start()
    {
        GetValor6_12();
        Desbloquear6_12();
        EvitarAudio();
        
    }

    void GetValor6_12()
    {
        marcador0 = Neuro.GetA6121J();
        marcador6_12_1 = Neuro.Get6121S();
        marcador6_12_2 = Neuro.Get6122S();
        marcador6_12_3 = Neuro.Get6123S();


    }

    void Desbloquear6_12()
    {
        if (marcador6_12_1 >= 1)
        {
            nivel6_12_2.interactable = true;

        }

        if (marcador6_12_2 >= 1)
        {
            nivel6_12_3.interactable = true;

        }

        if (marcador6_12_3 >= 1)
        {
            nivel6_12_4.interactable = true;

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
