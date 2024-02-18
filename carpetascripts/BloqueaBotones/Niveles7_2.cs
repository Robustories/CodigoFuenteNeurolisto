using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Niveles7_2 : MonoBehaviour
{
    public static Niveles7_2 niveles7_2 ;
    public Button nivel7_2_2;
    public Button nivel7_2_3;
    private int marcador7_2_1;
    private int marcador7_2_2;
    private int marcador0;
    public GameObject n1;
    // Start is called before the first frame update

    void Awake()
    {
        niveles7_2 = this;
        nivel7_2_2.interactable = false;
        nivel7_2_3.interactable = false;

    }


    void Start()
    {
        GetValor7_2();
        Desbloquear7_2();
        EvitarAudio();
        
    }

    void GetValor7_2()
    {
        marcador0 = Neuro.GetA721J();
        marcador7_2_1 = Neuro.GetA721S();
        marcador7_2_2 = Neuro.GetA722S();



    }

    void Desbloquear7_2()
    {
        if (marcador7_2_1 >= 1)
        {
            nivel7_2_2.interactable = true;

        }

        if (marcador7_2_2 >= 1)
        {
            nivel7_2_3.interactable = true;

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
