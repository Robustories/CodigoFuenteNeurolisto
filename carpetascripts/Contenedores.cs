using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Contenedores : MonoBehaviour
{

    public static int ScoreCS = 0;
    public string ScoreString = "Puntaje";
    public Text Textscore;
    public static int NegativoScore = 0;
    public Text Ntextscore;

    private SpriteRenderer rend;
    public Sprite revelado1;
    public Sprite revelado2;
    public Sprite revelado3;
    public Sprite revelado4;
    public Sprite revelado5;


    public GameObject Animal1;
    public GameObject Animal2;
    public GameObject Animal3;
    public GameObject Animal4;
    public GameObject Animal5;

    
    
    // Start is called before the first frame update
    void Start()
    {
        ScoreCS = 0;
        
    }

     void OnTriggerEnter2D (Collider2D other) 
     {
         if (other.gameObject.tag == ("1")) 
         {
            ScoreCS++;
            Textscore.text = "Puntaje:" + ScoreCS;
         }

         if (other.gameObject.tag == ("Animal1")) {
            Animal1.gameObject.GetComponent<SpriteRenderer>().sprite = revelado1;
            ScoreCS++;
            Textscore.text = "Puntaje:" + ScoreCS;   
         }

         if (other.gameObject.tag == ("Animal2")) {
            Animal2.gameObject.GetComponent<SpriteRenderer>().sprite = revelado2;
            ScoreCS++;
            Textscore.text = "Puntaje:" + ScoreCS;   
         }

         if (other.gameObject.tag == ("Animal3")) {
            Animal3.gameObject.GetComponent<SpriteRenderer>().sprite = revelado3;
            ScoreCS++;
            Textscore.text = "Puntaje:" + ScoreCS;   
         }

         if (other.gameObject.tag == ("Animal4")) {
            Animal4.gameObject.GetComponent<SpriteRenderer>().sprite = revelado4;
            ScoreCS++;
            Textscore.text = "Puntaje:" + ScoreCS;   
         }

         if (other.gameObject.tag == ("Animal5")) {
            Animal5.gameObject.GetComponent<SpriteRenderer>().sprite = revelado5;
            ScoreCS++;
            Textscore.text = "Puntaje:" + ScoreCS;   
         }
    }

    void OnTriggerExit2D (Collider2D other) 
     {
         if (other.gameObject.tag == ("1")) 
         {
            ScoreCS--;
            Textscore.text = "Puntaje:" + ScoreCS;
         }

         if (other.gameObject.tag == ("Animal1")) 
         {
            ScoreCS--;
            Textscore.text = "Puntaje:" + ScoreCS;
         }

         if (other.gameObject.tag == ("Animal2")) 
         {
            ScoreCS--;
            Textscore.text = "Puntaje:" + ScoreCS;
         }

         if (other.gameObject.tag == ("Animal3")) 
         {
            ScoreCS--;
            Textscore.text = "Puntaje:" + ScoreCS;
         }

         if (other.gameObject.tag == ("Animal4")) 
         {
            ScoreCS--;
            Textscore.text = "Puntaje:" + ScoreCS;
         }

         if (other.gameObject.tag == ("Animal5")) 
         {
            ScoreCS--;
            Textscore.text = "Puntaje:" + ScoreCS;
         }
    }


}
