using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Niveles1_15 : MonoBehaviour
{
    public static Niveles1_15 niveles1_15;
    public Button nivel1_15_2;
    public Button nivel1_15_3;
    private int marcador1_15_1;
    private int marcador1_15_2;
    private int marcador0;
    public GameObject n1;

    void Awake()
    {
        niveles1_15 = this;
        nivel1_15_2.interactable = false;
        nivel1_15_3.interactable = false;

    }
    // Start is called before the first frame update
    void Start()
    {
        GetValor1_15();
        Desbloquear1_15();
        EvitarAudio();
        
    }

    void GetValor1_15()
    {
        marcador0 = Neuro.GetA1151J();
        marcador1_15_1 = Neuro.GetA1151S();
        marcador1_15_2 = Neuro.GetA1152S();

    }

    void Desbloquear1_15()
    {
        if (marcador1_15_1 >= 1)
        {
            nivel1_15_2.interactable = true;

        }

        if (marcador1_15_2 >= 1)
        {
            nivel1_15_3.interactable = true;

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
