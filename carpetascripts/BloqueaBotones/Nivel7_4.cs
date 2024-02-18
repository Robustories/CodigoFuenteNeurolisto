using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nivel7_4 : MonoBehaviour
{
    public static Nivel7_4 nivel7_4;
    private int marcador0;
    public GameObject n1;

    void Awake()
    {
        nivel7_4 = this;

    }
    // Start is called before the first frame update
    void Start()
    {
        GetValor();
        EvitarAudio();
        
    }

    void GetValor()
    {
        marcador0 = Neuro.GetA74J();
    }

    void EvitarAudio()
    {
        if (marcador0 >= 1)
        {
            n1.gameObject.SetActive(false);

        }

    }
}
