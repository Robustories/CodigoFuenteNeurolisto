using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Niveles6_11 : MonoBehaviour
{
    public static Niveles6_11 niveles6_11;
    public Button nivel6_11_2;
    public Button nivel6_11_3;
    private int marcador6_11_1;
    private int marcador6_11_2;
    private int marcador0;
    public GameObject n1;
    // Start is called before the first frame update

    void Awake()
    {
        niveles6_11 = this;
        nivel6_11_2.interactable = false;
        nivel6_11_3.interactable = false;




    }


    void Start()
    {
        GetValor6_11();
        Desbloquear6_11();
        EvitarAudio();
        
    }

    void GetValor6_11()
    {
        marcador0 = Neuro.GetA6111J();
        marcador6_11_1 = Neuro.Get6111S();
        marcador6_11_2 = Neuro.Get6112S();



    }

    void Desbloquear6_11()
    {
        if (marcador6_11_1 >= 1)
        {
            nivel6_11_2.interactable = true;

        }

        if (marcador6_11_2 >= 1)
        {
            nivel6_11_3.interactable = true;

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
