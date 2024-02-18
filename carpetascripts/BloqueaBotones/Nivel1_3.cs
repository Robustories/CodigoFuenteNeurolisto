using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nivel1_3 : MonoBehaviour
{
   public static Nivel1_3 nivel1_3;
    private int marcador0;
    public GameObject n1_3;

    void Awake()
    {
        nivel1_3 = this;

    }
    // Start is called before the first frame update
    void Start()
    {
        GetValor();
        EvitarAudio();
        
    }

    void GetValor()
    {
        marcador0 = Neuro.GetA13J();
    }

    void EvitarAudio()
    {
        if (marcador0 >= 1)
        {
            n1_3.gameObject.SetActive(false);

        }

    }

}
