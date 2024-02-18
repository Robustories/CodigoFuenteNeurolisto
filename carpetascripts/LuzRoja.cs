using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuzRoja : MonoBehaviour
{
    public Color defaultcolor;
    public Color newcolor;
    
    float darktime = 9;// Del cuarto segundo al negro
    float alltime = 10;// Luz amarilla durante 2 segundos, un total de 10 segundos en una ronda
    public Renderer render;
    public static bool luzRojas = false;
    public Ruta rutaRoja;
    private bool inicioRojo;
    public GameObject lucecitaRoja;
    // Start is called before the first frame update
    // Start is called before the first frame update
    void Start()
    {
        //Material material = new Material(Shader.Find("Transparent/Diffuse"));
        //material.color = Color.black;
        //GetComponent<Renderer>().material = material;// Pon la luz en negro al principio
        //lucecitaRoja.SetActive(false);
        InvokeRepeating("RedTurn1", 5f, alltime);// Llamar a la función GreenTurn () después de 0 segundos y luego llamarla cada 10 segundos
        InvokeRepeating("TurnBlack3", darktime, alltime);// Luz verde apagada

        

        
    }

    // Update is called once per frame
    void Update()
    {
        Ruta variable = GetComponent<Ruta>();
        inicioRojo = Ruta.iniciarCarrera;

        
        
    }

    void RedTurn1()
    {
        render = GetComponent<Renderer>();
        render.material.color = Color.red;
        //Material material1 = new Material(Shader.Find("Transparent/Diffuse"));
        //material1.color = Color.red;
        //GetComponent<Renderer>().material = material1;
        luzRojas = true;
        lucecitaRoja.SetActive(true);
    }

    void TurnBlack3()
    {
        //Material material2 = new Material(Shader.Find("Transparent/Diffuse"));
        //material2.color = Color.black;
        //GetComponent<Renderer>().material = material2;
        render.material.color = defaultcolor;
        luzRojas = false;
        lucecitaRoja.SetActive(false);
    }
}
