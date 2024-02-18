using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuzRojal : MonoBehaviour
{
    public SpriteRenderer Rojoll;

    float darktime = 9;// Del cuarto segundo al negro
    float alltime = 10;// Luz amarilla durante 2 segundos, un total de 10 segundos en una ronda
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InvokeRepeating("RedTurn", 0f, alltime);// Llamar a la función GreenTurn () después de 0 segundos y luego llamarla cada 10 segundos
        InvokeRepeating("TurnBlack", darktime, alltime);// Luz verde apagada
        
    }

    void RedTurn()
    {
        Rojoll.color = new Color(Rojoll.color.r, Rojoll.color.g, Rojoll.color.b, 1f);
                
    }

    void TurnBlack()
    {
        Rojoll.color = new Color(Rojoll.color.r, Rojoll.color.g, Rojoll.color.b, 0.1f);
    }
}
