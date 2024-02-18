using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Contenedoresdos : MonoBehaviour
{
    public static int ScoreCSdos = 0;
    public string ScoreString = "Puntaje";
    public Text Textscore;
    public static int NegativoScore = 0;
    public Text Ntextscore;

    private SpriteRenderer rend;
    public Sprite revelado21;
    public Sprite revelado22;
    public Sprite revelado23;
    public Sprite revelado24;
    public Sprite revelado25;


    public GameObject Objeto1;
    public GameObject Objeto2;
    public GameObject Objeto3;
    public GameObject Objeto4;
    public GameObject Objeto5;
    
    // Start is called before the first frame update
    void Start()
    {
        
        ScoreCSdos = 0;
    }
    
     void OnTriggerEnter2D (Collider2D other) 
     {
         if (other.gameObject.tag == ("2")) 
         {
            ScoreCSdos++;
            Textscore.text = "Puntaje:" + ScoreCSdos;
         }

         if (other.gameObject.tag == ("Objeto1")) {
            Objeto1.gameObject.GetComponent<SpriteRenderer>().sprite = revelado21;
            ScoreCSdos++;
            Textscore.text = "Puntaje:" + ScoreCSdos;   
         }

         if (other.gameObject.tag == ("Objeto2")) {
            Objeto2.gameObject.GetComponent<SpriteRenderer>().sprite = revelado22;
            ScoreCSdos++;
            Textscore.text = "Puntaje:" + ScoreCSdos;   
         }

         if (other.gameObject.tag == ("Objeto3")) {
            Objeto3.gameObject.GetComponent<SpriteRenderer>().sprite = revelado23;
            ScoreCSdos++;
            Textscore.text = "Puntaje:" + ScoreCSdos;   
         }

         if (other.gameObject.tag == ("Objeto4")) {
            Objeto4.gameObject.GetComponent<SpriteRenderer>().sprite = revelado24;
            ScoreCSdos++;
            Textscore.text = "Puntaje:" + ScoreCSdos;   
         }

         if (other.gameObject.tag == ("Objeto5")) {
            Objeto5.gameObject.GetComponent<SpriteRenderer>().sprite = revelado25;
            ScoreCSdos++;
            Textscore.text = "Puntaje:" + ScoreCSdos;   
         }
    }

    

    void OnTriggerExit2D (Collider2D other) 
     {
         if (other.gameObject.tag == ("2")) 
         {
            ScoreCSdos--;
            Textscore.text = "Puntaje:" + ScoreCSdos;
         }

         if (other.gameObject.tag == ("Objeto1")) 
         {
            ScoreCSdos--;
            Textscore.text = "Puntaje:" + ScoreCSdos;
         }

         if (other.gameObject.tag == ("Objeto2")) 
         {
            ScoreCSdos--;
            Textscore.text = "Puntaje:" + ScoreCSdos;
         }

         if (other.gameObject.tag == ("Objeto3")) 
         {
            ScoreCSdos--;
            Textscore.text = "Puntaje:" + ScoreCSdos;
         }

         if (other.gameObject.tag == ("Objeto4")) 
         {
            ScoreCSdos--;
            Textscore.text = "Puntaje:" + ScoreCSdos;
         }

         if (other.gameObject.tag == ("Objeto5")) 
         {
            ScoreCSdos--;
            Textscore.text = "Puntaje:" + ScoreCSdos;
         }
    }


}
