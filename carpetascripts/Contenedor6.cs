using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contenedor6 : MonoBehaviour
{
    public static int ScoreCSs = 0;
    // Start is called before the first frame update
    void Start()
    {
        ScoreCSs = 0; 
        
    }

    void OnTriggerEnter2D (Collider2D other) 
     {
         if (other.gameObject.tag == ("6")) 
         {
            ScoreCSs++;
            
         }
    }

    void OnTriggerExit2D (Collider2D other) 
     {
         if (other.gameObject.tag == ("6")) 
         {
            ScoreCSs--;
            
         }
    }
}
