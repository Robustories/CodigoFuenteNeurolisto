using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControler : MonoBehaviour
{
    public static int Score = 0;
    public static int NegativoScore = 0;
    public int requisitoNivel;
    private int money;
    public int recompensa = 10;
    
    public string ScoreString = "Puntaje : ";
    Rigidbody2D rb;
    public GameObject objeto;
    public GameObject pantallaFallo;

    public Text Textscore;
    public static GameControler Gamecontroller;

    public string NscoreString = "00";
    public Text Ntextscore;

    
    // Start is called before the first frame update

    void Awake()
    {
        Gamecontroller = this;
        rb = GetComponent<Rigidbody2D>();
        Score = 0;
        NegativoScore = 0;
        ScoreString = "Puntaje : " + Score;
        NscoreString  = "00" + NegativoScore;

    }


    void Start()
    {
        
        objeto.gameObject.SetActive(false);
        pantallaFallo.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Textscore != null)
        {
            Textscore.text = ScoreString + Score.ToString();
        }

        if(Ntextscore != null)
        {
            Ntextscore.text = NscoreString + NegativoScore.ToString();
        }

        if (Score == requisitoNivel) 
        {
            Invoke ("Ganar", 0.3f);
            money += recompensa;
        }

        if (NegativoScore == 5) {Invoke ("Fallar", 0.3f); }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
        Score = Score + 1;
        Textscore.text = "Puntaje:" + Score;

         if (other.gameObject.tag ==("PuntajeNegativo")) 
         {
             Score = Score - 1;
             NegativoScore = NegativoScore + 1;
             Ntextscore.text = "Puntaje:" + NegativoScore;

         }
    }

    void Ganar()
    { 
        objeto.SetActive(true);
    }

    void Fallar()
    { 
        pantallaFallo.SetActive(true);
    }
    
}

