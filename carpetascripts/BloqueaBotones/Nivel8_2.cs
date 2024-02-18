using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nivel8_2 : MonoBehaviour
{
    public static Nivel8_2 nivel8_2;
    private int marcador0;
    public GameObject n1;

    void Awake()
    {
        nivel8_2 = this;

    }
    // Start is called before the first frame update
    void Start()
    {
        GetValor();
        EvitarAudio();
        
    }

    void GetValor()
    {
        marcador0 = Neuro.GetA82();
    }

    void EvitarAudio()
    {
        if (marcador0 >= 1)
        {
            n1.gameObject.SetActive(false);

        }

    }

}
