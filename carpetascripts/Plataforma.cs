using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Plataforma : MonoBehaviour
{
    private Rigidbody2D Rigidbody2D;
    
    private float Horizontal;
    public float JumpForce;
    public float Speed;
    private bool Grounded;
    public bool agachado = false;
    public bool dibujarRaycast = true;
    int AgacharID;
    public Vector2 colliderDePie;
    public Vector2 offsetDePie;
    public Vector2 colliderAgachado;
    public Vector2 offsetAgachado;
    BoxCollider2D coll;
    public GameObject neuroGanar;
    public GameObject neuroPerder;
    public int vidas;
    public Text Textvidas;
    public bool damaged;
    public Color flashcolor = new Color(1f, 0f, 0f, 0f);
    public Color inicialcolor = new Color(0f, 0f, 0f, 0f);
    public Renderer damageImage;
    public float flashspeed = 5f;
    public Sprite Spritedano;
    public Sprite Spritenormal;
    public bool isJumping = false;

    // Start is called before the first frame update

    void Awake()
    {
        
        Textvidas.text = vidas.ToString();
        

    }

    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        
        coll = GetComponent<BoxCollider2D>();
        

        colliderDePie = coll.size;
        offsetDePie = coll.offset;
        colliderAgachado = new Vector2(coll.size.x, coll.size.y/2f);
        offsetAgachado = new Vector2(coll.offset.x, coll.offset.y/2f);

        neuroPerder.gameObject.SetActive(false);
        neuroGanar.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");

        if (Horizontal < 0.0f) transform.localScale = new Vector3 (0.25f, 0.25f, 1.0f);
        else if (Horizontal > 0.0f) transform.localScale = new Vector3 (-0.25f, 0.25f, 1.0f );

        if (damaged == true)
        { 
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Spritedano;
            Invoke ("Restablecer", 0.8f); 
        }
        

        


        Debug.DrawRay(transform.position, Vector3.down * 0.1f, Color.red);
        if(Physics2D.Raycast(transform.position, Vector3.down, 0.1f))
        {
            Grounded = true;
        }
        else 
        {
            Grounded = false;
            agachado = false;
        }

        if (vidas == 0) 
        {
            neuroPerder.gameObject.SetActive(true);
            
        }


        //if(Input.GetMouseButton(0) && Grounded){Jump();}


        
    }

    private void FixedUpdate()
    {
        Rigidbody2D.velocity = new Vector2(Horizontal, Rigidbody2D.velocity.y);

    }

    void OnMouseUp()
    {
       if(!isJumping) {
       Rigidbody2D.AddForce(Vector2.up * JumpForce);
       isJumping = true;
       Invoke ("Descender", 1.5f);
       }
    }


    public void Agacharse()
    {
        if(!Grounded)
        return;

        //if (Input.GetKey("down")){
            agachado = true;
            coll.size = colliderAgachado;
            coll.offset = offsetAgachado;
        //}else{
            //agachado = false;
            //coll.size = colliderDePie;
            //coll.offset = offsetDePie;
        //}

       
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag ==("Meta")) 
         {
             neuroGanar.gameObject.SetActive(true);
             

         }

         if (other.gameObject.tag ==("Aaah")) 
         {
             neuroPerder.gameObject.SetActive(true);
             

         }

         if (other.gameObject.tag == ("Suelo"))
        {
            //Digo que no est saltando
            isJumping = false;
            //Le quito la fuerza de salto remanente que tuviera
            //Rigidbody2D.velocity = new Vector2(Rigidbody2D.velocity.x, 0);

        }

        else{if(damaged == false)
        
        {
        
        vidas = vidas - 1;
        Textvidas.text = vidas.ToString();
        damaged = true;

        
        }
        }

        

    }

    void Restablecer()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = Spritenormal;
        damaged = false;

    }

    void Descender()
    {
        isJumping = false;

    }

    
}
