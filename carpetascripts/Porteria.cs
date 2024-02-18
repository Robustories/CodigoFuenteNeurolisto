using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Porteria : MonoBehaviour
{
    public static int ScoreFu = 0;
    
    
    public string ScoreStringFu = "Puntaje : ";
    Rigidbody2D rbFu;
    Rigidbody2D extra;
    public GameObject gol;

    public GameObject balon;
    private GameObject balonCreado;

    public Portero portero;

    private int tapadoa; 
    public static int destapado;
    

    public Text TextscoreFu;
    public static Porteria Porterria;

    private bool reinicioPuntaje;

    public GameObject lanzable;
    public float m_Thrust = 20f;
    public AudioClip gols;
    public AudioSource gsource;
    public int pgol;
    // Start is called before the first frame update

    void Awake()
    {
        Porterria = this;
        rbFu = GetComponent<Rigidbody2D>();
        ScoreFu = 0;
        ScoreStringFu = "Puntaje :" + ScoreFu;

    }

    void Start()
    {
        gol.gameObject.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        lanzable = GameObject.FindGameObjectWithTag("Pelota");
        extra = lanzable.GetComponent<Rigidbody2D>();

        if(TextscoreFu != null)
        {
            TextscoreFu.text = ScoreStringFu + ScoreFu.ToString();
        }

        if (ScoreFu == pgol) {Invoke ("Goleada", 0.4f); }

        Portero variable = GetComponent<Portero>();
        tapadoa = Portero.tapado;

        if (tapadoa == 0) 
         {
             reinicioPuntaje = true;
             
             
         }

         if (reinicioPuntaje == true)
         {
             ScoreFu = 0;
             destapado = 0;
         }


        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
        //Destroy(gameObject);
        ScoreFu = ScoreFu + 1;
        TextscoreFu.text = ScoreFu + "  Puntos";
        destapado = 1; 
        reinicioPuntaje = false;
        gsource.clip = gols;
        gsource.Play();

        Vector3 position = new Vector3(0, -3, 1);
        balonCreado = Instantiate(balon, position, Quaternion.identity);

         if (other.gameObject.tag ==("PuntajeNegativo")) 
         {
             ScoreFu = 0;
            

         }



        

         

    }

    void Goleada()
    { 
        gol.SetActive(true);
    }

    public void Arriba(){extra.AddForce(transform.up * m_Thrust);}
    public void Derecha()
    {
        Vector3 derecha = Quaternion.AngleAxis(65, Vector3.forward) * Vector3.right;
        extra.AddForce(derecha * m_Thrust);
    }
    public void Izquierda()
    { 
        Vector3 izquierda = Quaternion.AngleAxis(295, Vector3.forward) * Vector3.left;
        extra.AddForce(izquierda * m_Thrust);
    }
}
