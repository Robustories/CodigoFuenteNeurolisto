using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColoreadoSencillo : MonoBehaviour
{
    public Colorear colorear;
    public ObjetoPintado objetopintado;
    int puntaje;
    int numerodesignado;
    public int numerocorrecto;
    Renderer render;
    Color newcolor;
    public bool connected = false;
    bool recibido;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ObjetoPintado variable = GetComponent<ObjetoPintado>();
        recibido = ObjetoPintado.senalenviada;
        
        if(numerodesignado == numerocorrecto)
        {
            connected = true;
        }
        else
        {
            connected = false;
        }
        

    if(connected == false && recibido == true)
    {
        render.material.color = Color.white;
    }
    }

    void OnMouseUp()
    {
        newcolor = Colorear.colorEscogido;
        numerodesignado = Colorear.numeroAsignado;
        render = GetComponent<Renderer>();
        render.material.color = newcolor;
        
    }
}
