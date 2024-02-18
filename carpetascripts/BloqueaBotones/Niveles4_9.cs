using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Niveles4_9 : MonoBehaviour
{
   public static Niveles4_9 niveles4_9;
   public Button nivel4_9_2;
   public Button nivel4_9_3;
   private int marcador4_9_1;
   private int marcador4_9_2;
   private int marcador0;
   public GameObject n1;


    void Awake()
    {
        niveles4_9 = this;
        nivel4_9_2.interactable = false;
        nivel4_9_3.interactable = false;



    }
    // Start is called before the first frame update
    void Start()
    {
        GetValor4_9();
        Desbloquear4_9();
        EvitarAudio();
        
    }


    void GetValor4_9()
    {
        marcador0 = Neuro.GetA491J();
        marcador4_9_1 = Neuro.Get491S();
        marcador4_9_2 = Neuro.Get492S();
        
        



    }

    void Desbloquear4_9()
    {
        if (marcador4_9_1 >= 1)
        {
            nivel4_9_2.interactable = true;

        }

        if (marcador4_9_2 >= 1)
        {
            nivel4_9_3.interactable = true;

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

 
