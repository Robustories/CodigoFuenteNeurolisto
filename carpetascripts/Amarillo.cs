using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Amarillo : MonoBehaviour
{
    public Color defaultcolor;
    public Color newcolor;
    
    float darktime = 5;// Del cuarto segundo al negro
    float alltime = 1;// Luz amarilla durante 2 segundos, un total de 10 segundos en una ronda
    public Renderer render;
    public Ruta rutaAmarilla;
    private bool inicioAmarillo;
    public GameObject lucecitaAmarilla;
    // Start is called before the first frame update
    void Start()
    {
        
        //Material material = new Material(Shader.Find("Transparent/Diffuse"));
        //material.color = Color.black;
        //GetComponent<Renderer>().material = material;// Pon la luz en negro al principio
        //lucecitaAmarilla.SetActive(false);
        InvokeRepeating("YellowTurn1", 4f, alltime);// Llamar a la función GreenTurn () después de 0 segundos y luego llamarla cada 10 segundos
        InvokeRepeating("TurnBlack2", darktime, alltime);// Luz verde apagada
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        Ruta variable = GetComponent<Ruta>();
        inicioAmarillo = Ruta.iniciarCarrera;

        
        
    }

    void YellowTurn1()
    {
        render = GetComponent<Renderer>();
        render.material.color = Color.yellow;
        //Material material1 = new Material(Shader.Find("Transparent/Diffuse"));
        //material1.color = Color.yellow;
        //GetComponent<Renderer>().material = material1;
        lucecitaAmarilla.SetActive(true);
    }

    void TurnBlack2()
    {
        //Material material2 = new Material(Shader.Find("Transparent/Diffuse"));
        //material2.color = Color.black;
        //GetComponent<Renderer>().material = material2;
        render.material.color = defaultcolor;
        lucecitaAmarilla.SetActive(false);
    }
}
