using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverObjetoConLinea2 : MonoBehaviour
{
    public GameObject ObjetoDesplazable2;
    public GameObject ObjetoDesplazable22;
    public GameObject Buscalineas2;
    public GameObject Buscalineas22;
    //public GameObject Buscalineas22;
    Linea2 referencia2;
    Vector2 Pos2;
    Vector2 Pos22;
    Vector2 NewPos2;
    Vector2 NewPos22;
    Vector2 primerPunto2;
    Vector2 primerPunto22;
    public GameObject lugarinicio2;
    public GameObject lugarinicio22;
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        Buscalineas2 = GameObject.FindGameObjectWithTag("Linea");
        Buscalineas22 = GameObject.FindGameObjectWithTag("Linea2");
        //Buscalineas22 = GameObject.FindGameObjectWithTag("Linea");
        Linea2 variable = GetComponent<Linea2>();

        if(Buscalineas2 != null)

        {       
           NewPos2 = Linea2.ultimoPunto2;
           ObjetoDesplazable2.transform.position = NewPos2;
        }

        if(Buscalineas22 != null)

        {
           NewPos22 = Linea2.ultimoPunto22;
           ObjetoDesplazable22.transform.position = NewPos22;
        }
        
    }
}
