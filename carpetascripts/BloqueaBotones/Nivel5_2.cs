using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nivel5_2 : MonoBehaviour
{
    public static Nivel5_2 nivel5_2;
    private int marcador0;
    public GameObject n1;

    void Awake()
    {
        nivel5_2 = this;

    }
    // Start is called before the first frame update
    void Start()
    {
        GetValor();
        EvitarAudio();
        
    }

    void GetValor()
    {
        marcador0 = Neuro.GetA52J();
    }

    void EvitarAudio()
    {
        if (marcador0 >= 1)
        {
            n1.gameObject.SetActive(false);

        }

    }

}
