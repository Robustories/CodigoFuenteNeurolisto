using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Niveles2_4 : MonoBehaviour
{
   public static Niveles2_4 niveles2_4;
    public Button nivel2_4_2;
    public Button nivel2_4_3;
    private int marcador2_4_1;
    private int marcador2_4_2;
    private int marcador0;
    public GameObject n1;

    void Awake()
    {
        niveles2_4 = this;
        nivel2_4_2.interactable = false;
        nivel2_4_3.interactable = false;

    }
    // Start is called before the first frame update
    void Start()
    {
        GetValor2_4();
        Desbloquear2_4();
        EvitarAudio();
        
    }

    void GetValor2_4()
    {
        marcador0 = Neuro.GetA241J();
        marcador2_4_1 = Neuro.Get241S();
        marcador2_4_2 = Neuro.Get242S();


    }

    void Desbloquear2_4()
    {
        if (marcador2_4_1 >= 1)
        {
            nivel2_4_2.interactable = true;

        }

        if (marcador2_4_2 >= 1)
        {
            nivel2_4_3.interactable = true;

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
