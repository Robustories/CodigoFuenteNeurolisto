using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuzVerde : MonoBehaviour
{
    public Color defaultcolor;
    public Color newcolor;
    
    float darktime = 4;// Del cuarto segundo al negro
    float alltime = 10;// Luz amarilla durante 2 segundos, un total de 10 segundos en una ronda
    public Renderer render;
    public Ruta rutaVerde;
    private bool inicioVerde;
    public GameObject lucecitaVerde;
    
    void Start()
    {
        //Material material = new Material(Shader.Find("Transparent/Diffuse"));
        //material.color = Color.black;
        //GetComponent<Renderer>().material = material;// Pon la luz en negro al principio
        //lucecitaVerde.SetActive(false);
        InvokeRepeating("GreenTurn1", 0f, alltime);// Llamar a la función GreenTurn () después de 0 segundos y luego llamarla cada 10 segundos
        InvokeRepeating("TurnBlack1", darktime, alltime);// Luz verde apagada
        
        
    }
    
    void Update()
    {
        Ruta variable = GetComponent<Ruta>();
        inicioVerde = Ruta.iniciarCarrera;

        
    }
    
    void GreenTurn1()
    {
        render = GetComponent<Renderer>();
        render.material.color = Color.green;
        //Material material1 = new Material(Shader.Find("Transparent/Diffuse"));
        //material1.color = Color.green;
        //GetComponent<Renderer>().material = material1;
        lucecitaVerde.SetActive(true);
        Debug.Log("Prueba Verde");
    }

    
    void TurnBlack1()
    {
        //Material material2 = new Material(Shader.Find("Transparent/Diffuse"));
        //material2.color = Color.black;
        //GetComponent<Renderer>().material = material2;
        render.material.color = defaultcolor;
        lucecitaVerde.SetActive(false);
        Debug.Log("Prueba Negro");
    }
}
