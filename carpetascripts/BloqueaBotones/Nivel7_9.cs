using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nivel7_9 : MonoBehaviour
{
    public static Nivel7_9 nivel7_9;
    public Button nivel7_9_2;
    public Button nivel7_9_3;
    private int marcador7_9_1;
    private int marcador7_9_2;
    private int marcador0;
    public GameObject n1;

    void Awake()
    {
        nivel7_9 = this;
        nivel7_9_2.interactable = false;
        nivel7_9_3.interactable = false;

    }
    // Start is called before the first frame update
    void Start()
    {
        GetValor7_9();
        Desbloquear7_9();
        EvitarAudio();
        
    }

    void GetValor7_9()
    {
        marcador0 = Neuro.GetA79J();
        marcador7_9_1 = Neuro.GetA79S();
        marcador7_9_2 = Neuro.GetA792S();
    }

    void Desbloquear7_9()
    {
        if (marcador7_9_1 >= 1)
        {
            nivel7_9_2.interactable = true;

        }

        if (marcador7_9_2 >= 1)
        {
            nivel7_9_3.interactable = true;

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
