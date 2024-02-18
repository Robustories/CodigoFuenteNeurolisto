using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CE2 : MonoBehaviour
{
    public static bool cera;
    // Start is called before the first frame update
    void Start()
    {
        cera = false;
        
    }

    void OnTriggerEnter2D (Collider2D other) 
     {
         if (other.gameObject.tag == ("ra")) 
         {
            cera = true;
         }
    }
}
