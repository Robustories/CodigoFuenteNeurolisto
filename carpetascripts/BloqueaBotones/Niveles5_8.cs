using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Niveles5_8 : MonoBehaviour
{
    public static Niveles5_8 niveles5_8;
    public Button nivel5_8_2;
    public Button nivel5_8_3;
    public Button nivel5_8_4;
    private int marcador5_8_1;
    private int marcador5_8_2;
    private int marcador5_8_3;
    private int marcador0;
    public GameObject n1;

    void Awake()
    {
        niveles5_8 = this;
        nivel5_8_2.interactable = false;
        nivel5_8_3.interactable = false;
        nivel5_8_4.interactable = false;


    }
    // Start is called before the first frame update
    void Start()
    {
        GetValor5_8();
        Desbloquear5_8();
        EvitarAudio();
        
    }

    void GetValor5_8()
    {
        marcador0 = Neuro.GetA581J();
        marcador5_8_1 = Neuro.Get581S();
        marcador5_8_2 = Neuro.Get582S();
        marcador5_8_3 = Neuro.Get583S();


    }

    void Desbloquear5_8()
    {
        if (marcador5_8_1 >= 1)
        {
            nivel5_8_2.interactable = true;

        }

        if (marcador5_8_2 >= 1)
        {
            nivel5_8_3.interactable = true;

        }

        if (marcador5_8_3 >= 1)
        {
            nivel5_8_4.interactable = true;

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
