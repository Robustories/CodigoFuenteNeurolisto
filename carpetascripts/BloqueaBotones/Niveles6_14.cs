using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Niveles6_14 : MonoBehaviour
{
    public static Niveles6_14 niveles6_14;
    public Button nivel6_14_2;
    private int marcador6_14_1;
    public Button nivel6_14_3;
    private int marcador6_14_2;
    private int marcador0;
    public GameObject n1;
    // Start is called before the first frame update

    void Awake()
    {
        niveles6_14 = this;
        nivel6_14_2.interactable = false;
        nivel6_14_3.interactable = false;




    }
    void Start()
    {
        GetValor6_14();
        Desbloquear6_14();
        EvitarAudio();
        
    }

    void GetValor6_14()
    {
        marcador0 = Neuro.GetA6141J();
        marcador6_14_1 = Neuro.Get6141S();
        marcador6_14_2 = Neuro.Get6142S();


    }

    void Desbloquear6_14()
    {
        if (marcador6_14_1 >= 1)
        {
            nivel6_14_2.interactable = true;

        }

        if (marcador6_14_2 >= 1)
        {
            nivel6_14_3.interactable = true;

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
