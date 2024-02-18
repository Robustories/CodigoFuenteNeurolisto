using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LO1 : MonoBehaviour
{
    public static bool pelo;
    // Start is called before the first frame update
    void Start()
    {
        pelo = false;
        
    }

     void OnTriggerEnter2D (Collider2D other) 
     {
         if (other.gameObject.tag == ("pe")) 
         {
            pelo = true;
         }
    }
}
