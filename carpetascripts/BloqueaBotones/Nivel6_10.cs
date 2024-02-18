using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nivel6_10 : MonoBehaviour
{
    public static Nivel6_10 nivel6_10;
    public Button nivel6_10_2;
    public Button nivel6_10_3;
    private int marcador6_10_1;
    private int marcador6_10_2;
    private int marcador0;
    public GameObject n1;

    void Awake()
    {
        nivel6_10 = this;
        nivel6_10_2.interactable = false;
        nivel6_10_3.interactable = false;

    }
    // Start is called before the first frame update
    void Start()
    {
        GetValor();
        EvitarAudio();
        Desbloquear6_10();
        
    }

    void GetValor()
    {
        marcador0 = Neuro.GetA610J();
        marcador6_10_1 = Neuro.Get610S();
        marcador6_10_2 = Neuro.Get6102S();
    }

    void Desbloquear6_10()
    {
        if (marcador6_10_1 >= 1)
        {
            nivel6_10_2.interactable = true;

        }

        if (marcador6_10_2 >= 1)
        {
            nivel6_10_3.interactable = true;

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
