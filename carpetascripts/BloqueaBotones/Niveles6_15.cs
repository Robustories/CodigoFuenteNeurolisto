using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Niveles6_15 : MonoBehaviour
{
    public static Niveles6_15 niveles6_15;
    public Button nivel6_15_2;
    public Button nivel6_15_3;
    private int marcador6_15_1;
    private int marcador6_15_2;
    private int marcador0;
    public GameObject n1;
    // Start is called before the first frame update

    void Awake()
    {
        niveles6_15 = this;
        nivel6_15_2.interactable = false;
        nivel6_15_3.interactable = false;



    }
    void Start()
    {
        GetValor6_15();
        Desbloquear6_15();
        EvitarAudio();
        
    }

    void GetValor6_15()
    {
        marcador0 = Neuro.GetA6151J();
        marcador6_15_1 = Neuro.Get6151S();
        marcador6_15_2 = Neuro.Get6152S();


    }

    void Desbloquear6_15()
    {
        if (marcador6_15_1 >= 1)
        {
            nivel6_15_2.interactable = true;

        }

        if (marcador6_15_2 >= 1)
        {
            nivel6_15_3.interactable = true;

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
