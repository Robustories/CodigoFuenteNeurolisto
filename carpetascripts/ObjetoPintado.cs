using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoPintado : MonoBehaviour
{
    public Colorear colorear;
    private Color colorSeleccion1, colorSeleccion2, colorSeleccion3, colorSeleccion4, colorSeleccion5, colorSeleccion6, colorSeleccion7, colorSeleccion8;
    public Color Seleccionado;
    public Renderer render;
    public Renderer render2;
    public Renderer render3;
    public Renderer render4;
    public Renderer render5;
    public Renderer render6;
    public Renderer render7;
    public Renderer render8;
    public bool ObjetoAPintar;
    public bool ObjetoAPintar2;
    public bool ObjetoAPintar3;
    public bool ObjetoAPintar4;
    public bool ObjetoAPintar5;
    public bool ObjetoAPintar6;
    public bool ObjetoAPintar7;
    public bool ObjetoAPintar8;
    public int numeroRespuesta1, numeroRespuesta2, numeroRespuesta3, numeroRespuesta4, numeroRespuesta5, numeroRespuesta6, numeroRespuesta7, numeroRespuesta8;
    private int numeroObtenido1, numeroObtenido2, numeroObtenido3 , numeroObtenido4, numeroObtenido5 , numeroObtenido6, numeroObtenido7 , numeroObtenido8;
    public static bool senalenviada;
    public GameObject pantallaColoreado;
    private bool correcto1;
    public int numerovictoria;
    int numerototal;
    bool won;
    
    // Start is called before the first frame update
    void Start()
    {
        
        pantallaColoreado.gameObject.SetActive(false);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        //ColoreadoSencillo[] yourObjects = FindObjectsOfType<ColoreadoSencillo>();
        //numerototal = yourObjects.puntaje;
        Colorear variable = GetComponent<Colorear>();
        Colorear variable2 = GetComponent<Colorear>();
        Colorear variable3 = GetComponent<Colorear>();
        Colorear variable4 = GetComponent<Colorear>();
        Colorear variable5 = GetComponent<Colorear>();
        Colorear variable6 = GetComponent<Colorear>();
        Colorear variable7 = GetComponent<Colorear>();
        Colorear variable8 = GetComponent<Colorear>();

        


        
        


        if (ObjetoAPintar == true)
        {
            render.material.color = colorSeleccion1;
            
        }

        if (ObjetoAPintar2 == true)
        {
            render2.material.color = colorSeleccion2;
            
        }

        if (ObjetoAPintar3 == true)
        {
            render3.material.color = colorSeleccion3;
            
        }

        if (ObjetoAPintar4 == true)
        {
            render4.material.color = colorSeleccion4;
            
        }

        if (ObjetoAPintar5 == true)
        {
            render5.material.color = colorSeleccion5;
            
        }

        if (ObjetoAPintar6 == true)
        {
            render6.material.color = colorSeleccion6;
           
        }

        if (ObjetoAPintar7 == true)
        {
            render7.material.color = colorSeleccion7;
            
        }

        if (ObjetoAPintar8 == true)
        {
            render8.material.color = colorSeleccion8;
            
        }
        
    }

    public void Revisar()
    {
        ColoreadoSencillo[] yourObjects = FindObjectsOfType<ColoreadoSencillo>();
        foreach(ColoreadoSencillo sc in yourObjects)//for each script
     {
        if(sc.connected == true)//if the boolean is true then win
        {
          won = true;
        }
        else
        {
          won = false;
          EnviarSenal();
          Invoke ("Retornar", 0.3f);
          break;
        }
     }

        if (won == true)
        {
            Invoke ("GanarPintar", 0.3f);
            
        }

    }

    public void Revisar2()
    {
        if(numeroObtenido1 == numeroRespuesta1 && numeroObtenido2 == numeroRespuesta2 && numeroObtenido3 == numeroRespuesta3 && numeroObtenido4 == numeroRespuesta4 )
        {
            Invoke ("GanarPintar", 0.3f);

        }
        else
        {
            if(numeroObtenido1 != numeroRespuesta1)
            {
                colorSeleccion1 = Color.white;
            }

            if(numeroObtenido2 != numeroRespuesta2)
            {
                colorSeleccion2 = Color.white;
            }

            if(numeroObtenido3 != numeroRespuesta3)
            {
                colorSeleccion3 = Color.white;
            }

            if(numeroObtenido4 != numeroRespuesta4)
            {
                colorSeleccion4 = Color.white;
            }


        }

    }

    public void Revisar3()
    {
        if(numeroObtenido1 == numeroRespuesta1 && numeroObtenido2 == numeroRespuesta2 && numeroObtenido3 == numeroRespuesta3 && numeroObtenido4 == numeroRespuesta4
        &&  numeroObtenido5 == numeroRespuesta5 && numeroObtenido6 == numeroRespuesta6)
        {
            Invoke ("GanarPintar", 0.3f);

        }
        else
        {
            if(numeroObtenido1 != numeroRespuesta1)
            {
                colorSeleccion1 = Color.white;
            }

            if(numeroObtenido2 != numeroRespuesta2)
            {
                colorSeleccion2 = Color.white;
            }

            if(numeroObtenido3 != numeroRespuesta3)
            {
                colorSeleccion3 = Color.white;
            }

            if(numeroObtenido4 != numeroRespuesta4)
            {
                colorSeleccion4 = Color.white;
            }

            if(numeroObtenido5 != numeroRespuesta5)
            {
                colorSeleccion5 = Color.white;
            }

            if(numeroObtenido6 != numeroRespuesta6)
            {
                colorSeleccion6 = Color.white;
            }


        }

    }

    public void Revisar4()
    {
        if(numeroObtenido1 == numeroRespuesta1 && numeroObtenido2 == numeroRespuesta2 && numeroObtenido3 == numeroRespuesta3 && numeroObtenido4 == numeroRespuesta4
        &&  numeroObtenido5 == numeroRespuesta5 && numeroObtenido6 == numeroRespuesta6 &&  numeroObtenido7 == numeroRespuesta7 && numeroObtenido8 == numeroRespuesta8)
        {
            Invoke ("GanarPintar", 0.3f);

        }
        else
        {
            if(numeroObtenido1 != numeroRespuesta1)
            {
                colorSeleccion1 = Color.white;
            }

            if(numeroObtenido2 != numeroRespuesta2)
            {
                colorSeleccion2 = Color.white;
            }

            if(numeroObtenido3 != numeroRespuesta3)
            {
                colorSeleccion3 = Color.white;
            }

            if(numeroObtenido4 != numeroRespuesta4)
            {
                colorSeleccion4 = Color.white;
            }

            if(numeroObtenido5 != numeroRespuesta1)
            {
                colorSeleccion5 = Color.white;
            }

            if(numeroObtenido6 != numeroRespuesta2)
            {
                colorSeleccion6 = Color.white;
            }

            if(numeroObtenido7 != numeroRespuesta3)
            {
                colorSeleccion7 = Color.white;
            }

            if(numeroObtenido8 != numeroRespuesta4)
            {
                colorSeleccion8 = Color.white;
            }


        }

    }

    

    

    public void CambiarObjeto1()
    {
        if(ObjetoAPintar == false)             
        {
            
            ObjetoAPintar = true;
            render.material.color = Seleccionado;
            Debug.Log("1");
            colorSeleccion1 = Colorear.colorEscogido;
            numeroObtenido1 = Colorear.numeroAsignado;
        }
        else
        {
            ObjetoAPintar = false;
            
        }
    }

    

    public void CambiarObjeto2()
    {
        if(ObjetoAPintar2 == false)             
        {
            ObjetoAPintar2 = true;
            render2.material.color = Seleccionado;
            colorSeleccion2 = Colorear.colorEscogido;
            numeroObtenido2 = Colorear.numeroAsignado;
        }

        else
        {
            ObjetoAPintar2 = false;
            
        }
    }

    public void CambiarObjeto3()
    {
        if(ObjetoAPintar3 == false)             
        {
            ObjetoAPintar3 = true;
            render3.material.color = Seleccionado;
            colorSeleccion3 = Colorear.colorEscogido;
            numeroObtenido3 = Colorear.numeroAsignado;
        }

        else
        {
            ObjetoAPintar3 = false;
            
        }
    }

    public void CambiarObjeto4()
    {
        if(ObjetoAPintar4 == false)             
        {
            ObjetoAPintar4 = true;
            render4.material.color = Seleccionado;
            colorSeleccion4 = Colorear.colorEscogido;
            numeroObtenido4 = Colorear.numeroAsignado;
        }

        else
        {
            ObjetoAPintar4 = false;
            
        }
    }

    public void CambiarObjeto5()
    {
        if(ObjetoAPintar5 == false)             
        {
            ObjetoAPintar5 = true;
            render5.material.color = Seleccionado;
            colorSeleccion5 = Colorear.colorEscogido;
            numeroObtenido5 = Colorear.numeroAsignado;
        }

        else
        {
            ObjetoAPintar5 = false;
            
        }
    }

    public void CambiarObjeto6()
    {
        if(ObjetoAPintar6 == false)             
        {
            ObjetoAPintar6 = true;
            render6.material.color = Seleccionado;
            colorSeleccion6 = Colorear.colorEscogido;
            numeroObtenido6 = Colorear.numeroAsignado;
        }

        else
        {
            ObjetoAPintar6 = false;
            
        }
    }

    public void CambiarObjeto7()
    {
        if(ObjetoAPintar7 == false)             
        {
            ObjetoAPintar7 = true;
            render7.material.color = Seleccionado;
            colorSeleccion7 = Colorear.colorEscogido;
            numeroObtenido7 = Colorear.numeroAsignado;
        }

        else
        {
            ObjetoAPintar7 = false;
            
        }
    }

    public void CambiarObjeto8()
    {
        if(ObjetoAPintar8 == false)             
        {
            ObjetoAPintar8 = true;
            render8.material.color = Seleccionado;
            colorSeleccion8 = Colorear.colorEscogido;
            numeroObtenido8 = Colorear.numeroAsignado;
        }

        else
        {
            ObjetoAPintar8 = false;
            
        }
    }

    void GanarPintar()
    { 
        pantallaColoreado.SetActive(true);
    }

    void EnviarSenal()
    {
        senalenviada = true;

    }

    void Retornar()
    {
        senalenviada = false;
    }

    
}
