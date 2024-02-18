using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nivel1_2 : MonoBehaviour
{
    public static Nivel1_2 nivel1_2;
    private int marcador0;
    public GameObject n1_2;

    void Awake()
    {
        nivel1_2 = this;

    }
    // Start is called before the first frame update
    void Start()
    {
        GetValor();
        EvitarAudio();
        
    }

    void GetValor()
    {
        marcador0 = Neuro.GetA12J();
    }

    void EvitarAudio()
    {
        if (marcador0 >= 1)
        {
            n1_2.gameObject.SetActive(false);

        }

    }

}
