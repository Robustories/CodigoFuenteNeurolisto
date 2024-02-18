using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuzAmarillal : MonoBehaviour
{
    public SpriteRenderer Amarilloll;

    float darktime = 5;// Del cuarto segundo al negro
    float alltime = 1;// Luz amarilla durante 2 segundos, un total de 10 segundos en una ronda
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InvokeRepeating("YellowTurn", 0f, alltime);// Llamar a la función GreenTurn () después de 0 segundos y luego llamarla cada 10 segundos
        InvokeRepeating("TurnBlack", darktime, alltime);// Luz verde apagada
        
    }

    void YellowTurn()
    {
        Amarilloll.color = new Color(Amarilloll.color.r, Amarilloll.color.g, Amarilloll.color.b, 1f);
                
    }

    void TurnBlack()
    {
       Amarilloll.color = new Color(Amarilloll.color.r, Amarilloll.color.g, Amarilloll.color.b, 0.1f);
    }
}
