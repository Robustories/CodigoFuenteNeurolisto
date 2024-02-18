using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LU2 : MonoBehaviour
{
    public static bool luca;
    public static bool luna;
    // Start is called before the first frame update
    void Start()
    {
        luca = false;
        luna = false;
    }

    void OnTriggerEnter2D (Collider2D other) 
     {
         if (other.gameObject.tag == ("ca")) 
         {
            luca = true;
         }

         if (other.gameObject.tag == ("na")) 
         {
            luna = true;
         }
    }
}
