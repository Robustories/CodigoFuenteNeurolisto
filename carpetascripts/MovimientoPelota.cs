using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPelota : MonoBehaviour
{
    public float speed = 1f;
    public Vector2 Direction;
    private Rigidbody2D RbObjetivo;
    public float JumpForce = 2.5f;

    private GameObject _target;
    // Start is called before the first frame update
    void Start()
    {
        RbObjetivo = GetComponent<Rigidbody2D>();
        transform.position = new Vector3(0,1);
        
    }

    // Update is called once per frame

    public void SetDirection(Vector3 direction)
    {
        Direction = direction;
    }

    void Update()
    {


     if (Input.GetMouseButtonDown(0))
        {
           Kick();

        }
     }
     
    void OnTriggerEnter(Collider other)
    {
      if (other.tag == "Contacto")
      {
         Destroy(gameObject);
      }
    }

    private void Kick()
    
    {
        RbObjetivo.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);

    }
}
