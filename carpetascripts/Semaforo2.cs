using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Semaforo2 : MonoBehaviour
{
    public SpriteRenderer Verdel;
    public SpriteRenderer Amarillol;
    public SpriteRenderer Rojol;
    
    float alltime = 10;
    float yellowtime = 5;

    public Ruta rutal;
    private bool inicioFuncionamientol;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ruta variable = GetComponent<Ruta>();
        inicioFuncionamientol = Ruta.iniciarCarrera;

        if(inicioFuncionamientol == true)
        {
            InvokeRepeating("GreenTurn", 0f, alltime);
            InvokeRepeating("YellowTurn", 4f, yellowtime);
            InvokeRepeating("RedTurn", 5f, alltime);// Llamar a la función GreenTurn () después de 0 segundos y luego llamarla cada 10 segundos
            //InvokeRepeating("TurnBlack", darktime, alltime);// Luz verde apagada

        }
        
    }

    void GreenTurn()
    {
        Verdel.color = new Color(Verdel.color.r, Verdel.color.g, Verdel.color.b, 1f);
        Amarillol.color = new Color(Amarillol.color.r, Amarillol.color.g, Amarillol.color.b, 0.05f);
        Rojol.color = new Color(Rojol.color.r, Rojol.color.g, Rojol.color.b, 0.05f);
                
    }

    void YellowTurn()
    {
        Verdel.color = new Color(Verdel.color.r, Verdel.color.g, Verdel.color.b, 0.05f);
        Amarillol.color = new Color(Amarillol.color.r, Amarillol.color.g, Amarillol.color.b, 1f);
        Rojol.color = new Color(Rojol.color.r, Rojol.color.g, Rojol.color.b, 0.05f);
                
    }

    void RedTurn()
    {
        Verdel.color = new Color(Verdel.color.r, Verdel.color.g, Verdel.color.b, 0.05f);
        Amarillol.color = new Color(Amarillol.color.r, Amarillol.color.g, Amarillol.color.b, 0.05f);
        Rojol.color = new Color(Rojol.color.r, Rojol.color.g, Rojol.color.b, 1f);
                
    }
}
