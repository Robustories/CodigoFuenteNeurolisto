using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioDireccion : MonoBehaviour
{
    public static bool CambioEtapa1;
    // Start is called before the first frame update
    void Start()
    {
        CambioEtapa1 = false;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == ("Player")) 
         {
            CambioEtapa1 = true;
            
         }
         
        
    }
}
