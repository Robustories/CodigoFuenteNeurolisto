using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Niveles4_8 : MonoBehaviour
{
   public static Niveles4_8 niveles4_8;
    public Button nivel4_8_2;
    public Button nivel4_8_3;
    private int marcador4_8_1;
    private int marcador4_8_2;
    private int marcador0;
    public GameObject n1;

    void Awake()
    {
        niveles4_8 = this;
        nivel4_8_2.interactable = false;
        nivel4_8_3.interactable = false;


    }
    // Start is called before the first frame update
    void Start()
    {
        GetValor4_8();
        Desbloquear4_8();
        EvitarAudio();
        
    }

    void GetValor4_8()
    {
        marcador0 = Neuro.GetA481J();
        marcador4_8_1 = Neuro.Get481S();
        marcador4_8_2 = Neuro.Get482S();


    }

    void Desbloquear4_8()
    {
        if (marcador4_8_1 >= 1)
        {
            nivel4_8_2.interactable = true;

        }

        if (marcador4_8_2 >= 1)
        {
            nivel4_8_3.interactable = true;

        }
    
    }
    
    void EvitarAudio()
    {
        if (marcador0 >= 1)
        {
            n1.gameObject.SetActive(false);

        }

    }
}
