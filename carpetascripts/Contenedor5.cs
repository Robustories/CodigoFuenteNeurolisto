using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Contenedor5 : MonoBehaviour
{
    public static int ScoreCSv = 0;
    public string ScoreStringv = "Puntaje";
    public Text Textscorev;
    public static int NegativoScorev = 0;
    public Text Ntextscorev;
    // Start is called before the first frame update
    void Start()
    {
       ScoreCSv = 0; 
    }

    void OnTriggerEnter2D (Collider2D other) 
     {
         if (other.gameObject.tag == ("5")) 
         {
            ScoreCSv++;
            Textscorev.text = "Puntaje:" + ScoreCSv;
         }
    }

    void OnTriggerExit2D (Collider2D other) 
     {
         if (other.gameObject.tag == ("5")) 
         {
            ScoreCSv--;
            Textscorev.text = "Puntaje:" + ScoreCSv;
         }
    }
}
