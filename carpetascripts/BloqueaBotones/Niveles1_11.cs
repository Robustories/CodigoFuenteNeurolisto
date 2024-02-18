using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Niveles1_11 : MonoBehaviour
{
    public static Niveles1_11 niveles1_11;
    public Button nivel1_11_2;
    public Button nivel1_11_3;
    private int marcador1_11_1;
    private int marcador1_11_2;
    private int marcador0;
    public GameObject n1;

    void Awake()
    {
        niveles1_11 = this;
        nivel1_11_2.interactable = false;
        nivel1_11_3.interactable = false;

    }

    // Start is called before the first frame update
    void Start()
    {
        GetValor1_11();
        Desbloquear1_11();
        EvitarAudio();
        
    }


    void GetValor1_11()
    {
        marcador0 = Neuro.GetA1111J();
        marcador1_11_1 = Neuro.GetA1111S();
        marcador1_11_2 = Neuro.GetA1112S();

    }

    void Desbloquear1_11()
    {
        if (marcador1_11_1 >= 1)
        {
            nivel1_11_2.interactable = true;

        }

        if (marcador1_11_2 >= 1)
        {
            nivel1_11_3.interactable = true;

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
