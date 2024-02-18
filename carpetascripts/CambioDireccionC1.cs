using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioDireccionC1 : MonoBehaviour
{
    public static bool CambioEtapac1;
    // Start is called before the first frame update
    void Start()
    {
        CambioEtapac1 = false;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == ("Player")) 
         {
            CambioEtapac1 = true;
            
         }
         
        
    }
}
