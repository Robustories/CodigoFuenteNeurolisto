using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nivel1_8 : MonoBehaviour
{
    public static Nivel1_8 nivel1_8;
    private int marcador0;
    public GameObject n1;
    public GameObject n2;

    void Awake()
    {
        nivel1_8 = this;

    }
    // Start is called before the first frame update
    void Start()
    {
        GetValor();
        EvitarAudio();
        
    }

    void GetValor()
    {
        marcador0 = Neuro.GetA18J();
    }

    void EvitarAudio()
    {
        if (marcador0 >= 1)
        {
            n1.gameObject.SetActive(false);
            n2.gameObject.SetActive(false);

        }

    }

}
