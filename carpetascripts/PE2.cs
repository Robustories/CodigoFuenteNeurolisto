using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PE2 : MonoBehaviour
{
    public static bool pece;
    public static bool pelo;
    public static bool pelu;
    // Start is called before the first frame update
    void Start()
    {
       pece = false;
       pelo = false;
       pelu = false;
        
    }

    void OnTriggerEnter2D (Collider2D other) 
     {
         if (other.gameObject.tag == ("ce1")) 
         {
            pece = true;
         }

         if (other.gameObject.tag == ("lo")) 
         {
            pelo = true;
         }

         if (other.gameObject.tag == ("lu")) 
         {
            pelu = true;
         }


    }

    void OnTriggerExit2D (Collider2D other) 
     {
         if (other.gameObject.tag == ("CE1")) 
         {
            pece = false;
         }

         if (other.gameObject.tag == ("lo")) 
         {
            pelo = false;
         }

         if (other.gameObject.tag == ("lu")) 
         {
            pelu = false;
         }
    }
}
