using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nivel2_3 : MonoBehaviour
{
    public static Nivel2_3 nivel2_3;
    private int marcador0;
    public GameObject n1;

    void Awake()
    {
        nivel2_3 = this;

    }
    // Start is called before the first frame update
    void Start()
    {
        GetValor();
        EvitarAudio();
        
    }

    void GetValor()
    {
        marcador0 = Neuro.GetA23J();
    }

    void EvitarAudio()
    {
        if (marcador0 >= 1)
        {
            n1.gameObject.SetActive(false);

        }

    }

}
