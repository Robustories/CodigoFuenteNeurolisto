using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nivel4_4 : MonoBehaviour
{
    public static Nivel4_4 nivel4_4;
    private int marcador0;
    public GameObject n1;
    public GameObject n2;

    void Awake()
    {
        nivel4_4 = this;

    }
    // Start is called before the first frame update
    void Start()
    {
        GetValor4_4();
        EvitarAudio4_4();
        
    }

    void GetValor4_4()
    {
        marcador0 = Neuro.GetA44J();
    }

    void EvitarAudio4_4()
    {
        if (marcador0 >= 1)
        {
            n1.gameObject.SetActive(false);
            

        }

        if (marcador0 >= 1)
        {
            n2.gameObject.SetActive(false);
            

        }

    }

}
