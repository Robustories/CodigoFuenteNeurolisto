using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nivel3_9 : MonoBehaviour
{
    public static Nivel3_9 nivel3_9;
    private int marcador0;
    public GameObject n1;

    void Awake()
    {
        nivel3_9 = this;

    }
    // Start is called before the first frame update
    void Start()
    {
        GetValor();
        EvitarAudio();
        
    }

    void GetValor()
    {
        marcador0 = Neuro.GetA39J();
    }

    void EvitarAudio()
    {
        if (marcador0 >= 1)
        {
            n1.gameObject.SetActive(false);

        }

    }

}
