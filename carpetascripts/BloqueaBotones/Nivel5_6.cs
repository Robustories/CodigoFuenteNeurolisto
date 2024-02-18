using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nivel5_6 : MonoBehaviour
{
    public static Nivel5_6 nivel5_6;
    private int marcador0;
    public GameObject n1;

    void Awake()
    {
        nivel5_6 = this;

    }
    // Start is called before the first frame update
    void Start()
    {
        GetValor();
        EvitarAudio();
        
    }

    void GetValor()
    {
        marcador0 = Neuro.GetA56J();
    }

    void EvitarAudio()
    {
        if (marcador0 >= 1)
        {
            n1.gameObject.SetActive(false);

        }

    }

}
