using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioDireccionC2 : MonoBehaviour
{
     public static bool CambioEtapac2;
    // Start is called before the first frame update
    void Start()
    {
        CambioEtapac2 = false;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == ("Player")) 
         {
            CambioEtapac2 = true;
            
         }
         
        
    }
}
