using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nivel8_8 : MonoBehaviour
{
    public static Nivel8_8 nivel8_8;
    private int marcador0;
    public GameObject n1;

    void Awake()
    {
        nivel8_8 = this;

    }
    // Start is called before the first frame update
    void Start()
    {
        GetValor();
        EvitarAudio();
        
    }

    void GetValor()
    {
        marcador0 = Neuro.GetA88();
    }

    void EvitarAudio()
    {
        if (marcador0 >= 1)
        {
            n1.gameObject.SetActive(false);

        }

    }
}
