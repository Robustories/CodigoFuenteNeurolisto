using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Niveles1_6 : MonoBehaviour
{
    public static Niveles1_6 niveles1_6;
    public Button nivel1_6_2;
    public Button nivel1_6_3;
    private int marcador1_6_1;
    private int marcador1_6_2;
    private int marcador0;
    public GameObject n1;

    // Start is called before the first frame update
    void Awake()
    {
        niveles1_6 = this;
        nivel1_6_2.interactable = false;
        nivel1_6_3.interactable = false;

        


    }

    void Start()
    {
        GetValor1_6();
        Desbloquear1_6();
        EvitarAudio();
        
    }


    void GetValor1_6()
    {
        marcador0 = Neuro.GetA161J();
        marcador1_6_1 = Neuro.GetA161S();
        marcador1_6_2 = Neuro.GetA162S();
        

    }

    void Desbloquear1_6()
    {
        if (marcador1_6_1 >= 1)
        {
            nivel1_6_2.interactable = true;

        }

        if (marcador1_6_2 >= 1)
        {
            nivel1_6_3.interactable = true;

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
