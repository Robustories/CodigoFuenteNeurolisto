using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Niveles5_3 : MonoBehaviour
{
    public static Niveles5_3 niveles5_3;
    public Button nivel5_3_2;
    public Button nivel5_3_3;
    private int marcador5_3_1;
    private int marcador5_3_2;
    private int marcador0;
    public GameObject n1;

    void Awake()
    {
        niveles5_3 = this;
        nivel5_3_2.interactable = false;
        nivel5_3_3.interactable = false;


    }
    // Start is called before the first frame update
    void Start()
    {
        GetValor5_3();
        Desbloquear5_3();
        EvitarAudio();
        
    }

    void GetValor5_3()
    {
        marcador0 = Neuro.GetA531J();
        marcador5_3_1 = Neuro.Get531S();
        marcador5_3_2 = Neuro.Get532S();


    }

    void Desbloquear5_3()
    {
        if (marcador5_3_1 >= 1)
        {
            nivel5_3_2.interactable = true;

        }

        if (marcador5_3_2 >= 1)
        {
            nivel5_3_3.interactable = true;

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
