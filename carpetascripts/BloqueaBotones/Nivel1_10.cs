using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nivel1_10 : MonoBehaviour
{
    public static Nivel1_10 nivel1_10;
    private int marcador0;
    public GameObject n1;

    void Awake()
    {
        nivel1_10 = this;

    }
    // Start is called before the first frame update
    void Start()
    {
        GetValor();
        EvitarAudio();
        
    }

    void GetValor()
    {
        marcador0 = Neuro.GetA110J();
    }

    void EvitarAudio()
    {
        if (marcador0 >= 1)
        {
            n1.gameObject.SetActive(false);

        }

    }

}
