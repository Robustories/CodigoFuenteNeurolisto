using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meta : MonoBehaviour
{
    public GameObject pantallaProseguir;
    public Competidor competidor;
    public static bool llegada;
    
    // Start is called before the first frame update
    void Start()
    {
        pantallaProseguir.gameObject.SetActive(false);
        Competidor variable = GetComponent<Competidor>();
        llegada = false;
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == ("Player")) 
         {
            pantallaProseguir.gameObject.SetActive(true);
            llegada = true;
            
         }
         
        
    }
}
