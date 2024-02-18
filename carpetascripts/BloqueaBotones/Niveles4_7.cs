using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Niveles4_7 : MonoBehaviour
{
   public static Niveles4_7 niveles4_7;
    public Button nivel4_7_2;
    public Button nivel4_7_3;
    private int marcador4_7_1;
    private int marcador4_7_2;
    private int marcador0;
    public GameObject n1;

    void Awake()
    {
        niveles4_7 = this;
        nivel4_7_2.interactable = false;
        nivel4_7_3.interactable = false;


    }
    // Start is called before the first frame update
    void Start()
    {
        GetValor4_7();
        Desbloquear4_7();
        EvitarAudio();
        
    }

    void GetValor4_7()
    {
        marcador0 = Neuro.GetA471J();
        marcador4_7_1 = Neuro.Get471S();
        marcador4_7_2 = Neuro.Get472S();


    }

    void Desbloquear4_7()
    {
        if (marcador4_7_1 >= 1)
        {
            nivel4_7_2.interactable = true;

        }

        if (marcador4_7_2 >= 1)
        {
            nivel4_7_3.interactable = true;

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
