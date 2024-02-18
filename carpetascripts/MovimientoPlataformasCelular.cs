using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPlataformasCelular : MonoBehaviour
{
    public bool dibujarRaycast = true;
    private Rigidbody2D cuerpo;
    public float Speed;
    public float JumpForce;
    private float Horizontal;
    private bool Grounded;
    private Animator anim;
    public bool agachado = false;
    public bool cabezaBloqueada = false;
    int agacharID;

    public Vector2 colliderDePie;
    public Vector2 offsetDePie;
    public Vector2 colliderAgachado;
    public Vector2 offsetAgachado;

    BoxCollider2D coll;
    // Start is called before the first frame update
    void Start()
    {
        cuerpo = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        coll = GetComponent<BoxCollider2D>();

        agacharID = Animator.StringToHash("agachado");

        colliderDePie = coll.size;
        offsetDePie = coll.offset;
        colliderAgachado = new Vector2(coll.size.x, coll.size.y / 2f );
        offsetAgachado = new Vector2(coll.size.x, coll.size.y / 2f );
    }

    // Update is called once per frame
    void Update()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");

        if (Horizontal < 0.0f) transform.localScale = new Vector3 (-1.0f, 1.0f, 1.0f);
        else if (Horizontal > 0.0f) transform.localScale = new Vector3 (1.0f, 1.0f, 1.0f);
        
        anim.SetBool("Running", Horizontal != 0.0f);

        Debug.DrawRay(transform.position, Vector3.down * 0.1f, Color.red);

        if (Physics2D.Raycast(transform.position, Vector3.down, 0.1f))
        {
            Grounded = true;
            

        }
        else Grounded = false;

        if (Input.GetMouseButtonDown(0))
        {
            Jump();

        }

        Agacharse();
    



        
    }

       private void Jump()
        {
        cuerpo.AddForce(Vector2.up * JumpForce);
        }

         private void FixedUpdate()
        {
        cuerpo.velocity = new Vector2(Horizontal, cuerpo.velocity.y);
        }


        void Agacharse()
        {
            if (Grounded)
            return;

            if (Input.GetKey ("down"))
            {
                agachado = true;
                coll.size = colliderAgachado;
                coll.offset = offsetAgachado;
            }
            else
            {
                if(!cabezaBloqueada)
                {
                agachado = false;
                coll.size = colliderDePie;
                coll.offset = offsetDePie;
                }
            }

            anim.SetBool(agacharID, agachado);
        }
}
