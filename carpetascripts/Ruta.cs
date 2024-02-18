using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ruta : MonoBehaviour{
    



public Transform target;
public Transform target2;
public float speed;
public bool error;
public bool puedeMoverse = true;
public bool pausaTemporal = false;
public bool enRojo;
private int puntosNegativos;
public int puntosPerder;
public Text vidasPerdidas;
public GameObject pantallaPerder11;
float repetirCambio = 10;
public static bool iniciarCarrera;
public Image barraDeVida;
public float vidaActual;
public float vidaMaxima;
public Meta metaa;
public static bool paro = true;
public bool Conteo = true;
public float ConteoRegresivo = 0;
public Text TextoCompleto;
public GameObject Penalizaciono;
[SerializeField]
private int seconds;
private int s;
private bool puntollegada1;
public CambioDireccion cd1;

[SerializeField]
public Text cuentaregresiva;

public Reloj reloj;



void Start()
    
    {
        Meta variable = GetComponent<Meta>();
        LuzRoja variable2 = GetComponent<LuzRoja>();
        CambioDireccion variable3 = GetComponent<CambioDireccion>();
        Reloj variable4 = GetComponent<Reloj>();

        pantallaPerder11.SetActive(false);
        Penalizaciono.SetActive(false);
        //InvokeRepeating("CambiarARojo", 5f, repetirCambio);
        //InvokeRepeating("QuitarRojo", 9f, repetirCambio);
        puntosNegativos = puntosPerder;
        InvokeRepeating("CambiarARojo", 5f, repetirCambio);
        InvokeRepeating("QuitarRojo", 9f, repetirCambio);
    
    }




void Update() 
{
    
    puntollegada1 = CambioDireccion.CambioEtapa1;
    if(TextoCompleto != null)
        {
            TextoCompleto.text =  ConteoRegresivo.ToString();
        }

    //parar = Meta.llegada;

    //enRojo = LuzRoja.luzRojas;
    //enRojo = Semaforo.rojo;
    
    
    //{float step = speed * Time.deltaTime;
    //transform.position = Vector3.MoveTowards(transform.position, target.position, step);}

    if (iniciarCarrera && paro == true)
        {
        
        
        Moverse();
        if (Input.GetMouseButtonUp(0)){Detener();}
        if (Input.GetMouseButtonDown(0)){Arrancar();}

        if(puntollegada1 == true)
    { 
        transform.eulerAngles = new Vector3(0, 0, 90);
        Cambiardireccion1();
        if (Input.GetMouseButtonUp(0)){Detener();}
        if (Input.GetMouseButtonDown(0)){Arrancar();}

    }
        
        }

    //if (Input.GetMouseButtonUp(0)){Detener();}
    //if (Input.GetMouseButtonDown(0)){Arrancar();}

    if(enRojo && puedeMoverse == true)
    {
        //puntosNegativos--;  
        //vidaActual--;  
        Penalizacion();
        
        

    }

    if(enRojo && puedeMoverse && Conteo == true)
    {
        reloj.Reiniciar();
        Conteo = false;
        Penalizaciono.SetActive(true);
        ConteoRegresivo = reloj.tiempoAMostrarEnSegundos;
        Invoke ("CambioConteo", 1f);
        Invoke ("OcultarPenalizacion", 5f);
        

    }



    vidasPerdidas.text = vidaActual.ToString();

    

    barraDeVida.fillAmount = vidaActual/vidaMaxima;
    puntollegada1 = CambioDireccion.CambioEtapa1;

    if(puntollegada1 && paro == true)
    { 
        Cambiardireccion1();
    }
    

    

    

    
    
}

public void Detener()
{
    speed = 0;
    puedeMoverse = false;
    
}

public void Arrancar()
{

    speed = 1f;
    puedeMoverse = true;
    Moverse();
    Debug.Log("Arranco");
    
    
    
}

public void CambiarARojo()
{
    enRojo = true;

}

public void QuitarRojo()
{
    enRojo = false;

}

public void BotonInicio()
{
    iniciarCarrera = true;
}

public void Moverse()
{
    {float step = speed * Time.deltaTime;
    transform.position = Vector3.MoveTowards(transform.position, target.position, step);}
    

}

public void Penalizacion()
{
    paro = false;
    Invoke ("Retomar", 5f);
    Conteo = true;
    iniciarCarrera = false;

    

    


}

public void Retomar()
{
    paro= true;
    Conteo = true;


}

public void IniciarTimer()
{
    EscribirTimer(s);
    Invoke ("ActualizarTimer", 1f);
    

}

public void DetenerTimer()
{
    
}

public void ActualizarTimer()
{
    s--;
    
}

private void EscribirTimer(int s)
{
    cuentaregresiva.text = ":"+ s.ToString();


}

private void CambioConteo()
{
    Conteo = false;

}

private void OcultarPenalizacion()
{
    Penalizaciono.SetActive(false);
}

public void Cambiardireccion1()
{   {float step = speed * Time.deltaTime;
    transform.position = Vector3.MoveTowards(transform.position, target2.position, step);}
    Debug.Log("Cambio Direccion Detectado");
    Debug.Log(speed);

}






}