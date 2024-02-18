using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Niveles6_9 : MonoBehaviour
{
    public static Niveles6_9 niveles6_9;
    public Button nivel6_9_2;
    public Button nivel6_9_3;
    private int marcador6_9_1;
    private int marcador6_9_2;
    private int marcador0;
    public GameObject n1;
    // Start is called before the first frame update

    void Awake()
    {
        niveles6_9 = this;
        nivel6_9_2.interactable = false;
        nivel6_9_3.interactable = false;



    }
    void Start()
    {
        GetValor6_9();
        Desbloquear6_9();
        EvitarAudio();
        
    }

    void GetValor6_9()
    {
        marcador0 = Neuro.GetA691J();
        marcador6_9_1 = Neuro.Get691S();
        marcador6_9_2 = Neuro.Get692S();


    }

    void Desbloquear6_9()
    {
        if (marcador6_9_1 >= 1)
        {
            nivel6_9_2.interactable = true;

        }

        if (marcador6_9_2 >= 1)
        {
            nivel6_9_3.interactable = true;

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
