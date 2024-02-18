using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CE1 : MonoBehaviour
{
    public static bool pece;
    
    

    // Start is called before the first frame update
    void Start()
    {
        pece = false;
        
    }


    void OnTriggerEnter2D (Collider2D other) 
     {
         if (other.gameObject.tag == ("pe")) 
         {
            pece = true;
         }
    }
}
