using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Linea : MonoBehaviour
{
    LineRenderer lineas;

    List<Vector2> puntos;
    public static Vector2 ultimoPunto;
    public GameObject Objetomovible;
    public Vector2  puntoinicio;

    private void Awake()
    {
        lineas = GetComponent<LineRenderer>();
        Objetomovible = GameObject.FindGameObjectWithTag("Inicio");
        puntoinicio = Objetomovible.transform.position;
        ultimoPunto = puntoinicio;
    }

    void Start()
    {
        
    }

    public void DibujarLinea(Vector2 mousePos)
    {
        if(puntos == null)
        {
            puntos = new List<Vector2>();
            //DibujarPunto(mousePos);
            
            return;

        }

        if(Vector2.Distance(ultimoPunto, mousePos) >= .01f && Vector2.Distance(ultimoPunto, mousePos) <= .5f)
        {
            DibujarPunto(mousePos);
        }
    }

    void DibujarPunto(Vector2 punto)
    {
        puntos.Add(punto);
        lineas.positionCount = puntos.Count;
        lineas.SetPosition(puntos.Count -1, punto);
        ultimoPunto = punto;
    }

    public void BorrarLineas()
    {
        lineas.positionCount = 0;
    }

    public void ActualizarPosicion()
    {
        puntoinicio = Objetomovible.transform.position;
        ultimoPunto = puntoinicio;

    }
}
