using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MA1 : MonoBehaviour
{
    public static bool cama;
    // Start is called before the first frame update
    void Start()
    {
        cama = false;
        
    }

    void OnTriggerEnter2D (Collider2D other) 
     {
         if (other.gameObject.tag == ("ca")) 
         {
            cama = true;
         }
    }
}
