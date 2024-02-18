using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Contenedorestres : MonoBehaviour
{
    public static int ScoreCStres = 0;
    public string ScoreString3 = "Puntaje";
    public Text Textscore3;
    public static int NegativoScore3 = 0;
    public Text Ntextscore3;
    // Start is called before the first frame update
    void Start()
    {
        ScoreCStres = 0;
        
    }

     void OnTriggerEnter2D (Collider2D other) 
     {
         if (other.gameObject.tag == ("3")) 
         {
            ScoreCStres++;
            Textscore3.text = "Puntaje:" + ScoreCStres;
         }
    }

    void OnTriggerExit2D (Collider2D other) 
     {
         if (other.gameObject.tag == ("3")) 
         {
            ScoreCStres--;
            Textscore3.text = "Puntaje:" + ScoreCStres;
         }
    }

}
