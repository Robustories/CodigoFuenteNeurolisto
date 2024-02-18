using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Niveles4_11 : MonoBehaviour
{
   public static Niveles4_11 niveles4_11;
    public Button nivel4_11_2;
    public Button nivel4_11_3;
    private int marcador4_11_1;
    private int marcador4_11_2;
    private int marcador0;
    public GameObject n1;

    void Awake()
    {
        niveles4_11 = this;
        nivel4_11_2.interactable = false;
        nivel4_11_3.interactable = false;


    }
    // Start is called before the first frame update
    void Start()
    {
        GetValor4_11();
        Desbloquear4_11();
        EvitarAudio();
        
    }

    void GetValor4_11()
    {
        marcador0 = Neuro.GetA4111J();
        marcador4_11_1 = Neuro.Get4111S();
        marcador4_11_2 = Neuro.Get4112S();


    }

    void Desbloquear4_11()
    {
        if (marcador4_11_1 >= 1)
        {
            nivel4_11_2.interactable = true;

        }

        if (marcador4_11_2 >= 1)
        {
            nivel4_11_3.interactable = true;

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
