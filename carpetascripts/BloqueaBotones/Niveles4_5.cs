using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Niveles4_5 : MonoBehaviour
{
   public static Niveles4_5 niveles4_5;
    public Button nivel4_5_2;
    public Button nivel4_5_3;
    private int marcador4_5_1;
    private int marcador4_5_2;
    private int marcador0;
    public GameObject n1;

    void Awake()
    {
        niveles4_5 = this;
        nivel4_5_2.interactable = false;
        nivel4_5_3.interactable = false;


    }
    // Start is called before the first frame update
    void Start()
    {
        GetValor4_5();
        Desbloquear4_5();
        EvitarAudio();
        
    }


    void GetValor4_5()
    {
        marcador0 = Neuro.GetA451J();
        marcador4_5_1 = Neuro.Get451S();
        marcador4_5_2 = Neuro.Get452S();


    }

    void Desbloquear4_5()
    {
        if (marcador4_5_1 >= 1)
        {
            nivel4_5_2.interactable = true;

        }

        if (marcador4_5_2 >= 1)
        {
            nivel4_5_3.interactable = true;

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
