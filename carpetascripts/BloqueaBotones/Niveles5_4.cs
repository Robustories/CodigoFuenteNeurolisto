using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Niveles5_4 : MonoBehaviour
{
    public static Niveles5_4 niveles5_4;
    public Button nivel5_4_2;
    public Button nivel5_4_3;
    private int marcador5_4_1;
    private int marcador5_4_2;
    private int marcador0;
    public GameObject n1;

    void Awake()
    {
        niveles5_4 = this;
        nivel5_4_2.interactable = false;
        nivel5_4_3.interactable = false;


    }
    // Start is called before the first frame update
    void Start()
    {
        GetValor5_4();
        Desbloquear5_4();
        EvitarAudio();
    }

    void GetValor5_4()
    {
        marcador0 = Neuro.GetA541J();
        marcador5_4_1 = Neuro.Get541S();
        marcador5_4_2 = Neuro.Get542S();


    }

    void Desbloquear5_4()
    {
        if (marcador5_4_1 >= 1)
        {
            nivel5_4_2.interactable = true;

        }

        if (marcador5_4_2 >= 1)
        {
            nivel5_4_3.interactable = true;

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
