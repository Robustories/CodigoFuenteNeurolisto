using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LO2 : MonoBehaviour
{
    public static bool lota;
    public static bool lobo;
    // Start is called before the first frame update
    void Start()
    {
      lota = false;
      lobo = false;
      
        
    }


    void OnTriggerEnter2D (Collider2D other) 
     {
         if (other.gameObject.tag == ("ta")) 
         {
            lota = true;
         }

         if (other.gameObject.tag == ("bo")) 
         {
            lobo = true;
         }
    }

    
}
