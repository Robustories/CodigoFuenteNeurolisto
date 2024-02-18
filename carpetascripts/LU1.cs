using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LU1 : MonoBehaviour
{
    public static bool pelu;
    // Start is called before the first frame update
    void Start()
    {
        pelu = false;
        
    }


    void OnTriggerEnter2D (Collider2D other) 
     {
         if (other.gameObject.tag == ("pe")) 
         {
            pelu = true;
         }
    }
}
