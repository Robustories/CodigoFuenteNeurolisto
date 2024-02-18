using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nivel4_6 : MonoBehaviour
{
    public static Nivel4_6 nivel4_6;
    private int marcador0;
    public GameObject n1;

    void Awake()
    {
        nivel4_6 = this;

    }

    void Start()
    {
        GetValor4_6();
        EvitarAudio4_6();
        
    }

    void GetValor4_6()
    {
        marcador0 = Neuro.GetA46J();
    }

    void EvitarAudio4_6()
    {
        if (marcador0 >= 1)
        {
            n1.gameObject.SetActive(false);
            

        }


    }
}
