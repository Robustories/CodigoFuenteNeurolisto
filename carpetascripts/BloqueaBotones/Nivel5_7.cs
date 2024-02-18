using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nivel5_7 : MonoBehaviour
{
    public static Nivel5_7 nivel5_7;
    private int marcador0;
    public GameObject n1;

    void Awake()
    {
        nivel5_7 = this;

    }
    // Start is called before the first frame update
    void Start()
    {
        GetValor();
        EvitarAudio();
        
    }

    void GetValor()
    {
        marcador0 = Neuro.GetA57J();
    }

    void EvitarAudio()
    {
        if (marcador0 >= 1)
        {
            n1.gameObject.SetActive(false);

        }

    }

}
