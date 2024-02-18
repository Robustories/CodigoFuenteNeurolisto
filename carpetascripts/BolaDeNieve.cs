using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BolaDeNieve : MonoBehaviour
{
    private SpriteRenderer rend;
    public Sprite parado, agachado;
    Rigidbody2D m_Rigidbody;
    public float m_Thrust = 20f;
    BoxCollider2D coll;
    public Vector2 colliderDePie;
    public Vector2 offsetDePie;
    public Vector2 colliderAgachado;
    public Vector2 offsetAgachado;
    public GameObject nieveGanar;
    public GameObject nievePerder;
    public bool agachadob;
    public int bolaImpacto;
    public Text TextNieve;
    public EventoReloj eventoReloj;
    public bool nieveEsquivada;
    public bool Enelaire;
    public Color flashcolor = new Color(0f, 0f, 0f, 0f);
    public Color inicialcolor = new Color(0f, 0f, 0f, 1f);
    public Renderer damageImage;
    public bool damaged;
    public Sprite Spritedano;
    public Sprite Spritenormal;
    public bool isJumping = false;
    public float JumpForce;

    void Awake()
    {
        
        TextNieve.text = bolaImpacto.ToString();
        

    }
    
    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();
        rend = GetComponent<SpriteRenderer>();

        colliderDePie = coll.size;
        offsetDePie = coll.offset;
        colliderAgachado = new Vector2(coll.size.x, coll.size.y/3f);
        offsetAgachado = new Vector2(coll.offset.x, coll.offset.y/3f);

        nievePerder.gameObject.SetActive(false);

        
    }

    // Update is called once per frame
    void Update()
    {
        EventoReloj variable1 = GetComponent<EventoReloj>();
        //nieveEsquivada = eventoReloj.tiempoSuperado;

        if (damaged == true)
        { 
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Spritedano;
            Invoke ("RestablecerNieve", 0.7f); 
        }


        
        if (bolaImpacto == 0) 
            {
            nievePerder.gameObject.SetActive(true);
            }



            

        
        
    }

    public void Agacharse()
    {
        if(agachadob == false)
        {
        rend.sprite = agachado;
        agachadob = true;
        coll.size = colliderAgachado;
        coll.offset = offsetAgachado;
        }
        else
        {
            rend.sprite = parado;
            agachadob = false;
            coll.size = colliderDePie;
            coll.offset = offsetDePie;

        }
        
    }

    public void Saltar()
    {
        if(agachadob == false)
        {
            if(!isJumping) 
            {
                m_Rigidbody.AddForce(Vector2.up * JumpForce);
                isJumping = true;
                Debug.Log(" isJumping is true");
                //Invoke ("Descender", 1.5f);
            }

            
        }

        if(agachadob == true)
        {
            
            rend.sprite = parado;
            agachadob = false;
            coll.size = colliderDePie;
            coll.offset = offsetDePie;
            

        }
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Suelo"))
        {
            //Digo que no est saltando
            isJumping = false;
            //Le quito la fuerza de salto remanente que tuviera
            //Rigidbody2D.velocity = new Vector2(Rigidbody2D.velocity.x, 0);

        }

        else{if(damaged == false)
        
        {
        
        bolaImpacto = bolaImpacto - 1;
        TextNieve.text = bolaImpacto.ToString();
        damaged = true;
        }

        }

        


    }

    void EnElAire()
    {
        Enelaire = true;

    }

    void Descender()
    {
        isJumping = false;

    }

    void RestablecerNieve()
    {
        rend.sprite = parado;
        agachadob = false;
        coll.size = colliderDePie;
        coll.offset = offsetDePie;
        damaged = false;

    }
}
