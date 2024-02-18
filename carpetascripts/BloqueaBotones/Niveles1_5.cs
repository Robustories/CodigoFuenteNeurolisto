using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Niveles1_5 : MonoBehaviour
{
    public static Niveles1_5 niveles1_5;
    public Button nivel2;
    private int marcador0;
    private int marcador1;
    public GameObject n1;

    void Awake()
    {
        niveles1_5 = this;
        nivel2.interactable = false;
        


    }

    // Start is called before the first frame update

    void Start()
    {
        GetValor();
        Desbloquear();
        EvitarAudio();
        
    }

    void GetValor()
    {
        marcador0 = Neuro.GetA15J();
        marcador1 = Neuro.GetA15S();
        

    }

    void Desbloquear()
    {
        if (marcador1 >= 1)
        {
            nivel2.interactable = true;

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
