using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nivel2_7 : MonoBehaviour
{
    public static Nivel2_7 nivel2_7;
    private int marcador0;
    public GameObject n1;

    void Awake()
    {
        nivel2_7 = this;

    }
    // Start is called before the first frame update
    void Start()
    {
        GetValor();
        EvitarAudio();
        
    }

    void GetValor()
    {
        marcador0 = Neuro.GetA27J();
    }

    void EvitarAudio()
    {
        if (marcador0 >= 1)
        {
            n1.gameObject.SetActive(false);

        }

    }

}
