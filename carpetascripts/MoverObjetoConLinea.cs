using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverObjetoConLinea : MonoBehaviour
{
    public GameObject ObjetoDesplazable;
    public GameObject Buscalineas;
    Linea referencia;
    Vector2 Pos;
    Vector2 NewPos;
    Vector2 primerPunto;
    public GameObject lugarinicio;
    //bool lineaactivada;


    // Start is called before the first frame update
    void Start()
    {
        //primerPunto = lugarinicio.transform.position;
        //NewPos = primerPunto;
        //lineaactivada = false;
        //Invoke ("Activarlinea", 2f);
        

        
    }

    // Update is called once per frame
    void Update()
    {
        
        Buscalineas = GameObject.FindGameObjectWithTag("Linea");
        Linea variable = GetComponent<Linea>();
        
        
        if(Buscalineas != null)
        {
           NewPos = Linea.ultimoPunto;
           ObjetoDesplazable.transform.position = NewPos;
        }

    }

    //public void Retorno(){ObjetoDesplazable.transform.position = primerPunto;}

    public void Activarlinea()
    {
        //lineaactivada = true;

    }

}
