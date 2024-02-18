using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GO2 : MonoBehaviour
{
    public static bool gota;
    // Start is called before the first frame update
    void Start()
    {
        gota = false;
        
    }

    void OnTriggerEnter2D (Collider2D other) 
     {
         if (other.gameObject.tag == ("ta")) 
         {
            gota = true;
         }
    }
}
