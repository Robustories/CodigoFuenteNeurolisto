using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laberinto : MonoBehaviour
{
    public GameObject NeuroPerdido;
    public Transform[] direcciones;
    public List<int> patrondirecciones;
    public float velocidadNeuro = 1f;
    public int inputInSequence2;
    public GameObject saliDelLaberinto;
    public int valorSalida;
    Vector2 entrada;
    public Transform prueba;
    // Start is called before the first frame update
    void Start()
    {
        saliDelLaberinto.gameObject.SetActive(false);
        entrada = NeuroPerdido.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {

        if(inputInSequence2 == valorSalida)
        {
            saliDelLaberinto.gameObject.SetActive(true); 
        }
        
    }

    public void RevisarDerecha()
    {
        
        if(patrondirecciones[inputInSequence2] == 1)
        {
        Avanzar();
        inputInSequence2++;
        
        Debug.Log("Derecha correcto");
        Debug.Log(inputInSequence2);
        }
        else
        {inputInSequence2 = 0;
        RegresarInicio();
        }

        //}

    }

    public void RevisarIzquierda()
    {
        
        if(patrondirecciones[inputInSequence2] == 2)
        {
        
        Avanzar();
        inputInSequence2++;
        Debug.Log("Izquierda correcto");
        Debug.Log(inputInSequence2);
        }
        else
        {inputInSequence2 = 0;
        RegresarInicio();
        }

        //}

    }

    public void RevisarAbajo()
    {
        
        if(patrondirecciones[inputInSequence2] == 3)
        {
        
        Avanzar();
        
        inputInSequence2++;
        Debug.Log("Abajo correcto");
        Debug.Log(inputInSequence2);
        }
        else
        {inputInSequence2 = 0;
        RegresarInicio();
        }

        //}

    }

    public void RevisarArriba()
    {
        
        if(patrondirecciones[inputInSequence2] == 4)
        {
        Avanzar();
        
        inputInSequence2++;
        Debug.Log("Arriba correcto");
        Debug.Log(inputInSequence2);
        }
        else
        {inputInSequence2 = 0;
        RegresarInicio();
        }

        //}

    }

    void RegresarInicio()
    {
        NeuroPerdido.transform.position = prueba.transform.position;
    }

    void Avanzar()
    {
        Debug.Log("Avanzo");
        //float step = velocidadNeuro * Time.deltaTime;
        //NeuroPerdido.transform.position = Vector3.MoveTowards(transform.position, direcciones[inputInSequence2].position, step);}
        NeuroPerdido.transform.position = direcciones[inputInSequence2].transform.position;
       
    }

    
}
