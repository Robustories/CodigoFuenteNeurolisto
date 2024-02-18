using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Contenedor4 : MonoBehaviour
{
    public static int ScoreCSq = 0;
    public string ScoreStringq = "Puntaje";
    public Text Textscoreq;
    public static int NegativoScoreq = 0;
    public Text Ntextscoreq;
    // Start is called before the first frame update
    void Start()
    {
        ScoreCSq = 0;
    }

    void OnTriggerEnter2D (Collider2D other) 
     {
         if (other.gameObject.tag == ("4")) 
         {
            ScoreCSq++;
            Textscoreq.text = "Puntaje:" + ScoreCSq;
         }
    }

    void OnTriggerExit2D (Collider2D other) 
     {
         if (other.gameObject.tag == ("4")) 
         {
            ScoreCSq--;
            Textscoreq.text = "Puntaje:" + ScoreCSq;
         }
    }
}
