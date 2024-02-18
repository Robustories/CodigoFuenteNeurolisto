using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nivel3_10 : MonoBehaviour
{
    public static Nivel3_10 nivel3_10;
    private int marcador0;
    public GameObject n1;

    void Awake()
    {
        nivel3_10 = this;

    }
    // Start is called before the first frame update
    void Start()
    {
        GetValor();
        EvitarAudio();
        
    }

    void GetValor()
    {
        marcador0 = Neuro.GetA310J();
    }

    void EvitarAudio()
    {
        if (marcador0 >= 1)
        {
            n1.gameObject.SetActive(false);

        }

    }

}
