using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConducirCarro : MonoBehaviour
{
    public float velocidad;
    public GameObject pantallaperder;
    public int vidasCarrito;
    public Text vidasCarritoText;

    void Awake()
    {
        
        vidasCarritoText.text = vidasCarrito.ToString();
        pantallaperder.gameObject.SetActive(false);
        

    }
    
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector2(7, -2);
    }

    // Update is called once per frame
    void Update()
    {
         // = transform.position + new Vector3(2, -2, 0);
         if (vidasCarrito == 0) 
        {
            Invoke ("Estrellada", 0.5f);
            
        }
        
       
    }

    public void Moverse()
    {
        if (transform.position.x == 7){
            transform.position = new Vector2(3, transform.position.y);
            
        }

        else if (transform.position.x == 3){
            transform.position = new Vector2(7, transform.position.y);
            
        }

    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        vidasCarrito = vidasCarrito - 1;
        vidasCarritoText.text = vidasCarrito.ToString();

    }

    void Estrellada()
    { 
        pantallaperder.SetActive(true);
    }
}
