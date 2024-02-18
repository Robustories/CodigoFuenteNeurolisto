using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Linea2 : MonoBehaviour
{
    LineRenderer lineas2;
    LineRenderer lineas22;

    List<Vector2> puntos2;
    List<Vector2> puntos22;
    public static Vector2 ultimoPunto2;
    public static Vector2 ultimoPunto22;
    public GameObject Objetomovible2;
    public GameObject Objetomovible22;
    public Vector2  puntoinicio2;
    public Vector2  puntoinicio22;
    Color newcolor;

    public Colorear colorear;

    private void Awake()
    {
        lineas2 = GetComponent<LineRenderer>();
        lineas22 = GetComponent<LineRenderer>();
        Objetomovible2 = GameObject.FindGameObjectWithTag("Inicio");
        Objetomovible22 = GameObject.FindGameObjectWithTag("A");
        puntoinicio2 = Objetomovible2.transform.position;
        puntoinicio22 = Objetomovible22.transform.position;
        ultimoPunto2 = puntoinicio2;
        ultimoPunto22 = puntoinicio22;
        
    }

    void Start()
    {
        
        SetSingleColor(this.GetComponent<LineRenderer>(), Color.blue);
    }

    void Update()
    {
        newcolor = Colorear.colorEscogido;
        SetSingleColor(this.GetComponent<LineRenderer>(), newcolor);
    }

    public void DibujarLinea2(Vector2 mousePos)
    {
        if(puntos2 == null)
        {
            puntos2 = new List<Vector2>();
            //DibujarPunto(mousePos);
            
            return;

        }

        if(Vector2.Distance(ultimoPunto2, mousePos) >= .01f && Vector2.Distance(ultimoPunto2, mousePos) <= .5f)
        {
            DibujarPunto2(mousePos);
        }
    }

    public void DibujarLinea22(Vector2 mousePos)
    {
        if(puntos22 == null)
        {
            puntos22 = new List<Vector2>();
            //DibujarPunto(mousePos);
            
            return;

        }

        if(Vector2.Distance(ultimoPunto22, mousePos) >= .01f && Vector2.Distance(ultimoPunto22, mousePos) <= .5f)
        {
            DibujarPunto22(mousePos);
        }
    }

    

    void DibujarPunto2(Vector2 punto2)
    {
        puntos2.Add(punto2);
        lineas2.positionCount = puntos2.Count;
        lineas2.SetPosition(puntos2.Count -1, punto2);
        ultimoPunto2 = punto2;
    }

    void DibujarPunto22(Vector2 punto22)
    {
        puntos22.Add(punto22);
        lineas22.positionCount = puntos22.Count;
        lineas22.SetPosition(puntos22.Count -1, punto22);
        ultimoPunto22 = punto22;
    }

    public void BorrarLineas2()
    {
        //lineas2.positionCount = 0;
    }

    void SetSingleColor(LineRenderer lineRendererToChange, Color blue)
    {
        lineRendererToChange.startColor = blue;
        lineRendererToChange.endColor = blue;
    }


}
