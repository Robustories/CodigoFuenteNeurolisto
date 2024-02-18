using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Niveles5_12 : MonoBehaviour
{
    public static Niveles5_12 niveles5_12;
    public Button nivel5_12_2;
    public Button nivel5_12_3;
    public Button nivel5_12_4;
    private int marcador5_12_1;
    private int marcador5_12_2;
    private int marcador5_12_3;
    private int marcador0;
    public GameObject n1;
    // Start is called before the first frame update

    void Awake()
    {
        niveles5_12 = this;
        nivel5_12_2.interactable = false;
        nivel5_12_3.interactable = false;
        nivel5_12_4.interactable = false;


    }
    void Start()
    {
        GetValor5_12();
        Desbloquear5_12();
        EvitarAudio();
        
    }

    void GetValor5_12()
    {
        marcador0 = Neuro.GetA5121J();
        marcador5_12_1 = Neuro.Get5121S();
        marcador5_12_2 = Neuro.Get5122S();
        marcador5_12_3 = Neuro.Get5123S();


    }

    void Desbloquear5_12()
    {
        if (marcador5_12_1 >= 1)
        {
            nivel5_12_2.interactable = true;

        }

        if (marcador5_12_2 >= 1)
        {
            nivel5_12_3.interactable = true;

        }

        if (marcador5_12_3 >= 1)
        {
            nivel5_12_4.interactable = true;

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
