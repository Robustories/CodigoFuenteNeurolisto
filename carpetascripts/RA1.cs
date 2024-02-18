using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RA1 : MonoBehaviour
{
    public static bool cera;
    public static bool mara;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D (Collider2D other) 
     {
         if (other.gameObject.tag == ("CE2")) 
         {
            cera = true;
         }

         if (other.gameObject.tag == ("ma")) 
         {
            mara = true;
        }
     }

     void OnTriggerExit2D (Collider2D other) 
     {
         if (other.gameObject.tag == ("ce2")) 
         {
            cera = false;
         }

         if (other.gameObject.tag == ("ma")) 
         {
            mara = false;
        }
     }
}

