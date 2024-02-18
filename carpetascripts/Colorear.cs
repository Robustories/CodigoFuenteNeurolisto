using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colorear : MonoBehaviour
{
    public Color color1;
    public Color color2;
    public Color color3;
    public Color color4;
    public Color color5;
    public Color color6;
    public Color color7;
    public Color color8;
    public static Color colorEscogido =Color.black;
    public static int numeroAsignado;
    
    // Start is called before the first frame update
    void Start()
    {
        
        Pintar1();
        
    }

    public void Pintar1()
    {
        colorEscogido = color1;
        numeroAsignado = 1;
    }

    public void Pintar2()
    {
        colorEscogido = color2;
        numeroAsignado = 2;
    }

    public void Pintar3()
    {
        colorEscogido = color3;
        numeroAsignado = 3;
    }

    public void Pintar4()
    {
        colorEscogido = color4;
        numeroAsignado = 4;
    }

    public void Pintar5()
    {
        colorEscogido = color5;
        numeroAsignado = 5;
    }

    public void Pintar6()
    {
        colorEscogido = color6;
        numeroAsignado = 6;
    }

    public void Pintar7()
    {
        colorEscogido = color7;
        numeroAsignado = 7;
    }

    public void Pintar8()
    {
        colorEscogido = color8;
        numeroAsignado = 8;
    }

    
}
