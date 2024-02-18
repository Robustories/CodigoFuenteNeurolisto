using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Niveles5_10 : MonoBehaviour
{
    public static Niveles5_10 niveles5_10;
    public Button nivel5_10_2;
    public Button nivel5_10_3;
    private int marcador5_10_1;
    private int marcador5_10_2;
    private int marcador0;
    public GameObject n1;

    // Start is called before the first frame update

    void Awake()
    {
        niveles5_10 = this;
        nivel5_10_2.interactable = false;
        nivel5_10_3.interactable = false;


    }
    void Start()
    {
        GetValor5_10();
        Desbloquear5_10();
        EvitarAudio();
        
    }

    void GetValor5_10()
    {
        marcador0 = Neuro.GetA5101J();
        marcador5_10_1 = Neuro.Get5101S();
        marcador5_10_2 = Neuro.Get5102S();


    }

    void Desbloquear5_10()
    {
        if (marcador5_10_1 >= 1)
        {
            nivel5_10_2.interactable = true;

        }

        if (marcador5_10_2 >= 1)
        {
            nivel5_10_3.interactable = true;

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
