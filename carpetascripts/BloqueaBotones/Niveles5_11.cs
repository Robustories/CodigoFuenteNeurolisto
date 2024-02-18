using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Niveles5_11 : MonoBehaviour
{
    public static Niveles5_11 niveles5_11;
    public Button nivel5_11_2;
    public Button nivel5_11_3;
    private int marcador5_11_1;
    private int marcador5_11_2;
    private int marcador0;
    public GameObject n1;
    // Start is called before the first frame update

    void Awake()
    {
        niveles5_11 = this;
        nivel5_11_2.interactable = false;
        nivel5_11_3.interactable = false;


    }
    void Start()
    {
        GetValor5_11();
        Desbloquear5_11();
        EvitarAudio();
        
    }

    void GetValor5_11()
    {
        marcador0 = Neuro.GetA5111J();
        marcador5_11_1 = Neuro.Get5111S();
        marcador5_11_2 = Neuro.Get5112S();


    }

    void Desbloquear5_11()
    {
        if (marcador5_11_1 >= 1)
        {
            nivel5_11_2.interactable = true;

        }

        if (marcador5_11_2 >= 1)
        {
            nivel5_11_3.interactable = true;

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
