using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicaFlecha : MonoBehaviour
{
    public float velocidad;
    public int contador = 0;
    public bool adentro = false;
    public Button btn{get {return GetComponent<Button>();}}
    public LogicaBoton logicaBoton;
    public bool senal;
    public GameObject buttonPersistance;


    // Start is called before the first frame update
    void Start()
    {
         buttonPersistance= GameObject.Find("Bo");
    }

    // Update is called once per frame
    void Update()
    {
        LogicaBoton logicaBoton = buttonPersistance.GetComponent<LogicaBoton>();
        
        
        transform.position+=transform.right*-velocidad*Time.deltaTime;
        if (contador == 2)
        {
            adentro = true;
        }
        else
        {
            adentro = false;
        }

        if (Input.GetMouseButtonDown(0))

        //if (logicaBoton.pressed)
        {
            if(adentro)
            {
                GameObject.Find("CasillaJugador").GetComponent<LogicaJugador>().puntaje++;
                GameObject.Find("CasillaJugador").GetComponent<LogicaJugador>().texto.text= "Score: "+ 
                GameObject.Find("CasillaJugador").GetComponent<LogicaJugador>().puntaje.ToString();
                Destroy(gameObject);

            }
        }

        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
            if(collision.gameObject.tag== "Player")
            {
                contador++;
            }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
            if(collision.gameObject.tag== "Player")
            {
                contador--;
            }
    }

    //public void AccionarBoton()

    
    
 

 
}
