using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Niveles1_14 : MonoBehaviour
{
    public static Niveles1_14 niveles1_14;
    public Button nivel1_14_2;
    public Button nivel1_14_3;
    public Button nivel1_14_4;
    private int marcador1_14_1;
    private int marcador1_14_2;
    private int marcador1_14_3;
    // Start is called before the first frame update

    void Awake()
    {
        niveles1_14 = this;
        nivel1_14_2.interactable = false;
        nivel1_14_3.interactable = false;
        nivel1_14_4.interactable = false;       
    }

    void Start()
    {
        GetValor1_14();
        Desbloquear1_14();
        
    }


    void GetValor1_14()
    {
        

    }

    void Desbloquear1_14()
    {
        if (marcador1_14_1 >= 1)
        {
            nivel1_14_2.interactable = true;

        }

        if (marcador1_14_2 >= 1)
        {
            nivel1_14_3.interactable = true;

        }

        if (marcador1_14_3 >= 1)
        {
            nivel1_14_4.interactable = true;

        }

    }
}
