using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Semaforo : MonoBehaviour
{
    public Color defaultcolor;
    public Color newcolor;
    public Renderer render;
    
    //float ytime = 2;// La luz verde está encendida durante 4 segundos, comenzando desde el segundo cero
    float darktime = 4;// Del cuarto segundo al negro
    float alltime = 10;
    float yellowtime = 5;// Luz amarilla durante 2 segundos, un total de 10 segundos en una ronda
    public static bool rojo = false;
    public static bool verde;
    public GameObject luzroja;
    public GameObject luzverde;
    public GameObject luzamarilla;
    public int numeroCambioLuz;
    public float tiempoSemaforo = 0.0f;
    public Text tiempoPrueba;
    public float escaladeTiempo = 1;
    
    public Ruta rutas;
    private bool inicioFuncionamiento;

   

    
    // Start is called before the first frame update
    void Start()
    {
        
        Material material = new Material(Shader.Find("Transparent/Diffuse"));
        material.color = Color.black;
        GetComponent<Renderer>().material = material;// Pon la luz en negro al principio
        
        
        
        
        
       
    }

    // Update is called once per frame
    void Update()
    {
        Ruta variable = GetComponent<Ruta>();
        inicioFuncionamiento = Ruta.iniciarCarrera;

        if(inicioFuncionamiento == true)
        {
            InvokeRepeating("GreenTurn", 0f, alltime);
            InvokeRepeating("YellowTurn", 4f, yellowtime);
            InvokeRepeating("RedTurn", 5f, alltime);// Llamar a la función GreenTurn () después de 0 segundos y luego llamarla cada 10 segundos
            InvokeRepeating("TurnBlack", darktime, alltime);// Luz verde apagada

        }


        
        
        

        
        
    }

    

    void GreenTurn()
    {
        render = GetComponent<Renderer>();
        render.material.color = newcolor;
        Material material1 = new Material(Shader.Find("Transparent/Diffuse"));
        material1.color = Color.green;
        GetComponent<Renderer>().material = material1;
        
        
    }

    void YellowTurn()
    {
        render = GetComponent<Renderer>();
        render.material.color = newcolor;
        Material material1 = new Material(Shader.Find("Transparent/Diffuse"));
        material1.color = Color.yellow;
        GetComponent<Renderer>().material = material1;
        rojo = false;
        
        
    }

    void RedTurn()
    {
        render = GetComponent<Renderer>();
        render.material.color = newcolor;
        Material material1 = new Material(Shader.Find("Transparent/Diffuse"));
        material1.color = Color.red;
        GetComponent<Renderer>().material = material1;
        rojo = true;
        
        
    }

    void TurnBlack()
    {
        Material material2 = new Material(Shader.Find("Transparent/Diffuse"));
        material2.color = Color.black;
        GetComponent<Renderer>().material = material2;
        
    }

    private void OnMouseOver()
    {
        render = GetComponent<Renderer>();
        render.material.color = newcolor;
    }

    
}

