using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuzVerdel : MonoBehaviour
{
    public SpriteRenderer Verdell;

    float darktime = 4;// Del cuarto segundo al negro
    float alltime = 10;// Luz amarilla durante 2 segundos, un total de 10 segundos en una ronda
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InvokeRepeating("GreenTurn", 0f, alltime);// Llamar a la función GreenTurn () después de 0 segundos y luego llamarla cada 10 segundos
        InvokeRepeating("TurnBlack", darktime, alltime);// Luz verde apagada
        
    }

    void GreenTurn()
    {
        Verdell.color = new Color(Verdell.color.r, Verdell.color.g, Verdell.color.b, 1f);
                
    }

    void TurnBlack()
    {
        Verdell.color = new Color(Verdell.color.r, Verdell.color.g, Verdell.color.b, 0.1f);
    }
}
