using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nivel8_10 : MonoBehaviour
{
    public static Nivel8_10 nivel8_10;
    private int marcador0;
    public GameObject n1;

    void Awake()
    {
        nivel8_10 = this;

    }
    // Start is called before the first frame update
    void Start()
    {
        GetValor();
        EvitarAudio();
        
    }

    void GetValor()
    {
        marcador0 = Neuro.GetA810();
    }

    void EvitarAudio()
    {
        if (marcador0 >= 1)
        {
            n1.gameObject.SetActive(false);

        }

    }

}
