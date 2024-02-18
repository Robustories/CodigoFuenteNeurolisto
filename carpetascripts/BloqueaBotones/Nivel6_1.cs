using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nivel6_1 : MonoBehaviour
{
    public static Nivel6_1 nivel6_1;
    public Button nivel6_1_2;
    private int marcador6_1_1;
    private int marcador0;
    public GameObject n1;
    // Start is called before the first frame update

    void Awake()
    {
        nivel6_1 = this;
        nivel6_1_2.interactable = false;


    }
    void Start()
    {
        GetValor6_1();
        Desbloquear6_1();
        EvitarAudio();
        
    }

    void GetValor6_1()
    {
        marcador0 = Neuro.GetA611J();
        marcador6_1_1 = Neuro.Get611S();


    }

    void Desbloquear6_1()
    {
        if (marcador6_1_1 >= 1)
        {
            nivel6_1_2.interactable = true;

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
