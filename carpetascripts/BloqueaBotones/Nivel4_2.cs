using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nivel4_2 : MonoBehaviour
{
    public static Nivel4_2 nivel4_2;
    private int marcador0;
    public GameObject n1;

    void Awake()
    {
        nivel4_2 = this;

    }
    // Start is called before the first frame update
    void Start()
    {
        GetValor();
        EvitarAudio();
        
    }

    void GetValor()
    {
        marcador0 = Neuro.GetA42J();
    }

    void EvitarAudio()
    {
        if (marcador0 >= 1)
        {
            n1.gameObject.SetActive(false);

        }

    }

}
