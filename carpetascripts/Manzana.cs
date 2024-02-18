using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manzana : MonoBehaviour
{
    
    public float Speed;
    public float LivingTime;
    private Rigidbody2D Rigidbody2D;


    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        Destroy(gameObject, LivingTime);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Canasta")){
            Destroy(gameObject, .1f);
        }
    }
}
