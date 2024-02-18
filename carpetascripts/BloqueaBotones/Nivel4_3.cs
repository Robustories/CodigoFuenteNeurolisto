using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nivel4_3 : MonoBehaviour
{
    public static Nivel4_3 nivel4_3;
    private int marcador0;
    public GameObject n1;

    void Awake()
    {
        nivel4_3 = this;

    }
    // Start is called before the first frame update
    void Start()
    {
        GetValor();
        EvitarAudio();
        
    }

    void GetValor()
    {
        marcador0 = Neuro.GetA43J();
    }

    void EvitarAudio()
    {
        if (marcador0 >= 1)
        {
            n1.gameObject.SetActive(false);

        }

    }

}
